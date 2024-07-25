using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employees
{
    public partial class Form1 : Form
    {
        int Count = 0;
        Employee [] employeesArr = new Employee[0];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)           
        {
            // Creat cless arrive 
            Employee employee = new Employee(
                fName.Text,
                lName.Text,
                id.Text,
                dateTimePicker1.Value,
                int.Parse(empNum.Text),
                phone.Text,
                city.Text,
                street.Text,
                int.Parse(houseNum.Text),
                getGender(),
                getStatus()
                );

            //Append employee to employeesArr
            if (employeesArr[employeesArr.Length - 1] == null)
            {
                employeesArr[employeesArr.Length - 1] = employee;
                return;
            }

            Employee [] tmp = new Employee [employeesArr.Length + 1];
            for (int i = 0; i < employeesArr.Length; i++)
            {
                tmp[i] = employeesArr[i];   
            }
            employeesArr = tmp;
            employeesArr[employeesArr.Length - 1] = employee;

        }
        private string employeeDetailes()
        {
            //Dictionary <string, string> empDtls = new Dictionary<string, string>();
            //empDtls.Add("First Name", fName.Text);
            //empDtls.Add("Last Name", lName.Text);
            //empDtls.Add("Id", id.Text);
            //empDtls.Add("Birthday", dateTimePicker1.Text);
            //empDtls.Add("Emplpyee Number", empNum.Text);
            //empDtls.Add("City", city.Text);
            //empDtls.Add("Street", street.Text);
            //empDtls.Add("House Number", houseNum.Text);
            //empDtls.Add("Gender", getGender());
            //empDtls.Add("Status", getStatus());
            //return empDtls;
            
            // Variable that contains all employee's details
            string empDtls = "";
            empDtls += ("First Name", fName.Text);
            empDtls += ("Last Name", lName.Text);
            empDtls += ("Id", id.Text);
            empDtls += ("Birthday", dateTimePicker1.Text);
            empDtls += ("Emplpyee Number", empNum.Text);
            empDtls += ("City", city.Text);
            empDtls += ("Street", street.Text);
            empDtls += ("House Number", houseNum.Text);
            empDtls += ("Gender", getGender());
            empDtls += ("Status", getStatus());
            fName.Text = empDtls;
            return empDtls;
        }

        private string getGender()
        {
            if (maleRd.Checked == true)
                return "Male";
            if (femaleRd.Checked == true)
                return "Female";
            else return ""; 

        }

        private string getStatus()
        {
            if (marriedRd.Checked == true)
                return "Married";
            if (bachelorRd.Checked == true)
                return "Bachelor";
            if (windowerRd.Checked == true)
                return "Windower";
            if (divorceeRd.Checked == true)
                return "Divorcee";
            else return "";

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {

        }

        private void birthday_Click(object sender, EventArgs e)
        {

        }

        private void srcByEmpNum_Click(object sender, EventArgs e)
        {
            foreach (Employee emp in employeesArr)
            { 
            if (emp.EmployeeNum == int.Parse(empNumTB.Text))
                fnTB.Text = emp.FirstName;
                lnTB.Text = emp.LastName;
                idTB.Text = emp.Id;
                dateTimePicker1 = new DateTimePicker();
                empNumTB.Text = emp.Birthday.ToString();
                phoneTB.Text = emp.Phone;
                cityTB.Text = emp.City;
                streetTB.Text = emp.Street;
                houseNumTB.Text = emp.HouseNum.ToString();

            }

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(1235567887);
            fnTB.Text = "";
            lnTB.Text = "";
            idTB.Text = "";
            //dateTimePicker1.Enabled = false;
            empNumTB.Text = "";
            phoneTB.Text = "";
            cityTB.Text = "";
            streetTB.Text = "";
            houseNumTB.Text = "";
        }

        private void buttonh_Click_2(object sender, EventArgs e)
        {
            Console.WriteLine(1235567887);
            fnTB.Text = "";
            lnTB.Text = "";
            idTB.Text = "";
            dateTimePicker1.Enabled = false;
            empNumTB.Text = "";
            phoneTB.Text = "";
            cityTB.Text = "";
            streetTB.Text = "";
            houseNumTB.Text = "";
        }
    }
}
