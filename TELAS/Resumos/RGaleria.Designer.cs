namespace WinFormsApp1.TELAS
{
    partial class Resumo___Galeria
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
            BtnCuriosidades = new Button();
            SuspendLayout();
            // 
            // BtnResumo
            // 
            BtnResumo.Cursor = Cursors.Hand;
            BtnResumo.Location = new Point(75, 22);
            BtnResumo.Name = "BtnResumo";
            BtnResumo.Size = new Size(60, 40);
            BtnResumo.TabIndex = 1;
            BtnResumo.UseVisualStyleBackColor = true;
            BtnResumo.Click += BtnResumo_Click;
            // 
            // BtnAstronautas
            // 
            BtnAstronautas.Cursor = Cursors.Hand;
            BtnAstronautas.Location = new Point(139, 20);
            BtnAstronautas.Name = "BtnAstronautas";
            BtnAstronautas.Size = new Size(71, 44);
            BtnAstronautas.TabIndex = 2;
            BtnAstronautas.UseVisualStyleBackColor = true;
            BtnAstronautas.Click += button1_Click;
            // 
            // BtnCuriosidades
            // 
            BtnCuriosidades.Cursor = Cursors.Hand;
            BtnCuriosidades.Location = new Point(260, 22);
            BtnCuriosidades.Name = "BtnCuriosidades";
            BtnCuriosidades.Size = new Size(83, 40);
            BtnCuriosidades.TabIndex = 3;
            BtnCuriosidades.UseVisualStyleBackColor = true;
            BtnCuriosidades.Click += BtnCuriosidades_Click;
            // 
            // Resumo___Galeria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RGaleria;
            ClientSize = new Size(534, 721);
            Controls.Add(BtnCuriosidades);
            Controls.Add(BtnAstronautas);
            Controls.Add(BtnResumo);
            Name = "Resumo___Galeria";
            Text = "Museu Totem";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnResumo;
        private Button BtnAstronautas;
        private Button BtnCuriosidades;
    }
}