using Dapper_CRUD_NW.Entities.Concrete;
using Dapper_CRUD_NW.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_CRUD_NW
{
    public partial class Form1 : Form
    {
        ProductRepository productRepository;
        public Form1()
        {
            InitializeComponent();
            //Creating an instance of ProductRepository class when Form1 initializing.
            productRepository = new ProductRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productRepository.GetProducts();
            lblRowCount.Text = dataGridView1.RowCount.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Creating an instance of my Product class and providing data to it with TextBox'es.
            //Sending this filled Product instance to "Insert()" method which in ProductRepository.
            //Calling the list of Products with GetProducts() method and giving it to datagridview as data source.
            try
            {
                Product product = new Product();
                product.ProductName = txtProductName.Text;
                product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                productRepository.Insert(product);
                dataGridView1.DataSource = productRepository.GetProducts();
                lblRowCount.Text = dataGridView1.RowCount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in the fields!..");;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Creating an instance of my Product class and providing data to it with TextBox'es.
            //Sending this filled Product instance to "Update()" method which in ProductRepository.
            //Calling the list of Products with GetProducts() method and giving it to datagridview as data source.
            try
            {
                Product product = new Product();
                product.ProductID = int.Parse(txtUpdateID.Text);
                product.ProductName = txtUpdateProductName.Text;
                product.UnitPrice = decimal.Parse(txtUpdateUnitPrice.Text);
                productRepository.Update(product);
                dataGridView1.DataSource = productRepository.GetProducts();
                lblRowCount.Text = dataGridView1.RowCount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please try again!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDeleteID.Text != string.Empty)
            {
                productRepository.Delete(int.Parse(txtDeleteID.Text));
                dataGridView1.DataSource = productRepository.GetProducts();
                lblRowCount.Text = dataGridView1.RowCount.ToString();
                MessageBox.Show("The product has been deactivated.");
            }
            else
            {
                MessageBox.Show("Please try again with an ID!...");
            }
        }
    }
}
