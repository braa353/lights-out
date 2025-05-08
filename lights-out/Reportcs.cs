using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;
using Game = lights_out.Game;
namespace lights_out
{
    public partial class Reportcs : Form
    {
        Game game3;
        Game game4;
        Game game5;
        public Reportcs(Game game3, Game game4, Game game5)
        {
            this.game3 = game3;
            this.game4 = game4;
            this.game5 = game5;
            InitializeComponent();
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();   
        }

        private void Reportcs_Load(object sender, EventArgs e)
        {
            S1.BackColor = Color.LightGreen;
            S2.BackColor = SystemColors.Control;
            S3.BackColor = SystemColors.Control;
            GamesL.Text = game3.playCount.ToString();
            WinsL.Text = game3.winCount.ToString();
            LoseL.Text = game3.GivUpCount.ToString();
            RecordL.Text = game3.BestRecord.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            S1.BackColor = Color.LightGreen;
            S2.BackColor = SystemColors.Control;
            S3.BackColor = SystemColors.Control;
            GamesL.Text = game3.playCount.ToString();
            WinsL.Text = game3.winCount.ToString();
            LoseL.Text = game3.GivUpCount.ToString();
            RecordL.Text = game3.BestRecord.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            S1.BackColor = SystemColors.Control;
            S2.BackColor = Color.LightGreen;
            S3.BackColor = SystemColors.Control;
            GamesL.Text = game4.playCount.ToString();
            WinsL.Text = game4.winCount.ToString();
            LoseL.Text = game4.GivUpCount.ToString();
            RecordL.Text = game4.BestRecord.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            S1.BackColor = SystemColors.Control;
            S2.BackColor = SystemColors.Control;
            S3.BackColor = Color.LightGreen;
            GamesL.Text = game5.playCount.ToString();
            WinsL.Text = game5.winCount.ToString();
            LoseL.Text = game5.GivUpCount.ToString();
            RecordL.Text = game5.BestRecord.ToString();
        }
    }
}
