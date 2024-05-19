using WinFormsApp1.TELAS;

namespace WinFormsApp1
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
            BtnClique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnClique.FlatAppearance.BorderSize = 0;
            BtnClique.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnClique.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnClique.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Oculta o FormInicial
            this.Hide();

            // Cria uma instância
            Resumo1 formResumo1 = new Resumo1();

            // Exibe o FormResumo1
            formResumo1.Show();
        }
    }
}
