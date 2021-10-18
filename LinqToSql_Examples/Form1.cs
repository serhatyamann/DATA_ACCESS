using LinqToSql_Examples.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql_Examples
{
    public partial class Form1 : Form
    {
        NorthwindEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new NorthwindEntities();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            //Listing FirstName, LastName, Title and Birthday fields of Employees.

            var employees = from x in db.Employees
                            select new
                            {
                                x.FirstName,
                                x.LastName,
                                x.Title,
                                x.BirthDate
                            };
            dataGridView1.DataSource = employees.ToList();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            //Listing the employees whose IDs are between 2 and 8.

            var employees = from x in db.Employees
                            where x.EmployeeID >= 2 & x.EmployeeID <= 8
                            orderby x.FirstName
                            select new
                            {
                                x.FirstName,
                                x.LastName,
                                x.Title,
                                x.BirthDate
                            };
            dataGridView1.DataSource = employees.ToList();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            //Sorting the employees older than 60.

            var employees = from x in db.Employees
                            where SqlFunctions.DateDiff("yy", x.BirthDate, DateTime.Now) > 60
                            orderby SqlFunctions.DateDiff("yy", x.BirthDate, DateTime.Now) descending
                            select new
                            {
                                FirstName = x.FirstName,
                                LastName = x.LastName,
                                Title = x.Title,
                                Age = SqlFunctions.DateDiff("yy", x.BirthDate, DateTime.Now)
                            };
            dataGridView1.DataSource = employees.ToList();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            //Sorting the employees whose title is Mr and whose age is over 60.

            var result = from x in db.Employees
                         where SqlFunctions.DateDiff("yy", x.BirthDate, DateTime.Now) > 60 &
                         x.TitleOfCourtesy == "Mr."
                         select new
                         {
                             FirstName = x.FirstName,
                             LastName = x.LastName,
                             TitleOfCourtesy = x.TitleOfCourtesy,
                             Age = SqlFunctions.DateDiff("yy", x.BirthDate, DateTime.Now)
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            //Listing each order with its amount.

            var result = (from od in db.Order_Details
                          group od.Quantity * od.UnitPrice * (int)Math.Floor(1 - od.Discount) by od.OrderID into oID
                          select new
                          {
                              Order = oID.Key,
                              TotalAmount = oID.Sum()
                          });

            dataGridView1.DataSource = result.ToList();
        }
    }
}
