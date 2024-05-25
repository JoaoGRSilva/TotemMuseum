namespace WinFormsApp1.TELAS.Resumos
{
    partial class AdmLogin
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
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new MaskedTextBox();
            BtnSair = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(385, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 44);
            btnLogin.TabIndex = 0;
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(209, 139);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(174, 23);
            txtUsername.TabIndex = 1;
            txtUsername.Click += ShowKeyboard;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(209, 196);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(174, 23);
            txtPassword.TabIndex = 2;
            txtPassword.Click += ShowKeyboardPW;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(442, 94);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(61, 51);
            BtnSair.TabIndex = 3;
            BtnSair.UseVisualStyleBackColor = true;
            // 
            // AdmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.admlogin;
            ClientSize = new Size(534, 721);
            Controls.Add(BtnSair);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "AdmLogin";
            Text = "AdmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsername;
        private MaskedTextBox txtPassword;
        private Button BtnSair;
    }
}