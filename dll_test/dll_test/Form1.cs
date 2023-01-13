using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using example;

namespace dll_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Employee emp = new Employee();
        private void btnSave_Click(object sender, EventArgs e)
        {
            emp.Info(int.Parse(txtEmployee.Text),txtName.Text,txtAdress.Text,decimal.Parse(txtSalary.Text),dateTimePicker.Value);
            lblEmployee.Text = emp.Number.ToString();
            lblName.Text = emp.Name;
            lblAdress.Text = emp.Adress;
            lblSalary.Text = emp.Salary.ToString();
            lblDate.Text = emp.Date.ToString();
        }
    }
}
