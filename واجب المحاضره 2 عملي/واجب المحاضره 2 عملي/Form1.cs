using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace واجب_المحاضره_2_عملي
{
    public partial class Form1 : Form
    {
        public void keypress1(KeyPressEventArgs s)
        {
            if ((s.KeyChar < '0' || s.KeyChar > ':') && (s.KeyChar != 8))
                s.Handled = true;
        }
        public void oper( char op)
        {
            if (textBox1.Text != "" || textBox2.Text != "") 
            switch (op)
            {
                case '+':
                    {
                        textBox3.Text = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text)).ToString();
                        break;
                    }
                case '*':
                    {

                        textBox3.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)).ToString();
                        break;
                    }
                case '-':
                    {
                        textBox3.Text = (double.Parse(textBox1.Text) - double.Parse(textBox2.Text)).ToString();
                        break;
                    }
                case '/':
                    {
                        if (double.Parse(textBox2.Text) != 0)
                            textBox3.Text = (double.Parse((textBox1.Text)) / (double.Parse(textBox2.Text))).ToString();
                        else {
                            MessageBox.Show("inter the number !=0");
                            textBox2.Focus();
                        }
                        break; }
                default: {
                        break;
                    }
            } 
             
        else if (textBox1.Text == "")
            {
                MessageBox.Show("inter the number");
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show(" please inter the number");
                textBox2.Focus();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oper( '+');
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress1(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.TextChanged += textBox1_TextChanged;
            textBox2.KeyPress += textBox1_KeyPress;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
            this.Text = "اله حاسبة ";
            button5.BackColor = Color.OrangeRed;
                   }

        private void button2_Click(object sender, EventArgs e)
        {
            oper('*');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oper('-');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oper('/');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text !="" || textBox2.Text !="")
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;


        }
    }
}
