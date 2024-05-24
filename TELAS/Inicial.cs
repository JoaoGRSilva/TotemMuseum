using WinFormsApp1.TELAS;

namespace WinFormsApp1
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            BtnClique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnClique.FlatAppearance.BorderSize = 0;
            BtnClique.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnClique.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnClique.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            R1 formResumo1 = new R1();
            formResumo1.Show();
        }

    }
}
