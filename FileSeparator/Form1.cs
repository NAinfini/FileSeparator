namespace FileSeparator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FileCountBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int iValue = -1;
            if (Int32.TryParse(textBox.Text, out iValue) == false)
            {
                TextChange textChange = e.Changes.ElementAt(0);
                int iAddedLength = textChange.AddedLength;
                int iOffset = textChange.Offset;
                textBox.Text = textBox.Text.Remove(iOffset, iAddedLength);
            }
        }
    }
}