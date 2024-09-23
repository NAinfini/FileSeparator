using FileSeparator.Helper;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Cursors = System.Windows.Input.Cursors;
using DataFormats = System.Windows.Forms.DataFormats;
using DragDropEffects = System.Windows.DragDropEffects;
using MessageBox = System.Windows.MessageBox;
using Path = System.IO.Path;

namespace FileSeparator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<TaskProgressTracker> tasks = new ObservableCollection<TaskProgressTracker>();
        private List<Task> Tasks = new List<Task>();
        private int _NumberOfFilesPerFolder = 1000;
        private string _savePath;
        private ObservableCollection<FileInfo> _files = new ObservableCollection<FileInfo>();

        public ObservableCollection<FileInfo> Files
        {
            get
            {
                return _files;
            }
            set
            {
                _files = value;
                OnPropertyChanged(nameof(Files));
            }
        }

        public int NumberOfFilesPerFolder
        {
            get
            {
                return _NumberOfFilesPerFolder;
            }
            set
            {
                _NumberOfFilesPerFolder = value;
                OnPropertyChanged(nameof(NumberOfFilesPerFolder));
            }
        }

        public ObservableCollection<TaskProgressTracker> TasksTracker
        {
            get
            {
                return tasks;
            }
            set
            {
                tasks = value;
                OnPropertyChanged(nameof(TasksTracker));
            }
        }

        public string SavePath
        {
            get
            {
                return _savePath;
            }
            set
            {
                _savePath = value;
                OnPropertyChanged(nameof(SavePath));
            }
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            var menuDropAlignmentField = typeof(SystemParameters).GetField("_menuDropAlignment", BindingFlags.NonPublic | BindingFlags.Static);
            if (SystemParameters.MenuDropAlignment && menuDropAlignmentField != null)
            {
                menuDropAlignmentField.SetValue(null, false);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void FileOpenClick(object sender, RoutedEventArgs e)
        {
            using var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in Directory.GetFiles(dialog.SelectedPath))
                {
                    Files.Add(new FileInfo(file));
                }
            }
        }

        private void FileSaveClick(object sender, RoutedEventArgs e)
        {
            TasksTracker.Clear();
            Tasks.Clear();
            OpenFolderDialog openFolderDialog = new OpenFolderDialog();
            openFolderDialog.Multiselect = false;
            if (openFolderDialog.ShowDialog() == true)
            {
                SavePath = openFolderDialog.FolderName;
            }
            else
            {
                return;
            }
            int NumberofThreads = Files.Count / NumberOfFilesPerFolder + 1;
            int counter = 0;
            for (int i = 0; i < NumberofThreads; i++)
            {
                int startIndex = i * NumberOfFilesPerFolder;
                var files = Files.Skip(startIndex).Take(NumberOfFilesPerFolder).ToList();
                Task task = new Task(() => ProcessFiles(counter++, startIndex, SavePath, files));
                Tasks.Add(task);
                TasksTracker.Add(new TaskProgressTracker { id = i, TaskName = $"Task {i}", Progress = 0, Status = "Running" });
            }
            Tasks.ForEach(x => x.Start());
            Files.Clear();
        }

        private void ProcessFiles(int taskIndex, int startIndex, string folderPath, List<FileInfo> files)
        {
            try
            {
                string newFolder = Path.Combine(folderPath, $"{startIndex} to {startIndex + files.Count}");
                if (!Directory.Exists(newFolder))
                {
                    Directory.CreateDirectory(newFolder);
                }
                for (int i = 0; i < files.Count; i++)
                {
                    var file = files[i];
                    string newFilePath = Path.Combine(newFolder, file.Name);
                    File.Copy(file.FullName, newFilePath, true);
                    File.Delete(file.FullName);
                    int percentage = (i + 1) * 100 / files.Count;
                    Dispatcher.Invoke(() =>
                    {
                        TasksTracker[taskIndex].Progress = percentage;
                    });
                }
                Dispatcher.Invoke(() =>
                {
                    TasksTracker[taskIndex].Status = "Completed";
                });
            }
            catch(Exception ex)
            {
                Dispatcher.Invoke(() =>
                {
                    TasksTracker[taskIndex].Status = "Failed";
                });
            }
            
        }

        private void FileClearClick(object sender, RoutedEventArgs e)
        {
            Files.Clear();
        }

        private void SelectedFilePanelDrop(object sender, System.Windows.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] droppedItems = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string item in droppedItems)
                {
                    if (File.Exists(item)) // If it's a file, add to list
                    {
                        Files.Add(new FileInfo(item));
                    }
                    else if (Directory.Exists(item)) // If it's a folder, get all files inside it
                    {
                        foreach (var file in GetAllFilesInFolder(item))
                        {
                            Files.Add(file);
                        }
                    }
                }
            }
        }

        private ObservableCollection<FileInfo> GetAllFilesInFolder(string folderPath)
        {
            ObservableCollection<FileInfo> files = new ObservableCollection<FileInfo>();

            try
            {
                string[] filenames = Directory.GetFiles(folderPath);
                foreach (string filename in filenames)
                {
                    files.Add(new FileInfo(filename));
                }
                foreach (var directory in Directory.GetDirectories(folderPath))
                {
                    foreach (var file in Directory.GetFiles(directory))
                    {
                        files.Add(new FileInfo(file));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing folder: {folderPath}\n{ex.Message}");
            }

            return files;
        }

        private void FilesPerfolder_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(FilesPerfolder.Text, out int result))
            {
                NumberOfFilesPerFolder = result;
            }
            else
            {
                FilesPerfolder.Text = "1000";
            }
        }
    }
}