﻿namespace WinFormsApp1
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
            BtnClique.Location = new Point(0, -3);
            BtnClique.Name = "BtnClique";
            BtnClique.Size = new Size(534, 730);
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
            ClientSize = new Size(534, 721);
            Controls.Add(BtnClique);
            Name = "Inicial";
            Text = "Museu Totem";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnClique;
        
    }
}
