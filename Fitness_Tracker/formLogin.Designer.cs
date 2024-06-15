namespace Fitness_Tracker
{
    partial class formLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoginLogin = new Button();
            btnLoginCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblLoginRegister = new Label();
            tbLoginName = new TextBox();
            tbLoginPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.Location = new Point(184, 237);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(75, 23);
            btnLoginLogin.TabIndex = 0;
            btnLoginLogin.Text = "Login";
            btnLoginLogin.UseVisualStyleBackColor = true;
            btnLoginLogin.Click += btnLoginLogin_Click;
            // 
            // btnLoginCancel
            // 
            btnLoginCancel.Location = new Point(299, 237);
            btnLoginCancel.Name = "btnLoginCancel";
            btnLoginCancel.Size = new Size(75, 23);
            btnLoginCancel.TabIndex = 1;
            btnLoginCancel.Text = "Cancel";
            btnLoginCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 93);
            label1.Name = "label1";
            label1.Size = new Size(35, 18);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 164);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 287);
            label3.Name = "label3";
            label3.Size = new Size(121, 18);
            label3.TabIndex = 4;
            label3.Text = "Don't have an account?";
            // 
            // lblLoginRegister
            // 
            lblLoginRegister.AutoSize = true;
            lblLoginRegister.ForeColor = SystemColors.Highlight;
            lblLoginRegister.Location = new Point(311, 287);
            lblLoginRegister.Name = "lblLoginRegister";
            lblLoginRegister.Size = new Size(48, 18);
            lblLoginRegister.TabIndex = 5;
            lblLoginRegister.Text = "Register";
            lblLoginRegister.Click += lblLoginRegister_Click;
            // 
            // tbLoginName
            // 
            tbLoginName.Location = new Point(220, 86);
            tbLoginName.Name = "tbLoginName";
            tbLoginName.Size = new Size(100, 25);
            tbLoginName.TabIndex = 6;
            // 
            // tbLoginPassword
            // 
            tbLoginPassword.Location = new Point(220, 157);
            tbLoginPassword.Name = "tbLoginPassword";
            tbLoginPassword.Size = new Size(100, 25);
            tbLoginPassword.TabIndex = 7;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(6F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbLoginPassword);
            Controls.Add(tbLoginName);
            Controls.Add(lblLoginRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoginCancel);
            Controls.Add(btnLoginLogin);
            Name = "formLogin";
            Text = "formLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginLogin;
        private Button btnLoginCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblLoginRegister;
        private TextBox tbLoginName;
        private TextBox tbLoginPassword;
    }
}