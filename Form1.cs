using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace IT481_Unit3
{
    public partial class Form1 : Form
    {
        private DB controller;
        private string user;
        private string password;
        private string server;
        private string database;

        
        public Form1()
        {
            InitializeComponent();
            boxServer.Text = "DESKTOP-R24ALRN";
            boxDatabase.Text = "Northwind";
            btnConnecttoDB.Click += new EventHandler(btnConnecttoDB_click);
            btnGetCusCount.Click += new EventHandler(btnGetCusCount_Click);
            btnGetOrderCount.Click += new EventHandler(btnGetOrderCount_Click);
            btnGetOrderList.Click += new EventHandler(btnGetOrderList_Click);
            btnGetEmployeeCount.Click += new EventHandler(btnGetEmployeeCount_Click);
            btnGetEmployee.Click += new EventHandler(btnGetEmployee_Click);
            btnGetCusList.Click += new EventHandler(btnGetCusList_Click_1);
        }
        private void btnConnecttoDB_click(object sender, EventArgs e)
        {
            bool isValid = true;
            user = boxUser.Text;
            password = boxPassword.Text;
            server = boxServer.Text;
            database = boxDatabase.Text;

            Regex regexUser = new Regex("^\\w+$");
            Regex regexPassword = new Regex(@"^[a-zA-Z0-9!@#] + [!@#]", RegexOptions.IgnorePatternWhitespace);

            if (user.Length == 0 || password.Length == 0 ||
                server.Length == 0 || database.Length == 0)
            {
                isValid = false;
                MessageBox.Show("You must enter user name, password, server, and database values");
            }

            else if (password.Length < 6)
            {
                isValid = false;
                MessageBox.Show("Password length must be 6 characters or more");
            }

            else if (!regexUser.IsMatch(user))
            {
                isValid = false;
                MessageBox.Show("User contains invalid characters: Alphanumeric Values Only!");
            }

            else if (!password.Any(ch => !Char.IsLetterOrDigit(ch)))
            {
                isValid = false;
                MessageBox.Show("Password must contain at least one special character");
            }

            if (isValid)
            {
                controller = new DB("Server = " + server + "\\SQLEXPRESS;" +
                                         "Database = " + database + ";" +
                                         "User Id = " + user + ";" +
                                         "Password = " + password + ";"
                                         );
                MessageBox.Show("Connection information sent");
            }
        }
        private void btnGetCusCount_Click(object sender, EventArgs e)
        {
            string count = controller.getCustomerCount();
            MessageBox.Show(count, "Customer Count");
        }
        private void btnGetOrderCount_Click(object sender, EventArgs e)
        {
            string count = controller.getOrderCount();
            MessageBox.Show(count, "Order Count");
        }
        private void btnGetOrderList_Click(object sender, EventArgs e)
        {
            string names = controller.getShipNames();
            MessageBox.Show(names, "Ship Names");
        }

        private void btnGetEmployeeCount_Click(object sender, EventArgs e)
        {
            string count = controller.getEmployeeCount();
            MessageBox.Show(count, "Employee Count");
        }

        private void btnGetEmployee_Click(object sender, EventArgs e)
        {
            string names = controller.getEmployeeName();
            MessageBox.Show(names, "Employee FirstName + LastName");
        }

        private void btnGetCusList_Click_1(object sender, EventArgs e)
        {
            string names = controller.getCompanyNames();
            MessageBox.Show(names, "Company Names");
        }

        private void Form1_load(object sender, EventArgs e)
        {

        }
    }
}
