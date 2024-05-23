namespace WinFormsApp1.TELAS
{
    partial class Resumo___Curiosidades
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
            BtnResumo = new Button();
            BtnAstronautas = new Button();
            BtnGaleria = new Button();
            BtnFeedBack = new Button();
            SuspendLayout();
            // 
            // BtnResumo
            // 
            BtnResumo.Location = new Point(67, 21);
            BtnResumo.Name = "BtnResumo";
            BtnResumo.Size = new Size(65, 40);
            BtnResumo.TabIndex = 0;
            BtnResumo.UseVisualStyleBackColor = true;
            BtnResumo.Click += button1_Click;
            // 
            // BtnAstronautas
            // 
            BtnAstronautas.Location = new Point(133, 21);
            BtnAstronautas.Name = "BtnAstronautas";
            BtnAstronautas.Size = new Size(76, 40);
            BtnAstronautas.TabIndex = 1;
            BtnAstronautas.UseVisualStyleBackColor = true;
            BtnAstronautas.Click += BtnAstronautas_Click;
            // 
            // BtnGaleria
            // 
            BtnGaleria.Location = new Point(212, 21);
            BtnGaleria.Name = "BtnGaleria";
            BtnGaleria.Size = new Size(53, 40);
            BtnGaleria.TabIndex = 2;
            BtnGaleria.UseVisualStyleBackColor = true;
            BtnGaleria.Click += button3_Click;
            // 
            // BtnFeedBack
            // 
            BtnFeedBack.Location = new Point(334, 12);
            BtnFeedBack.Name = "BtnFeedBack";
            BtnFeedBack.Size = new Size(75, 62);
            BtnFeedBack.TabIndex = 7;
            BtnFeedBack.TextAlign = ContentAlignment.BottomCenter;
            BtnFeedBack.UseVisualStyleBackColor = true;
            BtnFeedBack.Click += BtnFeedBack_Click;
            // 
            // Resumo___Curiosidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RCuriosidades;
            ClientSize = new Size(534, 721);
            Controls.Add(BtnFeedBack);
            Controls.Add(BtnGaleria);
            Controls.Add(BtnAstronautas);
            Controls.Add(BtnResumo);
            Name = "Resumo___Curiosidades";
            ShowInTaskbar = false;
            Text = "Museu Totem";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnResumo;
        private Button BtnAstronautas;
        private Button BtnGaleria;
        private Button BtnFeedBack;
    }
}