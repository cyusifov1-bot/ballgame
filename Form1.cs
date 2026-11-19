
using System;
using System.Windows.Forms;

namespace Ballgame
{
    public partial class Form1 : Form
    {
        int x = 5;
        int y = 5;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && panel1.Left > 0)
                panel1.Left -= 20;

            if (e.KeyCode == Keys.Right && panel1.Right < ClientSize.Width)
                panel1.Left += 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Left += x;
            ball.Top += y;

            if (ball.Left <= 0 || ball.Right >= ClientSize.Width)
                x = -x;

            if (ball.Top <= 0)
                y = -y;

            if (ball.Bounds.IntersectsWith(panel1.Bounds) && y > 0)
                y = -y;

            if (ball.Bottom >= panel2.Top)
            {
                timer1.Stop();
                MessageBox.Show("Oyun bitdi!");
            }
        }
    }
}
