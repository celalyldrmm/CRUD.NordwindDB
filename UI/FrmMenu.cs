using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDNordwindDB.UI.Forms.Category;
using CRUDNordwindDB.UI.Forms.Supplier;
using CRUDNordwindDB.UI.Forms.Product;

namespace CRUDNordwindDB.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void kategoriGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoryInsert frmCategoryInsert = new FrmCategoryInsert();
            frmCategoryInsert.ShowDialog();
        }

        private void markaGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupplierInsert frmSupplierInsert = new FrmSupplierInsert();
            frmSupplierInsert.ShowDialog();
        }

        private void ürünGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductInsert frmProductInsert = new FrmProductInsert();
            frmProductInsert.ShowDialog();
        }

        private void kATEGORİLİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorySelect frmCategorySelect = new FrmCategorySelect();
            frmCategorySelect.ShowDialog();
        }

        private void lİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductSelect frmProductSelect = new frmProductSelect();
            frmProductSelect.ShowDialog();
        }

        private void mARKALİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupplierSelect frmSupplierSelect = new FrmSupplierSelect();
            frmSupplierSelect.ShowDialog();
        }
    }
}
