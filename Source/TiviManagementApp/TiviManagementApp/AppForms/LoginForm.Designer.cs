namespace TiviManagementApp
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorMsg = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(84, 57);
            label1.Name = "label1";
            label1.Size = new Size(268, 54);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(38, 185);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(38, 295);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // errorMsg
            // 
            errorMsg.AutoSize = true;
            errorMsg.Font = new Font("Segoe UI", 10F);
            errorMsg.ForeColor = Color.Red;
            errorMsg.Location = new Point(70, 463);
            errorMsg.Name = "errorMsg";
            errorMsg.Size = new Size(346, 23);
            errorMsg.TabIndex = 4;
            errorMsg.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI Light", 14F);
            usernameTextBox.Location = new Point(170, 178);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(267, 39);
            usernameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14F);
            passwordTextBox.Location = new Point(170, 288);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(267, 39);
            passwordTextBox.TabIndex = 6;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.White;
            loginBtn.Font = new Font("Segoe UI", 12F);
            loginBtn.Location = new Point(170, 369);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(140, 71);
            loginBtn.TabIndex = 7;
            loginBtn.Text = "Đăng nhập!";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_TV1;
            pictureBox1.Location = new Point(371, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(480, 509);
            Controls.Add(pictureBox1);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(errorMsg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label errorMsg;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginBtn;
        private PictureBox pictureBox1;
    }
}
