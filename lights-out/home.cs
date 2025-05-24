namespace lights_out
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            game_3x3 game_3X3 = new game_3x3();
            game_3X3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Description description = new Description();
            description.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
