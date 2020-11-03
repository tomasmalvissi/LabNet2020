using Lab.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.WF
{
    public partial class FormMuestroDatos : Form
    {
        ProductLogic prodlog = new ProductLogic();
        CategoriesLogic catlog = new CategoriesLogic();
        int IDp = 1;
        int IDc = 1;
        public FormMuestroDatos()
        {
            InitializeComponent();
            CargarDGVp();
            CargarDGVc();
        }
        private void CargarDGVp() 
        {
            dgvp.Rows.Clear();
            var productos = prodlog.GetAll();
            foreach (var item in productos)
            {
                dgvp.Rows.Add(item.ProductID, item.ProductName, item.SupplierID, item.CategoryID, 
                              item.QuantityPerUnit, item.UnitPrice, item.UnitsInStock, item.UnitsOnOrder, 
                              item.ReorderLevel, item.Discontinued);
            }
        }
        private void CargarDGVc() 
        {
            dgvc.Rows.Clear();
            var categorias = catlog.GetAll();
            foreach (var item in categorias)
            {
                dgvc.Rows.Add(item.CategoryID, item.CategoryName, item.Description, item.Picture);
            }
                
        }
        private void DGVpID() 
        {
            dgvp.Rows.Clear();
            var prod = prodlog.GetOne(IDp);
            foreach (DataGridViewRow dr in dgvp.Rows)
            {
                dr.Cells[0].Value = prod.ProductID;
                dr.Cells[1].Value = prod.ProductName;
                dr.Cells[2].Value = prod.SupplierID;
                dr.Cells[3].Value = prod.CategoryID;
                dr.Cells[4].Value = prod.QuantityPerUnit;
                dr.Cells[5].Value = prod.UnitPrice;
                dr.Cells[6].Value = prod.UnitsInStock;
                dr.Cells[7].Value = prod.UnitsOnOrder;
                dr.Cells[8].Value = prod.ReorderLevel;
                dr.Cells[9].Value = prod.Discontinued;
            }
        }
        private void DGVcID()
        {
            dgvc.Rows.Clear();
            var cat = catlog.GetOne(IDc);
            foreach (DataGridViewRow dr in dgvc.Rows)
            {
                dr.Cells[0].Value = cat.CategoryID;
                dr.Cells[1].Value = cat.CategoryName;
                dr.Cells[2].Value = cat.Description;
                dr.Cells[3].Value = cat.Picture;
            }
        }
        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            IDp = int.Parse(txtIDProd.Text);
            DGVpID();
        }

        private void btnBuscarCat_Click(object sender, EventArgs e)
        {
            IDc = int.Parse(txtIDCat.Text);
            DGVcID();
        }
    }
}
