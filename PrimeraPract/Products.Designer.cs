namespace PrimeraPract
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label quantityPerUnitLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label unitsInStockLabel;
            System.Windows.Forms.Label unitsOnOrderLabel;
            System.Windows.Forms.Label reorderLevelLabel;
            System.Windows.Forms.Label discontinuedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.northwindDataSet = new PrimeraPract.NorthwindDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new PrimeraPract.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new PrimeraPract.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitsInStockTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnOrderTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.discontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.supplierid = new System.Windows.Forms.ComboBox();
            this.categoryid = new System.Windows.Forms.ComboBox();
            this.northwindDataSet9 = new PrimeraPract.NorthwindDataSet9();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new PrimeraPract.NorthwindDataSet9TableAdapters.SuppliersTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.northwindDataSet10 = new PrimeraPract.NorthwindDataSet10();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new PrimeraPract.NorthwindDataSet10TableAdapters.CategoriesTableAdapter();
            productNameLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            quantityPerUnitLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            unitsInStockLabel = new System.Windows.Forms.Label();
            unitsOnOrderLabel = new System.Windows.Forms.Label();
            reorderLevelLabel = new System.Windows.Forms.Label();
            discontinuedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.BackColor = System.Drawing.Color.LightCyan;
            productNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productNameLabel.ForeColor = System.Drawing.Color.Blue;
            productNameLabel.Location = new System.Drawing.Point(43, 117);
            productNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(109, 19);
            productNameLabel.TabIndex = 81;
            productNameLabel.Text = "Product Name:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.BackColor = System.Drawing.Color.LightCyan;
            supplierIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierIDLabel.ForeColor = System.Drawing.Color.Blue;
            supplierIDLabel.Location = new System.Drawing.Point(44, 145);
            supplierIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(93, 19);
            supplierIDLabel.TabIndex = 83;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.BackColor = System.Drawing.Color.LightCyan;
            categoryIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryIDLabel.ForeColor = System.Drawing.Color.Blue;
            categoryIDLabel.Location = new System.Drawing.Point(44, 171);
            categoryIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(100, 19);
            categoryIDLabel.TabIndex = 85;
            categoryIDLabel.Text = "Category ID:";
            // 
            // quantityPerUnitLabel
            // 
            quantityPerUnitLabel.AutoSize = true;
            quantityPerUnitLabel.BackColor = System.Drawing.Color.LightCyan;
            quantityPerUnitLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityPerUnitLabel.ForeColor = System.Drawing.Color.Blue;
            quantityPerUnitLabel.Location = new System.Drawing.Point(44, 198);
            quantityPerUnitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            quantityPerUnitLabel.Name = "quantityPerUnitLabel";
            quantityPerUnitLabel.Size = new System.Drawing.Size(137, 19);
            quantityPerUnitLabel.TabIndex = 87;
            quantityPerUnitLabel.Text = "Quantity Per Unit:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.BackColor = System.Drawing.Color.LightCyan;
            unitPriceLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitPriceLabel.ForeColor = System.Drawing.Color.Blue;
            unitPriceLabel.Location = new System.Drawing.Point(44, 225);
            unitPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(82, 19);
            unitPriceLabel.TabIndex = 89;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // unitsInStockLabel
            // 
            unitsInStockLabel.AutoSize = true;
            unitsInStockLabel.BackColor = System.Drawing.Color.LightCyan;
            unitsInStockLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitsInStockLabel.ForeColor = System.Drawing.Color.Blue;
            unitsInStockLabel.Location = new System.Drawing.Point(44, 252);
            unitsInStockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            unitsInStockLabel.Name = "unitsInStockLabel";
            unitsInStockLabel.Size = new System.Drawing.Size(116, 19);
            unitsInStockLabel.TabIndex = 91;
            unitsInStockLabel.Text = "Units In Stock:";
            // 
            // unitsOnOrderLabel
            // 
            unitsOnOrderLabel.AutoSize = true;
            unitsOnOrderLabel.BackColor = System.Drawing.Color.LightCyan;
            unitsOnOrderLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitsOnOrderLabel.ForeColor = System.Drawing.Color.Blue;
            unitsOnOrderLabel.Location = new System.Drawing.Point(44, 278);
            unitsOnOrderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            unitsOnOrderLabel.Name = "unitsOnOrderLabel";
            unitsOnOrderLabel.Size = new System.Drawing.Size(121, 19);
            unitsOnOrderLabel.TabIndex = 93;
            unitsOnOrderLabel.Text = "Units On Order:";
            // 
            // reorderLevelLabel
            // 
            reorderLevelLabel.AutoSize = true;
            reorderLevelLabel.BackColor = System.Drawing.Color.LightCyan;
            reorderLevelLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reorderLevelLabel.ForeColor = System.Drawing.Color.Blue;
            reorderLevelLabel.Location = new System.Drawing.Point(44, 304);
            reorderLevelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            reorderLevelLabel.Name = "reorderLevelLabel";
            reorderLevelLabel.Size = new System.Drawing.Size(110, 19);
            reorderLevelLabel.TabIndex = 95;
            reorderLevelLabel.Text = "Reorder Level:";
            // 
            // discontinuedLabel
            // 
            discontinuedLabel.AutoSize = true;
            discontinuedLabel.BackColor = System.Drawing.Color.LightCyan;
            discontinuedLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discontinuedLabel.ForeColor = System.Drawing.Color.Blue;
            discontinuedLabel.Location = new System.Drawing.Point(44, 334);
            discontinuedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            discontinuedLabel.Name = "discontinuedLabel";
            discontinuedLabel.Size = new System.Drawing.Size(98, 19);
            discontinuedLabel.TabIndex = 97;
            discontinuedLabel.Text = "Discontinued:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(37, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 42);
            this.button2.TabIndex = 77;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(710, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 59);
            this.button3.TabIndex = 78;
            this.button3.Text = "log out";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(119, 383);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 55);
            this.button5.TabIndex = 76;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(200, 383);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 55);
            this.button6.TabIndex = 75;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(37, 383);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 55);
            this.button7.TabIndex = 74;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(97, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 35);
            this.label13.TabIndex = 72;
            this.label13.Text = "Products window";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(767, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 447);
            this.panel2.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(452, -18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 129);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(4, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 447);
            this.panel1.TabIndex = 72;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.northwindDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrimeraPract.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(177, 115);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(125, 26);
            this.productNameTextBox.TabIndex = 82;
            // 
            // quantityPerUnitTextBox
            // 
            this.quantityPerUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "QuantityPerUnit", true));
            this.quantityPerUnitTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityPerUnitTextBox.Location = new System.Drawing.Point(178, 196);
            this.quantityPerUnitTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityPerUnitTextBox.Name = "quantityPerUnitTextBox";
            this.quantityPerUnitTextBox.Size = new System.Drawing.Size(125, 26);
            this.quantityPerUnitTextBox.TabIndex = 88;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceTextBox.Location = new System.Drawing.Point(178, 223);
            this.unitPriceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(125, 26);
            this.unitPriceTextBox.TabIndex = 90;
            // 
            // unitsInStockTextBox
            // 
            this.unitsInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitsInStock", true));
            this.unitsInStockTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsInStockTextBox.Location = new System.Drawing.Point(178, 250);
            this.unitsInStockTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitsInStockTextBox.Name = "unitsInStockTextBox";
            this.unitsInStockTextBox.Size = new System.Drawing.Size(125, 26);
            this.unitsInStockTextBox.TabIndex = 92;
            // 
            // unitsOnOrderTextBox
            // 
            this.unitsOnOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitsOnOrder", true));
            this.unitsOnOrderTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsOnOrderTextBox.Location = new System.Drawing.Point(178, 276);
            this.unitsOnOrderTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitsOnOrderTextBox.Name = "unitsOnOrderTextBox";
            this.unitsOnOrderTextBox.Size = new System.Drawing.Size(125, 26);
            this.unitsOnOrderTextBox.TabIndex = 94;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ReorderLevel", true));
            this.reorderLevelTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLevelTextBox.Location = new System.Drawing.Point(178, 303);
            this.reorderLevelTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(125, 26);
            this.reorderLevelTextBox.TabIndex = 96;
            // 
            // discontinuedCheckBox
            // 
            this.discontinuedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productsBindingSource, "Discontinued", true));
            this.discontinuedCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discontinuedCheckBox.Location = new System.Drawing.Point(178, 331);
            this.discontinuedCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.discontinuedCheckBox.Name = "discontinuedCheckBox";
            this.discontinuedCheckBox.Size = new System.Drawing.Size(124, 22);
            this.discontinuedCheckBox.TabIndex = 98;
            this.discontinuedCheckBox.Text = "checkBox1";
            this.discontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(317, 87);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 62;
            this.productsDataGridView.RowTemplate.Height = 28;
            this.productsDataGridView.Size = new System.Drawing.Size(451, 358);
            this.productsDataGridView.TabIndex = 98;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn3.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QuantityPerUnit";
            this.dataGridViewTextBoxColumn5.HeaderText = "QuantityPerUnit";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UnitsInStock";
            this.dataGridViewTextBoxColumn7.HeaderText = "UnitsInStock";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UnitsOnOrder";
            this.dataGridViewTextBoxColumn8.HeaderText = "UnitsOnOrder";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ReorderLevel";
            this.dataGridViewTextBoxColumn9.HeaderText = "ReorderLevel";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Discontinued";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Discontinued";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // supplierid
            // 
            this.supplierid.DataSource = this.suppliersBindingSource;
            this.supplierid.DisplayMember = "SupplierID";
            this.supplierid.FormattingEnabled = true;
            this.supplierid.Location = new System.Drawing.Point(178, 143);
            this.supplierid.Name = "supplierid";
            this.supplierid.Size = new System.Drawing.Size(125, 21);
            this.supplierid.TabIndex = 99;
            this.supplierid.ValueMember = "SupplierID";
            // 
            // categoryid
            // 
            this.categoryid.DataSource = this.categoriesBindingSource;
            this.categoryid.DisplayMember = "CategoryID";
            this.categoryid.FormattingEnabled = true;
            this.categoryid.Location = new System.Drawing.Point(178, 171);
            this.categoryid.Name = "categoryid";
            this.categoryid.Size = new System.Drawing.Size(125, 21);
            this.categoryid.TabIndex = 100;
            this.categoryid.ValueMember = "CategoryID";
            // 
            // northwindDataSet9
            // 
            this.northwindDataSet9.DataSetName = "NorthwindDataSet9";
            this.northwindDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.northwindDataSet9;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // northwindDataSet10
            // 
            this.northwindDataSet10.DataSetName = "NorthwindDataSet10";
            this.northwindDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.northwindDataSet10;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 446);
            this.Controls.Add(this.categoryid);
            this.Controls.Add(this.supplierid);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(supplierIDLabel);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(quantityPerUnitLabel);
            this.Controls.Add(this.quantityPerUnitTextBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(unitsInStockLabel);
            this.Controls.Add(this.unitsInStockTextBox);
            this.Controls.Add(unitsOnOrderLabel);
            this.Controls.Add(this.unitsOnOrderTextBox);
            this.Controls.Add(reorderLevelLabel);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(discontinuedLabel);
            this.Controls.Add(this.discontinuedCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox quantityPerUnitTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox unitsInStockTextBox;
        private System.Windows.Forms.TextBox unitsOnOrderTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.CheckBox discontinuedCheckBox;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ComboBox supplierid;
        private System.Windows.Forms.ComboBox categoryid;
        private NorthwindDataSet9 northwindDataSet9;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private NorthwindDataSet9TableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private NorthwindDataSet10 northwindDataSet10;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private NorthwindDataSet10TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
    }
}