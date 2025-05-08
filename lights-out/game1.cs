using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;
using Button = System.Windows.Forms.Button;

namespace lights_out
{
    public partial class game_3x3 : Form
    {
    
        Game game3x3 = new Game();
        Game game4x4 = new Game();
        Game game5x5 = new Game();
        public game_3x3()
        {
            InitializeComponent();
        }
        //تهيأ الكائنات
        private void game_3x3_Load(object sender, EventArgs e)
        {
            game3x3 = new Game
            {
                tableLayoutPanel1 = tableLayoutPanel1,
                label2 = label2,
                label4 = label4,
                rowCount = 3,
                columnCount = 3,
            };
             game4x4 = new Game
            {
                tableLayoutPanel1 = tableLayoutPanel1,
                 label2 = label2,
                 label4 = label4,
                 rowCount = 4,
                 columnCount = 4,
            };
             game5x5 = new Game
            {
                tableLayoutPanel1 = tableLayoutPanel1,
                 label2 = label2,
                 label4 = label4,
                 rowCount = 5,
                 columnCount = 5,
             };
       

        }
        //
        private void threebythree_Click(object sender, EventArgs e)
        {
            int Countofrow = tableLayoutPanel1.RowCount;
            if(Countofrow == 3)
            {
                Game_SWich(3);
            }
            if (Countofrow == 4 || Countofrow == 5)
            {
                if (game4x4.GameIsStarted == false && game5x5.GameIsStarted == false)
                {
                    Game_SWich(3);
                }
                else
                {
                    MessageBox.Show("Compleate this  Game  or GivUp", "Plase", MessageBoxButtons.OK);
                }
            }

        }

        private void forbyfor_Click(object sender, EventArgs e)
        {
            int Countofrow = tableLayoutPanel1.RowCount;
            if (Countofrow == 3 || Countofrow == 5)
            {
                if (game3x3.GameIsStarted == false && game5x5.GameIsStarted == false)
                {
                    Game_SWich(4);
                }
                else
                {
                    MessageBox.Show("Compleate this  Game  or GivUp", "Plase", MessageBoxButtons.OK);
                }
            }
           
        }

        private void fivebyfive_Click(object sender, EventArgs e)
        {
            int Countofrow = tableLayoutPanel1.RowCount;
            if (Countofrow == 3 || Countofrow == 4)
            {
                if (game3x3.GameIsStarted == false && game4x4.GameIsStarted == false)
                {
                    Game_SWich(5);
                }
                else
                {
                    MessageBox.Show("Compleate this  Game  or GivUp", "Plase", MessageBoxButtons.OK);
                }
            }
          
          
        }
        //
        private void button2_Click(object sender, EventArgs e)
        {
            home home = new home();
            this.Close();
            home.Show();
        }
        //
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //زر الاستسلام
        private void button4_Click(object sender, EventArgs e)
        {
            bool  a = game3x3.CheckIfAllButtonsAreOff();
            bool  b = game4x4.CheckIfAllButtonsAreOff();
            bool  c = game5x5.CheckIfAllButtonsAreOff();
            int curentGame = tableLayoutPanel1.RowCount; 
            while (true)
            {
                if (curentGame == 3 && !a)
                {
                    game3x3.GivUpCount++;
                    game3x3.Dsabel_button();
                    game3x3.GameIsStarted = false;
                    MessageBox.Show("Good Play ", "GG", MessageBoxButtons.OK);
                    break;
                }
                else if (curentGame == 4 && !b)
                {
                    game4x4.GivUpCount++;
                    game4x4.Dsabel_button();
                    game4x4.GameIsStarted = false;
                    MessageBox.Show("Good Play ", "GG", MessageBoxButtons.OK);
                    break;
                }
                else if (curentGame == 5 && !c)
                {
                    game5x5.GivUpCount++;
                    game5x5.Dsabel_button();
                    game5x5.GameIsStarted = false;
                    MessageBox.Show("Good Play ", "GG", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    MessageBox.Show("You Are Not Aple To GiveUP ", "LL", MessageBoxButtons.OK);
                    return;
                }
            }

        }
        //تلوين الزر الي اللعبة تبعو شغالة
        private void ColorOfB(int x)
        {
            if ( x == 3 )
            {
                threebythree.BackColor = Color.LightGreen;
                forbyfor.BackColor = SystemColors.Control;
                fivebyfive.BackColor = SystemColors.Control;
            }
            else if ( x == 4 )
            {
                threebythree.BackColor = SystemColors.Control;
                forbyfor.BackColor = Color.LightGreen;
                fivebyfive.BackColor = SystemColors.Control;
            }
            else if ( x == 5 )
            {
                threebythree.BackColor = SystemColors.Control;
                forbyfor.BackColor = SystemColors.Control;
                fivebyfive.BackColor = Color.LightGreen;
            }
        }
        // تحديد المستوى المراد لعبه
        private void Game_SWich( int x)
        { 
           if (x == 3)
              {
                game3x3.Game_Coundtion();
                ColorOfB(3);
              }
           else if (x == 4)
              {
                game4x4.Game_Coundtion();
                ColorOfB(4);
              }
           else if (x == 5)
              {
                game5x5.Game_Coundtion();
                ColorOfB(5);
              }   
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (game3x3.tableLayoutPanel1.ColumnCount == 3)
            {
                Game_SWich(3);
            }
            else if(game4x4.tableLayoutPanel1.ColumnCount == 4)
            {
                Game_SWich(4);
            }
            else if (game5x5.tableLayoutPanel1.ColumnCount == 5)
            {
                Game_SWich(5);
            }
            else
            {
                Game_SWich(3);
            }
        }
        // بعت النتائج لواجهة الاحصائيات
        private void button1_Click(object sender, EventArgs e)
        {
            new Reportcs( game3x3 , game4x4 ,game5x5 ).Show();   
        }
    }
}
