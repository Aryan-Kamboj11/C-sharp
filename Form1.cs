using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text+"8";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "9";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //this.label1.Text ="0";
            this.label1.ResetText();
            this.operator_label.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text=this.label1.Text+"2";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.label1.Text=this.label1.Text+"3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text=this.label1.Text+"4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text=this.label1.Text+"5";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.label1.Text=this.label1.Text+"6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "%";
            if (this.label1.Text != "")
            {
                this.first_num_label.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-"; 
            if (this.label1.Text != "")
            {
                this.first_num_label.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";
            if (this.label1.Text != "")
            {
                this.first_num_label.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "*";
            if (this.label1.Text != "")
            {
                this.first_num_label.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "/";
            if (this.label1.Text != "")
            {
                this.first_num_label.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

    }
}
