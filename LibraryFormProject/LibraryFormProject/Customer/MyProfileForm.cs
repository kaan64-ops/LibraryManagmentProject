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
    public partial class MyProfileForm : CustomerMenu
    {
        LibraryManagementDBEntities db = new LibraryManagementDBEntities();
        public void liste()
        {
            var veri = db.CustomerTable.FirstOrDefault(x => x.id == customerid);
            txtFirstname.Text = veri.firstName;
            txtLastname.Text = veri.lastName;
            txtEmail.Text = veri.email;
            txtUsername.Text = veri.username;
        }
        public MyProfileForm()
        {
            InitializeComponent();
        }
        public MyProfileForm(int id) : base(id)
        {
            InitializeComponent();
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            liste();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kontrol türü: " + txtFirstname.GetType().Name + "\nDeğer: " + txtFirstname.Text);
            string ad = txtFirstname.Text.Trim();
            string soy = txtLastname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            bool kulVar = db.CustomerTable.Any(x => x.id != customerid && x.username == username);
            if (kulVar)
            {
                MessageBox.Show("This username is already taken!");
                return;
            }
            bool emailvar = db.CustomerTable.Any(x => x.id != customerid && x.email == email);
            if (emailvar)
            {
                MessageBox.Show("This email is already taken!");
                return;
            }
            var veri = db.CustomerTable.FirstOrDefault(x => x.id == customerid);
            veri.email = email;
            veri.username = username;
            veri.firstName = ad;
            veri.lastName = soy;
            db.SaveChanges();

            liste();
        }

        private void btnPassUpdate_Click(object sender, EventArgs e)
        {
            string currPass = txtCurPass.Text;
            string newPass = txtNewPass.Text;
            string conPass = txtConPass.Text;
            var veri = db.CustomerTable.FirstOrDefault(x => x.id == customerid);
            if (currPass != veri.password)
            {
                MessageBox.Show("Current password is incorrect!");
                    return;
            }
            if (newPass != conPass)
            {
                MessageBox.Show("Correct the Confirming Password!");
                return;
            }
            veri.password=newPass;
            db.SaveChanges();
            txtConPass.Text = "";
            txtCurPass.Text = "";
            txtNewPass.Text = "";
        }
    }
}
