namespace OrderManagement
{
    partial class OrderMngmtForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dgTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.btnEditShippedDate = new System.Windows.Forms.Button();
            this.pnlShippedDate = new System.Windows.Forms.Panel();
            this.mtxtBoxShippedDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).BeginInit();
            this.pnlShippedDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ordersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(546, 509);
            this.ordersDataGridView.TabIndex = 1;
            this.ordersDataGridView.SelectionChanged += new System.EventHandler(this.ordersDataGridView_SelectionChanged);
            // 
            // orderDetailsDataGridView
            // 
            this.orderDetailsDataGridView.AutoGenerateColumns = false;
            this.orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dgDiscount,
            this.dgUnitPrice,
            this.dgQuantity,
            this.dgTotal});
            this.orderDetailsDataGridView.DataSource = this.orderDetailsBindingSource;
            this.orderDetailsDataGridView.Location = new System.Drawing.Point(552, 0);
            this.orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            this.orderDetailsDataGridView.Size = new System.Drawing.Size(638, 240);
            this.orderDetailsDataGridView.TabIndex = 1;
            // 
            // dgTotal
            // 
            this.dgTotal.HeaderText = "Total";
            this.dgTotal.Name = "dgTotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1030, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SubTotal:";
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.Location = new System.Drawing.Point(1090, 254);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.ReadOnly = true;
            this.txtBoxSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSubtotal.TabIndex = 3;
            // 
            // btnEditShippedDate
            // 
            this.btnEditShippedDate.Enabled = false;
            this.btnEditShippedDate.Location = new System.Drawing.Point(572, 296);
            this.btnEditShippedDate.Name = "btnEditShippedDate";
            this.btnEditShippedDate.Size = new System.Drawing.Size(111, 23);
            this.btnEditShippedDate.TabIndex = 4;
            this.btnEditShippedDate.Text = "EditShippedDate";
            this.btnEditShippedDate.UseVisualStyleBackColor = true;
            this.btnEditShippedDate.Click += new System.EventHandler(this.btnEditShippedDate_Click);
            // 
            // pnlShippedDate
            // 
            this.pnlShippedDate.Controls.Add(this.btnSave);
            this.pnlShippedDate.Controls.Add(this.label2);
            this.pnlShippedDate.Controls.Add(this.mtxtBoxShippedDate);
            this.pnlShippedDate.Location = new System.Drawing.Point(572, 325);
            this.pnlShippedDate.Name = "pnlShippedDate";
            this.pnlShippedDate.Size = new System.Drawing.Size(111, 70);
            this.pnlShippedDate.TabIndex = 5;
            this.pnlShippedDate.Visible = false;
            // 
            // mtxtBoxShippedDate
            // 
            this.mtxtBoxShippedDate.Culture = new System.Globalization.CultureInfo("en-CA");
            this.mtxtBoxShippedDate.Location = new System.Drawing.Point(2, 19);
            this.mtxtBoxShippedDate.Mask = "00/00/0000";
            this.mtxtBoxShippedDate.Name = "mtxtBoxShippedDate";
            this.mtxtBoxShippedDate.Size = new System.Drawing.Size(100, 20);
            this.mtxtBoxShippedDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Shipped Date:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn6.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dgDiscount
            // 
            this.dgDiscount.DataPropertyName = "Discount";
            this.dgDiscount.HeaderText = "Discount";
            this.dgDiscount.Name = "dgDiscount";
            // 
            // dgUnitPrice
            // 
            this.dgUnitPrice.DataPropertyName = "UnitPrice";
            this.dgUnitPrice.HeaderText = "UnitPrice";
            this.dgUnitPrice.Name = "dgUnitPrice";
            // 
            // dgQuantity
            // 
            this.dgQuantity.DataPropertyName = "Quantity";
            this.dgQuantity.HeaderText = "Quantity";
            this.dgQuantity.Name = "dgQuantity";
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(EntityClass.OrderDetails);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderDate";
            dataGridViewCellStyle7.Format = "D";
            dataGridViewCellStyle7.NullValue = "N/A";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn3.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RequiredDate";
            dataGridViewCellStyle8.Format = "D";
            dataGridViewCellStyle8.NullValue = "N/A";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn4.HeaderText = "RequiredDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ShippedDate";
            dataGridViewCellStyle9.Format = "D";
            dataGridViewCellStyle9.NullValue = "N/A";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn5.HeaderText = "ShippedDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(EntityClass.Orders);
            // 
            // OrderMngmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 509);
            this.Controls.Add(this.pnlShippedDate);
            this.Controls.Add(this.btnEditShippedDate);
            this.Controls.Add(this.txtBoxSubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderDetailsDataGridView);
            this.Controls.Add(this.ordersDataGridView);
            this.Name = "OrderMngmtForm";
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.OrderMngmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).EndInit();
            this.pnlShippedDate.ResumeLayout(false);
            this.pnlShippedDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnEditShippedDate;
        private System.Windows.Forms.Panel pnlShippedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtBoxShippedDate;
        private System.Windows.Forms.Button btnSave;
    }
}

