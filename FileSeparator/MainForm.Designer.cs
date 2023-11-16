namespace FileSeparator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FileListGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ProcessBtn = new Button();
            FileProgressBar = new ProgressBar();
            PreviewPicture = new PictureBox();
            panel1 = new Panel();
            FileCountBox = new TextBox();
            FIleCountLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)FileListGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PreviewPicture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FileListGrid
            // 
            FileListGrid.AllowDrop = true;
            FileListGrid.AllowUserToAddRows = false;
            FileListGrid.AllowUserToDeleteRows = false;
            FileListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FileListGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            FileListGrid.Dock = DockStyle.Left;
            FileListGrid.Location = new Point(0, 0);
            FileListGrid.Name = "FileListGrid";
            FileListGrid.ReadOnly = true;
            FileListGrid.RowHeadersWidth = 72;
            FileListGrid.RowTemplate.Height = 37;
            FileListGrid.Size = new Size(707, 585);
            FileListGrid.TabIndex = 0;
            FileListGrid.DragDrop += FileListGrid_DragDrop;
            FileListGrid.DragEnter += dataGridView1_DragEnter;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "File Name";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "File Extension";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "File Size";
            Column3.MinimumWidth = 9;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // ProcessBtn
            // 
            ProcessBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ProcessBtn.Location = new Point(159, 533);
            ProcessBtn.Name = "ProcessBtn";
            ProcessBtn.Size = new Size(131, 40);
            ProcessBtn.TabIndex = 3;
            ProcessBtn.Text = "Process";
            ProcessBtn.UseVisualStyleBackColor = true;
            ProcessBtn.Click += ProcessBtn_Click;
            // 
            // FileProgressBar
            // 
            FileProgressBar.Location = new Point(13, 53);
            FileProgressBar.Name = "FileProgressBar";
            FileProgressBar.Size = new Size(278, 40);
            FileProgressBar.TabIndex = 4;
            // 
            // PreviewPicture
            // 
            PreviewPicture.Location = new Point(11, 99);
            PreviewPicture.Name = "PreviewPicture";
            PreviewPicture.Size = new Size(279, 342);
            PreviewPicture.TabIndex = 5;
            PreviewPicture.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(FileCountBox);
            panel1.Controls.Add(FIleCountLbl);
            panel1.Controls.Add(ProcessBtn);
            panel1.Controls.Add(PreviewPicture);
            panel1.Controls.Add(FileProgressBar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(713, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 585);
            panel1.TabIndex = 6;
            // 
            // FileCountBox
            // 
            FileCountBox.Location = new Point(184, 12);
            FileCountBox.Name = "FileCountBox";
            FileCountBox.Size = new Size(107, 35);
            FileCountBox.TabIndex = 1;
            FileCountBox.Text = "1000";
            FileCountBox.TextAlign = HorizontalAlignment.Right;
            FileCountBox.KeyPress += FileCountBox_KeyPress;
            // 
            // FIleCountLbl
            // 
            FIleCountLbl.AutoSize = true;
            FIleCountLbl.Location = new Point(12, 9);
            FIleCountLbl.Name = "FIleCountLbl";
            FIleCountLbl.Size = new Size(165, 30);
            FIleCountLbl.TabIndex = 2;
            FIleCountLbl.Text = "Number of Files:";
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 585);
            Controls.Add(panel1);
            Controls.Add(FileListGrid);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)FileListGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)PreviewPicture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView FileListGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button ProcessBtn;
        private ProgressBar FileProgressBar;
        private PictureBox PreviewPicture;
        private Panel panel1;
        private TextBox FileCountBox;
        private Label FIleCountLbl;
    }
}