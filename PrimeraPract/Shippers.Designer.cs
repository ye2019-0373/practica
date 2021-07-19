namespace PrimeraPract
{
    partial class Shippers
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
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shippers));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.northwindDataSet = new PrimeraPract.NorthwindDataSet();
            this.shippersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippersTableAdapter = new PrimeraPract.NorthwindDataSetTableAdapters.ShippersTableAdapter();
            this.tableAdapterManager = new PrimeraPract.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.shippersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            companyNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.BackColor = System.Drawing.Color.LightCyan;
            companyNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyNameLabel.ForeColor = System.Drawing.Color.Blue;
            companyNameLabel.Location = new System.Drawing.Point(188, 147);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(167, 29);
            companyNameLabel.TabIndex = 94;
            companyNameLabel.Text = "Company Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = System.Drawing.Color.LightCyan;
            phoneLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.ForeColor = System.Drawing.Color.Blue;
            phoneLabel.Location = new System.Drawing.Point(188, 193);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(77, 29);
            phoneLabel.TabIndex = 96;
            phoneLabel.Text = "Phone:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(50, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 65);
            this.button2.TabIndex = 78;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(686, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 78);
            this.button3.TabIndex = 79;
            this.button3.Text = "log out";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(183, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 72);
            this.button5.TabIndex = 77;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(305, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 72);
            this.button6.TabIndex = 76;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(60, 271);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 72);
            this.button7.TabIndex = 75;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(222, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(306, 50);
            this.label13.TabIndex = 73;
            this.label13.Text = "Shippers window";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-62, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 768);
            this.panel1.TabIndex = 72;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(772, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 583);
            this.panel2.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(574, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 202);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 583);
            this.panel3.TabIndex = 91;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shippersBindingSource
            // 
            this.shippersBindingSource.DataMember = "Shippers";
            this.shippersBindingSource.DataSource = this.northwindDataSet;
            // 
            // shippersTableAdapter
            // 
            this.shippersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ShippersTableAdapter = this.shippersTableAdapter;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrimeraPract.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shippersDataGridView
            // 
            this.shippersDataGridView.AutoGenerateColumns = false;
            this.shippersDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.shippersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shippersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.shippersDataGridView.DataSource = this.shippersBindingSource;
            this.shippersDataGridView.Location = new System.Drawing.Point(50, 349);
            this.shippersDataGridView.Name = "shippersDataGridView";
            this.shippersDataGridView.RowHeadersWidth = 62;
            this.shippersDataGridView.RowTemplate.Height = 28;
            this.shippersDataGridView.Size = new System.Drawing.Size(724, 234);
            this.shippersDataGridView.TabIndex = 92;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ShipperID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ShipperID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompanyName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shippersBindingSource, "CompanyName", true));
            this.companyNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameTextBox.Location = new System.Drawing.Point(374, 144);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(194, 35);
            this.companyNameTextBox.TabIndex = 95;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shippersBindingSource, "Phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(374, 190);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(194, 35);
            this.phoneTextBox.TabIndex = 97;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Shippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 580);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.shippersDataGridView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Shippers";
            this.Text = "Shippers";
            this.Load += new System.EventHandler(this.Shippers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource shippersBindingSource;
        private NorthwindDataSetTableAdapters.ShippersTableAdapter shippersTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView shippersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}