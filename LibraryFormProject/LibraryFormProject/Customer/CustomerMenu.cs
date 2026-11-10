using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFormProject.Customer
{
    public partial class CustomerMenu : Form
    {
        public int customerid;
        public CustomerMenu(int id) : this()
        {
            InitializeComponent();
            customerid = id;
        }
        public CustomerMenu()
        {
            InitializeComponent();
            
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BooksForm bk=new BooksForm(customerid);
            bk.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MyOrdersForm mo=new MyOrdersForm(customerid);
            mo.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MyProfileForm mp=new MyProfileForm(customerid);
            mp.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm hf=new HomeForm(customerid);
            hf.Show();
            this.Hide();
        }
    }
}
