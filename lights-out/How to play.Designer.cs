namespace lights_out
{
    partial class Description
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
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 16.2F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(596, 44);
            label2.TabIndex = 0;
            label2.Text = "You Can Click The scilse To Tirn It Off";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(89, 98, 155);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 98, 155);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 98, 155);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Script", 18F);
            button1.Location = new Point(399, 124);
            button1.Name = "button1";
            button1.Size = new Size(200, 53);
            button1.TabIndex = 1;
            button1.Text = "GO Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 16.2F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 53);
            label3.Name = "label3";
            label3.Size = new Size(547, 44);
            label3.TabIndex = 0;
            label3.Text = "The Rowl Say Do't Click The scilse ";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 16.2F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 97);
            label4.Name = "label4";
            label4.Size = new Size(241, 44);
            label4.TabIndex = 0;
            label4.Text = "In the button  .";
            label4.Click += label2_Click;
            // 
            // Description
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 98, 155);
            ClientSize = new Size(611, 189);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Description";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Description";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}