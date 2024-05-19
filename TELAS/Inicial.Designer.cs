namespace WinFormsApp1
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            BtnClique = new Button();
            SuspendLayout();
            // 
            // BtnClique
            // 
            BtnClique.Location = new Point(2, 0);
            BtnClique.Name = "BtnClique";
            BtnClique.Size = new Size(464, 815);
            BtnClique.TabIndex = 0;
            BtnClique.UseVisualStyleBackColor = true;
            BtnClique.Click += button1_Click;
            // 
            // Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(464, 815);
            Controls.Add(BtnClique);
            Name = "Inicial";
            Text = "TELA AFK";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnClique;
        
    }
}
