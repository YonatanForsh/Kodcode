using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        Cars[] carsArr = new Cars[] {
            new Cars(Color.Green),
            new Cars(Color.Red),
            new Cars(Color.Blue)
        };

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var car in carsArr)
            {
                car.DisplayColor();
            }
        }
    }
}
