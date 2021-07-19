namespace PrimeraPract
{
    partial class Territories
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
            System.Windows.Forms.Label territoryDescriptionLabel;
            System.Windows.Forms.Label regionIDLabel;
            System.Windows.Forms.Label territoryIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Territories));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.northwindDataSet = new PrimeraPract.NorthwindDataSet();
            this.territoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.territoriesTableAdapter = new PrimeraPract.NorthwindDataSetTableAdapters.TerritoriesTableAdapter();
            this.tableAdapterManager = new PrimeraPract.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.territoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.territoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.regionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet3 = new PrimeraPract.NorthwindDataSet3();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet1 = new PrimeraPract.NorthwindDataSet1();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.regionTableAdapter = new PrimeraPract.NorthwindDataSet1TableAdapters.RegionTableAdapter();
            this.regionTableAdapter1 = new PrimeraPract.NorthwindDataSet3TableAdapters.RegionTableAdapter();
            this.territoryIDTextBox = new System.Windows.Forms.TextBox();
            territoryDescriptionLabel = new System.Windows.Forms.Label();
            regionIDLabel = new System.Windows.Forms.Label();
            territoryIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // territoryDescriptionLabel
            // 
            territoryDescriptionLabel.AutoSize = true;
            territoryDescriptionLabel.BackColor = System.Drawing.Color.LightCyan;
            territoryDescriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            territoryDescriptionLabel.ForeColor = System.Drawing.Color.Blue;
            territoryDescriptionLabel.Location = new System.Drawing.Point(87, 151);
            territoryDescriptionLabel.Name = "territoryDescriptionLabel";
            territoryDescriptionLabel.Size = new System.Drawing.Size(231, 29);
            territoryDescriptionLabel.TabIndex = 108;
            territoryDescriptionLabel.Text = "Territory Description:";
            // 
            // regionIDLabel
            // 
            regionIDLabel.AutoSize = true;
            regionIDLabel.BackColor = System.Drawing.Color.LightCyan;
            regionIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            regionIDLabel.ForeColor = System.Drawing.Color.Blue;
            regionIDLabel.Location = new System.Drawing.Point(87, 186);
            regionIDLabel.Name = "regionIDLabel";
            regionIDLabel.Size = new System.Drawing.Size(118, 29);
            regionIDLabel.TabIndex = 110;
            regionIDLabel.Text = "Region ID:";
            // 
            // territoryIDLabel
            // 
            territoryIDLabel.AutoSize = true;
            territoryIDLabel.Location = new System.Drawing.Point(193, 130);
            territoryIDLabel.Name = "territoryIDLabel";
            territoryIDLabel.Size = new System.Drawing.Size(91, 20);
            territoryIDLabel.TabIndex = 112;
            territoryIDLabel.Text = "Territory ID:";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(1, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 614);
            this.panel3.TabIndex = 105;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(50, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 65);
            this.button2.TabIndex = 101;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(591, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 98);
            this.button3.TabIndex = 102;
            this.button3.Text = "log out";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(173, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 72);
            this.button5.TabIndex = 100;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(295, 275);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 72);
            this.button6.TabIndex = 99;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(50, 275);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 72);
            this.button7.TabIndex = 98;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(138, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(347, 50);
            this.label13.TabIndex = 96;
            this.label13.Text = "Territories window";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(683, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 611);
            this.panel2.TabIndex = 95;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(491, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 202);
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // territoriesBindingSource
            // 
            this.territoriesBindingSource.DataMember = "Territories";
            this.territoriesBindingSource.DataSource = this.northwindDataSet;
            // 
            // territoriesTableAdapter
            // 
            this.territoriesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = this.territoriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = PrimeraPract.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // territoryDescriptionTextBox
            // 
            this.territoryDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.territoriesBindingSource, "TerritoryDescription", true));
            this.territoryDescriptionTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.territoryDescriptionTextBox.Location = new System.Drawing.Point(326, 151);
            this.territoryDescriptionTextBox.Name = "territoryDescriptionTextBox";
            this.territoryDescriptionTextBox.Size = new System.Drawing.Size(218, 35);
            this.territoryDescriptionTextBox.TabIndex = 109;
            // 
            // territoriesDataGridView
            // 
            this.territoriesDataGridView.AutoGenerateColumns = false;
            this.territoriesDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.territoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.territoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.territoriesDataGridView.DataSource = this.territoriesBindingSource;
            this.territoriesDataGridView.Location = new System.Drawing.Point(44, 357);
            this.territoriesDataGridView.Name = "territoriesDataGridView";
            this.territoriesDataGridView.RowHeadersWidth = 62;
            this.territoriesDataGridView.RowTemplate.Height = 28;
            this.territoriesDataGridView.Size = new System.Drawing.Size(633, 255);
            this.territoriesDataGridView.TabIndex = 111;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TerritoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TerritoryID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TerritoryDescription";
            this.dataGridViewTextBoxColumn2.HeaderText = "TerritoryDescription";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RegionID";
            this.dataGridViewTextBoxColumn3.HeaderText = "RegionID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.regionBindingSource1;
            this.comboBox1.DisplayMember = "RegionID";
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(326, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 36);
            this.comboBox1.TabIndex = 112;
            this.comboBox1.ValueMember = "RegionID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // regionBindingSource1
            // 
            this.regionBindingSource1.DataMember = "Region";
            this.regionBindingSource1.DataSource = this.northwindDataSet3;
            // 
            // northwindDataSet3
            // 
            this.northwindDataSet3.DataSetName = "NorthwindDataSet3";
            this.northwindDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "Region";
            this.regionBindingSource.DataSource = this.northwindDataSet1;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet1";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // regionTableAdapter1
            // 
            this.regionTableAdapter1.ClearBeforeFill = true;
            // 
            // territoryIDTextBox
            // 
            this.territoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.territoriesBindingSource, "TerritoryID", true));
            this.territoryIDTextBox.Location = new System.Drawing.Point(290, 127);
            this.territoryIDTextBox.Name = "territoryIDTextBox";
            this.territoryIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.territoryIDTextBox.TabIndex = 113;
            // 
            // Territories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 632);
            this.Controls.Add(territoryIDLabel);
            this.Controls.Add(this.territoryIDTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.territoriesDataGridView);
            this.Controls.Add(territoryDescriptionLabel);
            this.Controls.Add(this.territoryDescriptionTextBox);
            this.Controls.Add(regionIDLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Territories";
            this.Text = "Territories";
            this.Load += new System.EventHandler(this.Territories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource territoriesBindingSource;
        private NorthwindDataSetTableAdapters.TerritoriesTableAdapter territoriesTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox territoryDescriptionTextBox;
        private System.Windows.Forms.DataGridView territoriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private NorthwindDataSet1 northwindDataSet1;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private NorthwindDataSet1TableAdapters.RegionTableAdapter regionTableAdapter;
        private NorthwindDataSet3 northwindDataSet3;
        private System.Windows.Forms.BindingSource regionBindingSource1;
        private NorthwindDataSet3TableAdapters.RegionTableAdapter regionTableAdapter1;
        private System.Windows.Forms.TextBox territoryIDTextBox;
    }
}