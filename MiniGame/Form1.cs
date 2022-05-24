using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    // yazılımda beni büyüleyen şey basit bir oyunun bu kadar ilgi görmesi, yazılım mucizelerle dolu.
        public partial class Form : System.Windows.Forms.Form
    {
        
        int pipeSpeed = 8;
        int gravity = 8;
        int score = 0;

        public Form()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text=score.ToString();
            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left<-180)
            {
                pipeTop.Left = 950;
                score++;
            }
            if (FlappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || FlappyBird.Bounds.IntersectsWith(ground.Bounds) || FlappyBird.Top < -25 )
                // Burada flappybird ile pipebottomun sınırları  ya da pipetop'un sınırları ya da zeminin sınırları ya da tavanın sınırları çarpışırsa oyun biter diyoruz.
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 15;
            }
           

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -8;
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 8;
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "Game Over!";
        }
    }
}
