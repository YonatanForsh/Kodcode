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
    public partial class targil : Form
    {
        public targil()
        {
            InitializeComponent();
        }

        private void targil_Load(object sender, EventArgs e)
        {
            string sql = "select count (*) from Clock_time";
            string resolt = DBConnection.runSQL(sql);
            MessageBox.Show(resolt);
        }
    }
}
