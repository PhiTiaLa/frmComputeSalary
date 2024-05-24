using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        private PartTimeEmployee employee;

        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void frmComputeSalary_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string department = txtDepartment.Text;
            string jobTitle = txtJobTitle.Text;
            int hoursWorked = int.Parse(txtHoursWorked.Text);
            double ratePerHour = double.Parse(txtRatePerHour.Text);

            employee = new PartTimeEmployee(firstName, lastName, department, jobTitle);
            employee.computeSalary(hoursWorked, ratePerHour);
            lblResult.Text = $"Employee: {employee.FirstName} {employee.LastName}\n" +
                             $"Department: {employee.Department}\n" +
                             $"Job Title: {employee.JobTitle}\n" +
                             $"Basic Salary: {employee.getSalary():C}";
        }
    }
    }