namespace lights_out
{
    partial class game_3x3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            threebythree = new Button();
            forbyfor = new Button();
            fivebyfive = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 16.2F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(132, 64);
            label2.Name = "label2";
            label2.Size = new Size(39, 44);
            label2.TabIndex = 6;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 16.2F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 64);
            label1.Name = "label1";
            label1.Size = new Size(116, 44);
            label1.TabIndex = 5;
            label1.Text = "Moves:";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Location = new Point(132, 122);
            tableLayoutPanel1.MaximumSize = new Size(320, 320);
            tableLayoutPanel1.MinimumSize = new Size(450, 450);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(450, 450);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // threebythree
            // 
            threebythree.Cursor = Cursors.Hand;
            threebythree.FlatAppearance.BorderColor = Color.FromArgb(89, 98, 155);
            threebythree.FlatAppearance.BorderSize = 0;
            threebythree.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 98, 155);
            threebythree.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 98, 155);
            threebythree.FlatStyle = FlatStyle.Flat;
            threebythree.Font = new Font("Segoe Script", 12F);
            threebythree.Location = new Point(640, 6);
            threebythree.Name = "threebythree";
            threebythree.Size = new Size(94, 37);
            threebythree.TabIndex = 8;
            threebythree.Text = "3X3";
            threebythree.UseVisualStyleBackColor = true;
            threebythree.Click += threebythree_Click;
            // 
            // forbyfor
            // 
            forbyfor.Cursor = Cursors.Hand;
            forbyfor.FlatAppearance.BorderColor = Color.FromArgb(89, 98, 155);
            forbyfor.FlatAppearance.BorderSize = 0;
            forbyfor.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 98, 155);
            forbyfor.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 98, 155);
            forbyfor.FlatStyle = FlatStyle.Flat;
            forbyfor.Font = new Font("Segoe Script", 12F);
            forbyfor.Location = new Point(640, 49);
            forbyfor.Name = "forbyfor";
            forbyfor.Size = new Size(94, 37);
            forbyfor.TabIndex = 8;
            forbyfor.Text = "4X4";
            forbyfor.UseVisualStyleBackColor = true;
            forbyfor.Click += forbyfor_Click;
            // 
            // fivebyfive
            // 
            fivebyfive.Cursor = Cursors.Hand;
            fivebyfive.FlatAppearance.BorderColor = Color.FromArgb(89, 98, 155);
            fivebyfive.FlatAppearance.BorderSize = 0;
            fivebyfive.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 98, 155);
            fivebyfive.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 98, 155);
            fivebyfive.FlatStyle = FlatStyle.Flat;
            fivebyfive.Font = new Font("Segoe Script", 12F);
            fivebyfive.Location = new Point(640, 92);
            fivebyfive.Name = "fivebyfive";
            fivebyfive.Size = new Size(94, 37);
            fivebyfive.TabIndex = 8;
            fivebyfive.Text = "5X5";
            fivebyfive.UseVisualStyleBackColor = true;
            fivebyfive.Click += fivebyfive_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(89, 98, 155);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 98, 155);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 98, 155);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(134, 42);
            button2.TabIndex = 9;
            button2.Text = "GO Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.No;
            button3.FlatAppearance.BorderColor = Color.FromArgb(89, 98, 155);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 98, 155);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 98, 155);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe Script", 12F);
            button3.Location = new Point(671, 685);
            button3.Name = "button3";
            button3.Size = new Size(75, 37);
            button3.TabIndex = 10;
            button3.Text = "Quit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(89, 98, 155);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(89, 98, 155);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 98, 155);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 98, 155);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe Script", 18F);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(400, 616);
            button4.Name = "button4";
            button4.Size = new Size(156, 57);
            button4.TabIndex = 11;
            button4.Text = "GivUP";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.FromArgb(89, 98, 155);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 98, 155);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 98, 155);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe Script", 18F);
            button5.Location = new Point(173, 616);
            button5.Name = "button5";
            button5.Size = new Size(221, 57);
            button5.TabIndex = 12;
            button5.Text = "Start Game";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 16.2F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(173, 64);
            label3.Name = "label3";
            label3.Size = new Size(207, 44);
            label3.TabIndex = 13;
            label3.Text = "Top Record :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 16.2F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(386, 64);
            label4.Name = "label4";
            label4.Size = new Size(39, 44);
            label4.TabIndex = 14;
            label4.Text = "0";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(89, 98, 155);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 98, 155);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 98, 155);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Script", 12F);
            button1.Location = new Point(442, 685);
            button1.Name = "button1";
            button1.Size = new Size(223, 40);
            button1.TabIndex = 15;
            button1.Text = "Gameplays Record";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // game_3x3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(89, 98, 155);
            ClientSize = new Size(746, 722);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(fivebyfive);
            Controls.Add(forbyfor);
            Controls.Add(threebythree);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "game_3x3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "game_3x3";
            Load += game_3x3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button threebythree;
        private Button forbyfor;
        private Button fivebyfive;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}