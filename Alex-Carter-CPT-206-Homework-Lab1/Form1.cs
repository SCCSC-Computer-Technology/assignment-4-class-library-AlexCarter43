using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alex_Carter_CPT_206_Homework_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Clear all listbox and textbox
        private void Clear()
        {
            productListBox.Items.Clear();
            numTextBox.Text = "";
            desTextBox.Text = "";
            uOHTextBox.Text = "";
            minTextBox.Text = "";
            maxTextBox.Text = "";
        }
        //Load the database on to a listbox with formatting
        private void Form1_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            foreach (Product item in db.Products)
            {
                string formattedNumbers = item.Price.ToString("$0.00");

                productListBox.Items.Add($"{item.Product_Number, -7} {formattedNumbers, -7} {item.Units_On_Hand, -7} {item.Description, -50}");
            }
        }
        //Search button will load the first list box that was shown
        private void searchButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            Clear();

            foreach (Product item in db.Products)
            {
                string formattedNumbers = item.Price.ToString("$0.00");
                

                productListBox.Items.Add($"{item.Product_Number,-7} {formattedNumbers,-7} {item.Units_On_Hand,-7} {item.Description,-50}");
            }
            
        }
        //This button takes input and finds the matching product number and shows it
        private void searchByButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            string userInput1 = numTextBox.Text;
            var result1 = from item in db.Products where item.Product_Number == userInput1 select item;

            Clear();
            foreach (var item in result1)
            {
                string formattedNumbers = item.Price.ToString("$0.00");
                

                productListBox.Items.Add($"{item.Product_Number,-7} {formattedNumbers,-7} {item.Units_On_Hand,-7} {item.Description,-50}");
            }


        }
        //This button takes input and looks for description that contains what was inputed and shows it/them
        private void searchByDesButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            string userInput2 = desTextBox.Text;
            var result2 = db.Products.Where(item => item.Description.Contains(userInput2)).Select(item => item);

            Clear();
            foreach (var item in result2)
            {
                string formattedNumbers = item.Price.ToString("$0.00");


                productListBox.Items.Add($"{item.Product_Number,-7} {formattedNumbers,-7} {item.Units_On_Hand,-7} {item.Description,-50}");
            }
        }
        //This button shows all sorted in asc order of Units on hand
        private void allUnitsButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            Clear();

            var result = db.Products.OrderBy(item => item.Units_On_Hand).Select(item => item);
            foreach (var item in result)
            {
                string formattedNumbers = item.Price.ToString("$0.00");


                productListBox.Items.Add($"{item.Product_Number,-7} {formattedNumbers,-10} {item.Units_On_Hand,-7} {item.Description,-50}");
            }

        }
        //This button shows all with units on hand greater then the user input in asc order
        private void greaterButton_Click(object sender, EventArgs e)
        {
            Clear();
            if (int.TryParse(uOHTextBox.Text, out int userInput))
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                var result = db.Products.Where(item => item.Units_On_Hand > userInput).OrderBy(item => item.Units_On_Hand).Select(item => item);
                foreach (var item in result)
                {
                    string formattedNumbers = item.Price.ToString("$0.00");


                    productListBox.Items.Add($"{item.Product_Number,-7} {formattedNumbers,-10} {item.Units_On_Hand,-7} {item.Description,-50}");
                }
            }
        }
        //This button shows all with units on hand less then the user input in asc order
        private void lessButton_Click(object sender, EventArgs e)
        {
            Clear();
            if (int.TryParse(uOHTextBox.Text, out int userInput))
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                var result = db.Products.Where(item => item.Units_On_Hand < userInput).OrderBy(item => item.Units_On_Hand).Select(item => item);
                foreach (var item in result)
                {
                    string formattedNumbers = item.Price.ToString("$0.00");


                    productListBox.Items.Add($"{item.Product_Number,-7} {formattedNumbers,-10} {item.Units_On_Hand,-7} {item.Description,-50}");
                }
            }
        }
        //This button shows all in asc order by Price
        private void allPriceButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            Clear();

            var result = db.Products.OrderBy(item => item.Price).Select(item => item);
            foreach (var item in result)
            {
                string formattedNumbers = item.Price.ToString("$0.00");


                productListBox.Items.Add($"{item.Product_Number,-7} {formattedNumbers,-10} {item.Units_On_Hand,-7} {item.Description,-50}");
            }
        }
        //This button shows all inbetween two numbers enter and sorts in asc order
        private void minMaxButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Clear();

            if (decimal.TryParse(minTextBox.Text, out decimal minPrice) && decimal.TryParse(maxTextBox.Text, out decimal maxPrice))
            {
                var result = db.Products.Where(item => item.Price >= minPrice && item.Price <= maxPrice).OrderBy(item => item.Price).Select(item => item);
                foreach (var item in result)
                {
                    string formattedNumbers = item.Price.ToString("$0.00");


                    productListBox.Items.Add($"{item.Product_Number,-7} {formattedNumbers,-10} {item.Units_On_Hand,-7} {item.Description,-50}");
                }
            }

        }
        //Close
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
