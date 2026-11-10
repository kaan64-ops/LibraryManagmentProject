using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFormProject.Admin
{
    public partial class OrderForm : AdminMenu
    {
        LibraryManagementDBEntities db = new LibraryManagementDBEntities();
        int id;
        const decimal gunlukKira = 2;
        const decimal gunlukCeza = 5;

        public void liste()
        {
            var veri = (from o in db.orderTable join c in db.CustomerTable on o.customerId equals c.id join b in db.booksTable on o.bookId equals b.id
                        orderby o.orderDate descending, o.id descending select new{orderId = o.id, customer = c.firstName + " " + c.lastName,
                            book = b.name, orderDate = o.orderDate, dueDate = o.dueDate, returnDate=o.returnDate, status = o.status}).ToList();
            grdPending.DataSource = veri.Where(x => x.status == "pending").OrderByDescending(x=>x.orderDate).ToList();
            grdActive.DataSource = veri.Where(x => x.status == "active").OrderByDescending(x => x.orderDate).ToList();
            grdRet.DataSource=veri.Where(x => x.status == "returned").OrderByDescending(x => x.returnDate).ToList();
            grdAllOrder.DataSource = veri.OrderByDescending(x => x.orderDate).ToList();
        }
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnPenDet_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;
            var veri = db.orderTable.FirstOrDefault(x => x.id == Convert.ToInt32(grdPending.CurrentRow.Cells["orderId"].Value));
            txtOrderId.Text = veri.id.ToString();
            var veri2 = db.booksTable.FirstOrDefault(x => x.id == veri.bookId);
            txtBook.Text = veri2.name;
            var veri3 = db.CustomerTable.FirstOrDefault(x => x.id == veri.customerId);
            txtCustomer.Text = veri3.firstName + " " + veri3.lastName;
            var veri4 = db.physicalBookTable.FirstOrDefault(x => x.id == veri.physicalBookId);
            txtPhysicalCode.Text = veri4.barcode;
            txtOrderDate.Text = veri.orderDate.ToString();
            txtDueDate.Text = veri.dueDate.ToString();
            txtArrivalDate.Text = veri.arrivalDate.ToString();
            txtRetDate.Text = veri.returnDate.ToString();
        }

        private void btnActiveDet_Click(object sender, EventArgs e)
        {
            int orderid = Convert.ToInt32(grdActive.CurrentRow.Cells["orderId"].Value);
            pnlDetails.Visible = true;
            var veri = db.orderTable.FirstOrDefault(x => x.id == orderid);
            txtOrderId.Text = veri.id.ToString();
            var veri2 = db.booksTable.FirstOrDefault(x=> x.id == veri.bookId);
            txtBook.Text = veri2.name;
            var veri3 = db.CustomerTable.FirstOrDefault(x => x.id == veri.customerId);
            txtCustomer.Text = veri3.firstName + " " + veri3.lastName;
            var veri4 = db.physicalBookTable.FirstOrDefault(x => x.id == veri.physicalBookId);
            txtPhysicalCode.Text = veri4.barcode;
            txtOrderDate.Text = veri.orderDate.ToString();
            txtDueDate.Text = veri.dueDate.ToString();
            txtArrivalDate.Text = veri.arrivalDate.ToString();
            txtRetDate.Text = veri.returnDate.ToString();
        }

        private void btnReturnDet_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;
            int orderid = Convert.ToInt32(grdRet.CurrentRow.Cells["orderId"].Value);
            var veri = db.orderTable.FirstOrDefault(x => x.id == orderid);
            txtOrderId.Text = veri.id.ToString();
            var veri2 = db.booksTable.FirstOrDefault(x => x.id == veri.bookId);
            txtBook.Text = veri2.name;
            var veri3 = db.CustomerTable.FirstOrDefault(x => x.id == veri.customerId);
            txtCustomer.Text = veri3.firstName + " " + veri3.lastName;
            var veri4 = db.physicalBookTable.FirstOrDefault(x => x.id == veri.physicalBookId);
            txtPhysicalCode.Text = veri4.barcode;
            txtOrderDate.Text = veri.orderDate.ToString();
            txtDueDate.Text = veri.dueDate.ToString();
            txtArrivalDate.Text = veri.arrivalDate.ToString();
            txtRetDate.Text = veri.returnDate.ToString();
        }

        private void btnAllDetails_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;
            var veri = db.orderTable.FirstOrDefault(x => x.id == Convert.ToInt32(grdAllOrder.CurrentRow.Cells["orderId"].Value));
            txtOrderId.Text = veri.id.ToString();
            var veri2 = db.booksTable.FirstOrDefault(x => x.id == veri.bookId);
            txtBook.Text = veri2.name;
            var veri3 = db.CustomerTable.FirstOrDefault(x => x.id == veri.customerId);
            txtCustomer.Text = veri3.firstName + " " + veri3.lastName;
            var veri4 = db.physicalBookTable.FirstOrDefault(x => x.id == veri.physicalBookId);
            txtPhysicalCode.Text = veri4.barcode;
            txtOrderDate.Text = veri.orderDate.ToString();
            txtDueDate.Text = veri.dueDate.ToString();
            txtArrivalDate.Text = veri.arrivalDate.ToString();
            txtRetDate.Text = veri.returnDate.ToString();
        }

        private void btnPnlClose_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
            txtRetDate.Text = "";
            txtArrivalDate.Text = "";
            txtBook.Text = "";
            txtBarcode.Text = "";
            txtCustomer.Text = "";
            txtDueDate.Text = "";
            txtOrderDate.Text = "";
            txtOrderId.Text = "";
            btnAllDetails.Visible = false;
            btnAppr.Visible = false;
            btnReject.Visible = false;
            btnPenDet.Visible = false;
            btnReturn.Visible = false;
            btnEditLoan.Visible = false;
            btnActiveDet.Visible = false;
            btnReturnDet.Visible = false;
        }

        private void cbActive_CheckedChanged(object sender)
        {
            if (cbActive.Checked) 
            {
                var veri = (from o in db.orderTable join c in db.CustomerTable on o.customerId equals c.id join b in db.booksTable on o.bookId equals b.id
                            where o.status == "active"&&o.dueDate < DateTime.Now orderby o.orderDate descending select new{orderId = o.id,
                                customer = c.firstName + " " + c.lastName, book = b.name, orderDate = o.orderDate, dueDate = o.dueDate,
                                returnDate = o.returnDate, status = o.status}).ToList();
                grdActive.DataSource = veri;
            }
            else
            {
                liste();
            }
        }

        private void cbAllOrders_CheckedChanged(object sender)
        {
            if (cbAllOrders.Checked)
            {
                var veri = (from o in db.orderTable join c in db.CustomerTable on o.customerId equals c.id join b in db.booksTable on o.bookId equals b.id
                            where o.status == "active" && o.dueDate < DateTime.Now orderby o.orderDate descending select new
                            {orderId = o.id, customer = c.firstName + " " + c.lastName, book = b.name, orderDate = o.orderDate,
                                dueDate = o.dueDate, returnDate = o.returnDate, status = o.status}).ToList();
                grdAllOrder.DataSource = veri;

            }
            else
            {
                liste();
            }
        }

        private void grdActive_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id=Convert.ToInt32(grdActive.CurrentRow.Cells["orderId"].Value);
            btnReturn.Visible = false;
            btnEditLoan.Visible = true;
            btnActiveDet.Visible = true;
        }

        private void grdPending_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdPending.CurrentRow.Cells["orderId"].Value);
            btnAppr.Visible = true;
            btnReject.Visible = true;
            btnPenDet.Visible = true;
        }

        private void btnAppr_Click(object sender, EventArgs e)
        {
            var veri = db.orderTable.FirstOrDefault(x => x.id == id);
            var borrowed = db.orderTable.Where(x => x.status == "active").Select(x => x.physicalBookId).ToList();
            var aval = db.physicalBookTable.Where(x => x.bookId == veri.bookId && !borrowed.Contains(x.id)).FirstOrDefault();
            if (aval != null)
            {
                veri.physicalBookId = aval.id;
                veri.status = "active";
                veri.arrivalDate = DateTime.Now;
                veri.dueDate = DateTime.Now.AddDays(14); 
                int day =(veri.dueDate.Value.Date-veri.arrivalDate.Value.Date).Days;
                veri.profit = day * gunlukKira;
                db.SaveChanges();
                MessageBox.Show("Order approved successfully.");
                liste();

            }
            else
            {
                MessageBox.Show("No available physical book for this order.");
            }
            liste();
            btnAppr.Visible = false;
            btnReject.Visible = false;
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            var veri = db.orderTable.FirstOrDefault(x => x.id == id);
            veri.status = "rejected";
            btnAppr.Visible = false;
            btnReject.Visible = false;
            db.SaveChanges();
            liste();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var veri=db.orderTable.FirstOrDefault(x => x.id == id);
            if(veri.status != "active")
            {
                MessageBox.Show("Only active orders can be returned.");
                return;
            }
            veri.returnDate = DateTime.Now;
            int late= (veri.returnDate.Value.Date -veri.dueDate.Value.Date).Days;
            if (late > 0) {
                veri.profit = veri.profit.GetValueOrDefault() + late * gunlukCeza;
            }
            veri.status = "returned";
            btnReturn.Visible = false;
            btnEditLoan.Visible = false;
            db.SaveChanges();
            liste();
        }

        private void btnEditLoan_Click(object sender, EventArgs e)
        {
            pnlActiveEdit.Visible = true;
            var veri=db.orderTable.FirstOrDefault(x => x.id == id);
            txtActiveDueDate.Text = veri.dueDate.ToString();
        }

        private void btnActivePnlCancel_Click(object sender, EventArgs e)
        {
            txtActiveDueDate.Text = "";
            pnlActiveEdit.Visible = false;
            btnReturn.Visible = false;
            btnEditLoan.Visible = false;
            btnActiveDet.Visible = false;
        }

        private void btnActiveLblSave_Click(object sender, EventArgs e)
        {
            var veri= db.orderTable.FirstOrDefault(x => x.id == id);
            veri.dueDate = Convert.ToDateTime(txtActiveDueDate.Text);
            int day = (veri.dueDate.Value.Date -veri.arrivalDate.Value.Date).Days;
            veri.profit = day * gunlukKira;
            db.SaveChanges();
            liste();
            pnlActiveEdit.Visible = false;
            btnReturn.Visible = false;
            btnEditLoan.Visible = false;
            btnActiveDet.Visible = false;
        }

        private void grdRet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdRet.CurrentRow.Cells["orderId"].Value);
            btnReturnDet.Visible = true;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            pnlNewOrder.Visible = true;
            cmAllOrdersBook.DataSource=db.booksTable.ToList();
            cmAllOrdersBook.DisplayMember = "name";
            cmAllOrdersBook.ValueMember = "id";
            cmAllOrdersCustomer.DataSource = db.CustomerTable.Select(x => new { id = x.id, fullname = x.firstName + " " + x.lastName }).ToList();
            cmAllOrdersCustomer.DisplayMember = "fullname";
            cmAllOrdersCustomer.ValueMember="id";
            dtAllOrdersDueDate.Value=DateTime.Now.AddDays(14);
        }

        private void btnAllOrdersPnlAdd_Click(object sender, EventArgs e)
        {
            if (dtAllOrdersDueDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Due date must be in the future.");
                pnlNewOrder.Visible=false;
                return;
            }
            else
            {
                int customerid=Convert.ToInt32(cmAllOrdersCustomer.SelectedValue);
                int bookid=Convert.ToInt32(cmAllOrdersBook.SelectedValue);
                var borrow=db.orderTable.Where(x=>x.status=="active").Select(x=>x.physicalBookId).ToList();
                var available = db.physicalBookTable.Where(x => x.bookId == bookid && !borrow.Contains(x.id)).FirstOrDefault();
                if(available!=null)
                {
                    orderTable or=new orderTable();
                    or.customerId = customerid;
                    or.bookId = bookid;
                    or.physicalBookId = available.id;
                    or.orderDate = DateTime.Now;
                    or.arrivalDate= DateTime.Now;
                    or.dueDate = dtAllOrdersDueDate.Value.Date;
                    or.status = "active";
                    int day = (or.dueDate.Value.Date -or.arrivalDate.Value.Date).Days;

                    or.profit = day * gunlukKira;
                    db.orderTable.Add(or);
                    db.SaveChanges();

                }
                else
                {
                    MessageBox.Show("No available copy of this book.");
                    return;
                }
            }
            pnlNewOrder.Visible = false;
            liste();
        }

        private void btnAllOrderPnlCancel_Click(object sender, EventArgs e)
        {
            pnlNewOrder.Visible = false;
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            var veri = (from o in db.orderTable join c in db.CustomerTable on o.customerId equals c.id join b in db.booksTable on o.bookId equals b.id
                        select new{orderId = o.id, customer = c.firstName + " " + c.lastName, book = b.name, orderDate = o.orderDate,
                            dueDate = o.dueDate, returnDate = o.returnDate, status = o.status}).ToList();
            grdPending.DataSource = veri.Where(x=>x.status=="pending"&&x.book.ToLower().Contains(txtSearchBook.Text.ToLower())).ToList();
            if (cbActive.Checked)
            {
                grdActive.DataSource = veri.Where(x => x.status == "active" && x.dueDate < DateTime.Now && x.book.ToLower().Contains(txtSearchBook.Text.ToLower())).ToList();
            }
            else
            {
                grdActive.DataSource = veri.Where(x => x.status == "active" && x.book.ToLower().Contains(txtSearchBook.Text.ToLower())).ToList();
            }
            grdRet.DataSource = veri.Where(x => x.status == "returned" && x.book.ToLower().Contains(txtSearchBook.Text.ToLower())).ToList();
            if (cbAllOrders.Checked)
            {
                grdAllOrder.DataSource = veri.Where(x => x.book.ToLower().Contains(txtSearchBook.Text.ToLower()) && x.status == "active" && x.dueDate < DateTime.Now).ToList();

            }
            else
            {
                grdAllOrder.DataSource = veri.Where(x => x.book.ToLower().Contains(txtSearchBook.Text.ToLower())).ToList();
            }
            if (txtSearchBook.Text == "")
            {
                liste();
            }
        }

        private void grdAllOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdAllOrder.CurrentRow.Cells["id"].Value);
            btnAllDetails.Visible = true;
        }
    }
}
