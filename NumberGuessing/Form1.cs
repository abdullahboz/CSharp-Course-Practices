using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSteps_Click(object sender, EventArgs e)
        {
            lbxResult.Items.Clear();
            int number = Convert.ToInt32(tbxNumber.Text);
            int step = 0;
            while (number > 0)
            {
                step = number % 10; //123%10=3.......12%10=2........1%10=1 (Mod Alma)
                number = number / 10; //123/10 = 12 ---- 12/10=1 --- 1/10=1 (integer bölme)
                lbxResult.Items.Add(step);
            }
        }

        private void btnStepSum_Click(object sender, EventArgs e)
        {
            lbxResult.Items.Clear();
            int number = Convert.ToInt32(tbxNumber.Text);
            int step = 0;
            int sum = 0;
            while (number > 0)
            {
                step = number % 10; //123%10=3.......12%10=2........1%10=1 (Mod Alma)
                number = number / 10; //123/10 = 12 ---- 12/10=1 --- 1/10=1 (integer bölme)
                sum += step; //sum=sum+stek(3,5,6)
            }
            lbxResult.Items.Add("Basamak Toplamı: " + sum);
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            lbxResult.Items.Clear();
            string word = tbxWord.Text;
            for (int i = 0; i < word.Length; i++)
            {
                lbxResult.Items.Add(word[i]);
            }
        }

        private void btnCharSum_Click(object sender, EventArgs e)
        {
            lbxResult.Items.Clear();
            string word = tbxWord.Text;
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                sum++;
            }
            lbxResult.Items.Add("Karakter Sayısı Toplamı: " + sum);
        }

        private void btnGuessing_Click(object sender, EventArgs e)
        {
            int[] userNumber = new int[6];
            userNumber[0] = Convert.ToInt32(tbxNumber1.Text);
            userNumber[1] = Convert.ToInt32(tbxNumber2.Text);
            userNumber[2] = Convert.ToInt32(tbxNumber3.Text);
            userNumber[3] = Convert.ToInt32(tbxNumber4.Text);
            userNumber[4] = Convert.ToInt32(tbxNumber5.Text);
            userNumber[5] = Convert.ToInt32(tbxNumber6.Text);

            Random rnd = new Random();
            int[] randomNumber = new int[6];
            for (int i = 0; i < 6; i++)
            {
                randomNumber[i] = rnd.Next(1, 50);
            }

            lblNumber1.Text = randomNumber[0].ToString();

            lblNumber2.Text = randomNumber[1].ToString();

            lblNumber3.Text = randomNumber[2].ToString();

            lblNumber4.Text = randomNumber[3].ToString();

            lblNumber5.Text = randomNumber[4].ToString();

            lblNumber6.Text = randomNumber[5].ToString();


            int sum = 0;

            for (int i = 0; i < 6; i++) // loop for a userNumber array
            {
                for (int j = 0; j < 6; j++) // loop for a randomNumber array
                {
                    //(i,j)=(0,0)-(0,1)-(0,2)-(0,3)-(0,4)-(0,5)
                    //(i,j)=(1,0)-(1,1)-(1,2)-(1,3)-(1,4)-(1,5)
                    //...........
                    //(i,j)=(5,0)-(5,1)-(5,2)-(5,3)-(5,4)-(5,5)
                    if (userNumber[i] == randomNumber[j])
                    {
                        sum++;
                    }
                }
            }

            lblGuessingResult.Text = "Aynı Tahmin Sayısı: " + sum.ToString();
        }
    }
}
