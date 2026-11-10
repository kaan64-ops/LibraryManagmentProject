using LibraryFormProject.Admin;
using LibraryFormProject.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFormProject
{
    public partial class Login : Form
    {
        LibraryManagementDBEntities db = new LibraryManagementDBEntities();
        bool admin = true;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            admin = true;
            pnlLogin.Visible = false;
            btnSignIn.Visible = false;







        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassCon.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            pnlLogin.Visible = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            pnlSignIn.Visible = true;
            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            admin = false;
            pnlLogin.Visible = false;
            btnSignIn.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassCon.Text != txtPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                txtPassCon.Text = "";
            }
            else
            {
                if (admin)
                {
                    var veri = db.adminTable.FirstOrDefault(a => a.userName == txtUsername.Text &&
                 a.password == txtPassword.Text &&
                 a.email == txtEmail.Text &&
                 a.firstName == txtFirstName.Text &&
                 a.lastName == txtLastName.Text);

                    if (veri != null)
                    {
                        AdminMainForm ad=new AdminMainForm();
                        ad.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid information. Please try again.");
                    }
                }
                else
                {
                    var veri = db.CustomerTable.FirstOrDefault(a => a.username == txtUsername.Text &&
                 a.password == txtPassword.Text &&
                 a.email == txtEmail.Text &&
                 a.firstName == txtFirstName.Text &&
                 a.lastName == txtLastName.Text);

                    if (veri != null)
                    {
                        HomeForm hf = new HomeForm(veri.id);
                        hf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid information. Please try again.");
                    }
                }
            }
        }

        private void btnPnlCancel_Click(object sender, EventArgs e)
        {
            txtSignUsername.Text = "";
            txtSignPassword.Text = "";
            txtSignFirstname.Text = "";
            txtSignLastname.Text = "";
            txtSignEmail.Text = "";
            txtSignConPass.Text = "";
            pnlSignIn.Visible = false;
        }

        private void btnPnlSignIn_Click(object sender, EventArgs e)
        {
            CustomerTable signIn = new CustomerTable();
            signIn.firstName = txtSignFirstname.Text;
            signIn.lastName = txtSignLastname.Text;
            signIn.email = txtSignEmail.Text;
            signIn.username = txtSignUsername.Text;
            signIn.password = txtSignPassword.Text;
            if(txtSignConPass.Text != txtSignPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                txtSignConPass.Text = "";
            }
            db.CustomerTable.Add(signIn);
            db.SaveChanges();
            pnlSignIn.Visible = false;
            
        }
    }
}
