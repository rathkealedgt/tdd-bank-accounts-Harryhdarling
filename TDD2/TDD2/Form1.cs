using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD2
{

    public partial class Form1 : Form
    {
        int Chnge;

        string Country;
        string Num;
        string Usr;
        string Interest;
        string Money;

        double Time;
        double Mon;
        double Int;
        double Answer;
        string q1;
        string q2;
        string q3;
        string q4;
        string q5;
        string q6;
        string q7;
        string q8;
        string q9;
        string q10;

        public Form1()
        {
            InitializeComponent();
        }
        

    private void button1_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;

            Country = textBox1.Text;
            Num = textBox2.Text;
            Usr = textBox3.Text;
            Interest = textBox4.Text;
            Money = textBox5.Text;

            textBox6.Text = Country +newLine+ Num +newLine+ Usr +newLine+ Interest +newLine + Money;



        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Chnge = Convert.ToInt32(numericUpDown1.Value);

            if (Chnge == 1)
            {
                textBox6.Text = q1;
            }

            if (Chnge == 2)
            {
                textBox6.Text = q2;

            }

            if (Chnge == 3)
            {
                textBox6.Text = q3;

            }

            if (Chnge == 4)
            {
                textBox6.Text = q4;
            }

            if (Chnge == 5)
            {
                textBox6.Text = q5;
            }

            if (Chnge == 6)
            {
                textBox6.Text = q6;
            }

            if (Chnge == 7)
            {
                textBox6.Text = q7;
            }

            if (Chnge == 8)
            {
                textBox6.Text = q8;
            }

            if (Chnge == 9)
            {
                textBox6.Text = q9;
            }

            if (Chnge == 10)
            {
                textBox6.Text = q10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Chnge == 1)
            {
                q1 = textBox6.Text;
            }

            if (Chnge == 2)
            {
                q2 = textBox6.Text;
            }

            if (Chnge == 3)
            {
                q3 = textBox6.Text;
            }

            if (Chnge == 4)
            {
                q4 = textBox6.Text;
            }

            if (Chnge == 5)
            {
                q5 = textBox6.Text;
            }

            if (Chnge == 6)
            {
                q6 = textBox6.Text;
            }

            if (Chnge == 7)
            {
                q7 = textBox6.Text;
            }

            if (Chnge == 8)
            {
                q8 = textBox6.Text;
            }

            if (Chnge == 9)
            {
                q9 = textBox6.Text;
            }

            if (Chnge == 10)
            {
                q10 = textBox6.Text;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Time = Convert.ToDouble(numericUpDown2.Value);
            string[] temp = textBox6.Text.Split('\n');
            int lenth = temp.Count();
            Int = Convert.ToDouble(temp[lenth - 1]);
            Mon = Convert.ToDouble(temp[lenth - 2]);
            Answer = (Mon * Int * Time);
            textBox7.Text = Convert.ToString(Answer);
        }
    }
}
