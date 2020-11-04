using Lab.Entities;
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
        Products prod = new Products();
        Categories cat = new Categories();
        int IDp = 1;
        int IDc = 1;
        int flag;

        public FormMuestroDatos()
        {
            InitializeComponent();
            CargarDGVp();
            CargarDGVc();
        }
        #region Metodos
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
        private void ModifProd()
        {
            if (dgvp.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvp.CurrentRow.Cells[0].Value.ToString());

                prod.ProductID = id;
                prod.ProductName = dgvp.CurrentRow.Cells[1].Value.ToString();
                prod.QuantityPerUnit = dgvp.CurrentRow.Cells[4].Value.ToString();
                prod.UnitPrice = int.Parse(dgvp.CurrentRow.Cells[4].Value.ToString());
                prod.UnitsInStock = Int16.Parse(dgvp.CurrentRow.Cells[5].Value.ToString());
                prod.UnitsOnOrder = Int16.Parse(dgvp.CurrentRow.Cells[6].Value.ToString());
                prod.ReorderLevel = Int16.Parse(dgvp.CurrentRow.Cells[7].Value.ToString());

                prodlog.Update(prod);
            }
        }
        private void ModifCat()
        {
            if (dgvc.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvc.CurrentRow.Cells[0].Value.ToString());

                cat.CategoryID = id;
                cat.CategoryName = dgvc.CurrentRow.Cells[1].Value.ToString();
                cat.Description = dgvc.CurrentRow.Cells[2].Value.ToString();

                catlog.Update(cat);
            }
        }
        #endregion
        #region Buttons
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

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            flag = 1;
            FormAltaDatos fad = new FormAltaDatos(flag);            
            fad.Show();
            this.Hide();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            flag = 2;
            FormAltaDatos fad = new FormAltaDatos(flag);           
            fad.Show();
            this.Hide();
        }

        private void btnElimCat_Click(object sender, EventArgs e)
        {
            if (dgvc.SelectedRows.Count > 0)
            {
                DialogResult avisoelimina = MessageBox.Show("¿Quiere eliminar el registro seleccionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (avisoelimina == DialogResult.Yes)
                {
                    int id = int.Parse(dgvc.CurrentRow.Cells[0].Value.ToString());
                    catlog.Delete(id);
                    CargarDGVc();
                }
            }
        }

        private void btnElimP_Click(object sender, EventArgs e)
        {
            if (dgvp.SelectedRows.Count > 0)
            {
                DialogResult avisoelimina = MessageBox.Show("¿Quiere eliminar el registro seleccionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (avisoelimina == DialogResult.Yes)
                {
                    int id = int.Parse(dgvp.CurrentRow.Cells[0].Value.ToString());
                    prodlog.Delete(id);
                    CargarDGVp();
                }
            }
            
        }

        private void btnModC_Click(object sender, EventArgs e)
        {
            DialogResult avisomodif = MessageBox.Show("¿Quiere modificar el registro seleccionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (avisomodif == DialogResult.Yes)
            {
                int id = int.Parse(dgvc.CurrentRow.Cells[0].Value.ToString());
                ModifCat();
                MessageBox.Show("Registro actualizado");
                CargarDGVc();
            }
        }

        private void btnModP_Click(object sender, EventArgs e)
        {
            DialogResult avisomodif = MessageBox.Show("¿Quiere modificar el registro seleccionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (avisomodif == DialogResult.Yes)
            {

                ModifProd();
                MessageBox.Show("Registro actualizado");
                CargarDGVp();
            }
        }
        #endregion
    }
}
