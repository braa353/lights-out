using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tableLayoutPanel = System.Windows.Forms.TableLayoutPanel;
using Lable = System.Windows.Forms.Label;

namespace lights_out
{
    public class Game
    {
        public tableLayoutPanel tableLayoutPanel1 { get; set; }
        public Lable label2 {  get; set; } //النص تبع الحركات 
        public Lable label4 { get; set; }//النص تبع افضل نتيجه
        public int rowCount { get; set; }
        public int columnCount { get; set; }
        public int Move_count { get; set; }
        public int playCount { get; set; }
        public int winCount { get; set; }
        public int GivUpCount { get; set; }
        public int BestRecord { get; set; }
        public bool GameIsStarted { get; set; }
        public Game() {/**/} //باني فاضي


        // تنضيف البورد تبع اللعب من الازرار
        public void cleir_bord()
        {
           
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = rowCount;
            tableLayoutPanel1.ColumnCount = columnCount;
          
            for (int i = 0; i < columnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnCount));
            }

            for (int i = 0; i < rowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rowCount));
            }
       
        }

        //بتبلش اللعبه
        public void Start_Game()
        {
            cleir_bord();
            GameIsStarted = true;
            tableLayoutPanel1.Controls.Clear();
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {

                    Button btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        ImageAlign = ContentAlignment.MiddleCenter,
                      
                    };
                    //Image originalImage = Image.FromFile("C:\\Users\\Acer\\Desktop\\lights-out1\\lights-out\\lights-out\\assits");

                    // تغيير حجم الصورة لتناسب أبعاد الزر  
                    //Image resizedImage = new Bitmap(originalImage, new Size(70, 70));

                    // تعيين الصورة التي تم تغيير حجمها  
                    //btn.Image = resizedImage;
                    btn.Click += Button_Click;

                    tableLayoutPanel1.Controls.Add(btn, col, row);
                }
            }
            ColorRandomizeButtons();
           
        }

        //تلوين الازرار بشكل عشوائي
        public void ColorRandomizeButtons()
        {

            Random rand = new Random();


            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button button)
                {

                    int randomValue = rand.Next(0, 2);

                    if (randomValue == 0)
                    {
                        button.BackColor = Color.LightGreen;
                        button.ForeColor = Color.Black;
                    }
                    else
                    {
                        button.BackColor = SystemColors.Control;
                        button.ForeColor = Color.Gray;
                    }
                }
            }
        }
        //حدث الضغط عالزر
        public void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Move_count++;
            label2.Text = Move_count.ToString();
            if (clickedButton != null)
            {

                ToggleButton(clickedButton);

                ToggleAdjacentButtons(clickedButton);
                if (CheckIfAllButtonsAreOff())
                {
                    Win_Stat();
                }
                
            }
        }
        //جيب الاحداثيات تبع كل زر
        public void ToggleAdjacentButtons(Button clickedButton)
        {

            int col = tableLayoutPanel1.GetColumn(clickedButton);
            int row = tableLayoutPanel1.GetRow(clickedButton);


            ToggleButtonAtPosition(col, row - 1);

            ToggleButtonAtPosition(col, row + 1);

            ToggleButtonAtPosition(col - 1, row);

            ToggleButtonAtPosition(col + 1, row);
        }
        //تتبع حالة الزر الي فوقو والي تحتو و يمينو و يسارو
        public void ToggleButtonAtPosition(int col, int row)
        {

            if (col >= 0 && col < tableLayoutPanel1.ColumnCount && row >= 0 && row < tableLayoutPanel1.RowCount)
            {

                Button button = tableLayoutPanel1.GetControlFromPosition(col, row) as Button;
                if (button != null)
                {

                    ToggleButton(button);
                }
            }
        }
        //تتبع حالة  الزر
        public void ToggleButton(Button button)
        {

            if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = SystemColors.Control;
                button.ForeColor = Color.Gray;
            }
            else
            {
                button.BackColor = Color.LightGreen;
                button.ForeColor = Color.Black;
            }
        }
        //التحقق من كل الازرار انو فاضية
        public bool CheckIfAllButtonsAreOff()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button button)
                {

                    if (button.BackColor == Color.LightGreen)
                    {
                        return false;
                    }
                }
            }
            return true;
              
        }
        //التحقق من الفوز
        public void Win_Stat()
        {
            MessageBox.Show($"You Win By {Move_count} Moves", "Great", MessageBoxButtons.OK);
            winCount++;
            Dsabel_button();
            GameIsStarted = false;
            PestRecord();
        }
        //جعل كل الازرار مقفلة
        public void Dsabel_button()
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button btn)
                {
                    btn.Click -= Button_Click;
                }
            }
        }
        //اعادة اللعبة
        public void ResetGame()
        {
            playCount++;
            Start_Game();
            Move_count = 0;
            label2.Text = "0";
            GameIsStarted = true;
         
        }
        //حساب افضل نتيجه
        public void PestRecord()
        {
            if (BestRecord == 0)
            {
                BestRecord = Move_count;
                label4.Text = BestRecord.ToString();

            }
            else if (BestRecord > Move_count)
            {
                BestRecord = Move_count;
                label4.Text = BestRecord.ToString();
            }
            else
            {
                BestRecord = BestRecord;
                label4.Text = BestRecord.ToString();    
            }

        }
        //بدأ اللعبة
        public void Game_Coundtion()
        {
            if (GameIsStarted == true)
            {
                MessageBox.Show("Complite the Game OR GivUP", "Plase" , MessageBoxButtons.OK);       
            }
            else if (GameIsStarted == false && Move_count > 0)
            {
                ResetGame();
            }
            else
            {
                playCount++;  
                Start_Game();
            }
        }

    }
}
