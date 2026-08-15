namespace ChuongTrinhDauTien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void greetingButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            MessageBox.Show($"Xin chào bạn {name}, rất vui được gặp bạn!", "Thông điệp chào mừng");
        }


        private void copyButton_Click_1(object sender, EventArgs e)
        {
            copyTextBox.Text = nameTextBox.Text;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            copyTextBox.Text = nameTextBox.Text;
        }
    }
}
