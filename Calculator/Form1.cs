using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private TextBox selectedTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            //Error if n1 or n2 are empty
            if (txt1.Text == "" ||  txt2.Text == "")
            {
                lblResolt.Text = "Error";
                return;
            }

            //Convert  string to float

            float n1 = float.Parse(txt1.Text);
            float n2 = float.Parse(txt2.Text);

            if (cmbOperator.Text == "+")
            {
                lblResolt.Text = (n1 + n2).ToString();
            }
            else if (cmbOperator.Text == "-")
            {
                lblResolt.Text = (n1 - n2).ToString();
            }
            else if (cmbOperator.Text == "*")
            {
                lblResolt.Text = (n1 * n2).ToString();
            }
            else if (cmbOperator.Text == "/")
            {
                // - Check that n2 isn't 0
                if (n2 == 0)
                {
                    lblResolt.Text = "error";
                    return;
                }
                lblResolt.Text = (n1 / n2).ToString();
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt1_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void txt2_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void cmbOperator_TextChanged(object sender, EventArgs e)
        {
            selectedTextBox = txt2;
        }

        private void allButtons_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += ((Button)sender).Text;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedTextBox.Text.Length <= 0)
            {
                //lblResolt.Text = "error";
                return;
            }
            selectedTextBox.Text =  selectedTextBox.Text.Remove(selectedTextBox.Text.Length-1);
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (cmbOperator.Items.Count > 0)
                cmbOperator.SelectedItem = cmbOperator.Items[1];
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            if (cmbOperator.Items.Count > 0)
                cmbOperator.SelectedItem = cmbOperator.Items[1];
        }

        private void mul_button_Click(object sender, EventArgs e)
        {
            if (cmbOperator.Items.Count > 0)
                cmbOperator.SelectedItem = cmbOperator.Items[2];
        }

        private void div_button_Click(object sender, EventArgs e)
        {
            if (cmbOperator.Items.Count > 0)
                cmbOperator.SelectedItem = cmbOperator.Items[3];
        }
    }
}