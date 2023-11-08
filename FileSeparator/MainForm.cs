namespace FileSeparator
{
    public partial class MainForm : Form
    {
        private List<FileInfo> files;

        public MainForm()
        {
            InitializeComponent();
        }

        private void FileCountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Take int only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                {
                    effects = DragDropEffects.Copy;
                }
            }

            e.Effect = effects;
        }

        private void FileListGrid_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                {
                    files = new List<FileInfo>();
                    var dir = new DirectoryInfo(path);
                    var DroppedFiles = dir.GetFiles("*.*", SearchOption.AllDirectories);
                    foreach (var file in DroppedFiles)
                    {
                        files.Add(file);
                    }

                    fillDataGrid();
                }
            }
        }

        private void fillDataGrid()
        {
            FileListGrid.Rows.Clear();
            foreach (var file in files)
            {
                FileListGrid.Rows.Add(file.Name, file.Extension, file.Length / 1000);
            }
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(SeparateFiles);
            int.TryParse(FileCountBox.Text, out Globals.fileCount);
            thread.Start();
            FileProgressBar.Maximum = files.Count;
            while (Globals.processedFiles < files.Count)
            {
                FileProgressBar.Value = Globals.processedFiles;
                Thread.Sleep(100);
            }
            thread.Join();
            MessageBox.Show("Done");
            FileProgressBar.Value = 0;
        }

        private void SeparateFiles()
        {
            int leftFileCount = files.Count;
            while (leftFileCount - Globals.fileCount >= 0)
            {
                var newDir = Directory.CreateDirectory(Path.Combine(files[0].DirectoryName, $"Range {Globals.processedFiles}"));
                for (int i = 0; i < Globals.fileCount; i++)
                {
                    Globals.processedFiles++;
                    var file = files[0];
                    var newFile = Path.Combine(newDir.FullName, file.Name);
                    File.Move(file.FullName, newFile);
                    files.RemoveAt(0);
                }

                leftFileCount = leftFileCount - Globals.fileCount;
            }
        }
    }
}