namespace WinFormsApp1.TELAS
{
    partial class Resumo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resumo1));
            BtnAstronautas = new Button();
            BtnGaleria = new Button();
            BtnCuriosidades = new Button();
            BtnNeil = new Button();
            BtnApollo = new Button();
            BtnNasa = new Button();
            SuspendLayout();
            // 
            // BtnAstronautas
            // 
            BtnAstronautas.BackColor = Color.Transparent;
            BtnAstronautas.Cursor = Cursors.Hand;
            BtnAstronautas.ForeColor = Color.Transparent;
            BtnAstronautas.Location = new Point(118, 36);
            BtnAstronautas.Name = "BtnAstronautas";
            BtnAstronautas.Size = new Size(63, 23);
            BtnAstronautas.TabIndex = 0;
            BtnAstronautas.UseVisualStyleBackColor = false;
            BtnAstronautas.Click += BtnAstronautas_Click;
            // 
            // BtnGaleria
            // 
            BtnGaleria.BackColor = Color.Transparent;
            BtnGaleria.Cursor = Cursors.Hand;
            BtnGaleria.ForeColor = Color.Transparent;
            BtnGaleria.Location = new Point(184, 36);
            BtnGaleria.Name = "BtnGaleria";
            BtnGaleria.Size = new Size(41, 23);
            BtnGaleria.TabIndex = 1;
            BtnGaleria.UseVisualStyleBackColor = false;
            BtnGaleria.Click += BtnGaleria_Click;
            // 
            // BtnCuriosidades
            // 
            BtnCuriosidades.Location = new Point(231, 36);
            BtnCuriosidades.Name = "BtnCuriosidades";
            BtnCuriosidades.Size = new Size(59, 23);
            BtnCuriosidades.TabIndex = 2;
            BtnCuriosidades.UseVisualStyleBackColor = true;
            BtnCuriosidades.Click += BtnCuriosidades_Click;
            // 
            // BtnNeil
            // 
            BtnNeil.Location = new Point(91, 322);
            BtnNeil.Name = "BtnNeil";
            BtnNeil.Size = new Size(72, 37);
            BtnNeil.TabIndex = 3;
            BtnNeil.UseVisualStyleBackColor = true;
            BtnNeil.Click += BtnNeil_Click;
            // 
            // BtnApollo
            // 
            BtnApollo.Location = new Point(201, 485);
            BtnApollo.Name = "BtnApollo";
            BtnApollo.Size = new Size(75, 43);
            BtnApollo.TabIndex = 4;
            BtnApollo.UseVisualStyleBackColor = true;
            BtnApollo.Click += BtnApollo_Click;
            // 
            // BtnNasa
            // 
            BtnNasa.Location = new Point(91, 696);
            BtnNasa.Name = "BtnNasa";
            BtnNasa.Size = new Size(90, 41);
            BtnNasa.TabIndex = 5;
            BtnNasa.TabStop = false;
            BtnNasa.UseVisualStyleBackColor = true;
            BtnNasa.Click += BtnNasa_Click;
            // 
            // Resumo1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(464, 815);
            Controls.Add(BtnNasa);
            Controls.Add(BtnApollo);
            Controls.Add(BtnNeil);
            Controls.Add(BtnCuriosidades);
            Controls.Add(BtnGaleria);
            Controls.Add(BtnAstronautas);
            Name = "Resumo1";
            Text = "Resumo";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAstronautas;
        private Button BtnGaleria;
        private Button BtnCuriosidades;
        private Button BtnNeil;
        private Button BtnApollo;
        private Button BtnNasa;
    }
}