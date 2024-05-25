using System;
using System.Windows.Forms;

namespace WinFormsApp1.TELAS.Feedback
{
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
            ConfigureButtons();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true; // Permite que o formulário capture os eventos de teclado antes dos controles
            this.KeyDown += F2_KeyDown; // Associa o evento KeyDown do formulário à função F2_KeyDown


            textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8C649F");
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.ForeColor = System.Drawing.Color.White;

            comboBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8C649F");
            comboBox1.ForeColor = System.Drawing.Color.White;
            comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Remover bordas
            comboBox1.MaxDropDownItems = 10;

            for (int i = 0; i <= 100; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void ConfigureButtons()
        {
            ConfigureButton(button2);
            ConfigureButton(button1);
        }

        private void ConfigureButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.BackColor = Color.Transparent;
        }

        private void ShowKeyboard(object sender, EventArgs e)
        {
            // Calcular a posição Y para o teclado
            int tecladoPosY = this.Top + this.Height / 2 + 50; // 50 é uma distância específica abaixo do centro

            // Criar o formulário do teclado com a posição calculada
            Teclado teclado = new Teclado(textBox1);
            teclado.StartPosition = FormStartPosition.Manual; // Definir a posição manualmente

            // Calcular a posição X para o teclado (centralizado horizontalmente)
            int tecladoPosX = this.Left + (this.Width - teclado.Width) / 2;
            teclado.Location = new Point(tecladoPosX, tecladoPosY); // Definir a posição calculada

            teclado.Show();
        }

        private void F2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) // Verifica se a tecla pressionada não é Enter
            {
                textBox1.Text += e.KeyCode.ToString(); // Adiciona o código da tecla pressionada ao TextBox
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            F3 f3 = new F3();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F1 f1 = new F1();
            f1.Show();
        }
    }
}
