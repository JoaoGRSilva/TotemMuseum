namespace WinFormsApp1.TELAS.Feedback
{
    partial class F4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F4));
            BtnSim1 = new Button();
            BtnNao1 = new Button();
            BtnSim = new Button();
            BtnNao = new Button();
            button1 = new Button();
            btnUm = new Button();
            BtnDois = new Button();
            BtnTres = new Button();
            BtnQuatro = new Button();
            BtnCinco = new Button();
            SuspendLayout();
            // 
            // BtnSim1
            // 
            BtnSim1.Cursor = Cursors.Hand;
            BtnSim1.Location = new Point(128, 234);
            BtnSim1.Name = "BtnSim1";
            BtnSim1.Size = new Size(100, 45);
            BtnSim1.TabIndex = 0;
            BtnSim1.Tag = "1";
            BtnSim1.TextAlign = ContentAlignment.MiddleRight;
            BtnSim1.UseVisualStyleBackColor = true;
            BtnSim1.Click += checkExpect;
            // 
            // BtnNao1
            // 
            BtnNao1.Cursor = Cursors.Hand;
            BtnNao1.Location = new Point(230, 234);
            BtnNao1.Name = "BtnNao1";
            BtnNao1.Size = new Size(100, 45);
            BtnNao1.TabIndex = 1;
            BtnNao1.Tag = "2";
            BtnNao1.UseVisualStyleBackColor = true;
            BtnNao1.Click += checkExpect;
            // 
            // BtnSim
            // 
            BtnSim.Cursor = Cursors.Hand;
            BtnSim.Location = new Point(128, 504);
            BtnSim.Name = "BtnSim";
            BtnSim.Size = new Size(100, 45);
            BtnSim.TabIndex = 2;
            BtnSim.Tag = "3";
            BtnSim.UseVisualStyleBackColor = true;
            BtnSim.Click += checkRecomenda;
            // 
            // BtnNao
            // 
            BtnNao.Cursor = Cursors.Hand;
            BtnNao.Location = new Point(230, 504);
            BtnNao.Name = "BtnNao";
            BtnNao.Size = new Size(100, 45);
            BtnNao.TabIndex = 3;
            BtnNao.Tag = "4";
            BtnNao.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(322, 568);
            button1.Name = "button1";
            button1.Size = new Size(127, 42);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnUm
            // 
            btnUm.Cursor = Cursors.Hand;
            btnUm.Location = new Point(130, 352);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(50, 50);
            btnUm.TabIndex = 5;
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // BtnDois
            // 
            BtnDois.Cursor = Cursors.Hand;
            BtnDois.Location = new Point(191, 352);
            BtnDois.Name = "BtnDois";
            BtnDois.Size = new Size(50, 50);
            BtnDois.TabIndex = 6;
            BtnDois.UseVisualStyleBackColor = true;
            BtnDois.Click += BtnDois_Click;
            // 
            // BtnTres
            // 
            BtnTres.Cursor = Cursors.Hand;
            BtnTres.Location = new Point(251, 352);
            BtnTres.Name = "BtnTres";
            BtnTres.Size = new Size(50, 50);
            BtnTres.TabIndex = 7;
            BtnTres.UseVisualStyleBackColor = true;
            BtnTres.Click += BtnTres_Click;
            // 
            // BtnQuatro
            // 
            BtnQuatro.Cursor = Cursors.Hand;
            BtnQuatro.Location = new Point(309, 352);
            BtnQuatro.Name = "BtnQuatro";
            BtnQuatro.Size = new Size(50, 50);
            BtnQuatro.TabIndex = 8;
            BtnQuatro.UseVisualStyleBackColor = true;
            BtnQuatro.Click += BtnQuatro_Click;
            // 
            // BtnCinco
            // 
            BtnCinco.Cursor = Cursors.Hand;
            BtnCinco.Location = new Point(367, 352);
            BtnCinco.Name = "BtnCinco";
            BtnCinco.Size = new Size(50, 50);
            BtnCinco.TabIndex = 9;
            BtnCinco.UseVisualStyleBackColor = true;
            BtnCinco.Click += BtnCinco_Click;
            // 
            // F4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(534, 721);
            Controls.Add(BtnCinco);
            Controls.Add(BtnQuatro);
            Controls.Add(BtnTres);
            Controls.Add(BtnDois);
            Controls.Add(btnUm);
            Controls.Add(button1);
            Controls.Add(BtnNao);
            Controls.Add(BtnSim);
            Controls.Add(BtnNao1);
            Controls.Add(BtnSim1);
            Name = "F4";
            Text = "Museu Totem";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSim1;
        private Button BtnNao1;
        private Button BtnSim;
        private Button BtnNao;
        private Button button1;
        private Button btnUm;
        private Button BtnDois;
        private Button BtnTres;
        private Button BtnQuatro;
        private Button BtnCinco;
    }
}