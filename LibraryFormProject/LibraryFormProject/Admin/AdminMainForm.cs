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
    public partial class AdminMainForm : AdminMenu
    {
        LibraryManagementDBEntities db = new LibraryManagementDBEntities();
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            lblBookCount.Text = db.booksTable.Count().ToString();
            lblCustoCont.Text = db.CustomerTable.Count().ToString();
            lblRented.Text = db.orderTable.Count(x=>x.status=="active").ToString();
            lblOverBook.Text = db.orderTable.Count(x => x.status == "active"&&x.dueDate<DateTime.Now).ToString();
            var veri =
            (from o in db.orderTable join c in db.CustomerTable on o.customerId equals c.id join b in db.booksTable on o.bookId equals b.id
             orderby o.orderDate descending, o.id descending
             select new
             {
                 OrderID = o.id,
                 Customer = c.firstName + " " + c.lastName,
                 Book = b.name,
                 OrderDate = o.orderDate,
                 DueDate = o.dueDate,
                 Status = o.status
             })
            .Take(5)
            .ToList();
            grdOrders.DataSource = veri;
        }
    }
}
