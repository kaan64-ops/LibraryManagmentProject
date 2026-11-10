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
    public partial class CategoryForm : AdminMenu
    {
        LibraryManagementDBEntities db = new LibraryManagementDBEntities();
        bool edit = false;
        int id;
        public void liste()
        {
           grdCate.DataSource=db.CategoryTable.Where(x=>x.categoryName.Contains(txtSearchCateMain.Text)).ToList();
        }
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCategoryDesc.Text = "";
            txtCategoryName.Text = "";
            pnlAddCat.Visible = false;
            liste();
            
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            pnlAddCat.Visible = true;
            edit = false;
        }

        private void grdCate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id =  Convert.ToInt32(grdCate.CurrentRow.Cells["id"].Value);

            btnEditcCate.Visible = true;
            btnDelCate.Visible = true;
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                CategoryTable ct = new CategoryTable();
                ct.categoryName = txtCategoryName.Text;
                ct.description = txtCategoryDesc.Text;
                db.CategoryTable.Add(ct);
                db.SaveChanges();
                pnlAddCat.Visible = false;
                liste();
            }
            else
            {
                var veri = db.CategoryTable.FirstOrDefault(x => x.id == id);
                veri.categoryName = txtCategoryName.Text;
                veri.description = txtCategoryDesc.Text;
                db.SaveChanges();
                pnlAddCat.Visible = false;
                liste();
            }
        }

        private void btnDelCate_Click(object sender, EventArgs e)
        {
            var veri = db.CategoryTable.FirstOrDefault(x => x.id == id);
            db.CategoryTable.Remove(veri);
            db.SaveChanges();
            btnDelCate.Visible = false;
            btnEditcCate.Visible = false;
            liste();
        }

        private void btnEditcCate_Click(object sender, EventArgs e)
        {
            edit = true;
            pnlAddCat.Visible = true;
            var veri = db.CategoryTable.FirstOrDefault(x => x.id == id);
            txtCategoryDesc.Text = veri.description;
            txtCategoryName.Text = veri.categoryName;

          
            
            btnDelCate.Visible = false;
            btnEditcCate.Visible = false;
        }

        private void txtSearchCateMain_TextChanged(object sender, EventArgs e)
        {
            liste();
        }

        private void txtSearchCateMain_Click(object sender, EventArgs e)
        {
            txtSearchCateMain.Text = "";
        }

        private void txtSearchCateMain_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchCateMain.Text = "";
        }
    }
}
