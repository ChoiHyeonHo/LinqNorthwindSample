namespace WinNorthwind
{
    partial class frmOrder
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCartDel = new System.Windows.Forms.Button();
            this.btnCartAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.nuQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.dtpRequired = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnShip = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboEmployee2 = new System.Windows.Forms.ComboBox();
            this.cboCustomer2 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.cboShipper = new System.Windows.Forms.ComboBox();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dtpRequired);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cboEmployee);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboCustomer);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "주문 신규등록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(19, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "*";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrder.Location = new System.Drawing.Point(792, 229);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(224, 75);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuantityPerUnit);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnOrder);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCartDel);
            this.groupBox1.Controls.Add(this.btnCartAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.nuQuantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboProduct);
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.dgvCart);
            this.groupBox1.Location = new System.Drawing.Point(16, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 310);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Item";
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(683, 22);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.ReadOnly = true;
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(103, 22);
            this.txtQuantityPerUnit.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(7, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(7, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "*";
            // 
            // btnCartDel
            // 
            this.btnCartDel.Location = new System.Drawing.Point(792, 49);
            this.btnCartDel.Name = "btnCartDel";
            this.btnCartDel.Size = new System.Drawing.Size(129, 23);
            this.btnCartDel.TabIndex = 7;
            this.btnCartDel.Text = "장바구니 삭제";
            this.btnCartDel.UseVisualStyleBackColor = true;
            this.btnCartDel.Click += new System.EventHandler(this.btnCartDel_Click);
            // 
            // btnCartAdd
            // 
            this.btnCartAdd.Location = new System.Drawing.Point(683, 49);
            this.btnCartAdd.Name = "btnCartAdd";
            this.btnCartAdd.Size = new System.Drawing.Size(103, 23);
            this.btnCartAdd.TabIndex = 6;
            this.btnCartAdd.Text = "장바구니 추가";
            this.btnCartAdd.UseVisualStyleBackColor = true;
            this.btnCartAdd.Click += new System.EventHandler(this.btnCartAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(792, 23);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(129, 22);
            this.txtUnitPrice.TabIndex = 5;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nuQuantity
            // 
            this.nuQuantity.Location = new System.Drawing.Point(84, 50);
            this.nuQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuQuantity.Name = "nuQuantity";
            this.nuQuantity.Size = new System.Drawing.Size(60, 22);
            this.nuQuantity.TabIndex = 7;
            this.nuQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product";
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.ItemHeight = 16;
            this.cboProduct.Location = new System.Drawing.Point(256, 21);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(421, 24);
            this.cboProduct.TabIndex = 4;
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.ItemHeight = 16;
            this.cboCategory.Location = new System.Drawing.Point(84, 21);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(166, 24);
            this.cboCategory.TabIndex = 3;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(21, 78);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowTemplate.Height = 23;
            this.dgvCart.Size = new System.Drawing.Size(765, 226);
            this.dgvCart.TabIndex = 0;
            // 
            // dtpRequired
            // 
            this.dtpRequired.Location = new System.Drawing.Point(137, 124);
            this.dtpRequired.Name = "dtpRequired";
            this.dtpRequired.Size = new System.Drawing.Size(292, 22);
            this.dtpRequired.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Required Date";
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(137, 82);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(292, 24);
            this.cboEmployee.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(137, 42);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(292, 24);
            this.cboCustomer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtFreight);
            this.tabPage2.Controls.Add(this.dtpShippedDate);
            this.tabPage2.Controls.Add(this.cboShipper);
            this.tabPage2.Controls.Add(this.lblRequiredDate);
            this.tabPage2.Controls.Add(this.lblOrderDate);
            this.tabPage2.Controls.Add(this.lblEmployeeName);
            this.tabPage2.Controls.Add(this.lblCustomerName);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnShip);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.dgvOrderDetail);
            this.tabPage2.Controls.Add(this.dgvOrder);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1040, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "주문 조회/관리";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(19, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.dtpTo);
            this.groupBox2.Controls.Add(this.dtpFrom);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cboEmployee2);
            this.groupBox2.Controls.Add(this.cboCustomer2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1026, 78);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dgvOrder
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrder.Location = new System.Drawing.Point(8, 110);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 23;
            this.dgvOrder.Size = new System.Drawing.Size(656, 182);
            this.dgvOrder.TabIndex = 1;
            // 
            // dgvOrderDetail
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetail.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrderDetail.Location = new System.Drawing.Point(8, 301);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 23;
            this.dgvOrderDetail.Size = new System.Drawing.Size(656, 182);
            this.dgvOrderDetail.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(670, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(670, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(692, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Order Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(692, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Customer";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(692, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Required Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(692, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "Shipper";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(692, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "Shipped Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(692, 360);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "Freight";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(670, 361);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 20);
            this.label19.TabIndex = 26;
            this.label19.Text = "*";
            // 
            // btnShip
            // 
            this.btnShip.Location = new System.Drawing.Point(800, 433);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(101, 34);
            this.btnShip.TabIndex = 13;
            this.btnShip.Text = "배송처리";
            this.btnShip.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(907, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 34);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "주문 삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cboEmployee2
            // 
            this.cboEmployee2.FormattingEnabled = true;
            this.cboEmployee2.Location = new System.Drawing.Point(163, 37);
            this.cboEmployee2.Name = "cboEmployee2";
            this.cboEmployee2.Size = new System.Drawing.Size(197, 24);
            this.cboEmployee2.TabIndex = 3;
            // 
            // cboCustomer2
            // 
            this.cboCustomer2.FormattingEnabled = true;
            this.cboCustomer2.Location = new System.Drawing.Point(2, 37);
            this.cboCustomer2.Name = "cboCustomer2";
            this.cboCustomer2.Size = new System.Drawing.Size(155, 24);
            this.cboCustomer2.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 16);
            this.label20.TabIndex = 18;
            this.label20.Text = "Customer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(160, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Employee";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(692, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 16);
            this.label21.TabIndex = 29;
            this.label21.Text = "Employee";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(370, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 16);
            this.label22.TabIndex = 20;
            this.label22.Text = "Order Date";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(366, 37);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(117, 22);
            this.dtpFrom.TabIndex = 21;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(512, 37);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(117, 22);
            this.dtpTo.TabIndex = 22;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(489, 43);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 16);
            this.label23.TabIndex = 23;
            this.label23.Text = "~";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(899, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 34);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(964, 31);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(54, 34);
            this.btnExport.TabIndex = 29;
            this.btnExport.Text = "Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(797, 120);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 16);
            this.lblCustomerName.TabIndex = 30;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(797, 160);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 16);
            this.lblEmployeeName.TabIndex = 31;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(797, 200);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(0, 16);
            this.lblOrderDate.TabIndex = 32;
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.Location = new System.Drawing.Point(797, 240);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(0, 16);
            this.lblRequiredDate.TabIndex = 33;
            // 
            // cboShipper
            // 
            this.cboShipper.FormattingEnabled = true;
            this.cboShipper.Location = new System.Drawing.Point(800, 273);
            this.cboShipper.Name = "cboShipper";
            this.cboShipper.Size = new System.Drawing.Size(208, 24);
            this.cboShipper.TabIndex = 10;
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShippedDate.Location = new System.Drawing.Point(800, 319);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(113, 22);
            this.dtpShippedDate.TabIndex = 11;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(800, 357);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(113, 22);
            this.txtFreight.TabIndex = 12;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 518);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOrder";
            this.Text = "주문관리";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DateTimePicker dtpRequired;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCartDel;
        private System.Windows.Forms.Button btnCartAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.NumericUpDown nuQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboEmployee2;
        private System.Windows.Forms.ComboBox cboCustomer2;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.ComboBox cboShipper;
        private System.Windows.Forms.Label lblRequiredDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
    }
}

