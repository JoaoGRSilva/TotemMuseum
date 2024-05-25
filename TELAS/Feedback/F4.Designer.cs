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
            BtnExpectSim = new Button();
            BtnExpectNao = new Button();
            BtnRecomendaNao = new Button();
            BtnRecomendaSim = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            BtnProx = new Button();
            BtnVolta = new Button();
            SuspendLayout();
            // 
            // BtnExpectSim
            // 
            BtnExpectSim.Cursor = Cursors.Hand;
            BtnExpectSim.Location = new Point(126, 233);
            BtnExpectSim.Name = "BtnExpectSim";
            BtnExpectSim.Size = new Size(107, 45);
            BtnExpectSim.TabIndex = 0;
            BtnExpectSim.Tag = "1";
            BtnExpectSim.UseVisualStyleBackColor = true;
            BtnExpectSim.Click += checkExpectativa;
            // 
            // BtnExpectNao
            // 
            BtnExpectNao.Cursor = Cursors.Hand;
            BtnExpectNao.Location = new Point(249, 233);
            BtnExpectNao.Name = "BtnExpectNao";
            BtnExpectNao.Size = new Size(107, 45);
            BtnExpectNao.TabIndex = 1;
            BtnExpectNao.Tag = "2";
            BtnExpectNao.UseVisualStyleBackColor = true;
            BtnExpectNao.Click += checkExpectativa;
            // 
            // BtnRecomendaNao
            // 
            BtnRecomendaNao.Cursor = Cursors.Hand;
            BtnRecomendaNao.Location = new Point(249, 505);
            BtnRecomendaNao.Name = "BtnRecomendaNao";
            BtnRecomendaNao.Size = new Size(107, 45);
            BtnRecomendaNao.TabIndex = 3;
            BtnRecomendaNao.Tag = "2";
            BtnRecomendaNao.UseVisualStyleBackColor = true;
            BtnRecomendaNao.Click += checkRecomendacao;
            // 
            // BtnRecomendaSim
            // 
            BtnRecomendaSim.Cursor = Cursors.Hand;
            BtnRecomendaSim.Location = new Point(126, 505);
            BtnRecomendaSim.Name = "BtnRecomendaSim";
            BtnRecomendaSim.Size = new Size(107, 45);
            BtnRecomendaSim.TabIndex = 2;
            BtnRecomendaSim.Tag = "1";
            BtnRecomendaSim.UseVisualStyleBackColor = true;
            BtnRecomendaSim.Click += checkRecomendacao;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(131, 351);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(190, 351);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(249, 351);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(308, 351);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(367, 351);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // BtnProx
            // 
            BtnProx.Cursor = Cursors.Hand;
            BtnProx.Location = new Point(310, 566);
            BtnProx.Name = "BtnProx";
            BtnProx.Size = new Size(125, 45);
            BtnProx.TabIndex = 9;
            BtnProx.Tag = "2";
            BtnProx.UseVisualStyleBackColor = true;
            BtnProx.Click += BtnProx_Click;
            // 
            // BtnVolta
            // 
            BtnVolta.Cursor = Cursors.Hand;
            BtnVolta.Location = new Point(126, 566);
            BtnVolta.Name = "BtnVolta";
            BtnVolta.Size = new Size(125, 45);
            BtnVolta.TabIndex = 10;
            BtnVolta.Tag = "2";
            BtnVolta.UseVisualStyleBackColor = true;
            BtnVolta.Click += BtnVolta_Click;
            // 
            // F4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.F4;
            ClientSize = new Size(534, 721);
            Controls.Add(BtnVolta);
            Controls.Add(BtnProx);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnRecomendaNao);
            Controls.Add(BtnRecomendaSim);
            Controls.Add(BtnExpectNao);
            Controls.Add(BtnExpectSim);
            Name = "F4";
            Text = "F4";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnExpectSim;
        private Button BtnExpectNao;
        private Button BtnRecomendaNao;
        private Button BtnRecomendaSim;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button BtnProx;
        private Button BtnVolta;
    }
}