using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.TELAS.Feedback
{
    public partial class F5 : Form
    {


        public static List<string> F5List = new List<string>();


        public F5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


            this.KeyPreview = true; // Permite que o formulário capture os eventos de teclado antes dos controles
            this.KeyDown += F5_KeyDown; // Associa o evento KeyDown do formulário à função F3C_KeyDown

            textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8C649F");
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.ForeColor = System.Drawing.Color.White;

            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userinput = textBox1.Text;
            F5List.Add(userinput);

            this.Close();
            Feed_6 feed_6 = new Feed_6();
            feed_6.Show();
        }

        private void F5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) // Verifica se a tecla pressionada não é Enter
            {
                textBox1.Text += e.KeyCode.ToString(); // Adiciona o código da tecla pressionada ao TextBox
            }
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
    }
}
