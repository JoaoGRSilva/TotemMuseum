namespace WinFormsApp1.TELAS.Resumo
{
    partial class resumo_neil
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
            BtnCuriosidades = new Button();
            BtnGaleria = new Button();
            BtnAstronautas = new Button();
            BtnResumo = new Button();
            BtnFeedBack = new Button();
            SuspendLayout();
            // 
            // BtnCuriosidades
            // 
            BtnCuriosidades.Cursor = Cursors.Hand;
            BtnCuriosidades.Location = new Point(266, 30);
            BtnCuriosidades.Name = "BtnCuriosidades";
            BtnCuriosidades.Size = new Size(70, 23);
            BtnCuriosidades.TabIndex = 5;
            BtnCuriosidades.UseVisualStyleBackColor = true;
            BtnCuriosidades.Click += BtnCuriosidades_Click_1;
            // 
            // BtnGaleria
            // 
            BtnGaleria.BackColor = Color.Transparent;
            BtnGaleria.Cursor = Cursors.Hand;
            BtnGaleria.ForeColor = Color.Transparent;
            BtnGaleria.Location = new Point(212, 30);
            BtnGaleria.Name = "BtnGaleria";
            BtnGaleria.Size = new Size(52, 23);
            BtnGaleria.TabIndex = 4;
            BtnGaleria.UseVisualStyleBackColor = false;
            BtnGaleria.Click += BtnGaleria_Click_1;
            // 
            // BtnAstronautas
            // 
            BtnAstronautas.BackColor = Color.Transparent;
            BtnAstronautas.Cursor = Cursors.Hand;
            BtnAstronautas.ForeColor = Color.Transparent;
            BtnAstronautas.Location = new Point(138, 30);
            BtnAstronautas.Name = "BtnAstronautas";
            BtnAstronautas.Size = new Size(68, 23);
            BtnAstronautas.TabIndex = 3;
            BtnAstronautas.UseVisualStyleBackColor = false;
            BtnAstronautas.Click += BtnAstronautas_Click;
            // 
            // BtnResumo
            // 
            BtnResumo.Location = new Point(25, 73);
            BtnResumo.Name = "BtnResumo";
            BtnResumo.Size = new Size(214, 63);
            BtnResumo.TabIndex = 6;
            BtnResumo.UseVisualStyleBackColor = true;
            BtnResumo.Click += BtnResumo_Click_1;
            // 
            // BtnFeedBack
            // 
            BtnFeedBack.Location = new Point(342, 12);
            BtnFeedBack.Name = "BtnFeedBack";
            BtnFeedBack.Size = new Size(75, 62);
            BtnFeedBack.TabIndex = 7;
            BtnFeedBack.TextAlign = ContentAlignment.BottomCenter;
            BtnFeedBack.UseVisualStyleBackColor = true;
            BtnFeedBack.Click += BtnFeedBack_Click;
            // 
            // resumo_neil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RNeil;
            ClientSize = new Size(534, 721);
            Controls.Add(BtnFeedBack);
            Controls.Add(BtnResumo);
            Controls.Add(BtnCuriosidades);
            Controls.Add(BtnGaleria);
            Controls.Add(BtnAstronautas);
            Name = "resumo_neil";
            Text = "Museu Totem";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCuriosidades;
        private Button BtnGaleria;
        private Button BtnAstronautas;
        private Button BtnResumo;
        private Button BtnFeedBack;
    }
}