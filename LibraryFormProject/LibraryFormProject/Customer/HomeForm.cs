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
   
    public partial class HomeForm : CustomerMenu
    {
        LibraryManagementDBEntities db=new LibraryManagementDBEntities();
        public HomeForm(int id): base(id)
        {
            InitializeComponent();
        }
        public HomeForm() 
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            var veri = (from o in db.orderTable join b in db.booksTable on o.bookId equals b.id where o.customerId==customerid
                        orderby o.orderDate descending select new {OrderId=o.id, Book=b.name, OrderDate=o.orderDate, DueDate=o.dueDate,
                        Status=o.status}).Take(5).ToList();
            grdRecentOr.DataSource = veri;
            var veri2=db.CustomerTable.FirstOrDefault(x=>x.id== customerid);
            lblName.Text = veri2.firstName;
            lblBooks.Text=(from p in db.physicalBookTable where !db.orderTable.Any(x=>x.physicalBookId==p.id&&x.status=="active")select
                           p.bookId).Distinct().Count().ToString();
            lblLoans.Text=db.orderTable.Count(x=>x.customerId==customerid&&x.status=="active").ToString();
            lblPendin.Text=db.orderTable.Count(x=>x.customerId==customerid&&x.status=="pending").ToString();
        }
    }
}
