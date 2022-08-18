using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        bool isDefaultState = true;
        string defaultStateValue = "0.";
        public Form1()
        {
            InitializeComponent();
            lblInput.Text = defaultStateValue;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            CheckDefaultState();
            lblInput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            CheckDefaultState();
            lblInput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            CheckDefaultState();
            lblInput.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CheckDefaultState();
            lblInput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CheckDefaultState();
            lblInput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            CheckDefaultState();
            lblInput.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CheckDefaultState();
            lblInput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CheckDefaultState();
            lblInput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CheckDefaultState();
            lblInput.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            CheckDefaultState();
            lblInput.Text += "0";
        }

        private void CheckDefaultState()
        {
            if (isDefaultState)
            {
                // clear the input
                isDefaultState = false;
                lblInput.Text = "";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblInput.Text = defaultStateValue;
            isDefaultState = true;
        }


        private string BackSpace(string input)
        {
            if(input.Length ==1 || isDefaultState)
            {
                isDefaultState = true;
                return defaultStateValue;
            }
            string data = input.Substring(0, input.Length - 1);
            return data;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            lblInput.Text = BackSpace(lblInput.Text);
        }

     
    }
}
