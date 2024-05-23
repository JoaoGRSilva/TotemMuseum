namespace WinFormsApp1.TELAS.Resumo
{
    partial class Resumo___Nasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resumo___Nasa));
            BtnResumo = new Button();
            BtnCuriosidades = new Button();
            BtnGaleria = new Button();
            BtnAstronautas = new Button();
            BtnFeedBack = new Button();
            SuspendLayout();
            // 
            // BtnResumo
            // 
            BtnResumo.Location = new Point(25, 75);
            BtnResumo.Name = "BtnResumo";
            BtnResumo.Size = new Size(214, 63);
            BtnResumo.TabIndex = 10;
            BtnResumo.UseVisualStyleBackColor = true;
            BtnResumo.Click += BtnResumo_Click;
            // 
            // BtnCuriosidades
            // 
            BtnCuriosidades.BackgroundImageLayout = ImageLayout.Center;
            BtnCuriosidades.Cursor = Cursors.Hand;
            BtnCuriosidades.Location = new Point(266, 32);
            BtnCuriosidades.Name = "BtnCuriosidades";
            BtnCuriosidades.Size = new Size(76, 23);
            BtnCuriosidades.TabIndex = 9;
            BtnCuriosidades.UseVisualStyleBackColor = true;
            BtnCuriosidades.Click += BtnCuriosidades_Click;
            // 
            // BtnGaleria
            // 
            BtnGaleria.BackColor = Color.Transparent;
            BtnGaleria.Cursor = Cursors.Hand;
            BtnGaleria.ForeColor = Color.Transparent;
            BtnGaleria.Location = new Point(212, 32);
            BtnGaleria.Name = "BtnGaleria";
            BtnGaleria.Size = new Size(52, 23);
            BtnGaleria.TabIndex = 8;
            BtnGaleria.UseVisualStyleBackColor = false;
            BtnGaleria.Click += BtnGaleria_Click;
            // 
            // BtnAstronautas
            // 
            BtnAstronautas.BackColor = Color.Transparent;
            BtnAstronautas.Cursor = Cursors.Hand;
            BtnAstronautas.ForeColor = Color.Transparent;
            BtnAstronautas.Location = new Point(138, 32);
            BtnAstronautas.Name = "BtnAstronautas";
            BtnAstronautas.Size = new Size(68, 23);
            BtnAstronautas.TabIndex = 7;
            BtnAstronautas.UseVisualStyleBackColor = false;
            BtnAstronautas.Click += BtnAstronautas_Click_1;
            // 
            // BtnFeedBack
            // 
            BtnFeedBack.Location = new Point(345, 12);
            BtnFeedBack.Name = "BtnFeedBack";
            BtnFeedBack.Size = new Size(75, 62);
            BtnFeedBack.TabIndex = 11;
            BtnFeedBack.TextAlign = ContentAlignment.BottomCenter;
            BtnFeedBack.UseVisualStyleBackColor = true;
            BtnFeedBack.Click += BtnFeedBack_Click;
            // 
            // Resumo___Nasa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(534, 721);
            Controls.Add(BtnFeedBack);
            Controls.Add(BtnResumo);
            Controls.Add(BtnCuriosidades);
            Controls.Add(BtnGaleria);
            Controls.Add(BtnAstronautas);
            Name = "Resumo___Nasa";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnResumo;
        private Button BtnCuriosidades;
        private Button BtnGaleria;
        private Button BtnAstronautas;
        private Button BtnFeedBack;
    }
}