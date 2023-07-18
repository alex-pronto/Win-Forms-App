using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        RandomSizeAndPointBall randomSizeAndPointBall;
        PointBall pointBall;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ballButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
           
            
        }

        private void randomBallButton_Click(object sender, EventArgs e)
        {
            randomSizeAndPointBall = new RandomSizeAndPointBall(this);
            randomSizeAndPointBall.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 50; i++)
            {
                pointBall.Move();
            }
            
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            randomSizeAndPointBall.Move();
        }
    }
}
