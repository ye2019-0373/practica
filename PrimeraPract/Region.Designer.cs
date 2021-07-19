namespace PrimeraPract
{
    partial class Region
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
            System.Windows.Forms.Label regionDescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Region));
            System.Windows.Forms.Label regionIDLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.northwindDataSet = new PrimeraPract.NorthwindDataSet();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionTableAdapter = new PrimeraPract.NorthwindDataSetTableAdapters.RegionTableAdapter();
            this.tableAdapterManager = new PrimeraPract.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.regionDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.regionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.northwindDataSet1 = new PrimeraPract.NorthwindDataSet();
            this.regionIDTextBox = new System.Windows.Forms.TextBox();
            regionDescriptionLabel = new System.Windows.Forms.Label();
            regionIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // regionDescriptionLabel
            // 
            regionDescriptionLabel.AutoSize = true;
            regionDescriptionLabel.BackColor = System.Drawing.Color.LightCyan;
            regionDescriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            regionDescriptionLabel.ForeColor = System.Drawing.Color.Blue;
            regionDescriptionLabel.Location = new System.Drawing.Point(88, 207);
            regionDescriptionLabel.Name = "regionDescriptionLabel";
            regionDescriptionLabel.Size = new System.Drawing.Size(201, 29);
            regionDescriptionLabel.TabIndex = 108;
            regionDescriptionLabel.Text = "Region Description:";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(1, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 542);
            this.panel3.TabIndex = 105;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(50, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 65);
            this.button2.TabIndex = 101;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(438, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 87);
            this.button3.TabIndex = 102;
            this.button3.Text = "log out";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(71, 263);
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
            this.label13.Location = new System.Drawing.Point(133, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(267, 50);
            this.label13.TabIndex = 96;
            this.label13.Text = "Region window";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(526, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 542);
            this.panel2.TabIndex = 95;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(320, -44);
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
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "Region";
            this.regionBindingSource.DataSource = this.northwindDataSet;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RegionTableAdapter = this.regionTableAdapter;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrimeraPract.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // regionDescriptionTextBox
            // 
            this.regionDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regionBindingSource, "RegionDescription", true));
            this.regionDescriptionTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionDescriptionTextBox.Location = new System.Drawing.Point(302, 206);
            this.regionDescriptionTextBox.Name = "regionDescriptionTextBox";
            this.regionDescriptionTextBox.Size = new System.Drawing.Size(167, 35);
            this.regionDescriptionTextBox.TabIndex = 109;
            // 
            // regionDataGridView
            // 
            this.regionDataGridView.AutoGenerateColumns = false;
            this.regionDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.regionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.regionDataGridView.DataSource = this.regionBindingSource;
            this.regionDataGridView.Location = new System.Drawing.Point(50, 341);
            this.regionDataGridView.Name = "regionDataGridView";
            this.regionDataGridView.RowHeadersWidth = 62;
            this.regionDataGridView.RowTemplate.Height = 28;
            this.regionDataGridView.Size = new System.Drawing.Size(479, 198);
            this.regionDataGridView.TabIndex = 109;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RegionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RegionID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RegionDescription";
            this.dataGridViewTextBoxColumn2.HeaderText = "RegionDescription";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regionIDLabel
            // 
            regionIDLabel.AutoSize = true;
            regionIDLabel.BackColor = System.Drawing.Color.LightCyan;
            regionIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            regionIDLabel.ForeColor = System.Drawing.Color.Blue;
            regionIDLabel.Location = new System.Drawing.Point(171, 164);
            regionIDLabel.Name = "regionIDLabel";
            regionIDLabel.Size = new System.Drawing.Size(118, 29);
            regionIDLabel.TabIndex = 109;
            regionIDLabel.Text = "Region ID:";
            // 
            // regionIDTextBox
            // 
            this.regionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regionBindingSource, "RegionID", true));
            this.regionIDTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionIDTextBox.Location = new System.Drawing.Point(302, 164);
            this.regionIDTextBox.Name = "regionIDTextBox";
            this.regionIDTextBox.Size = new System.Drawing.Size(167, 35);
            this.regionIDTextBox.TabIndex = 110;
            // 
            // Region
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 559);
            this.Controls.Add(regionIDLabel);
            this.Controls.Add(this.regionIDTextBox);
            this.Controls.Add(this.regionDataGridView);
            this.Controls.Add(regionDescriptionLabel);
            this.Controls.Add(this.regionDescriptionTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Region";
            this.Text = "Region";
            this.Load += new System.EventHandler(this.Region_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private NorthwindDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox regionDescriptionTextBox;
        private System.Windows.Forms.DataGridView regionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private NorthwindDataSet northwindDataSet1;
        private System.Windows.Forms.TextBox regionIDTextBox;
    }
}