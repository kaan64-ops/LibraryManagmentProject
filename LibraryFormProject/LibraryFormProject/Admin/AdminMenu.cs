using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFormProject.Admin
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            AdminMainForm ad=new AdminMainForm();
            ad.Show();
            this.Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BookForm bf =new BookForm();
            bf.Show();
            this.Hide();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            CategoryForm ct=new CategoryForm();
            ct.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm of=new OrderForm();
            of.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm();
            cf.Show();
            this.Hide();
        }
    }
}
