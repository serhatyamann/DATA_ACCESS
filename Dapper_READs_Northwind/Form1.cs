using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Dapper_READs_Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExampleQueries_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(DbConnection.ConnectionString))
            {
                //Join
                db.Open();
                var parameter = txtParameter.Text;
                dataGridView1.DataSource = db.Query("select distinct p.*, c.CategoryName from Categories c join Products p on c.CategoryID = p.CategoryID where p.Discontinued = @dis order by p.ProductName", new { dis = parameter }).ToList();
                db.Close();
            }

            using (IDbConnection db = new SqlConnection(DbConnection.ConnectionString))
            {
                //Simple Select
                db.Open();
                dataGridView1.DataSource = db.Query("select * from Employees").ToList();
                db.Close();
            }

            using (IDbConnection db = new SqlConnection(DbConnection.ConnectionString))
            {
                //Select Using Join, Group By and SQL Aggregate Function Sum
                db.Open();
                var parameter = txtParameter.Text; //String CustomerID
                dataGridView1.DataSource = db.Query("select c.CompanyName, CAST(SUM(UnitPrice * Quantity * (1 - Discount)) AS decimal) as [Total Sale] from Customers c INNER JOIN Orders o on c.CustomerID = o.CustomerID INNER JOIN[Order Details] od on o.OrderID = od.OrderID WHERE c.CustomerID = @id GROUP BY c.CustomerID, c.CompanyName", new { id = parameter }).ToList();
                db.Close();
            }

            using (IDbConnection db = new SqlConnection(DbConnection.ConnectionString))
            {
                //Stored Procedure - Giving its parameter by using DynamicParameters.
                db.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@name", txtParameter.Text);
                dataGridView1.DataSource = db.Query("Sp_TotalSaleByEmployee", parameters, commandType: CommandType.StoredProcedure).ToList();
                db.Close();
            }

            using (IDbConnection db = new SqlConnection(DbConnection.ConnectionString))
            {
                //Stored Procedure
                db.Open();
                dataGridView1.DataSource = db.Query("Sp_GetTotalSaleOfSuppliersProduct", commandType: CommandType.StoredProcedure).ToList();
                db.Close();
            }
        }
    }
}
