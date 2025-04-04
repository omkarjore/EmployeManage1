namespace EmployeManage1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UNameTb = new TextBox();
            PasswordTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LoginBtn = new Button();
            ResetLbl = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 724);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(741, 24);
            label1.Name = "label1";
            label1.Size = new Size(176, 33);
            label1.TabIndex = 2;
            label1.Text = "Employe M S";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(705, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // UNameTb
            // 
            UNameTb.BackColor = Color.White;
            UNameTb.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNameTb.Location = new Point(651, 379);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(357, 38);
            UNameTb.TabIndex = 4;
            // 
            // PasswordTb
            // 
            PasswordTb.BackColor = Color.White;
            PasswordTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordTb.Location = new Point(651, 482);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(357, 34);
            PasswordTb.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(651, 329);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(651, 437);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.White;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(768, 564);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(149, 46);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ResetLbl
            // 
            ResetLbl.AutoSize = true;
            ResetLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetLbl.Location = new Point(815, 623);
            ResetLbl.Name = "ResetLbl";
            ResetLbl.Size = new Size(61, 28);
            ResetLbl.TabIndex = 9;
            ResetLbl.Text = "Reset";
            ResetLbl.Click += ResetLbl_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1147, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1219, 724);
            Controls.Add(pictureBox2);
            Controls.Add(ResetLbl);
            Controls.Add(LoginBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordTb);
            Controls.Add(UNameTb);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox UNameTb;
        private TextBox PasswordTb;
        private Label label2;
        private Label label3;
        private Button LoginBtn;
        private Label ResetLbl;
        private PictureBox pictureBox2;
    }
}
