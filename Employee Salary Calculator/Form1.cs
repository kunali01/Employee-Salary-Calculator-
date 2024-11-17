using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Salary_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBasicSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Input Fields
                string empId = txtEmpId.Text;
                string empName = txtEmpName.Text;
                decimal basicSalary = decimal.Parse(txtBasicSalary.Text);

                // Calculations
                decimal hra = basicSalary * 0.40m;  // HRA is 40% of Basic
                decimal da = basicSalary * 0.30m;   // DA is 30% of Basic
                decimal ta = basicSalary * 0.20m;   // TA is 20% of Basic
                decimal pf = basicSalary * 0.12m;   // PF is 12% of Basic
                decimal pt = 200m;                  // PT is fixed 200
                decimal grossSalary = basicSalary + hra + da + ta - pf - pt;

                // Display Results
                txtHRA.Text = hra.ToString("F2");
                txtDA.Text = da.ToString("F2");
                txtTA.Text = ta.ToString("F2");
                txtPF.Text = pf.ToString("F2");
                txtPT.Text = pt.ToString("F2");
                txtGrossSalary.Text = grossSalary.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Basic Salary.", "Input Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error");
            }
        }
    }
    
}
