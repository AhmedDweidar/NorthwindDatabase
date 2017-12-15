using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindDatabase
{
    public partial class Form1 : Form
    {
        List<Customer> customers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerRepository cr = new CustomerRepository();
            dgv.DataSource = cr.GetCustomer(textBoxSearch.Text);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            CustomerRepository cr = new CustomerRepository();

            customers = cr.GetCustomer(textBoxSearch.Text);
            dgv.DataSource = customers;
        }
    }
}
