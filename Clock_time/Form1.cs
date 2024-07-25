using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PassTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string resolt = EmployeeManager.Login(IdTB.Text, PassTB.Text);
                MessageBox.Show(resolt);
                IdTB.Text = null;
                PassTB.Text = null;
            }
        }
    

        private void PassTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChPBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword();
            changePasswordForm.Show();
        }
    }
}
