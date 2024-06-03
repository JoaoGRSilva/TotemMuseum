namespace WinFormsApp1.TELAS.Feedback
{
    public partial class F3C : Form
    {
        public static List<string> respostas = new List<string>();
        private Teclado teclado; // Variável de instância para o teclado

        public F3C()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8C649F");
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.ForeColor = System.Drawing.Color.White;

            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

            this.KeyPreview = true; // Permite que o formulário capture os eventos de teclado antes dos controles
            this.KeyDown += F3C_KeyDown; // Associa o evento KeyDown do formulário à função F3C_KeyDown
        }

        private void F3C_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) // Verifica se a tecla pressionada não é Enter
            {
                textBox1.Text += e.KeyCode.ToString(); // Adiciona o código da tecla pressionada ao TextBox
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            respostas.Add(userInput);
            if (teclado != null && !teclado.IsDisposed)
            {
                teclado.Close(); // Fecha o teclado se estiver aberto
            }
            this.Close();
        }

        private void ShowKeyboard(object sender, EventArgs e)
        {
            // Calcular a posição Y para o teclado
            int tecladoPosY = this.Top + this.Height / 2 + 50; // 50 é uma distância específica abaixo do centro

            // Inicializar a variável de instância do teclado
            teclado = new Teclado(textBox1);
            teclado.StartPosition = FormStartPosition.Manual; // Definir a posição manualmente

            // Calcular a posição X para o teclado (centralizado horizontalmente)
            int tecladoPosX = this.Left + (this.Width - teclado.Width) / 2;
            teclado.Location = new Point(tecladoPosX, tecladoPosY); // Definir a posição calculada

            teclado.Show();
        }
    }
}
