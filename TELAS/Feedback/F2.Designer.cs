namespace WinFormsApp1.TELAS.Feedback
{
    partial class F2
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
            btnOpenKeyboard = new Button();
            btnProx = new Button();
            SuspendLayout();
            // 
            // btnOpenKeyboard
            // 
            btnOpenKeyboard.Location = new Point(125, 239);
            btnOpenKeyboard.Name = "btnOpenKeyboard";
            btnOpenKeyboard.Size = new Size(174, 47);
            btnOpenKeyboard.TabIndex = 0;
            btnOpenKeyboard.UseVisualStyleBackColor = true;
            btnOpenKeyboard.Click += btnOpenKeyboard_Click;
            // 
            // btnProx
            // 
            btnProx.Location = new Point(296, 537);
            btnProx.Name = "btnProx";
            btnProx.Size = new Size(117, 51);
            btnProx.TabIndex = 1;
            btnProx.UseVisualStyleBackColor = true;
            btnProx.Click += button1_Click;
            // 
            // F2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.F2;
            ClientSize = new Size(534, 721);
            Controls.Add(btnProx);
            Controls.Add(btnOpenKeyboard);
            Name = "F2";
            Text = "Museu Totem";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenKeyboard;
        private Button btnProx;
    }
}