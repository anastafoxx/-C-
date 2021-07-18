using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong23
{
    public partial class Form1 : Form
    {
        private int speed_vert = 3;
        private int speed_hor = 3;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            gamepanel.Top = background.Bottom - (background.Bottom / 10);

            loose.Visible = false;
            loose.Left = (background.Width / 2) - (loose.Width / 2);
            loose.Top = (background.Height / 2) - (loose.Height / 2);


        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if(e.KeyCode == Keys.Enter)
            {
                gameball.Top = 50;
                gameball.Left = 70;
                speed_hor = 2;
                speed_vert = 2;
                score = 0;
                loose.Visible = false;
                timer1.Enabled = true;
                result.Text = "Result: 0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gamepanel.Left = Cursor.Position.X - (gamepanel.Width / 2);

            gameball.Left += speed_hor;
            gameball.Top += speed_vert;

            if (gameball.Left <= background.Left)
                speed_hor *= -1;
            if (gameball.Right >= background.Right)
                speed_hor *= -1;
            if (gameball.Top <= background.Top)
                speed_vert *= -1;
            if (gameball.Bottom >= background.Bottom)
            {
                timer1.Enabled = false;
                loose.Visible = true;
            }

                if (gameball.Bottom >= gamepanel.Top && gameball.Bottom <= gamepanel.Bottom &&
                gameball.Left >= gamepanel.Left && gameball.Right <= gamepanel.Right) { 
                    speed_hor += 1;  //усложнение игры
                    speed_vert += 1;
                    score++;
                    speed_vert *= -1;

                result.Text = "Result: " + score.ToString();
                Random randColor = new Random();
                background.BackColor = Color.FromArgb(randColor.Next(150,255), randColor.Next(150, 255), randColor.Next(150, 255));



            }
        }
    }
}
