using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.TELAS.Feedback
{
    public partial class F2 : Form, IKeyboardTarget
    {
        public F2()
        {
            InitializeComponent();

            Console.WriteLine("RT");

            this.StartPosition = FormStartPosition.CenterScreen;

            btnProx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProx.FlatAppearance.BorderSize = 0;
            btnProx.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProx.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProx.BackColor = Color.Transparent;

            btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVoltar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnVoltar.BackColor = Color.Transparent;

            textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8C64A0");
            textBox1.ForeColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;

            for (int i = 0; i <= 100; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;

            comboBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8C64A0");
            comboBox1.ForeColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; // Remove a capacidade de edição
            comboBox1.FlatStyle = FlatStyle.Flat; // Remove a borda 3D
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed; // Desenha manualmente o item selecionado
            comboBox1.DrawItem += ComboBox_DrawItem;

            // Adicionando evento MouseClick ao textBox1
            textBox1.MouseClick += opemKeyboard;
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            System.Windows.Forms.ComboBox combo = (System.Windows.Forms.ComboBox)sender;

            e.Graphics.FillRectangle(new SolidBrush(combo.BackColor), e.Bounds);
            e.Graphics.DrawString(combo.Items[e.Index].ToString(), combo.Font, new SolidBrush(combo.ForeColor), new Point(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }

        public void AddTextToTextBox(string text)
        {
            textBox1.Text += text;
            Console.WriteLine("Texto adicionado: " + text); // Instrução de depuração
        }

        public void RemoveLastCharacterFromTextBox()
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F3 f3 = new F3();
            f3.Show();
        }

        private void opemKeyboard(object sender, MouseEventArgs e)
        {
            // Verifica se o teclado já está aberto para evitar a abertura múltipla
            if (Application.OpenForms.OfType<Teclado>().Any())
                return;

            Teclado teclado = new Teclado(this);
            teclado.Show();

            // Adiciona o foco à caixa de texto após abrir o teclado virtual
            textBox1.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
