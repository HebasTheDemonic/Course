using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part3
{
    public partial class Form1 : Form
    {
        static int LabelAmount = 5;
        Random randomGen = new Random();
        int[] labelValues = new int[LabelAmount];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ValueGenerator();
            LabelNumGenerator();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (RnNum1.Visible)
            {
                FlipVisible();
            }
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            int score = 0;
            CheckIfMatch(textBox1, labelValues[0], ref score, RnNum1);
            CheckIfMatch(textBox2, labelValues[1], ref score, RnNum2);
            CheckIfMatch(textBox3, labelValues[2], ref score, RnNum3);
            CheckIfMatch(textBox4, labelValues[3], ref score, RnNum4);
            CheckIfMatch(textBox5, labelValues[4], ref score, RnNum5);
            ScoreList.Items.Add($"You guessed {score} numbers correctly");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValueGenerator();
            ScoreList.Items.Clear();
            LabelNumGenerator();
            FlipVisible();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LabelNumGenerator()
        {
            RnNum1.Text = labelValues[0].ToString();
            RnNum2.Text = labelValues[1].ToString();
            RnNum3.Text = labelValues[2].ToString();
            RnNum4.Text = labelValues[3].ToString();
            RnNum5.Text = labelValues[4].ToString();
        }

        private void FlipVisible()
        {
            RnNum1.Visible = !RnNum1.Visible;
            RnNum2.Visible = !RnNum2.Visible;
            RnNum3.Visible = !RnNum3.Visible;
            RnNum4.Visible = !RnNum4.Visible;
            RnNum5.Visible = !RnNum5.Visible;
        }

        private void ValueGenerator()
        {
            for (int counter = 0; counter < LabelAmount; counter++)
            {
                labelValues[counter] = randomGen.Next(101);
            }
        }

         private void CheckIfMatch(TextBox textBox, int v, ref int score, Label rnNum)
         {
            if (Convert.ToInt32(textBox.Text) == v)
            {
                score++;
                rnNum.ForeColor = SystemColors.ControlText;
            }
            else
            {
                rnNum.ForeColor = Color.Red;
            }
         }

    }
}
