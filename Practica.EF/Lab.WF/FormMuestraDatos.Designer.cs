namespace Lab.WF
{
    partial class FormMuestroDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvp = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitInOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discontinued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCat = new System.Windows.Forms.Button();
            this.txtIDCat = new System.Windows.Forms.TextBox();
            this.dgvc = new System.Windows.Forms.DataGridView();
            this.CategoryyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnElimP = new System.Windows.Forms.Button();
            this.btnElimCat = new System.Windows.Forms.Button();
            this.btnModP = new System.Windows.Forms.Button();
            this.btnModC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvp
            // 
            this.dgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.SupplierID,
            this.CategoryID,
            this.QuantityPerUnit,
            this.UnitPrice,
            this.UnitInStock,
            this.UnitInOrder,
            this.ReorderLevel,
            this.Discontinued});
            this.dgvp.Location = new System.Drawing.Point(38, 72);
            this.dgvp.Name = "dgvp";
            this.dgvp.ReadOnly = true;
            this.dgvp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvp.Size = new System.Drawing.Size(727, 160);
            this.dgvp.TabIndex = 0;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // SupplierID
            // 
            this.SupplierID.HeaderText = "SupplierID";
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            // 
            // CategoryID
            // 
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            // 
            // QuantityPerUnit
            // 
            this.QuantityPerUnit.HeaderText = "QuantityPerUnit";
            this.QuantityPerUnit.Name = "QuantityPerUnit";
            this.QuantityPerUnit.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // UnitInStock
            // 
            this.UnitInStock.HeaderText = "UnitInStock";
            this.UnitInStock.Name = "UnitInStock";
            this.UnitInStock.ReadOnly = true;
            // 
            // UnitInOrder
            // 
            this.UnitInOrder.HeaderText = "UnitInOrder";
            this.UnitInOrder.Name = "UnitInOrder";
            this.UnitInOrder.ReadOnly = true;
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.HeaderText = "ReorderLevel";
            this.ReorderLevel.Name = "ReorderLevel";
            this.ReorderLevel.ReadOnly = true;
            // 
            // Discontinued
            // 
            this.Discontinued.HeaderText = "Discontinued";
            this.Discontinued.Name = "Discontinued";
            this.Discontinued.ReadOnly = true;
            // 
            // txtIDProd
            // 
            this.txtIDProd.Location = new System.Drawing.Point(38, 35);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(100, 20);
            this.txtIDProd.TabIndex = 1;
            this.txtIDProd.Text = "1";
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(144, 35);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarProd.TabIndex = 2;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FILTRE PRODUCTOS POR ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "FILTRE CATEGORIAS POR ID";
            // 
            // btnBuscarCat
            // 
            this.btnBuscarCat.Location = new System.Drawing.Point(144, 257);
            this.btnBuscarCat.Name = "btnBuscarCat";
            this.btnBuscarCat.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarCat.TabIndex = 5;
            this.btnBuscarCat.Text = "Buscar";
            this.btnBuscarCat.UseVisualStyleBackColor = true;
            this.btnBuscarCat.Click += new System.EventHandler(this.btnBuscarCat_Click);
            // 
            // txtIDCat
            // 
            this.txtIDCat.Location = new System.Drawing.Point(38, 258);
            this.txtIDCat.Name = "txtIDCat";
            this.txtIDCat.Size = new System.Drawing.Size(100, 20);
            this.txtIDCat.TabIndex = 4;
            this.txtIDCat.Text = "1";
            // 
            // dgvc
            // 
            this.dgvc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryyID,
            this.CategoryName,
            this.Description,
            this.Picture});
            this.dgvc.Location = new System.Drawing.Point(38, 283);
            this.dgvc.Name = "dgvc";
            this.dgvc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvc.Size = new System.Drawing.Size(443, 155);
            this.dgvc.TabIndex = 7;
            // 
            // CategoryyID
            // 
            this.CategoryyID.HeaderText = "CategoryID";
            this.CategoryyID.Name = "CategoryyID";
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Picture
            // 
            this.Picture.HeaderText = "Picture";
            this.Picture.Name = "Picture";
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(468, 35);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(104, 23);
            this.btnAddProd.TabIndex = 8;
            this.btnAddProd.Text = "Añadir Producto";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(529, 283);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(114, 23);
            this.btnAddCat.TabIndex = 9;
            this.btnAddCat.Text = "Añadir Categoria";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnElimP
            // 
            this.btnElimP.Location = new System.Drawing.Point(690, 35);
            this.btnElimP.Name = "btnElimP";
            this.btnElimP.Size = new System.Drawing.Size(75, 23);
            this.btnElimP.TabIndex = 10;
            this.btnElimP.Text = "Eliminar";
            this.btnElimP.UseVisualStyleBackColor = true;
            this.btnElimP.Click += new System.EventHandler(this.btnElimP_Click);
            // 
            // btnElimCat
            // 
            this.btnElimCat.Location = new System.Drawing.Point(529, 383);
            this.btnElimCat.Name = "btnElimCat";
            this.btnElimCat.Size = new System.Drawing.Size(75, 23);
            this.btnElimCat.TabIndex = 11;
            this.btnElimCat.Text = "Eliminar";
            this.btnElimCat.UseVisualStyleBackColor = true;
            this.btnElimCat.Click += new System.EventHandler(this.btnElimCat_Click);
            // 
            // btnModP
            // 
            this.btnModP.Location = new System.Drawing.Point(594, 35);
            this.btnModP.Name = "btnModP";
            this.btnModP.Size = new System.Drawing.Size(75, 23);
            this.btnModP.TabIndex = 12;
            this.btnModP.Text = "Modificar";
            this.btnModP.UseVisualStyleBackColor = true;
            this.btnModP.Click += new System.EventHandler(this.btnModP_Click);
            // 
            // btnModC
            // 
            this.btnModC.Location = new System.Drawing.Point(529, 336);
            this.btnModC.Name = "btnModC";
            this.btnModC.Size = new System.Drawing.Size(75, 23);
            this.btnModC.TabIndex = 13;
            this.btnModC.Text = "Modificar";
            this.btnModC.UseVisualStyleBackColor = true;
            this.btnModC.Click += new System.EventHandler(this.btnModC_Click);
            // 
            // FormMuestroDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModC);
            this.Controls.Add(this.btnModP);
            this.Controls.Add(this.btnElimCat);
            this.Controls.Add(this.btnElimP);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.dgvc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarCat);
            this.Controls.Add(this.txtIDCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.dgvp);
            this.Name = "FormMuestroDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitInOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discontinued;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCat;
        private System.Windows.Forms.TextBox txtIDCat;
        private System.Windows.Forms.DataGridView dgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Picture;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnElimP;
        private System.Windows.Forms.Button btnElimCat;
        private System.Windows.Forms.Button btnModP;
        private System.Windows.Forms.Button btnModC;
    }
}

