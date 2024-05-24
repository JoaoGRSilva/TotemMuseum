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
            SuspendLayout();
            // 
            // BtnSim1
            // 
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
            BtnNao.Location = new Point(230, 504);
            BtnNao.Name = "BtnNao";
            BtnNao.Size = new Size(100, 45);
            BtnNao.TabIndex = 3;
            BtnNao.Tag = "4";
            BtnNao.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(322, 568);
            button1.Name = "button1";
            button1.Size = new Size(127, 42);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // F4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(534, 721);
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
    }
}