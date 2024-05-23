namespace WinFormsApp1.TELAS.Resumos
{
    partial class RMichael
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
            BtnFeedBack = new Button();
            BtnCuriosidades = new Button();
            BtnGaleria = new Button();
            BtnAstronautas = new Button();
            BtnResumo = new Button();
            SuspendLayout();
            // 
            // BtnFeedBack
            // 
            BtnFeedBack.Location = new Point(341, 12);
            BtnFeedBack.Name = "BtnFeedBack";
            BtnFeedBack.Size = new Size(75, 62);
            BtnFeedBack.TabIndex = 10;
            BtnFeedBack.TextAlign = ContentAlignment.BottomCenter;
            BtnFeedBack.UseVisualStyleBackColor = true;

            // 
            // BtnCuriosidades
            // 
            BtnCuriosidades.Cursor = Cursors.Hand;
            BtnCuriosidades.Location = new Point(267, 12);
            BtnCuriosidades.Name = "BtnCuriosidades";
            BtnCuriosidades.Size = new Size(74, 62);
            BtnCuriosidades.TabIndex = 9;
            BtnCuriosidades.UseVisualStyleBackColor = true;
            BtnCuriosidades.Click += BtnCuriosidades_Click;
            // 
            // BtnGaleria
            // 
            BtnGaleria.BackColor = Color.Transparent;
            BtnGaleria.Cursor = Cursors.Hand;
            BtnGaleria.ForeColor = Color.Transparent;
            BtnGaleria.Location = new Point(213, 12);
            BtnGaleria.Name = "BtnGaleria";
            BtnGaleria.Size = new Size(52, 62);
            BtnGaleria.TabIndex = 8;
            BtnGaleria.UseVisualStyleBackColor = false;
            BtnGaleria.Click += BtnGaleria_Click;
            // 
            // BtnAstronautas
            // 
            BtnAstronautas.BackColor = Color.Transparent;
            BtnAstronautas.Cursor = Cursors.Hand;
            BtnAstronautas.ForeColor = Color.Transparent;
            BtnAstronautas.Location = new Point(139, 12);
            BtnAstronautas.Name = "BtnAstronautas";
            BtnAstronautas.Size = new Size(68, 62);
            BtnAstronautas.TabIndex = 7;
            BtnAstronautas.UseVisualStyleBackColor = false;
            BtnAstronautas.Click += BtnAstronautas_Click_1;
            // 
            // BtnResumo
            // 
            BtnResumo.Location = new Point(24, 86);
            BtnResumo.Name = "BtnResumo";
            BtnResumo.Size = new Size(225, 56);
            BtnResumo.TabIndex = 11;
            BtnResumo.UseVisualStyleBackColor = true;
            BtnResumo.Click += BtnResumo_Click;
            // 
            // RMichael
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RMichael;
            ClientSize = new Size(534, 721);
            Controls.Add(BtnResumo);
            Controls.Add(BtnFeedBack);
            Controls.Add(BtnCuriosidades);
            Controls.Add(BtnGaleria);
            Controls.Add(BtnAstronautas);
            Name = "RMichael";
            Text = "Museu Totem";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnFeedBack;
        private Button BtnCuriosidades;
        private Button BtnGaleria;
        private Button BtnAstronautas;
        private Button BtnResumo;
    }
}