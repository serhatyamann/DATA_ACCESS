using Linq_Methods.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities1 db = new NorthwindEntities1();
        private void btnToList_Click(object sender, EventArgs e)
        {
            //ToList() method one of the most subsconsciously used LINQ methods in all our journeys with collections. ToList() method takes in an IEnumerable type and converts it to a List type.

            dataGridView1.DataSource = db.Categories.ToList();
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            //Where() method returns all the elements from the collection which satisfy a given condition.

            //Products with a unit price between 20 and 40.
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice >= 20 &&
                                                              x.UnitPrice <= 40).ToList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //The Select() method helps in projecting or mapping each element of the collection into a new sequence.

            //List the products with UnitsInStock is between 100 and 200. Get the ID, Name, UnitPrice and UnitsInStock fields of these products.
            dataGridView1.DataSource = db.Products.Where(x => x.UnitsInStock > 20 && x.UnitPrice < 40).Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.UnitPrice,
                x.UnitsInStock
            }).ToList();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            //OrderBy() method sorts the elements in a given collection in ascending order based on a given condition and returns the sorted collection.
            #region OrderBy()
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 20).OrderBy(x => x.ProductName).Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.UnitPrice,
                x.UnitsInStock
            }).ToList();
            #endregion

            //OrderByDescending() method is similar to OrderBy() method, except that the collection is sorted in a descending order.
            #region OrderByDescending()
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 20).OrderByDescending(x => x.UnitPrice).Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.UnitPrice,
                x.UnitsInStock
            }).ToList();
            #endregion
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //First() method returns the "first" element in the collection, for an optional condition.If a condition is passed to the function as a predicate, the method returns the first element in the list which satisfies the predicate function.If no elements satisfy the condition, it throws an exception.

            Category category = db.Categories.First();
            if (category == null)
            {
                MessageBox.Show("The category you are looking for could not be found!");
            }
            else
            {
                MessageBox.Show($"The category you are looking for is: {category.CategoryName}");
            }
        }

        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            //FirstOrDefault() works in a similar fashion as the First() method for positive cases in a collection - it returns the first element in the collection which satisfy an optional condition. The difference is in the negative case where there are no elements that satisfy the condition or the collection is empty - the method returns the default value for that type: NULL for reference types and respective default value for value types.

            Product product = db.Products.FirstOrDefault();
            if (product == null)
            {
                MessageBox.Show("The category you are looking for could not be found!");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Find() => Used to filter out unique fields such as ID.
            Category category = db.Categories.Find(37);

            if (category == null)
            {
                MessageBox.Show("The category you are looking for could not be found!");
            }
            else
            {
                MessageBox.Show($"The category you are looking for is: {category.CategoryName}");
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            //Take() extracts the first n elements (where n is a parameter to the method) from the beginning of the target sequence and returns a new sequence containing only the elements taken.
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 20).Select(x => new { x.ProductID, x.ProductName, x.UnitPrice }).OrderByDescending(x => x.ProductID).Take(5).ToList();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            //Skip() "skips" over the first n elements (where n is a parameter to the method) in the sequence and returns a new sequence containing the remaining elements after the first n elements.
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 20 && x.UnitPrice < 50).OrderByDescending(x => x.UnitPrice).Select(x => new { x.ProductID, x.ProductName, x.UnitPrice, x.UnitsInStock }).Skip(5).Take(5).ToList();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            //Contains() => Used to check whether a sequence or collection (i.e. data source) contains a specified element or not. If the data source contains the specified element, then it returns true else returns false.

            //Listing the products with the letter "b" in the ProductName.
            dataGridView1.DataSource = db.Products.Select(x => new { x.ProductID, x.ProductName, x.UnitPrice }).Where(x => x.ProductName.Contains("b")).ToList();
        }

        private void btnStartsEndsWith_Click(object sender, EventArgs e)
        {
            // StartsWith() => Used to check whether the beginning of the current string instance matches with a specified string or not. If it matches then it returns the string otherwise false.

            dataGridView1.DataSource = db.Employees.Where(x => x.FirstName.StartsWith("r")).ToList();

            // EndsWith() => Used to check whether the ending of the current string instance matches with a specified string or not. If it matches then it returns the string otherwise false.

            dataGridView1.DataSource = db.Employees.Where(x => x.FirstName.EndsWith("t")).ToList();
        }

        private void btnAny_Click(object sender, EventArgs e)
        {
            //Any() => Used to check whether at least one of the elements of a data source satisfies a given condition or not. If any of the elements satisfy the given condition, then it returns true else return false.

            //bool result = db.Categories.Any(x => x.CategoryName == "Bavaragos");
            //MessageBox.Show(result.ToString());

            bool result = db.Categories.Any(x => x.CategoryName.StartsWith("Be"));

            MessageBox.Show(result.ToString());
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            //Count() => Used to count number of items in collection.
            int countProducts = db.Products.Count();
            MessageBox.Show(countProducts.ToString());
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            //Sum() => Can only be called on a sequence containing numerical elements. It returns a single value indicating the sum of all elements in the sequence.
            int? StockSum = db.Products.Sum(x => x.UnitsInStock);
            MessageBox.Show(StockSum.ToString());
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            //Min() => Returns the minimum value from the source sequence.
            decimal? cheapestProduct = db.Products.Min(x => x.UnitPrice);

            //Max() returns the maximum value from the source sequence.
            decimal? mostExpensiveProduct = db.Products.Max(x => x.UnitPrice);
        }

        private void btnDistinct_Click(object sender, EventArgs e)
        {
            //Distinct() => Used for removing duplicates elements from the sequence (list). 
            List<string> countries = db.Employees.Select(x => x.City).Distinct().ToList();
            foreach (var item in countries)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            //GroupBy() => Takes a flat sequence of elements and then organizes the elements into groups (i.e. IGrouping<TKey, TSource>) based on a given key.
            //Join() => The Join operator joins two sequences (collections) based on a key and returns a resulted sequence.
            //How many products do each category has?
            dataGridView1.DataSource = db.Categories
                 .Join(db.Products, c => c.CategoryID, p => p.CategoryID, (c, p) => new { c, p })
                 .GroupBy(x => x.c.CategoryName)
                 .Select(x => new
                 {
                     CategoryName = x.Key,
                     TotalNumberofProducts = x.Sum(q => q.p.UnitsInStock)
                 }).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
