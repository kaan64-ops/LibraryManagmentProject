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
    public partial class CustomerForm : AdminMenu
    {
        int id;
        LibraryManagementDBEntities db = new LibraryManagementDBEntities();
        bool edit=false;
        public void liste()
        {
            grdCustomer.DataSource = db.CustomerTable.ToList();
        }
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnPnlCancel_Click(object sender, EventArgs e)
        {
            pnlCustomerEdit.Visible = false;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            pnlCustomerEdit.Visible = true;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            var veri =db.CustomerTable.FirstOrDefault(x => x.id== id);
            pnlCustomerEdit.Visible = true;
            txtSignConPass.Text = "";
            txtSignEmail.Text = veri.email;
            txtSignFirstname.Text = veri.firstName;
            txtSignLastname.Text = veri.lastName;
            txtSignPassword.Text = veri.password;
            txtSignUsername.Text = veri.username;
        }

        private void btnCusHis_Click(object sender, EventArgs e)
        {
            pnlCustomerHis.Visible = true;
            var veri =db.CustomerTable.FirstOrDefault( x => x.id== id);
            lblCustomerName.Text = veri.firstName + " " + veri.firstName;
            lblCustomerId.Text =veri.id.ToString();
            var veri2=(from o in db.orderTable join b in db.booksTable on o.bookId equals b.id where o.customerId==id orderby o.orderDate descending 
                       select new {orderId=o.id, book=b.name, orderDate=o.orderDate, dueDate=o.dueDate, returnDate=o.returnDate, status=o.status}).ToList();
            grdCusHis.DataSource = veri2;
            lblActiveLoan.Text=veri2.Count(x=>x.status=="active").ToString();
            lblReturned.Text=veri2.Count(x=> x.status=="returned").ToString();
            lblTotalOrder.Text=veri2.Count.ToString();
        }

        private void btnHisPnlExit_Click(object sender, EventArgs e)
        {
            pnlCustomerHis.Visible = false;
        }

        private void grdCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id=Convert.ToInt32(grdCustomer.CurrentRow.Cells["id"].Value);
            btnDelCustomer.Visible = true;
            btnEditCustomer.Visible = true;
            btnCusHis.Visible = true;
        }

        private void btnPnlSignIn_Click(object sender, EventArgs e)
        {
            if (!edit)
            {

                if (txtSignPassword.Text != txtSignConPass.Text)
                {
                    MessageBox.Show("Please write the password correctly!");
                    txtSignConPass.Text = "";

                }
                else
                {
                    CustomerTable veri = new CustomerTable();
                    veri.email = txtSignEmail.Text;
                    veri.username = txtSignUsername.Text;
                    veri.firstName = txtSignFirstname.Text;
                    veri.lastName = txtSignLastname.Text;
                    veri.password = txtSignPassword.Text;
                    db.CustomerTable.Add(veri);
                    db.SaveChanges();
                    liste();
                    pnlCustomerEdit.Visible = false;
                }
            }
            else
            {
                if (txtSignPassword.Text != txtSignConPass.Text)
                {
                    MessageBox.Show("Please write the password correctly!");
                    txtSignConPass.Text = "";

                }
                else
                {
                    var veri= db.CustomerTable.FirstOrDefault( x => x.id == id);
                    veri.email = txtSignEmail.Text;
                    veri.username = txtSignUsername.Text;
                    veri.firstName = txtSignFirstname.Text;
                    veri.lastName = txtSignLastname.Text;
                    veri.password = txtSignPassword.Text;
                    db.SaveChanges() ;
                    liste(); 
                    pnlCustomerEdit.Visible = false;
                    btnCusHis.Visible = false;
                    btnDelCustomer.Visible = false;
                    btnEditCustomer.Visible = false;
                }
            }
        }

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            var veri = db.CustomerTable.FirstOrDefault(x => x.id == id);
            db.CustomerTable.Remove(veri);
            db.SaveChanges();
            liste(); 
            pnlCustomerEdit.Visible = false;
            btnCusHis.Visible = false;
            btnDelCustomer.Visible = false;
            btnEditCustomer.Visible = false;
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            var veri=db.CustomerTable.Where(x=>x.id == id&&x.firstName.Contains(txtSearchCustomer.Text.ToLower())||x.lastName
            .Contains(txtSearchCustomer.Text.ToLower())).ToList();
            grdCustomer.DataSource = veri;
            if (txtSearchCustomer.Text == "")
            {
                liste();
            }
        }
    }
}
