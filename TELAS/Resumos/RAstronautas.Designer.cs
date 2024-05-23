namespace WinFormsApp1.TELAS
{
    partial class Resumo___Astronautas
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
            BtnGaleria = new Button();
            BtnCuriosidades = new Button();
            BtnMichael = new Button();
            BtnBuzz = new Button();
            BtnNeil = new Button();
            BtnFeedBack = new Button();
            SuspendLayout();
            // 
            // BtnResumo
            // 
            BtnResumo.Cursor = Cursors.Hand;
            BtnResumo.Location = new Point(77, 21);
            BtnResumo.Name = "BtnResumo";
            BtnResumo.Size = new Size(60, 40);
            BtnResumo.TabIndex = 0;
            BtnResumo.UseVisualStyleBackColor = true;
            BtnResumo.Click += BtnResumo_Click;
            // 
            // BtnGaleria
            // 
            BtnGaleria.Cursor = Cursors.Hand;
            BtnGaleria.Location = new Point(206, 21);
            BtnGaleria.Name = "BtnGaleria";
            BtnGaleria.Size = new Size(60, 40);
            BtnGaleria.TabIndex = 1;
            BtnGaleria.UseVisualStyleBackColor = true;
            BtnGaleria.Click += BtnGaleria_Click;
            // 
            // BtnCuriosidades
            // 
            BtnCuriosidades.Cursor = Cursors.Hand;
            BtnCuriosidades.Location = new Point(266, 21);
            BtnCuriosidades.Name = "BtnCuriosidades";
            BtnCuriosidades.Size = new Size(75, 40);
            BtnCuriosidades.TabIndex = 2;
            BtnCuriosidades.UseVisualStyleBackColor = true;
            BtnCuriosidades.Click += BtnCuriosidades_Click;
            // 
            // BtnMichael
            // 
            BtnMichael.Cursor = Cursors.Hand;
            BtnMichael.Location = new Point(290, 195);
            BtnMichael.Name = "BtnMichael";
            BtnMichael.Size = new Size(87, 50);
            BtnMichael.TabIndex = 3;
            BtnMichael.UseVisualStyleBackColor = true;
            BtnMichael.Click += BtnMichael_Click;
            // 
            // BtnBuzz
            // 
            BtnBuzz.Cursor = Cursors.Hand;
            BtnBuzz.Location = new Point(353, 434);
            BtnBuzz.Name = "BtnBuzz";
            BtnBuzz.Size = new Size(105, 69);
            BtnBuzz.TabIndex = 4;
            BtnBuzz.UseVisualStyleBackColor = true;
            BtnBuzz.Click += BtnBuzz_Click;
            // 
            // BtnNeil
            // 
            BtnNeil.Cursor = Cursors.Hand;
            BtnNeil.Location = new Point(266, 650);
            BtnNeil.Name = "BtnNeil";
            BtnNeil.Size = new Size(89, 59);
            BtnNeil.TabIndex = 5;
            BtnNeil.UseVisualStyleBackColor = true;
            BtnNeil.Click += BtnNeil_Click;
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
            // Resumo___Astronautas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RAstronauta;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(534, 721);
            Controls.Add(BtnFeedBack);
            Controls.Add(BtnNeil);
            Controls.Add(BtnBuzz);
            Controls.Add(BtnMichael);
            Controls.Add(BtnCuriosidades);
            Controls.Add(BtnGaleria);
            Controls.Add(BtnResumo);
            DoubleBuffered = true;
            Name = "Resumo___Astronautas";
            Text = "Museu Totem";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnResumo;
        private Button BtnGaleria;
        private Button BtnCuriosidades;
        private Button BtnMichael;
        private Button BtnBuzz;
        private Button BtnNeil;
        private Button BtnFeedBack;
    }
}