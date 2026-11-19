
namespace Ballgame  
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            ball = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(359, 456);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 25);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(0, 638);
            panel2.Name = "panel2";
            panel2.Size = new Size(950, 12);
            panel2.TabIndex = 2;
            // 
            // ball
            // 
            ball.Image = Properties.Resources.ball;
            ball.Location = new Point(260, 100);
            ball.Name = "ball";
            ball.Size = new Size(75, 75);
            ball.SizeMode = PictureBoxSizeMode.StretchImage;
            ball.TabIndex = 0;
            ball.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(965, 589);
            Controls.Add(ball);
            Controls.Add(panel1);
            Controls.Add(panel2);
            KeyPreview = true;
            Name = "Form1";
            Text = "Mini Arkanoid";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
        }
    }
}
