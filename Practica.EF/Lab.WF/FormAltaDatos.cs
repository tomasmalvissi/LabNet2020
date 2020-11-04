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
    public partial class FormAltaDatos : Form
    {
        ProductLogic prodlog = new ProductLogic();
        CategoriesLogic catlog = new CategoriesLogic();
        Products prod = new Products();
        Categories cat = new Categories();
        private int Flag;
        public FormAltaDatos(int flag)
        {
            InitializeComponent();

            this.Flag = flag;
            TabOpen();
        }
        private void TabOpen()
        {
            if (Flag == 1)
            {
                tabControl1.SelectedIndex = 0;
            }
            else if (Flag == 2)
            {
                tabControl1.SelectedIndex = 1;
            }
        }
        private void InstanciaDatosC()
        {
            cat.CategoryName = txtNameC.Text;
            cat.Description = txtDescC.Text;
        }
        private void InstanciaDatosP() 
        {
            prod.ProductName = txtNameP.Text;
            prod.QuantityPerUnit = txtQpUp.Text;
            prod.UnitPrice = Decimal.Parse(txtUPp.Text);
            prod.UnitsInStock = Int16.Parse(txtUiSp.Text);
            prod.UnitsOnOrder = Int16.Parse(txtUiOp.Text);
            prod.ReorderLevel = Int16.Parse(txtRLp.Text);
            if (rbNO.Checked == true)
                prod.Discontinued = true;
            else if (rbYES.Checked == true)
                prod.Discontinued = false;
        }

        private void btnCrearP_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNameP.Text) || String.IsNullOrEmpty(txtQpUp.Text) || String.IsNullOrEmpty(txtUPp.Text) ||
                String.IsNullOrEmpty(txtUiSp.Text) || String.IsNullOrEmpty(txtUiOp.Text) || String.IsNullOrEmpty(txtRLp.Text))
            {
                MessageBox.Show("Complete todos los campos para realizar esta acción");
            }
            else
            {
                InstanciaDatosP();
                prodlog.Insert(prod);
                MessageBox.Show("Datos Cargados");
                FormMuestroDatos fmd = new FormMuestroDatos();
                fmd.Show();
                this.Close();
            }
        }

        private void btnCrearC_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNameC.Text) || String.IsNullOrEmpty(txtDescC.Text))
            {
                MessageBox.Show("Complete todos los campos para realizar esta acción");
            }
            else
            {
                InstanciaDatosC();
                catlog.Insert(cat);
                MessageBox.Show("Datos Cargados");
                FormMuestroDatos fmd = new FormMuestroDatos();
                fmd.Show();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormMuestroDatos fmd = new FormMuestroDatos();
            fmd.Show();
            this.Close();
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            FormMuestroDatos fmd = new FormMuestroDatos();
            fmd.Show();
            this.Close();
        }
    }
}
