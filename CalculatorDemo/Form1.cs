using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number1, number2, answer , count=0;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            number1= Convert.ToInt32(tbxNumber.Text);
            tbxNumber.Text = "0";
            count = 1;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(tbxNumber.Text);
            tbxNumber.Text = "0";
            count = 2;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(tbxNumber.Text);
            tbxNumber.Text = "0";
            count = 3;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(tbxNumber.Text);
            tbxNumber.Text = "0";
            count = 4;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(tbxNumber.Text);
            if (count == 1)
            {
                count = number1 + number2;
                tbxNumber.Text = count.ToString();
            }
            else if (count==2)
            {
                count = number1 - number2;
                tbxNumber.Text = count.ToString();
            }
            else if (count == 3)
            {
                count = number1 * number2;
                tbxNumber.Text = count.ToString();
            }
            else if (count == 4)
            {
                count = number1 / number2;
                tbxNumber.Text = count.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxNumber.Text = "0";
        }


        //private void btn1_Click(object sender, EventArgs e)
        //{
        //    tbxNumber.Text = tbxNumber.Text + 1;
        //}

        //private void btn2_Click(object sender, EventArgs e)
        //{
        //    tbxNumber.Text = tbxNumber.Text + 2;
        //}

        //private void btn3_Click(object sender, EventArgs e)
        //{
        //    tbxNumber.Text = tbxNumber.Text + 3;
        //}

        //private void btn4_Click(object sender, EventArgs e)
        //{
        //    tbxNumber.Text = tbxNumber.Text + 4;
        //}

        //private void btn5_Click(object sender, EventArgs e)
        //{
        //    tbxNumber.Text = tbxNumber.Text + 5;
        //}

        //private void btn6_Click(object sender, EventArgs e)
        //{
        //    tbxNumber.Text = tbxNumber.Text + 6;
        //}

        //private void btn7_Click(object sender, EventArgs e)
        //{
        //    tbxNumber.Text = tbxNumber.Text + 7;
        //}

        //private void btn8_Click(object sender, EventArgs e)
        //{
        //    tbxNumber.Text = tbxNumber.Text + 8;
        //}

        //private void btn9_Click(object sender, EventArgs e)
        //{
        //    tbxNumber.Text = tbxNumber.Text + 9;
        //}

        //private void btnDoubleZero_Click(object sender, EventArgs e)
        //{
        //    tbxNumber.Text = tbxNumber.Text + 0+0;
        //}
        //private void btn0_Click(object sender, EventArgs e)
        //{
        //    tbxNumber.Text = tbxNumber.Text + 0;
        //}

        private void SelectedButtons(object sender, EventArgs e)
        // yukarıdaki kodları yazmak yerine bir event oluştuyoruz.
        {
            if (tbxNumber.Text=="0")
            {
                tbxNumber.Text = "";
            }

            tbxNumber.Text = tbxNumber.Text + ((Button)sender).Text;
            //Yani buttonda ne yazılıysa textBox'a ekle demiş olduk.
        }

        
    }
}
