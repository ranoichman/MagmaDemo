namespace MagmaDemo
{
    partial class Form1
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
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.GB_Machine = new System.Windows.Forms.GroupBox();
            this.Lbl_CurrentMach = new System.Windows.Forms.Label();
            this.DGV_Machines = new System.Windows.Forms.DataGridView();
            this.machineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magmaDataSet1 = new MagmaDemo.MagmaDataSet1();
            this.GB_AddMach = new System.Windows.Forms.GroupBox();
            this.Btn_AddMach = new System.Windows.Forms.Button();
            this.Lbl_MachName = new System.Windows.Forms.Label();
            this.Txt_Machine = new System.Windows.Forms.TextBox();
            this.GB_Items = new System.Windows.Forms.GroupBox();
            this.DGV_Items = new System.Windows.Forms.DataGridView();
            this.catalogNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magmaDataSet = new MagmaDemo.MagmaDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_ItemDesc = new System.Windows.Forms.TextBox();
            this.Btn_AddItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ItemNum = new System.Windows.Forms.TextBox();
            this.GB_WrkOrd = new System.Windows.Forms.GroupBox();
            this.Lbl_wrkOrds = new System.Windows.Forms.Label();
            this.DGV_WrkOrds = new System.Windows.Forms.DataGridView();
            this.ordNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrkOrdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magmaDataSet4 = new MagmaDemo.MagmaDataSet4();
            this.GB_AddWrkOrd = new System.Windows.Forms.GroupBox();
            this.Txt_Qty = new System.Windows.Forms.TextBox();
            this.CB_CatNum = new System.Windows.Forms.ComboBox();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.magmaDataSet3 = new MagmaDemo.MagmaDataSet3();
            this.CB_MachName = new System.Windows.Forms.ComboBox();
            this.machinesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.magmaDataSet2 = new MagmaDemo.MagmaDataSet2();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_AddWrkOrd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.itemTableAdapter = new MagmaDemo.MagmaDataSetTableAdapters.ItemTableAdapter();
            this.machinesTableAdapter = new MagmaDemo.MagmaDataSet1TableAdapters.MachinesTableAdapter();
            this.machinesTableAdapter1 = new MagmaDemo.MagmaDataSet2TableAdapters.MachinesTableAdapter();
            this.itemTableAdapter1 = new MagmaDemo.MagmaDataSet3TableAdapters.ItemTableAdapter();
            this.wrkOrdsTableAdapter = new MagmaDemo.MagmaDataSet4TableAdapters.WrkOrdsTableAdapter();
            this.GB_Machine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Machines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet1)).BeginInit();
            this.GB_AddMach.SuspendLayout();
            this.GB_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GB_WrkOrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_WrkOrds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrkOrdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet4)).BeginInit();
            this.GB_AddWrkOrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lbl_Title.Location = new System.Drawing.Point(778, 48);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(338, 39);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Shop Floor Manager";
            // 
            // GB_Machine
            // 
            this.GB_Machine.Controls.Add(this.Lbl_CurrentMach);
            this.GB_Machine.Controls.Add(this.DGV_Machines);
            this.GB_Machine.Controls.Add(this.GB_AddMach);
            this.GB_Machine.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GB_Machine.Location = new System.Drawing.Point(17, 90);
            this.GB_Machine.Name = "GB_Machine";
            this.GB_Machine.Size = new System.Drawing.Size(875, 381);
            this.GB_Machine.TabIndex = 1;
            this.GB_Machine.TabStop = false;
            this.GB_Machine.Text = "Machines";
            // 
            // Lbl_CurrentMach
            // 
            this.Lbl_CurrentMach.AutoSize = true;
            this.Lbl_CurrentMach.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lbl_CurrentMach.Location = new System.Drawing.Point(15, 166);
            this.Lbl_CurrentMach.Name = "Lbl_CurrentMach";
            this.Lbl_CurrentMach.Size = new System.Drawing.Size(116, 18);
            this.Lbl_CurrentMach.TabIndex = 4;
            this.Lbl_CurrentMach.Text = "Machines In DB:";
            // 
            // DGV_Machines
            // 
            this.DGV_Machines.AllowUserToAddRows = false;
            this.DGV_Machines.AllowUserToDeleteRows = false;
            this.DGV_Machines.AutoGenerateColumns = false;
            this.DGV_Machines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Machines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineNameDataGridViewTextBoxColumn});
            this.DGV_Machines.DataSource = this.machinesBindingSource;
            this.DGV_Machines.Location = new System.Drawing.Point(17, 203);
            this.DGV_Machines.Name = "DGV_Machines";
            this.DGV_Machines.ReadOnly = true;
            this.DGV_Machines.Size = new System.Drawing.Size(519, 150);
            this.DGV_Machines.TabIndex = 3;
            // 
            // machineNameDataGridViewTextBoxColumn
            // 
            this.machineNameDataGridViewTextBoxColumn.DataPropertyName = "Machine_Name";
            this.machineNameDataGridViewTextBoxColumn.HeaderText = "Machine_Name";
            this.machineNameDataGridViewTextBoxColumn.Name = "machineNameDataGridViewTextBoxColumn";
            this.machineNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machinesBindingSource
            // 
            this.machinesBindingSource.DataMember = "Machines";
            this.machinesBindingSource.DataSource = this.magmaDataSet1;
            // 
            // magmaDataSet1
            // 
            this.magmaDataSet1.DataSetName = "MagmaDataSet1";
            this.magmaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GB_AddMach
            // 
            this.GB_AddMach.Controls.Add(this.Btn_AddMach);
            this.GB_AddMach.Controls.Add(this.Lbl_MachName);
            this.GB_AddMach.Controls.Add(this.Txt_Machine);
            this.GB_AddMach.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GB_AddMach.Location = new System.Drawing.Point(8, 26);
            this.GB_AddMach.Name = "GB_AddMach";
            this.GB_AddMach.Size = new System.Drawing.Size(528, 104);
            this.GB_AddMach.TabIndex = 2;
            this.GB_AddMach.TabStop = false;
            this.GB_AddMach.Text = "Add New machine";
            // 
            // Btn_AddMach
            // 
            this.Btn_AddMach.Location = new System.Drawing.Point(231, 75);
            this.Btn_AddMach.Name = "Btn_AddMach";
            this.Btn_AddMach.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddMach.TabIndex = 2;
            this.Btn_AddMach.Text = "Add";
            this.Btn_AddMach.UseVisualStyleBackColor = true;
            this.Btn_AddMach.Click += new System.EventHandler(this.Btn_AddMach_Click);
            // 
            // Lbl_MachName
            // 
            this.Lbl_MachName.AutoSize = true;
            this.Lbl_MachName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lbl_MachName.Location = new System.Drawing.Point(6, 27);
            this.Lbl_MachName.Name = "Lbl_MachName";
            this.Lbl_MachName.Size = new System.Drawing.Size(110, 18);
            this.Lbl_MachName.TabIndex = 1;
            this.Lbl_MachName.Text = "Machine Name:";
            // 
            // Txt_Machine
            // 
            this.Txt_Machine.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Txt_Machine.Location = new System.Drawing.Point(133, 19);
            this.Txt_Machine.Name = "Txt_Machine";
            this.Txt_Machine.Size = new System.Drawing.Size(173, 26);
            this.Txt_Machine.TabIndex = 0;
            // 
            // GB_Items
            // 
            this.GB_Items.Controls.Add(this.DGV_Items);
            this.GB_Items.Controls.Add(this.label3);
            this.GB_Items.Controls.Add(this.groupBox1);
            this.GB_Items.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GB_Items.Location = new System.Drawing.Point(951, 90);
            this.GB_Items.Name = "GB_Items";
            this.GB_Items.Size = new System.Drawing.Size(875, 381);
            this.GB_Items.TabIndex = 2;
            this.GB_Items.TabStop = false;
            this.GB_Items.Text = "Items";
            // 
            // DGV_Items
            // 
            this.DGV_Items.AllowUserToAddRows = false;
            this.DGV_Items.AllowUserToDeleteRows = false;
            this.DGV_Items.AutoGenerateColumns = false;
            this.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catalogNumberDataGridViewTextBoxColumn,
            this.itemDescDataGridViewTextBoxColumn});
            this.DGV_Items.DataSource = this.itemBindingSource;
            this.DGV_Items.Location = new System.Drawing.Point(21, 203);
            this.DGV_Items.Name = "DGV_Items";
            this.DGV_Items.ReadOnly = true;
            this.DGV_Items.Size = new System.Drawing.Size(519, 150);
            this.DGV_Items.TabIndex = 6;
            // 
            // catalogNumberDataGridViewTextBoxColumn
            // 
            this.catalogNumberDataGridViewTextBoxColumn.DataPropertyName = "Catalog_Number";
            this.catalogNumberDataGridViewTextBoxColumn.HeaderText = "Catalog_Number";
            this.catalogNumberDataGridViewTextBoxColumn.Name = "catalogNumberDataGridViewTextBoxColumn";
            this.catalogNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDescDataGridViewTextBoxColumn
            // 
            this.itemDescDataGridViewTextBoxColumn.DataPropertyName = "Item_Desc";
            this.itemDescDataGridViewTextBoxColumn.HeaderText = "Item_Desc";
            this.itemDescDataGridViewTextBoxColumn.Name = "itemDescDataGridViewTextBoxColumn";
            this.itemDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.AllowNew = false;
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.magmaDataSet;
            // 
            // magmaDataSet
            // 
            this.magmaDataSet.DataSetName = "MagmaDataSet";
            this.magmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(18, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Items In DB:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_ItemDesc);
            this.groupBox1.Controls.Add(this.Btn_AddItem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_ItemNum);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Description:";
            // 
            // Txt_ItemDesc
            // 
            this.Txt_ItemDesc.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Txt_ItemDesc.Location = new System.Drawing.Point(133, 51);
            this.Txt_ItemDesc.Name = "Txt_ItemDesc";
            this.Txt_ItemDesc.Size = new System.Drawing.Size(173, 26);
            this.Txt_ItemDesc.TabIndex = 3;
            // 
            // Btn_AddItem
            // 
            this.Btn_AddItem.Location = new System.Drawing.Point(231, 102);
            this.Btn_AddItem.Name = "Btn_AddItem";
            this.Btn_AddItem.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddItem.TabIndex = 2;
            this.Btn_AddItem.Text = "Add";
            this.Btn_AddItem.UseVisualStyleBackColor = true;
            this.Btn_AddItem.Click += new System.EventHandler(this.Btn_AddItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catalog Number:";
            // 
            // Txt_ItemNum
            // 
            this.Txt_ItemNum.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Txt_ItemNum.Location = new System.Drawing.Point(133, 19);
            this.Txt_ItemNum.Name = "Txt_ItemNum";
            this.Txt_ItemNum.Size = new System.Drawing.Size(173, 26);
            this.Txt_ItemNum.TabIndex = 0;
            // 
            // GB_WrkOrd
            // 
            this.GB_WrkOrd.Controls.Add(this.Lbl_wrkOrds);
            this.GB_WrkOrd.Controls.Add(this.DGV_WrkOrds);
            this.GB_WrkOrd.Controls.Add(this.GB_AddWrkOrd);
            this.GB_WrkOrd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GB_WrkOrd.Location = new System.Drawing.Point(300, 490);
            this.GB_WrkOrd.Name = "GB_WrkOrd";
            this.GB_WrkOrd.Size = new System.Drawing.Size(1389, 460);
            this.GB_WrkOrd.TabIndex = 2;
            this.GB_WrkOrd.TabStop = false;
            this.GB_WrkOrd.Text = "Work Orders";
            // 
            // Lbl_wrkOrds
            // 
            this.Lbl_wrkOrds.AutoSize = true;
            this.Lbl_wrkOrds.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lbl_wrkOrds.Location = new System.Drawing.Point(12, 277);
            this.Lbl_wrkOrds.Name = "Lbl_wrkOrds";
            this.Lbl_wrkOrds.Size = new System.Drawing.Size(96, 18);
            this.Lbl_wrkOrds.TabIndex = 8;
            this.Lbl_wrkOrds.Text = "Work Orders:";
            // 
            // DGV_WrkOrds
            // 
            this.DGV_WrkOrds.AllowUserToAddRows = false;
            this.DGV_WrkOrds.AllowUserToDeleteRows = false;
            this.DGV_WrkOrds.AutoGenerateColumns = false;
            this.DGV_WrkOrds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_WrkOrds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordNumDataGridViewTextBoxColumn,
            this.itemNumDataGridViewTextBoxColumn,
            this.machineDataGridViewTextBoxColumn,
            this.qTYDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.userCodeDataGridViewTextBoxColumn,
            this.langCodeDataGridViewTextBoxColumn});
            this.DGV_WrkOrds.DataSource = this.wrkOrdsBindingSource;
            this.DGV_WrkOrds.Location = new System.Drawing.Point(12, 298);
            this.DGV_WrkOrds.Name = "DGV_WrkOrds";
            this.DGV_WrkOrds.ReadOnly = true;
            this.DGV_WrkOrds.Size = new System.Drawing.Size(1345, 150);
            this.DGV_WrkOrds.TabIndex = 7;
            // 
            // ordNumDataGridViewTextBoxColumn
            // 
            this.ordNumDataGridViewTextBoxColumn.DataPropertyName = "Ord_Num";
            this.ordNumDataGridViewTextBoxColumn.HeaderText = "Ord_Num";
            this.ordNumDataGridViewTextBoxColumn.Name = "ordNumDataGridViewTextBoxColumn";
            this.ordNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNumDataGridViewTextBoxColumn
            // 
            this.itemNumDataGridViewTextBoxColumn.DataPropertyName = "Item_Num";
            this.itemNumDataGridViewTextBoxColumn.HeaderText = "Item_Num";
            this.itemNumDataGridViewTextBoxColumn.Name = "itemNumDataGridViewTextBoxColumn";
            this.itemNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineDataGridViewTextBoxColumn
            // 
            this.machineDataGridViewTextBoxColumn.DataPropertyName = "Machine";
            this.machineDataGridViewTextBoxColumn.HeaderText = "Machine";
            this.machineDataGridViewTextBoxColumn.Name = "machineDataGridViewTextBoxColumn";
            this.machineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qTYDataGridViewTextBoxColumn
            // 
            this.qTYDataGridViewTextBoxColumn.DataPropertyName = "QTY";
            this.qTYDataGridViewTextBoxColumn.HeaderText = "QTY";
            this.qTYDataGridViewTextBoxColumn.Name = "qTYDataGridViewTextBoxColumn";
            this.qTYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userCodeDataGridViewTextBoxColumn
            // 
            this.userCodeDataGridViewTextBoxColumn.DataPropertyName = "User_Code";
            this.userCodeDataGridViewTextBoxColumn.HeaderText = "User_Code";
            this.userCodeDataGridViewTextBoxColumn.Name = "userCodeDataGridViewTextBoxColumn";
            this.userCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // langCodeDataGridViewTextBoxColumn
            // 
            this.langCodeDataGridViewTextBoxColumn.DataPropertyName = "Lang_Code";
            this.langCodeDataGridViewTextBoxColumn.HeaderText = "Lang_Code";
            this.langCodeDataGridViewTextBoxColumn.Name = "langCodeDataGridViewTextBoxColumn";
            this.langCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wrkOrdsBindingSource
            // 
            this.wrkOrdsBindingSource.DataMember = "WrkOrds";
            this.wrkOrdsBindingSource.DataSource = this.magmaDataSet4;
            // 
            // magmaDataSet4
            // 
            this.magmaDataSet4.DataSetName = "MagmaDataSet4";
            this.magmaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GB_AddWrkOrd
            // 
            this.GB_AddWrkOrd.Controls.Add(this.Txt_Qty);
            this.GB_AddWrkOrd.Controls.Add(this.CB_CatNum);
            this.GB_AddWrkOrd.Controls.Add(this.CB_MachName);
            this.GB_AddWrkOrd.Controls.Add(this.label6);
            this.GB_AddWrkOrd.Controls.Add(this.label4);
            this.GB_AddWrkOrd.Controls.Add(this.BTN_AddWrkOrd);
            this.GB_AddWrkOrd.Controls.Add(this.label5);
            this.GB_AddWrkOrd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GB_AddWrkOrd.Location = new System.Drawing.Point(12, 36);
            this.GB_AddWrkOrd.Name = "GB_AddWrkOrd";
            this.GB_AddWrkOrd.Size = new System.Drawing.Size(380, 153);
            this.GB_AddWrkOrd.TabIndex = 4;
            this.GB_AddWrkOrd.TabStop = false;
            this.GB_AddWrkOrd.Text = "Add New Work Order";
            // 
            // Txt_Qty
            // 
            this.Txt_Qty.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Txt_Qty.Location = new System.Drawing.Point(150, 89);
            this.Txt_Qty.Name = "Txt_Qty";
            this.Txt_Qty.Size = new System.Drawing.Size(173, 26);
            this.Txt_Qty.TabIndex = 8;
            this.Txt_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Qty_KeyPress);
            // 
            // CB_CatNum
            // 
            this.CB_CatNum.DataSource = this.itemBindingSource1;
            this.CB_CatNum.DisplayMember = "Item_Desc";
            this.CB_CatNum.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.CB_CatNum.FormattingEnabled = true;
            this.CB_CatNum.Location = new System.Drawing.Point(150, 59);
            this.CB_CatNum.Name = "CB_CatNum";
            this.CB_CatNum.Size = new System.Drawing.Size(173, 26);
            this.CB_CatNum.TabIndex = 7;
            this.CB_CatNum.ValueMember = "Catalog_Number";
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "Item";
            this.itemBindingSource1.DataSource = this.magmaDataSet3;
            // 
            // magmaDataSet3
            // 
            this.magmaDataSet3.DataSetName = "MagmaDataSet3";
            this.magmaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CB_MachName
            // 
            this.CB_MachName.DataSource = this.machinesBindingSource1;
            this.CB_MachName.DisplayMember = "Machine_Name";
            this.CB_MachName.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.CB_MachName.FormattingEnabled = true;
            this.CB_MachName.Location = new System.Drawing.Point(150, 27);
            this.CB_MachName.Name = "CB_MachName";
            this.CB_MachName.Size = new System.Drawing.Size(173, 26);
            this.CB_MachName.TabIndex = 6;
            this.CB_MachName.ValueMember = "Machine_Name";
            // 
            // machinesBindingSource1
            // 
            this.machinesBindingSource1.DataMember = "Machines";
            this.machinesBindingSource1.DataSource = this.magmaDataSet2;
            // 
            // magmaDataSet2
            // 
            this.magmaDataSet2.DataSetName = "MagmaDataSet2";
            this.magmaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Catalog Number:";
            // 
            // BTN_AddWrkOrd
            // 
            this.BTN_AddWrkOrd.Location = new System.Drawing.Point(212, 121);
            this.BTN_AddWrkOrd.Name = "BTN_AddWrkOrd";
            this.BTN_AddWrkOrd.Size = new System.Drawing.Size(75, 23);
            this.BTN_AddWrkOrd.TabIndex = 2;
            this.BTN_AddWrkOrd.Text = "Add";
            this.BTN_AddWrkOrd.UseVisualStyleBackColor = true;
            this.BTN_AddWrkOrd.Click += new System.EventHandler(this.BTN_AddWrkOrd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Machine Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1916, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(1630, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 16);
            this.label7.TabIndex = 250;
            this.label7.Text = "Shop Floor Manager By Ran Oichman  -  V1.0.0";
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // machinesTableAdapter
            // 
            this.machinesTableAdapter.ClearBeforeFill = true;
            // 
            // machinesTableAdapter1
            // 
            this.machinesTableAdapter1.ClearBeforeFill = true;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // wrkOrdsTableAdapter
            // 
            this.wrkOrdsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1916, 985);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GB_WrkOrd);
            this.Controls.Add(this.GB_Items);
            this.Controls.Add(this.GB_Machine);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shop Floor Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_Machine.ResumeLayout(false);
            this.GB_Machine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Machines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet1)).EndInit();
            this.GB_AddMach.ResumeLayout(false);
            this.GB_AddMach.PerformLayout();
            this.GB_Items.ResumeLayout(false);
            this.GB_Items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB_WrkOrd.ResumeLayout(false);
            this.GB_WrkOrd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_WrkOrds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrkOrdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet4)).EndInit();
            this.GB_AddWrkOrd.ResumeLayout(false);
            this.GB_AddWrkOrd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magmaDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.GroupBox GB_Machine;
        private System.Windows.Forms.GroupBox GB_Items;
        private System.Windows.Forms.GroupBox GB_WrkOrd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_CurrentMach;
        private System.Windows.Forms.DataGridView DGV_Machines;
        private System.Windows.Forms.GroupBox GB_AddMach;
        private System.Windows.Forms.Button Btn_AddMach;
        private System.Windows.Forms.Label Lbl_MachName;
        private System.Windows.Forms.TextBox Txt_Machine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_ItemDesc;
        private System.Windows.Forms.Button Btn_AddItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ItemNum;
        private System.Windows.Forms.DataGridView DGV_Items;
        private MagmaDataSet magmaDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private MagmaDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescDataGridViewTextBoxColumn;
        private MagmaDataSet1 magmaDataSet1;
        private System.Windows.Forms.BindingSource machinesBindingSource;
        private MagmaDataSet1TableAdapters.MachinesTableAdapter machinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox GB_AddWrkOrd;
        private System.Windows.Forms.Button BTN_AddWrkOrd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Qty;
        private System.Windows.Forms.ComboBox CB_CatNum;
        private System.Windows.Forms.ComboBox CB_MachName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private MagmaDataSet2 magmaDataSet2;
        private System.Windows.Forms.BindingSource machinesBindingSource1;
        private MagmaDataSet2TableAdapters.MachinesTableAdapter machinesTableAdapter1;
        private MagmaDataSet3 magmaDataSet3;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private MagmaDataSet3TableAdapters.ItemTableAdapter itemTableAdapter1;
        private System.Windows.Forms.Label Lbl_wrkOrds;
        private System.Windows.Forms.DataGridView DGV_WrkOrds;
        private MagmaDataSet4 magmaDataSet4;
        private System.Windows.Forms.BindingSource wrkOrdsBindingSource;
        private MagmaDataSet4TableAdapters.WrkOrdsTableAdapter wrkOrdsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn langCodeDataGridViewTextBoxColumn;
    }
}

