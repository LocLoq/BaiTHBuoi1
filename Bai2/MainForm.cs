namespace Bai2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MaleRB_CheckedChanged(object sender, EventArgs e)
        {
            if (maleRB.Checked)
            {
                MessageBox.Show("Bạn đã chọn giới tính Nam.", "Thông báo");
            }
        }

        private void FemaleRB_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleRB.Checked)
            {
                MessageBox.Show("Bạn đã chọn giới tính Nữ.", "Thông báo");
            }
        }

        private void paintColorButton_Click(object sender, EventArgs e)
        {
            if (blueRB.Checked) {
                colorTextBox.BackColor = Color.Blue;
            }
            else
            {
                colorTextBox.BackColor = Color.Red;
            }
        }
    }
}
