namespace WinFormsApp1.TELAS.Feedback
{
    partial class F3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F3));
            BtnSim = new Button();
            BtnNao = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // BtnSim
            // 
            BtnSim.Cursor = Cursors.Hand;
            BtnSim.Location = new Point(126, 237);
            BtnSim.Name = "BtnSim";
            BtnSim.Size = new Size(100, 45);
            BtnSim.TabIndex = 0;
            BtnSim.Tag = "1";
            BtnSim.UseVisualStyleBackColor = true;
            BtnSim.Click += checarEspaco;
            // 
            // BtnNao
            // 
            BtnNao.Cursor = Cursors.Hand;
            BtnNao.Location = new Point(232, 237);
            BtnNao.Name = "BtnNao";
            BtnNao.Size = new Size(100, 45);
            BtnNao.TabIndex = 1;
            BtnNao.Tag = "2";
            BtnNao.UseVisualStyleBackColor = true;
            BtnNao.Click += checarEspaco;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(126, 365);
            button3.Name = "button3";
            button3.Size = new Size(100, 45);
            button3.TabIndex = 2;
            button3.Tag = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += checarObra;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(232, 365);
            button4.Name = "button4";
            button4.Size = new Size(100, 45);
            button4.TabIndex = 3;
            button4.Tag = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += checarObra;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(126, 502);
            button5.Name = "button5";
            button5.Size = new Size(100, 45);
            button5.TabIndex = 4;
            button5.Tag = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += checarAlgo;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(232, 502);
            button6.Name = "button6";
            button6.Size = new Size(100, 45);
            button6.TabIndex = 5;
            button6.Tag = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += checarAlgo;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(311, 576);
            button1.Name = "button1";
            button1.Size = new Size(122, 44);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // F3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(534, 721);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(BtnNao);
            Controls.Add(BtnSim);
            Name = "F3";
            Text = "Museu Totem";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSim;
        private Button BtnNao;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button1;
    }
}