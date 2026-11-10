using Microsoft.EntityFrameworkCore.Internal;
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
    public partial class BooksForm : CustomerMenu
    {
        int id;
        LibraryManagementDBEntities db=new LibraryManagementDBEntities();
        public BooksForm()
        {
            InitializeComponent();
        }
        public BooksForm(int id):base(id)
        {
            InitializeComponent();
        }
        public void liste()
        {
            
            int cateid = 0;
            
            string search=txtSearchBook.Text.Trim().ToLower();
            
            if (cmCate.SelectedValue is int)
            {
                cateid=Convert.ToInt32(cmCate.SelectedValue);
            }
            
            var veri2=(from b in db.booksTable join c in db.CategoryTable on b.catergoryId equals c.id join p in db.PublisherTable
                       on b.publisherId equals p.id select new {BookId=b.id,CategoryId=c.id,Book=b.name, Category=c.categoryName, Publisher=p.publisherName,
                       Language=b.language, AvailableCopies=db.physicalBookTable.Count(x=>x.bookId==b.id&&!db.orderTable.Any(o=>o.physicalBookId
                       ==x.id&&o.status=="active"))}).ToList();
            if (cateid != 0)
            {
                veri2 = veri2.Where(x => x.CategoryId == cateid).ToList();
            }
            if (search != "")
            {
                veri2=veri2.Where(x=>x.Book!=null&&x.Book.ToLower().Contains(search)).ToList();
            }
            lblTotBooks.Text = db.booksTable.Count().ToString();
            lblAvaBooks.Text= (from b in db.booksTable where db.physicalBookTable.Any(x=>x.bookId==b.id&&!db.orderTable.Any(o=>o.physicalBookId
                               ==x.id&&o.status=="active"))select(b.id)).Count().ToString();
            
            if (chAvaOnly.Checked)
            {
                veri2=veri2.Where(x=>x.AvailableCopies>0).ToList();
            }
            grdBooks.DataSource = veri2;
            grdBooks.Columns["BookId"].Visible = false;
            grdBooks.Columns["CategoryId"].Visible = false;

        }
        private void BooksForm_Load(object sender, EventArgs e)
        {
            
            cmCate.DataSource = db.CategoryTable.ToList();
            cmCate.DisplayMember = "categoryName";
            cmCate.ValueMember = "id";
            liste();
        }

        private void grdBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdBooks.CurrentRow.Cells["BookId"].Value);
            btnReq.Visible = true;
            btnShowDet.Visible = true;
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            liste();
        }

        private void chAvaOnly_CheckedChanged(object sender)
        {
            liste();
        }

        private void btnShowDet_Click(object sender, EventArgs e)
        {
            pnlDet.Visible = true;
            var veri = (from b in db.booksTable
                        join p in db.PublisherTable on b.publisherId equals p.id
                        
                        join c in db.CategoryTable on b.catergoryId
                      equals c.id where b.id==id
                        select new
                        {
                            
                            book = b.name,
                            
                            cate = c.categoryName,
                            pub = p.publisherName,
                            lan = b.language,
                            page = b.Page,
                            desc = b.decription
                        }).FirstOrDefault();
            var veri2 =(from a in db.AuthorTable join ba in db.BookAuthorTable on a.id equals ba.authorId where ba.bookId==id select 
                        a.authorName).ToList();
            txtDetBookName.Text = veri.book;
            if(veri2.Count > 0 ) txtDetAut.Text = string.Join(", ", veri2);
            else txtDetAut.Text = "No author assigned";
            txtDetCat.Text=veri.cate;
            txtDetDesc.Text= veri.desc;
            txtDetLan.Text = veri.lan;
            txtDetPage.Text= veri.page.ToString();
            txtDetPub.Text= veri.pub;
            txtDetCoNum.Text=db.physicalBookTable.Count(x=>x.bookId==id&&!db.orderTable.Any(b=>b.physicalBookId==x.id&&b.status=="active"
            )).ToString();
        }

        private void btnDetClose_Click(object sender, EventArgs e)
        {
            txtDetAut.Text = "";
            txtDetBookName.Text = "";
            txtDetCat.Text = "";
            txtDetCoNum.Text = "";
            txtDetDesc.Text = "";
            txtDetPage.Text = "";
            txtDetPub.Text = "";
            txtDetLan.Text = "";
            pnlDet.Visible=false;
            btnReq.Visible=false;
            btnShowDet.Visible=false;
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            bool avaible =db.physicalBookTable.Any(s=>s.bookId==id&&!db.orderTable.Any(a=>a.physicalBookId==s.id&&a.status=="active"));
            if (!avaible)
            {
                MessageBox.Show("This book is taken.");
                liste();
                btnReq.Visible=false;
                btnShowDet.Visible = false;
                return;
            }
            bool isReq=db.orderTable.Any(x=>x.bookId==id&&x.customerId==customerid&&(x.status=="pending"||x.status=="active"));
            if(isReq)
            {
                MessageBox.Show("You have already requested this book!");
                liste();
                btnReq.Visible = false;
                btnShowDet.Visible = false;
                return;
            }
            orderTable or=new orderTable();
            or.bookId = id;
            or.customerId = customerid;
            or.orderDate=DateTime.Now;
            or.status = "pending";
            db.orderTable.Add(or);
            db.SaveChanges();
            MessageBox.Show("You have  requested this book!");
            liste();
        }

        private void cmCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            liste();
            btnReq.Visible = false;
            btnShowDet.Visible = false;
        }
    }
}
