namespace WinFormsApp1.TELAS.Feedback
{
    partial class F2
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnProx;
        private TextBox textBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnProx = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProx
            // 
            btnProx.Cursor = Cursors.Hand;
            btnProx.Location = new Point(296, 537);
            btnProx.Name = "btnProx";
            btnProx.Size = new Size(117, 51);
            btnProx.TabIndex = 1;
            btnProx.UseVisualStyleBackColor = true;
            btnProx.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(130, 242);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 43);
            textBox1.TabIndex = 2;
            textBox1.MouseClick += opemKeyboard;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(113, 409);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 89);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 20.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(130, 344);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 45);
            comboBox1.TabIndex = 6;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(113, 540);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(123, 48);
            btnVoltar.TabIndex = 7;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // F2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.F2;
            ClientSize = new Size(534, 721);
            Controls.Add(btnVoltar);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(btnProx);
            Name = "F2";
            Text = "Museu Totem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Button btnVoltar;
    }
}
