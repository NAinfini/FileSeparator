namespace FileSeparator
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            FileCountBox = new TextBox();
            FIleCountLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(707, 552);
            dataGridView1.TabIndex = 0;
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
            FileCountBox.TextChanged += FileCountBox_TextChanged;
            // 
            // FIleCountLbl
            // 
            FIleCountLbl.AutoSize = true;
            FIleCountLbl.Location = new Point(725, 9);
            FIleCountLbl.Name = "FIleCountLbl";
            FIleCountLbl.Size = new Size(165, 30);
            FIleCountLbl.TabIndex = 2;
            FIleCountLbl.Text = "Number of Files:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 585);
            Controls.Add(FIleCountLbl);
            Controls.Add(FileCountBox);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox FileCountBox;
        private Label FIleCountLbl;
    }
}