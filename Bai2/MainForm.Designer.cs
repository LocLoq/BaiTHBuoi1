namespace Bai2
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
            groupBox1 = new GroupBox();
            femaleRB = new RadioButton();
            maleRB = new RadioButton();
            groupBox2 = new GroupBox();
            paintColorButton = new Button();
            blueRB = new RadioButton();
            redRB = new RadioButton();
            colorTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(femaleRB);
            groupBox1.Controls.Add(maleRB);
            groupBox1.Location = new Point(51, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn giới tính";
            // 
            // femaleRB
            // 
            femaleRB.AutoSize = true;
            femaleRB.Location = new Point(6, 70);
            femaleRB.Name = "femaleRB";
            femaleRB.Size = new Size(41, 19);
            femaleRB.TabIndex = 0;
            femaleRB.Text = "Nữ";
            femaleRB.UseVisualStyleBackColor = true;
            femaleRB.CheckedChanged += FemaleRB_CheckedChanged;
            // 
            // maleRB
            // 
            maleRB.AutoSize = true;
            maleRB.Checked = true;
            maleRB.Location = new Point(6, 45);
            maleRB.Name = "maleRB";
            maleRB.Size = new Size(51, 19);
            maleRB.TabIndex = 0;
            maleRB.TabStop = true;
            maleRB.Text = "Nam";
            maleRB.UseVisualStyleBackColor = true;
            maleRB.CheckedChanged += MaleRB_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(paintColorButton);
            groupBox2.Controls.Add(blueRB);
            groupBox2.Controls.Add(redRB);
            groupBox2.Location = new Point(341, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 140);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn màu";
            // 
            // paintColorButton
            // 
            paintColorButton.Location = new Point(104, 56);
            paintColorButton.Name = "paintColorButton";
            paintColorButton.Size = new Size(75, 23);
            paintColorButton.TabIndex = 1;
            paintColorButton.Text = "Tô màu";
            paintColorButton.UseVisualStyleBackColor = true;
            paintColorButton.Click += paintColorButton_Click;
            // 
            // blueRB
            // 
            blueRB.AutoSize = true;
            blueRB.Location = new Point(6, 70);
            blueRB.Name = "blueRB";
            blueRB.Size = new Size(77, 19);
            blueRB.TabIndex = 0;
            blueRB.Text = "Màu xanh";
            blueRB.UseVisualStyleBackColor = true;
            // 
            // redRB
            // 
            redRB.AutoSize = true;
            redRB.Checked = true;
            redRB.Location = new Point(6, 45);
            redRB.Name = "redRB";
            redRB.Size = new Size(66, 19);
            redRB.TabIndex = 0;
            redRB.TabStop = true;
            redRB.Text = "Màu đỏ";
            redRB.UseVisualStyleBackColor = true;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(577, 68);
            colorTextBox.Multiline = true;
            colorTextBox.Name = "colorTextBox";
            colorTextBox.ReadOnly = true;
            colorTextBox.Size = new Size(100, 82);
            colorTextBox.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(colorTextBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Bai tap 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton maleRB;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton femaleRB;
        private GroupBox groupBox2;
        private RadioButton blueRB;
        private RadioButton redRB;
        private Button paintColorButton;
        private TextBox colorTextBox;
    }
}
