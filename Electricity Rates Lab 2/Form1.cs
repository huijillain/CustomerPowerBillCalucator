using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CustomersData;

namespace Electricity_Rates_Lab_2
{
    public partial class frmPowerBill : Form
    {
        public frmPowerBill()
        {
            InitializeComponent();
        }
        //Customer Type kWh Peak and Off Peak visible or not
        private void CmbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCustomerType.SelectedIndex)
            {
                // Residential & Commercial:
                case 0:
                case 1:
                    txtOffPeak.Enabled = false;
                    txtPeak.Enabled = false;
                    txtKwh.Enabled = true;
                    break;
                //Industrial
                case 2:
                    txtPeak.Enabled = true;
                    txtOffPeak.Enabled = true;
                    txtKwh.Enabled = false;
                    break;
            }
        }

        private void txtCustomerName_KeyPresstxtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtChargeAmount_KeyPresstxtChargeAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar != '.') && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Calculate and Add info to the List
        private void btnAdd2List_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                MessageBox.Show("Please insert account number!");
                return;
            }

            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Please insert customer name!");
                return;
            }


            var cust = CreateCustomer(cmbCustomerType.SelectedIndex, txtKwh.Text, txtOffPeak.Text);
            if (cust == null)
            {
                MessageBox.Show("Wrong Input!");
                return;
            }

            dgvMain.Rows.Add(cust.AccountNo, cust.CustomerName, cust.GetName(), cust.ChargeAmount);
            
            txtTtlCust.Text = (int.Parse(txtTtlCust.Text) + 1).ToString();
            
            ////Couldn't get the Total charges section to work 
            decimal tr = 0m, tc = 0m, ti = 0m;
            decimal ChargeAmount = 0;
            switch (cmbCustomerType.Items[cmbCustomerType.SelectedIndex].ToString())
            {
                case "Residential":

                    tr += ChargeAmount;
                    break;
                case "Commercial":

                    tc += ChargeAmount;
                    break;
                case "Industrial":

                    ti += ChargeAmount;
                    break;
            }
            txtTtlCharges.Text = (tr + tc + ti).ToString("c");
            txtAccountNumber.Text = txtCustomerName.Text = "";
            cmbCustomerType.SelectedIndex = 0;
        }
        //Creating Customers
        private Customers CreateCustomer(int index, string kwhStr, string offPeakStr = "") 
        {
            decimal offPeak;
            decimal kwh;
            if (index == 0) // Residential
            {
                bool succeeded = decimal.TryParse(kwhStr, out kwh);
                if (succeeded)
                {
                    Customers c = new ResidentialCustomers(txtAccountNumber.Text, txtCustomerName.Text);
                    c.CalculateCharge(kwh);
                    return c;
                }
            }
            else if (index == 1) // Commercial
            {
                bool succeeded = decimal.TryParse(kwhStr, out kwh);
                if (succeeded)
                {
                    Customers c = new CommercialCustomers(txtAccountNumber.Text, txtCustomerName.Text);
                    c.CalculateCharge(kwh);
                    return c;
                }
            }
            else // Industrial
            {
                bool succeeded = decimal.TryParse(kwhStr, out kwh);
                bool succeeded2 = decimal.TryParse(offPeakStr, out offPeak);
                if (succeeded && succeeded2)
                {
                    Customers c = new IndustrialCustomers(txtAccountNumber.Text, txtCustomerName.Text);
                    c.CalculateCharge(kwh, offPeak);
                    return c;
                }
            }

            return null;
        }

       //When loading the form, info is read from a txt file
        private void frmPowerBill_Load(object sender, EventArgs e)
        {
            cmbCustomerType.SelectedIndex = 0;

            int count = 0;
            if (File.Exists("backup_charge.txt"))
            {
                string line = "";
                using (StreamReader sr = new StreamReader("backup_charge.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        var temp = line.Split(',');
                        dgvMain.Rows.Add(temp[0], temp[1], temp[2], temp[3]);
                        
                              //Could not get this to work             
                        decimal tr = 0m, tc = 0m, ti = 0m;
                        
                            decimal ChargeAmount = 0;
                            switch (temp[2])
                            {
                                case "Residential":
                                   tr += ChargeAmount;
                                break;
                                case "Commercial":
                                    tc += ChargeAmount;
                                    break;
                                case "Industrial":
                                ti += ChargeAmount;
                                    break;
                            }
                            
                            count++;
                        
                        txtTtlCharges.Text = (tr + tc + ti).ToString("c");
                        txtRCharges.Text = tr.ToString("c");
                        txtCCharges.Text = tc.ToString("c");
                        txtICharges.Text = ti.ToString("c");
                    }
                }
                txtTtlCust.Text = count.ToString();
            }
        }
        //When form is closed, list info is written to a file
        private void frmPowerBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("backup_charge.txt"))
            {
                for (int i = 0; i < dgvMain.Rows.Count - 1; i++)
                {
                    sw.WriteLine(dgvMain.Rows[i].Cells[0].Value + "," + dgvMain.Rows[i].Cells[1].Value +
                        "," + dgvMain.Rows[i].Cells[2].Value + "," + dgvMain.Rows[i].Cells[3].Value);
                }
            }
        }
    }
}
