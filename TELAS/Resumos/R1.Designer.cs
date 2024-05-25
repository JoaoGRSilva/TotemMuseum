namespace WinFormsApp1.TELAS
{
    partial class R1
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
            BtnAstronautas = new Button();
            BtnGaleria = new Button();
            BtnCuriosidades = new Button();
            BtnNeil = new Button();
            BtnApollo = new Button();
            BtnNasa = new Button();
            BtnFeedBack = new Button();
            BtnAdm = new Button();
            SuspendLayout();
            // 
            // BtnAstronautas
            // 
            BtnAstronautas.BackColor = Color.Transparent;
            BtnAstronautas.Cursor = Cursors.Hand;
            BtnAstronautas.ForeColor = Color.Transparent;
            BtnAstronautas.Location = new Point(130, 12);
            BtnAstronautas.Name = "BtnAstronautas";
            BtnAstronautas.Size = new Size(78, 62);
            BtnAstronautas.TabIndex = 0;
            BtnAstronautas.UseVisualStyleBackColor = false;
            BtnAstronautas.Click += BtnAstronautas_Click;
            // 
            // BtnGaleria
            // 
            BtnGaleria.BackColor = Color.Transparent;
            BtnGaleria.Cursor = Cursors.Hand;
            BtnGaleria.ForeColor = Color.Transparent;
            BtnGaleria.Location = new Point(208, 12);
            BtnGaleria.Name = "BtnGaleria";
            BtnGaleria.Size = new Size(58, 62);
            BtnGaleria.TabIndex = 1;
            BtnGaleria.UseVisualStyleBackColor = false;
            BtnGaleria.Click += BtnGaleria_Click;
            // 
            // BtnCuriosidades
            // 
            BtnCuriosidades.Cursor = Cursors.Hand;
            BtnCuriosidades.Location = new Point(266, 12);
            BtnCuriosidades.Name = "BtnCuriosidades";
            BtnCuriosidades.Size = new Size(69, 62);
            BtnCuriosidades.TabIndex = 2;
            BtnCuriosidades.UseVisualStyleBackColor = true;
            BtnCuriosidades.Click += BtnCuriosidades_Click;
            // 
            // BtnNeil
            // 
            BtnNeil.Cursor = Cursors.Hand;
            BtnNeil.Location = new Point(101, 278);
            BtnNeil.Name = "BtnNeil";
            BtnNeil.Size = new Size(110, 48);
            BtnNeil.TabIndex = 3;
            BtnNeil.UseVisualStyleBackColor = true;
            BtnNeil.Click += BtnNeil_Click;
            // 
            // BtnApollo
            // 
            BtnApollo.Cursor = Cursors.Hand;
            BtnApollo.Location = new Point(208, 411);
            BtnApollo.Name = "BtnApollo";
            BtnApollo.Size = new Size(139, 79);
            BtnApollo.TabIndex = 4;
            BtnApollo.UseVisualStyleBackColor = true;
            BtnApollo.Click += BtnApollo_Click;
            // 
            // BtnNasa
            // 
            BtnNasa.Cursor = Cursors.Hand;
            BtnNasa.Location = new Point(101, 580);
            BtnNasa.Name = "BtnNasa";
            BtnNasa.Size = new Size(110, 89);
            BtnNasa.TabIndex = 5;
            BtnNasa.UseVisualStyleBackColor = true;
            BtnNasa.Click += BtnNasa_Click;
            // 
            // BtnFeedBack
            // 
            BtnFeedBack.Cursor = Cursors.Hand;
            BtnFeedBack.Location = new Point(342, 12);
            BtnFeedBack.Name = "BtnFeedBack";
            BtnFeedBack.Size = new Size(75, 62);
            BtnFeedBack.TabIndex = 6;
            BtnFeedBack.TextAlign = ContentAlignment.BottomCenter;
            BtnFeedBack.UseVisualStyleBackColor = true;
            BtnFeedBack.Click += BtnFeedBack_Click;
            // 
            // BtnAdm
            // 
            BtnAdm.Cursor = Cursors.Hand;
            BtnAdm.Location = new Point(429, 11);
            BtnAdm.Name = "BtnAdm";
            BtnAdm.Size = new Size(82, 72);
            BtnAdm.TabIndex = 7;
            BtnAdm.UseVisualStyleBackColor = true;
            BtnAdm.Click += BtnAdm_Click;
            // 
            // R1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.R1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(534, 721);
            Controls.Add(BtnAdm);
            Controls.Add(BtnFeedBack);
            Controls.Add(BtnNasa);
            Controls.Add(BtnApollo);
            Controls.Add(BtnNeil);
            Controls.Add(BtnCuriosidades);
            Controls.Add(BtnGaleria);
            Controls.Add(BtnAstronautas);
            DoubleBuffered = true;
            Name = "R1";
            Text = "Museu Totem";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAstronautas;
        private Button BtnGaleria;
        private Button BtnCuriosidades;
        private Button BtnNeil;
        private Button BtnApollo;
        private Button BtnNasa;
        private Button BtnFeedBack;
        private Button BtnAdm;
    }
}