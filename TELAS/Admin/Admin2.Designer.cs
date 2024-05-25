namespace WinFormsApp1.TELAS.Admin
{
    partial class Admin2
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
            lblF3 = new Label();
            lblf5 = new Label();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblF3
            // 
            lblF3.AutoSize = true;
            lblF3.BackColor = Color.Transparent;
            lblF3.Font = new Font("Lembra Test XBold", 11.9999981F, FontStyle.Bold);
            lblF3.ForeColor = Color.MintCream;
            lblF3.Location = new Point(59, 161);
            lblF3.Name = "lblF3";
            lblF3.Size = new Size(57, 19);
            lblF3.TabIndex = 0;
            lblF3.Text = "label1";
            // 
            // lblf5
            // 
            lblf5.AutoSize = true;
            lblf5.BackColor = Color.Transparent;
            lblf5.Font = new Font("Lembra Test XBold", 11.9999981F, FontStyle.Bold);
            lblf5.ForeColor = Color.MintCream;
            lblf5.Location = new Point(59, 348);
            lblf5.Name = "lblf5";
            lblf5.Size = new Size(57, 19);
            lblf5.TabIndex = 1;
            lblf5.Text = "label1";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(21, 547);
            button1.Name = "button1";
            button1.Size = new Size(72, 63);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(459, 641);
            button2.Name = "button2";
            button2.Size = new Size(81, 84);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lembra Test XBold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(59, 123);
            label1.Name = "label1";
            label1.Size = new Size(318, 25);
            label1.TabIndex = 4;
            label1.Text = "O que gostariam de ver a mais:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lembra Test XBold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(59, 314);
            label2.Name = "label2";
            label2.Size = new Size(406, 25);
            label2.TabIndex = 5;
            label2.Text = "Possiveis dificuldades de uso no totem:";
            // 
            // Admin2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.admGeral1;
            ClientSize = new Size(534, 721);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblf5);
            Controls.Add(lblF3);
            Name = "Admin2";
            Text = "Admin2";
            Load += Admin2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblF3;
        private Label lblf5;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}