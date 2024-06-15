namespace Fitness_Tracker
{
    partial class formRegistration
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
            lblRegisterName = new Label();
            label2 = new Label();
            btnRegisterRegister = new Button();
            btnRegisterClear = new Button();
            label3 = new Label();
            tbRegisterName = new TextBox();
            tbRegisterPassword = new TextBox();
            lblRegisterLogin = new Label();
            SuspendLayout();
            // 
            // lblRegisterName
            // 
            lblRegisterName.AutoSize = true;
            lblRegisterName.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegisterName.Location = new Point(109, 74);
            lblRegisterName.Name = "lblRegisterName";
            lblRegisterName.Size = new Size(32, 15);
            lblRegisterName.TabIndex = 0;
            lblRegisterName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 139);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // btnRegisterRegister
            // 
            btnRegisterRegister.Location = new Point(225, 208);
            btnRegisterRegister.Name = "btnRegisterRegister";
            btnRegisterRegister.Size = new Size(75, 23);
            btnRegisterRegister.TabIndex = 2;
            btnRegisterRegister.Text = "Register";
            btnRegisterRegister.UseVisualStyleBackColor = true;
            btnRegisterRegister.Click += btnRegisterRegister_Click;
            // 
            // btnRegisterClear
            // 
            btnRegisterClear.Location = new Point(363, 208);
            btnRegisterClear.Name = "btnRegisterClear";
            btnRegisterClear.Size = new Size(75, 23);
            btnRegisterClear.TabIndex = 3;
            btnRegisterClear.Text = "Clear";
            btnRegisterClear.UseVisualStyleBackColor = true;
            btnRegisterClear.Click += btnRegisterClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 256);
            label3.Name = "label3";
            label3.Size = new Size(133, 18);
            label3.TabIndex = 4;
            label3.Text = "Have already an account?";
            // 
            // tbRegisterName
            // 
            tbRegisterName.Location = new Point(225, 71);
            tbRegisterName.Name = "tbRegisterName";
            tbRegisterName.Size = new Size(100, 25);
            tbRegisterName.TabIndex = 5;
            // 
            // tbRegisterPassword
            // 
            tbRegisterPassword.Location = new Point(225, 136);
            tbRegisterPassword.Name = "tbRegisterPassword";
            tbRegisterPassword.Size = new Size(100, 25);
            tbRegisterPassword.TabIndex = 6;
            // 
            // lblRegisterLogin
            // 
            lblRegisterLogin.AutoSize = true;
            lblRegisterLogin.ForeColor = SystemColors.Highlight;
            lblRegisterLogin.Location = new Point(363, 256);
            lblRegisterLogin.Name = "lblRegisterLogin";
            lblRegisterLogin.Size = new Size(33, 18);
            lblRegisterLogin.TabIndex = 7;
            lblRegisterLogin.Text = "Login";
            lblRegisterLogin.Click += lblRegisterLogin_Click;
            // 
            // formRegistration
            // 
            AutoScaleDimensions = new SizeF(6F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRegisterLogin);
            Controls.Add(tbRegisterPassword);
            Controls.Add(tbRegisterName);
            Controls.Add(label3);
            Controls.Add(btnRegisterClear);
            Controls.Add(btnRegisterRegister);
            Controls.Add(label2);
            Controls.Add(lblRegisterName);
            Name = "formRegistration";
            Text = "Registration Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegisterName;
        private Label label2;
        private Button btnRegisterRegister;
        private Button btnRegisterClear;
        private Label label3;
        private TextBox tbRegisterName;
        private TextBox tbRegisterPassword;
        private Label lblRegisterLogin;
    }
}
