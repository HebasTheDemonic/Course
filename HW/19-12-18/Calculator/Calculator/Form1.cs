using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calcBody : Form
    {
        public calcBody()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            int numOne = Convert.ToInt32(firstNumTxtBx.Text);
            int numTwo = Convert.ToInt32(secondNumTxtBx.Text);
            int result = numOne + numTwo;
            resultsList.Items.Add(result);
            resultsList.SelectedIndex = resultsList.Items.Count - 1;
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            int numOne = Convert.ToInt32(firstNumTxtBx.Text);
            int numTwo = Convert.ToInt32(secondNumTxtBx.Text);
            int result = numOne - numTwo;
            resultsList.Items.Add(result);
            resultsList.SelectedIndex = resultsList.Items.Count - 1;
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            int numOne = Convert.ToInt32(firstNumTxtBx.Text);
            int numTwo = Convert.ToInt32(secondNumTxtBx.Text);
            int result = numOne * numTwo;
            resultsList.Items.Add(result);
            resultsList.SelectedIndex = resultsList.Items.Count - 1;
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            int numOne = Convert.ToInt32(firstNumTxtBx.Text);
            int numTwo = Convert.ToInt32(secondNumTxtBx.Text);
            if (numTwo != 0)
            {
                int result = numOne / numTwo;
                resultsList.Items.Add(result);
                resultsList.SelectedIndex = resultsList.Items.Count - 1;
            }
            else
            {
                BackColor = Color.FromArgb(128, 0, 0);
            }
        }

        private void RootBtn_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            int numOne = Convert.ToInt32(firstNumTxtBx.Text);
            int numTwo = Convert.ToInt32(secondNumTxtBx.Text);
            double result = Math.Pow(numOne, (1 / numTwo));
            resultsList.Items.Add(result);
            resultsList.SelectedIndex = resultsList.Items.Count - 1;
        }

        private void PowerBtn_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            int numOne = Convert.ToInt32(firstNumTxtBx.Text);
            int numTwo = Convert.ToInt32(secondNumTxtBx.Text);
            double result = Math.Pow(numOne, numTwo);
            resultsList.Items.Add(result);
            resultsList.SelectedIndex = resultsList.Items.Count - 1;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            Debug.WriteLine("Result Box Cleared!");
            resultsList.Items.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            Random randomGen = new Random();
            firstNumTxtBx.Text = randomGen.Next(101).ToString();
            secondNumTxtBx.Text = randomGen.Next(101).ToString();
        }

        private void secondNumTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void firstNumTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            BackColor = SystemColors.Control;
        }
    }
}
