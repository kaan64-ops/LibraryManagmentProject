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
    public partial class MyOrdersForm : CustomerMenu
    {
        LibraryManagementDBEntities db=new LibraryManagementDBEntities();
        int id;
        public void liste()
        {
            var veri=(from o in db.orderTable join b in db.booksTable on o.bookId equals b.id where o.customerId==customerid orderby 
                      o.orderDate descending select new {orderId=o.id, Book=b.name, OrderDate=o.orderDate, DueDate=o.dueDate, ReturnDate=
                      o.returnDate, Status=o.status, TotalFee = o.profit}).ToList();
            
            grdAllOrder.DataSource = veri;
            grdPending.DataSource= veri.Where(z=>z.Status=="pending").ToList();
            dataGridView2.DataSource = veri.Where(x=>x.Status=="active").ToList();
            grdHistory.DataSource=veri.Where(x=>x.Status!="active"&&x.Status!="pending").ToList();
            lblPend.Text=veri.Count(x=>x.Status=="pending").ToString();
            lblActive.Text=veri.Count( x=>x.Status=="active").ToString();
            lblRet.Text=veri.Count(x=> x.Status=="returned").ToString();
        }
        public void buttonListe()
        {
            var veri = (from o in db.orderTable
                        join b in db.booksTable on o.bookId equals b.id
                        where o.id == id && o.customerId == customerid
                        select new { o.id, book = b.name, o.status, o.orderDate, o.dueDate, o.returnDate, o.arrivalDate, o.profit }).FirstOrDefault();
            lblDetOrderid.Text = veri.id.ToString();
            lblDetBook.Text = veri.book;
            lblDetStatus.Text = veri.status;
            lblDetOrderDate.Text = veri.orderDate.ToString();
            if (veri.arrivalDate.HasValue) lblDetArrDate.Text = veri.arrivalDate.Value.ToString();
            else lblDetArrDate.Text = "-";
            if (veri.dueDate.HasValue) lblDetDueDate.Text = veri.dueDate.Value.ToString();
            else lblDetDueDate.Text = "-";
            if (veri.returnDate.HasValue) lblDetRetDate.Text = veri.returnDate.Value.ToString();
            else lblDetRetDate.Text = "-";
            if (veri.profit.HasValue) lblDetTotalFee.Text = veri.profit.Value.ToString() + " TL";
            else lblDetTotalFee.Text = "-";
            pnlOrderDet.Visible = true;
        }
        public MyOrdersForm()
        {
            InitializeComponent();
        }
        public MyOrdersForm(int id):base(id)
        {
            InitializeComponent();
        }

        private void MyOrdersForm_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            var veri = db.orderTable.FirstOrDefault(x => x.id == id && x.customerId == customerid && x.status == "active");
            veri.returnDate = DateTime.Now;
            int late= (veri.returnDate.Value.Date -veri.dueDate.Value.Date).Days;
            if (late > 0)
            {
                veri.profit = veri.profit.GetValueOrDefault() + late * 5;
            }
            veri.status = "returned";
            db.SaveChanges();
            liste();
            btnReturnBook.Visible = false;
            btnDetActive.Visible = false;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //active datagrid
            id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["orderId"].Value);
            btnReturnBook.Visible = true;
            btnDetActive.Visible = true;
        }

        private void btnDetAllOrder_Click(object sender, EventArgs e)
        {
            buttonListe();
        }

        private void grdAllOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdAllOrder.CurrentRow.Cells["orderId"].Value);
            btnDetAllOrder.Visible = true;
        }

        private void btnDetClose_Click(object sender, EventArgs e)
        {
            btnDetAllOrder.Visible=false;
            btnDetActive.Visible=false;
            btnDetHistory.Visible=false;
            btnDetPending.Visible=false;
            btnCancelReq.Visible=false;
            btnReturnBook.Visible=false;
            pnlOrderDet.Visible=false;
        }

        private void grdPending_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdPending.CurrentRow.Cells["orderId"].Value);
            btnDetPending.Visible = true;
            btnCancelReq.Visible=true;
        }

        private void grdHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id= Convert.ToInt32(grdHistory.CurrentRow.Cells["orderId"].Value);
            btnDetHistory.Visible = true;
        }

        private void btnDetPending_Click(object sender, EventArgs e)
        {
            buttonListe();
        }

        private void btnDetActive_Click(object sender, EventArgs e)
        {
            buttonListe();
        }

        private void btnDetHistory_Click(object sender, EventArgs e)
        {
            buttonListe();
        }

        private void btnCancelReq_Click(object sender, EventArgs e)
        {
            var veri =db.orderTable.FirstOrDefault(x=>x.id==id&&x.customerId==customerid&&x.status=="pending");
            veri.status = "cancelled";
            db.SaveChanges();
            liste();
            btnCancelReq.Visible = false;
            btnDetPending.Visible=false;
        }

        private void txtSearchAllOrder_TextChanged(object sender, EventArgs e)
        {
            var veri = (from o in db.orderTable
                        join b in db.booksTable on o.bookId equals b.id
                        where o.customerId == customerid
                        orderby
                      o.orderDate descending
                        select new
                        {
                            orderId = o.id,
                            Book = b.name,
                            OrderDate = o.orderDate,
                            DueDate = o.dueDate,
                            ReturnDate =
                      o.returnDate,
                            Status = o.status,
                            TotalFee = o.profit
                        }).ToList();
            string search = txtSearchAllOrder.Text.Trim().ToLower();
            if (search != null)
            {
                veri = veri.Where(x => x.Book.ToLower().Contains(search)).ToList();
                grdAllOrder.DataSource = veri;
            }else liste();
        }

        private void txtSearchPend_TextChanged(object sender, EventArgs e)
        {
            var veri = (from o in db.orderTable
                        join b in db.booksTable on o.bookId equals b.id
                        where o.customerId == customerid
                        orderby
                      o.orderDate descending
                        select new
                        {
                            orderId = o.id,
                            Book = b.name,
                            OrderDate = o.orderDate,
                            DueDate = o.dueDate,
                            ReturnDate =
                      o.returnDate,
                            Status = o.status,
                            TotalFee = o.profit
                        }).ToList();
            string search = txtSearchPend.Text.Trim().ToLower();
            if (search != null)
            {
                veri = veri.Where(x => x.Book.ToLower().Contains(search)).ToList();
                grdPending.DataSource = veri;
            }else liste();
        }

        private void txtsearchActive_TextChanged(object sender, EventArgs e)
        {
            var veri = (from o in db.orderTable
                        join b in db.booksTable on o.bookId equals b.id
                        where o.customerId == customerid
                        orderby
                      o.orderDate descending
                        select new
                        {
                            orderId = o.id,
                            Book = b.name,
                            OrderDate = o.orderDate,
                            DueDate = o.dueDate,
                            ReturnDate =
                      o.returnDate,
                            Status = o.status,
                            TotalFee = o.profit
                        }).ToList();
            string search = txtsearchActive.Text.Trim().ToLower();
            if (search != null)
            {
                veri = veri.Where(x => x.Book.ToLower().Contains(search)).ToList();
                dataGridView2.DataSource = veri;

            }
            else liste();
        }

        private void txtSearchHist_TextChanged(object sender, EventArgs e)
        {
            var veri = (from o in db.orderTable
                        join b in db.booksTable on o.bookId equals b.id
                        where o.customerId == customerid
                        orderby
                      o.orderDate descending
                        select new
                        {
                            orderId = o.id,
                            Book = b.name,
                            OrderDate = o.orderDate,
                            DueDate = o.dueDate,
                            ReturnDate =
                      o.returnDate,
                            Status = o.status,
                            TotalFee = o.profit
                        }).ToList();
            string search = txtSearchHist.Text.Trim().ToLower();
            if (search != null)
            {
                veri = veri.Where(x => x.Book.ToLower().Contains(search)).ToList();
                grdHistory.DataSource = veri;
            }else liste();
        }
    }
}
