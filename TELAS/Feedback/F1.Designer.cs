namespace WinFormsApp1.TELAS.Feedback
{
    partial class F1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F1));
            BtnNao = new Button();
            BtnSim = new Button();
            SuspendLayout();
            // 
            // BtnNao
            // 
            BtnNao.Location = new Point(290, 273);
            BtnNao.Name = "BtnNao";
            BtnNao.Size = new Size(117, 64);
            BtnNao.TabIndex = 0;
            BtnNao.UseVisualStyleBackColor = true;
            BtnNao.Click += BtnNao_Click;
            // 
            // BtnSim
            // 
            BtnSim.Location = new Point(100, 273);
            BtnSim.Name = "BtnSim";
            BtnSim.Size = new Size(142, 64);
            BtnSim.TabIndex = 1;
            BtnSim.UseVisualStyleBackColor = true;
            BtnSim.Click += BtnSim_Click;
            // 
            // F1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(534, 721);
            Controls.Add(BtnSim);
            Controls.Add(BtnNao);
            Name = "F1";
            Text = "Museu Totem";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnNao;
        private Button BtnSim;
    }
}