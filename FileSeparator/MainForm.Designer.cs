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
            FileCountBox = new TextBox();
            FIleCountLbl = new Label();
            ProcessBtn = new Button();
            FileProgressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)FileListGrid).BeginInit();
            SuspendLayout();
            // 
            // FileListGrid
            // 
            FileListGrid.AllowDrop = true;
            FileListGrid.AllowUserToAddRows = false;
            FileListGrid.AllowUserToDeleteRows = false;
            FileListGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FileListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FileListGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            FileListGrid.Location = new Point(12, 12);
            FileListGrid.Name = "FileListGrid";
            FileListGrid.ReadOnly = true;
            FileListGrid.RowHeadersWidth = 72;
            FileListGrid.RowTemplate.Height = 37;
            FileListGrid.Size = new Size(707, 552);
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
            // FileCountBox
            // 
            FileCountBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileCountBox.Location = new Point(896, 6);
            FileCountBox.Name = "FileCountBox";
            FileCountBox.Size = new Size(107, 35);
            FileCountBox.TabIndex = 1;
            FileCountBox.Text = "1000";
            FileCountBox.TextAlign = HorizontalAlignment.Right;
            FileCountBox.KeyPress += FileCountBox_KeyPress;
            // 
            // FIleCountLbl
            // 
            FIleCountLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FIleCountLbl.AutoSize = true;
            FIleCountLbl.Location = new Point(725, 9);
            FIleCountLbl.Name = "FIleCountLbl";
            FIleCountLbl.Size = new Size(165, 30);
            FIleCountLbl.TabIndex = 2;
            FIleCountLbl.Text = "Number of Files:";
            // 
            // ProcessBtn
            // 
            ProcessBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ProcessBtn.Location = new Point(872, 533);
            ProcessBtn.Name = "ProcessBtn";
            ProcessBtn.Size = new Size(131, 40);
            ProcessBtn.TabIndex = 3;
            ProcessBtn.Text = "Process";
            ProcessBtn.UseVisualStyleBackColor = true;
            ProcessBtn.Click += ProcessBtn_Click;
            // 
            // FileProgressBar
            // 
            FileProgressBar.Location = new Point(725, 47);
            FileProgressBar.Name = "FileProgressBar";
            FileProgressBar.Size = new Size(278, 40);
            FileProgressBar.TabIndex = 4;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 585);
            Controls.Add(FileProgressBar);
            Controls.Add(ProcessBtn);
            Controls.Add(FIleCountLbl);
            Controls.Add(FileCountBox);
            Controls.Add(FileListGrid);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)FileListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView FileListGrid;
        private TextBox FileCountBox;
        private Label FIleCountLbl;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button ProcessBtn;
        private ProgressBar FileProgressBar;
    }
}