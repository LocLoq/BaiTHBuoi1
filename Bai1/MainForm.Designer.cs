namespace ChuongTrinhDauTien
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
            nameTextBox = new TextBox();
            label1 = new Label();
            greetingButton = new Button();
            copyButton = new Button();
            label2 = new Label();
            copyTextBox = new TextBox();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(207, 124);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(245, 23);
            nameTextBox.TabIndex = 0;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 127);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Nhập tên:";
            // 
            // greetingButton
            // 
            greetingButton.Location = new Point(230, 180);
            greetingButton.Name = "greetingButton";
            greetingButton.Size = new Size(75, 23);
            greetingButton.TabIndex = 2;
            greetingButton.Text = "Xử Lý";
            greetingButton.UseVisualStyleBackColor = true;
            greetingButton.Click += greetingButton_Click;
            // 
            // copyButton
            // 
            copyButton.Location = new Point(377, 180);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(75, 23);
            copyButton.TabIndex = 3;
            copyButton.Text = "Sao chép";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 240);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "Bạn đã nhập:";
            // 
            // copyTextBox
            // 
            copyTextBox.Location = new Point(207, 237);
            copyTextBox.Name = "copyTextBox";
            copyTextBox.ReadOnly = true;
            copyTextBox.Size = new Size(245, 23);
            copyTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(copyTextBox);
            Controls.Add(copyButton);
            Controls.Add(greetingButton);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Name = "MainForm";
            Text = "Chuong trinh dau tien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label label1;
        private Button greetingButton;
        private Button copyButton;
        private Label label2;
        private TextBox copyTextBox;
    }
}
