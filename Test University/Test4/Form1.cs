using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddDateBtn_Click(object sender, EventArgs e)
        {
            List<string> list = new List <string>();
            list.Add(CMBXDay.Text);
            list.Add(CMBXDayInMonth.Text);
            list.Add(CMBXMonth.Text);
            list.Add(CMBXYear.Text);
            
            Test4Manager.AddDate(list);
            MessageBox.Show("");
        }
    }
}
