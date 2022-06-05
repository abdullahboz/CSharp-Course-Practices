using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrisCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(tbxRow.Text);
            int column = Convert.ToInt32(tbxColumn.Text);

            Random rnd = new Random();

            int[,] matrix = new int[row,column];
            int[,] matrix2 = new int[row,column];
            int[,] sumMatrix = new int[row, column];// Matris Tanımlaması


            // Matris doldurma
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = rnd.Next(1, 20);
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix2[i, j] = rnd.Next(1, 10);
                }
            }
            // Matris Toplama
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sumMatrix[i, j] = matrix[i,j] + matrix2[i,j];
                }
            }
            tbxResult.Clear();
            // toplam matris ekrana yazdırma
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    tbxResult3.Text += sumMatrix[i, j].ToString()  + " ";
                }

                tbxResult3.Text += Environment.NewLine; // alt satıra geçme
            }
            tbxResult.Clear();
            // matris1 ekrana yazdırma
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    tbxResult.Text += matrix[i, j].ToString() + " ";
                }

                tbxResult.Text += Environment.NewLine; // alt satıra geçme
            }
            tbxResult2.Clear();
            // matris2 ekrana yazdırma
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    tbxResult2.Text += matrix2[i, j].ToString() + " ";
                }

                tbxResult2.Text += Environment.NewLine; // alt satıra geçme
            }

        }
    }
}
