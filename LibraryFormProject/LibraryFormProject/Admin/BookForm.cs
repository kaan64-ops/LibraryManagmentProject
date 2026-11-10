using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFormProject.Admin
{
    public partial class BookForm : AdminMenu
    {
        LibraryManagementDBEntities db = new LibraryManagementDBEntities();
        int id;
        int mode;
        bool edit;
        bool bookEdit = false;
        public void autListe()
        {
            clAut.Items.Clear();
            var veri = db.AuthorTable.ToList();
            foreach (var a in veri)
            {
                clAut.Items.Add(a.authorName);
            }
        }
        public void liste()
        {
            grdBook.DataSource = db.booksTable.Where(x => x.name.Contains(txtSearchBook.Text)).ToList();
            grdAuthors.DataSource = db.AuthorTable.ToList();
            grdPub.DataSource = db.PublisherTable.ToList();
            grdCopy.DataSource = db.physicalBookTable.ToList();
            cmBookName.DataSource = db.booksTable.ToList();
            cmBookName.DisplayMember = "name";
            cmBookName.ValueMember = "id";
            cmCategory.DataSource = db.CategoryTable.ToList();
            cmCategory.DisplayMember = "categoryName";
            cmCategory.ValueMember = "id";
            cmPublisher.DataSource = db.PublisherTable.ToList();
            cmPublisher.DisplayMember = "publisherName";
            cmPublisher.ValueMember = "id";
        }

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void grdCopy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdCopy.CurrentRow.Cells["id"].Value);
            btnCopyEdit.Visible = true;
            btnCopyDel.Visible = true;
        }

        private void btnCopyEdit_Click(object sender, EventArgs e)
        {
            mode = 2;
            edit = true;
            pnlExtraSmall.Visible = true;
            cmBookName.Visible = true;
            txtNameSmall.Visible = false;
            lblExtraSmall.Visible = true;
            txtExtraSmall.Visible = true;
            lblNameSmall.Text = "Book ID";
            lblExtraSmall.Text = "Barcode";
            var veri = db.physicalBookTable.FirstOrDefault(x => x.id == id);
            txtExtraSmall.Text = veri.barcode;
        }

        private void btnBookEdit_Click(object sender, EventArgs e)
        {
            bookEdit = true;
            pnlEditDelBooks.Visible = true;
            cmBookName.Visible = false;
            var veri = db.booksTable.FirstOrDefault(x => x.id == id);
            txtBookName.Text = veri.name;
            txtDesc.Text = veri.decription;
            txtPage.Text = veri.Page.ToString();
            cmCategory.SelectedValue = veri.catergoryId;
            cmPublisher.SelectedValue = veri.publisherId;
            txtLanguage.Text = veri.language;
            autListe();
            var veri2=db.BookAuthorTable.Where(x=>x.bookId==id).Select(x=>x.authorId).ToList();
            for (int i = 0;i< clAut.Items.Count; i++)
            {
                string author = clAut.Items[i].ToString();
                var veri3=db.AuthorTable.FirstOrDefault(x=>x.authorName==author);
                if(veri3!= null&&veri2.Contains(veri3.id))
                {
                    clAut.SetItemChecked(i, true);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlEditDelBooks.Visible = false;
            txtBookName.Text = "";
            txtDesc.Text = "";
            txtLanguage.Text = "";
            txtPage.Text = "";

        }

        private void grdBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdBook.CurrentRow.Cells["id"].Value);
            btnBookEdit.Visible = true;
            btnDel.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var veri = db.booksTable.FirstOrDefault(x => x.id == id);
            db.booksTable.Remove(veri);
            db.SaveChanges();
            btnDel.Visible = false;
            btnBookEdit.Visible = false;
            liste();
        }

        private void btnAutAdd_Click(object sender, EventArgs e)
        {
            mode = 0;
            edit = false;
            pnlExtraSmall.Visible = true;
            txtNameSmall.Visible = true;
            lblNameSmall.Text = "Author Name";
            lblExtraSmall.Visible = false;
            txtExtraSmall.Visible = false;
        }

        private void btnSmallClose_Click(object sender, EventArgs e)
        {
            pnlExtraSmall.Visible = false;
            txtNameSmall.Text = "";
            txtExtraSmall.Text = "";
            cmBookName.Visible = false;
        }

        private void btnSmallSave_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                if (edit)
                {
                    var veri = db.AuthorTable.FirstOrDefault(x => x.id == id);
                    veri.authorName = txtNameSmall.Text;

                    db.SaveChanges();

                }
                else
                {
                    AuthorTable at = new AuthorTable();

                    at.authorName = txtNameSmall.Text;
                    db.AuthorTable.Add(at);
                    db.SaveChanges();

                }
            }
            else if (mode == 1)
            {
                if (edit)
                {
                    var veri = db.PublisherTable.FirstOrDefault(x => x.id == id);
                    veri.publisherName = txtNameSmall.Text;

                    db.SaveChanges();

                }
                else
                {
                    PublisherTable pt = new PublisherTable();
                    lblNameSmall.Text = "Publisher Name";
                    lblExtraSmall.Visible = false;
                    txtExtraSmall.Visible = false;
                    pt.publisherName = txtNameSmall.Text;
                    db.PublisherTable.Add(pt);
                    db.SaveChanges();
                }
            }
            else if (mode == 2)
            {

                if (edit)
                {
                    var veri = db.physicalBookTable.FirstOrDefault(x => x.id == id);



                    veri.bookId = Convert.ToInt32(cmBookName.SelectedValue);
                    veri.barcode = txtExtraSmall.Text;

                    db.SaveChanges();
                }
                else
                {
                    physicalBookTable pbt = new physicalBookTable();


                    pbt.bookId = Convert.ToInt32(cmBookName.SelectedValue);
                    pbt.barcode = txtExtraSmall.Text;

                    if (db.physicalBookTable.Any(x => x.barcode == txtExtraSmall.Text))
                    {

                        MessageBox.Show("You already have one book with this barcode!");
                        return;
                    }

                    db.physicalBookTable.Add(pbt);
                    db.SaveChanges();


                }
            }
            txtNameSmall.Visible = false;
            cmBookName.Visible = false;
            txtExtraSmall.Visible = false;
            lblExtraSmall.Visible = false;
            lblNameSmall.Visible = false;
            liste();
            pnlExtraSmall.Visible = false;
            btnAutDel.Visible = false;
            btnAutEdit.Visible = false;
            btnPubDel.Visible = false;
            btnPubEdit.Visible = false;
            btnCopyDel.Visible = false;
            btnCopyEdit.Visible = false;
            txtExtraSmall.Text = "";
        }

        private void btnAutEdit_Click(object sender, EventArgs e)
        {
            mode = 0;
            edit = true;
            pnlExtraSmall.Visible = true;
            lblNameSmall.Text = "Author Name";
            lblExtraSmall.Visible = false;
            txtExtraSmall.Visible = false;
            var veri = db.AuthorTable.FirstOrDefault(x => x.id == id);
            txtNameSmall.Text = veri.authorName;
        }

        private void grdCopy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            bookEdit = false;
            txtBookName.Text = "";
            txtDesc.Text = "";
            txtLanguage.Text = "";
            txtPage.Text = "";
            pnlEditDelBooks.Visible = true;
            autListe();
        }

        private void btnBookSave_Click(object sender, EventArgs e)
        {
            if (clAut.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one author!");
                return;
            }
            List <int> yazarlar= new List<int>();
            foreach (string a in clAut.CheckedItems)
            {
                string yazAd=a.ToString();
                var yazar = db.AuthorTable.FirstOrDefault(x => x.authorName == yazAd);
                if(yazar != null)
                {
                    yazarlar.Add(yazar.id);
                }
            }
            if (bookEdit)
            {
                var veri = db.booksTable.FirstOrDefault(x => x.id == id);
                
                veri.name = txtBookName.Text;
                veri.decription = txtDesc.Text;
                veri.language = txtLanguage.Text;
                veri.Page = Convert.ToInt32(txtPage.Text);
                veri.catergoryId = Convert.ToInt32(cmCategory.SelectedValue);
                veri.publisherId = Convert.ToInt32(cmPublisher.SelectedValue);
                
                var eskiYazar =db.BookAuthorTable.Where(x=>x.bookId == id).ToList();
                db.BookAuthorTable.RemoveRange(eskiYazar);
                foreach(int yazId in yazarlar)
                {
                    BookAuthorTable ba=new BookAuthorTable();
                    ba.bookId = id;
                    ba.authorId=yazId;
                    db.BookAuthorTable.Add(ba);
                }
                pnlEditDelBooks.Visible = false;
                db.SaveChanges();
                liste();
            }
            else
            {
                booksTable bt = new booksTable();
                bt.name = txtBookName.Text;
                bt.decription = txtDesc.Text;
                bt.language = txtLanguage.Text;
                bt.Page = Convert.ToInt32(txtPage.Text);
                bt.catergoryId = Convert.ToInt32(cmCategory.SelectedValue);
                bt.publisherId = Convert.ToInt32(cmPublisher.SelectedValue);
                db.booksTable.Add(bt);
                foreach(int yazId in yazarlar)
                {
                    BookAuthorTable ba=new BookAuthorTable();
                    ba.bookId = id;
                    ba.authorId = yazId;
                    db.BookAuthorTable.Add(ba);
                }
                db.SaveChanges();

                pnlEditDelBooks.Visible = false;
                liste();
            }
            btnBookEdit.Visible = false;
            btnDel.Visible = false;
        }

        private void btnAutDel_Click(object sender, EventArgs e)
        {
            var veri = db.AuthorTable.FirstOrDefault(x => x.id == id);
            db.AuthorTable.Remove(veri);
            db.SaveChanges();
            btnAutDel.Visible = false;
            btnAutEdit.Visible = false;
            liste();
        }

        private void btnPubAdd_Click(object sender, EventArgs e)
        {
            mode = 1;
            edit = false;
            pnlExtraSmall.Visible = true;
            txtNameSmall.Visible = true;
            lblNameSmall.Text = "Publisher Name";
            lblExtraSmall.Visible = false;
            txtExtraSmall.Visible = false;
        }

        private void btnPubEdit_Click(object sender, EventArgs e)
        {
            mode = 1;
            edit = true;
            pnlExtraSmall.Visible = true;
            lblNameSmall.Text = "Publisher Name";
            lblExtraSmall.Visible = false;
            lblNameSmall.Visible = true;
            txtNameSmall.Visible = true;
            txtExtraSmall.Visible = false;
            var veri = db.PublisherTable.FirstOrDefault(x => x.id == id);
            txtNameSmall.Text = veri.publisherName;
        }

        private void btnPubDel_Click(object sender, EventArgs e)
        {
            var veri = db.PublisherTable.FirstOrDefault(x => x.id == id);
            db.PublisherTable.Remove(veri);
            btnPubDel.Visible = false;
            btnPubEdit.Visible = false;
            db.SaveChanges();
            liste();
        }

        private void btnCopyAdd_Click(object sender, EventArgs e)
        {
            mode = 2;
            edit = false;
            pnlExtraSmall.Visible = true;
            cmBookName.Visible = true;
            lblNameSmall.Visible = true;
            txtNameSmall.Visible = false;
            lblExtraSmall.Visible = true;
            txtExtraSmall.Visible = true;
            lblNameSmall.Text = "Book ID";
            lblExtraSmall.Text = "Barcode";

        }

        private void btnCopyDel_Click(object sender, EventArgs e)
        {
            var veri = db.physicalBookTable.FirstOrDefault(x => x.id == id);
            db.physicalBookTable.Remove(veri);
            btnCopyDel.Visible = false;
            btnCopyEdit.Visible = false;
            db.SaveChanges();
            liste();
        }

        private void grdBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdAuthors.CurrentRow.Cells["id"].Value);
            btnAutDel.Visible = true;
            btnAutEdit.Visible = true;

        }

        private void grdPub_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdPub.CurrentRow.Cells["id"].Value);
            btnPubDel.Visible = true;
            btnPubEdit.Visible = true;
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            grdBook.DataSource = db.booksTable.Where(x => x.name.Contains(txtSearchBook.Text)).ToList();
            grdAuthors.DataSource = db.AuthorTable.Where(x => x.authorName.Contains(txtSearchBook.Text)).ToList();
            grdPub.DataSource = db.PublisherTable.Where(x => x.publisherName.Contains(txtSearchBook.Text)).ToList();
            grdCopy.DataSource = db.physicalBookTable.Where(x => x.barcode.Contains(txtSearchBook.Text)).ToList();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchBook.Text = "";
        }
    }
}
