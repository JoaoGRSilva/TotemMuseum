namespace WinFormsApp1.TELAS.Feedback
{
    public partial class Feed_6 : Form
    {
        public static int respondentes { get; set; }

        public Feed_6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            respondentes++;
            this.Close();
            Inicial r1 = new Inicial();
            r1.Show();
        }

    }
}
