using System.Linq.Expressions;
using System.Windows.Forms;

namespace HefdynApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            jScrollPane3 = new DataGridView();
            jTableComp = new DataGridView();
            jLabel13 = new Label();
            jLabel14 = new Label();
            labelResComp = new Label();
            panelNaik = new Panel();
            txtDataNaik = new TextBox();
            labelDataNaik = new Label();
            labelWeightNaik = new Label();
            txtWeightNaik = new TextBox();
            btnEditNaik = new Button();
            btnDeleteNaik = new Button();
            btnAddNaik = new Button();
            jTableNaik = new DataGridView();
            btnRefreshNaik = new Button();
            labelDateNaik = new Label();
            txtDateNaik = new TextBox();
            labelNaik = new Label();
            labelTitleSubNaik = new Label();
            labelSubNaik = new Label();
            panelTurun = new Panel();
            txtDataTurun = new TextBox();
            labelDataTurun = new Label();
            labelWeightTurun = new Label();
            txtWeightTurun = new TextBox();
            btnEditTurun = new Button();
            btnDeleteTurun = new Button();
            btnAddTurun = new Button();
            jTableTurun = new DataGridView();
            btnRefreshTurun = new Button();
            labelDateTurun = new Label();
            txtDateTurun = new TextBox();
            labelTurun = new Label();
            labelTitleSubTurun = new Label();
            labelSubTurun = new Label();
            title = new Label();
            panelTrademark = new Panel();
            txtTrademark = new RichTextBox();
            sheetsName = new ComboBox();
            btnAdd = new Button();
            btnRename = new Button();
            btnRemove = new Button();
            txtSheetsName = new TextBox();
            labelTotal = new Label();
            btnComp = new Button();
            jLabel12 = new Label();
            labelTitleTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)jScrollPane3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jTableComp).BeginInit();
            panelNaik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jTableNaik).BeginInit();
            panelTurun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jTableTurun).BeginInit();
            panelTrademark.SuspendLayout();
            SuspendLayout();
            // 
            // jScrollPane3
            // 
            jScrollPane3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jScrollPane3.Location = new Point(94, 74);
            jScrollPane3.Name = "jScrollPane3";
            jScrollPane3.RowHeadersWidth = 51;
            jScrollPane3.Size = new Size(240, 150);
            jScrollPane3.TabIndex = 0;
            // 
            // jTableComp
            // 
            jTableComp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jTableComp.Location = new Point(29, 59);
            jTableComp.Name = "jTableComp";
            jTableComp.RowHeadersWidth = 51;
            jTableComp.Size = new Size(287, 280);
            jTableComp.TabIndex = 0;
            // 
            // jLabel13
            // 
            jLabel13.AutoSize = true;
            jLabel13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            jLabel13.Location = new Point(94, 9);
            jLabel13.Name = "jLabel13";
            jLabel13.Size = new Size(156, 32);
            jLabel13.TabIndex = 1;
            jLabel13.Text = "COMPOSITE INDEX";
            // 
            // jLabel14
            // 
            jLabel14.AutoSize = true;
            jLabel14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            jLabel14.Location = new Point(144, 345);
            jLabel14.Name = "jLabel14";
            jLabel14.Size = new Size(52, 25);
            jLabel14.TabIndex = 2;
            jLabel14.Text = "- result -";
            // 
            // labelResComp
            // 
            labelResComp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelResComp.Location = new Point(87, 370);
            labelResComp.Name = "labelResComp";
            labelResComp.Size = new Size(170, 29);
            labelResComp.TabIndex = 3;
            labelResComp.Text = "...";
            labelResComp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelNaik
            // 
            panelNaik.BorderStyle = BorderStyle.FixedSingle;
            panelNaik.Controls.Add(txtDataNaik);
            panelNaik.Controls.Add(labelDataNaik);
            panelNaik.Controls.Add(labelWeightNaik);
            panelNaik.Controls.Add(txtWeightNaik);
            panelNaik.Controls.Add(btnEditNaik);
            panelNaik.Controls.Add(btnDeleteNaik);
            panelNaik.Controls.Add(btnAddNaik);
            panelNaik.Controls.Add(jTableNaik);
            panelNaik.Controls.Add(btnRefreshNaik);
            panelNaik.Controls.Add(labelDateNaik);
            panelNaik.Controls.Add(txtDateNaik);
            panelNaik.Controls.Add(labelNaik);
            panelNaik.Controls.Add(labelTitleSubNaik);
            panelNaik.Controls.Add(labelSubNaik);
            panelNaik.Location = new Point(16, 89);
            panelNaik.Margin = new Padding(4, 5, 4, 5);
            panelNaik.Name = "panelNaik";
            panelNaik.Size = new Size(559, 568);
            panelNaik.TabIndex = 0;
            // 
            // txtDataNaik
            // 
            txtDataNaik.Location = new Point(120, 92);
            txtDataNaik.Margin = new Padding(4, 5, 4, 5);
            txtDataNaik.Name = "txtDataNaik";
            txtDataNaik.Size = new Size(220, 27);
            txtDataNaik.TabIndex = 1;
            // 
            // labelDataNaik
            // 
            labelDataNaik.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataNaik.Location = new Point(13, 85);
            labelDataNaik.Margin = new Padding(4, 0, 4, 0);
            labelDataNaik.Name = "labelDataNaik";
            labelDataNaik.Size = new Size(73, 43);
            labelDataNaik.TabIndex = 0;
            labelDataNaik.Text = "DATA";
            // 
            // labelWeightNaik
            // 
            labelWeightNaik.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeightNaik.Location = new Point(13, 131);
            labelWeightNaik.Margin = new Padding(4, 0, 4, 0);
            labelWeightNaik.Name = "labelWeightNaik";
            labelWeightNaik.Size = new Size(108, 43);
            labelWeightNaik.TabIndex = 0;
            labelWeightNaik.Text = "WEIGHT";
            // 
            // txtWeightNaik
            // 
            txtWeightNaik.Location = new Point(120, 138);
            txtWeightNaik.Margin = new Padding(4, 5, 4, 5);
            txtWeightNaik.Name = "txtWeightNaik";
            txtWeightNaik.Size = new Size(220, 27);
            txtWeightNaik.TabIndex = 1;
            // 
            // btnEditNaik
            // 
            btnEditNaik.Location = new Point(400, 85);
            btnEditNaik.Margin = new Padding(4, 5, 4, 5);
            btnEditNaik.Name = "btnEditNaik";
            btnEditNaik.Size = new Size(100, 35);
            btnEditNaik.TabIndex = 2;
            btnEditNaik.Text = "EDIT";
            btnEditNaik.UseVisualStyleBackColor = true;
            btnEditNaik.Click += btnEditNaik_Click;
            // 
            // btnDeleteNaik
            // 
            btnDeleteNaik.Location = new Point(400, 131);
            btnDeleteNaik.Margin = new Padding(4, 5, 4, 5);
            btnDeleteNaik.Name = "btnDeleteNaik";
            btnDeleteNaik.Size = new Size(100, 35);
            btnDeleteNaik.TabIndex = 2;
            btnDeleteNaik.Text = "DELETE";
            btnDeleteNaik.UseVisualStyleBackColor = true;
            btnDeleteNaik.Click += btnDeleteNaik_Click;
            // 
            // btnAddNaik
            // 
            btnAddNaik.Location = new Point(400, 38);
            btnAddNaik.Margin = new Padding(4, 5, 4, 5);
            btnAddNaik.Name = "btnAddNaik";
            btnAddNaik.Size = new Size(100, 35);
            btnAddNaik.TabIndex = 2;
            btnAddNaik.Text = "ADD";
            btnAddNaik.UseVisualStyleBackColor = true;
            btnAddNaik.Click += btnAddNaik_Click;
            // 
            // jTableNaik
            // 
            jTableNaik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jTableNaik.Location = new Point(20, 177);
            jTableNaik.Margin = new Padding(4, 5, 4, 5);
            jTableNaik.Name = "jTableNaik";
            jTableNaik.RowHeadersWidth = 51;
            jTableNaik.Size = new Size(480, 308);
            jTableNaik.TabIndex = 3;
            jTableNaik.CellClick += jTableNaik_CellClick;
            jTableNaik.RowPostPaint += dgGrid_RowPostPaint;
            // 
            // btnRefreshNaik
            // 
            btnRefreshNaik.Location = new Point(400, 492);
            btnRefreshNaik.Margin = new Padding(4, 5, 4, 5);
            btnRefreshNaik.Name = "btnRefreshNaik";
            btnRefreshNaik.Size = new Size(100, 35);
            btnRefreshNaik.TabIndex = 2;
            btnRefreshNaik.Text = "REFRESH";
            btnRefreshNaik.UseVisualStyleBackColor = true;
            btnRefreshNaik.Click += btnRefreshNaik_Click;
            // 
            // labelDateNaik
            // 
            labelDateNaik.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateNaik.Location = new Point(13, 38);
            labelDateNaik.Margin = new Padding(4, 0, 4, 0);
            labelDateNaik.Name = "labelDateNaik";
            labelDateNaik.Size = new Size(73, 43);
            labelDateNaik.TabIndex = 0;
            labelDateNaik.Text = "DATE";
            // 
            // txtDateNaik
            // 
            txtDateNaik.Location = new Point(120, 46);
            txtDateNaik.Margin = new Padding(4, 5, 4, 5);
            txtDateNaik.Name = "txtDateNaik";
            txtDateNaik.Size = new Size(220, 27);
            txtDateNaik.TabIndex = 1;
            // 
            // labelNaik
            // 
            labelNaik.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNaik.Location = new Point(13, 0);
            labelNaik.Margin = new Padding(4, 0, 4, 0);
            labelNaik.Name = "labelNaik";
            labelNaik.Size = new Size(220, 43);
            labelNaik.TabIndex = 0;
            labelNaik.Text = "APPRECIATION";
            // 
            // labelTitleSubNaik
            // 
            labelTitleSubNaik.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleSubNaik.Location = new Point(20, 485);
            labelTitleSubNaik.Margin = new Padding(4, 0, 4, 0);
            labelTitleSubNaik.Name = "labelTitleSubNaik";
            labelTitleSubNaik.Size = new Size(108, 43);
            labelTitleSubNaik.TabIndex = 0;
            labelTitleSubNaik.Text = "Subtotal:";
            // 
            // labelSubNaik
            // 
            labelSubNaik.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubNaik.Location = new Point(136, 490);
            labelSubNaik.Margin = new Padding(4, 0, 4, 0);
            labelSubNaik.Name = "labelSubNaik";
            labelSubNaik.Size = new Size(232, 31);
            labelSubNaik.TabIndex = 1;
            labelSubNaik.Text = "...";
            // 
            // panelTurun
            // 
            panelTurun.BorderStyle = BorderStyle.FixedSingle;
            panelTurun.Controls.Add(txtDataTurun);
            panelTurun.Controls.Add(labelDataTurun);
            panelTurun.Controls.Add(labelWeightTurun);
            panelTurun.Controls.Add(txtWeightTurun);
            panelTurun.Controls.Add(btnEditTurun);
            panelTurun.Controls.Add(btnDeleteTurun);
            panelTurun.Controls.Add(btnAddTurun);
            panelTurun.Controls.Add(jTableTurun);
            panelTurun.Controls.Add(btnRefreshTurun);
            panelTurun.Controls.Add(labelDateTurun);
            panelTurun.Controls.Add(txtDateTurun);
            panelTurun.Controls.Add(labelTurun);
            panelTurun.Controls.Add(labelTitleSubTurun);
            panelTurun.Controls.Add(labelSubTurun);
            panelTurun.Location = new Point(783, 96);
            panelTurun.Margin = new Padding(4, 5, 4, 5);
            panelTurun.Name = "panelTurun";
            panelTurun.Size = new Size(559, 568);
            panelTurun.TabIndex = 0;
            // 
            // txtDataTurun
            // 
            txtDataTurun.Location = new Point(114, 92);
            txtDataTurun.Margin = new Padding(4, 5, 4, 5);
            txtDataTurun.Name = "txtDataTurun";
            txtDataTurun.Size = new Size(226, 27);
            txtDataTurun.TabIndex = 1;
            // 
            // labelDataTurun
            // 
            labelDataTurun.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataTurun.Location = new Point(13, 85);
            labelDataTurun.Margin = new Padding(4, 0, 4, 0);
            labelDataTurun.Name = "labelDataTurun";
            labelDataTurun.Size = new Size(73, 43);
            labelDataTurun.TabIndex = 0;
            labelDataTurun.Text = "DATA";
            // 
            // labelWeightTurun
            // 
            labelWeightTurun.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeightTurun.Location = new Point(13, 131);
            labelWeightTurun.Margin = new Padding(4, 0, 4, 0);
            labelWeightTurun.Name = "labelWeightTurun";
            labelWeightTurun.Size = new Size(103, 43);
            labelWeightTurun.TabIndex = 0;
            labelWeightTurun.Text = "WEIGHT";
            // 
            // txtWeightTurun
            // 
            txtWeightTurun.Location = new Point(114, 138);
            txtWeightTurun.Margin = new Padding(4, 5, 4, 5);
            txtWeightTurun.Name = "txtWeightTurun";
            txtWeightTurun.Size = new Size(226, 27);
            txtWeightTurun.TabIndex = 1;
            // 
            // btnEditTurun
            // 
            btnEditTurun.Location = new Point(400, 85);
            btnEditTurun.Margin = new Padding(4, 5, 4, 5);
            btnEditTurun.Name = "btnEditTurun";
            btnEditTurun.Size = new Size(100, 35);
            btnEditTurun.TabIndex = 2;
            btnEditTurun.Text = "EDIT";
            btnEditTurun.UseVisualStyleBackColor = true;
            btnEditTurun.Click += btnEditTurun_Click;
            // 
            // btnDeleteTurun
            // 
            btnDeleteTurun.Location = new Point(400, 131);
            btnDeleteTurun.Margin = new Padding(4, 5, 4, 5);
            btnDeleteTurun.Name = "btnDeleteTurun";
            btnDeleteTurun.Size = new Size(100, 35);
            btnDeleteTurun.TabIndex = 2;
            btnDeleteTurun.Text = "DELETE";
            btnDeleteTurun.UseVisualStyleBackColor = true;
            btnDeleteTurun.Click += btnDeleteTurun_Click;
            // 
            // btnAddTurun
            // 
            btnAddTurun.Location = new Point(400, 38);
            btnAddTurun.Margin = new Padding(4, 5, 4, 5);
            btnAddTurun.Name = "btnAddTurun";
            btnAddTurun.Size = new Size(100, 35);
            btnAddTurun.TabIndex = 2;
            btnAddTurun.Text = "ADD";
            btnAddTurun.UseVisualStyleBackColor = true;
            btnAddTurun.Click += btnAddTurun_Click;
            // 
            // jTableTurun
            // 
            jTableTurun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jTableTurun.Location = new Point(20, 177);
            jTableTurun.Margin = new Padding(4, 5, 4, 5);
            jTableTurun.Name = "jTableTurun";
            jTableTurun.RowHeadersWidth = 51;
            jTableTurun.Size = new Size(480, 308);
            jTableTurun.TabIndex = 3;
            jTableTurun.CellClick += jTableTurun_CellClick;
            jTableTurun.RowPostPaint += dgGrid_RowPostPaint;
            // 
            // btnRefreshTurun
            // 
            btnRefreshTurun.Location = new Point(400, 492);
            btnRefreshTurun.Margin = new Padding(4, 5, 4, 5);
            btnRefreshTurun.Name = "btnRefreshTurun";
            btnRefreshTurun.Size = new Size(100, 35);
            btnRefreshTurun.TabIndex = 2;
            btnRefreshTurun.Text = "REFRESH";
            btnRefreshTurun.UseVisualStyleBackColor = true;
            btnRefreshTurun.Click += btnRefreshTurun_Click;
            // 
            // labelDateTurun
            // 
            labelDateTurun.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateTurun.Location = new Point(13, 38);
            labelDateTurun.Margin = new Padding(4, 0, 4, 0);
            labelDateTurun.Name = "labelDateTurun";
            labelDateTurun.Size = new Size(73, 43);
            labelDateTurun.TabIndex = 0;
            labelDateTurun.Text = "DATE";
            // 
            // txtDateTurun
            // 
            txtDateTurun.Location = new Point(114, 46);
            txtDateTurun.Margin = new Padding(4, 5, 4, 5);
            txtDateTurun.Name = "txtDateTurun";
            txtDateTurun.Size = new Size(226, 27);
            txtDateTurun.TabIndex = 1;
            // 
            // labelTurun
            // 
            labelTurun.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTurun.Location = new Point(13, 0);
            labelTurun.Margin = new Padding(4, 0, 4, 0);
            labelTurun.Name = "labelTurun";
            labelTurun.Size = new Size(304, 43);
            labelTurun.TabIndex = 0;
            labelTurun.Text = "DEPRECIATION";
            // 
            // labelTitleSubTurun
            // 
            labelTitleSubTurun.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleSubTurun.Location = new Point(20, 485);
            labelTitleSubTurun.Margin = new Padding(4, 0, 4, 0);
            labelTitleSubTurun.Name = "labelTitleSubTurun";
            labelTitleSubTurun.Size = new Size(113, 43);
            labelTitleSubTurun.TabIndex = 0;
            labelTitleSubTurun.Text = "Subtotal:";
            // 
            // labelSubTurun
            // 
            labelSubTurun.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubTurun.Location = new Point(141, 490);
            labelSubTurun.Margin = new Padding(4, 0, 4, 0);
            labelSubTurun.Name = "labelSubTurun";
            labelSubTurun.Size = new Size(238, 31);
            labelSubTurun.TabIndex = 1;
            labelSubTurun.Text = "...";
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(703, 22);
            title.Margin = new Padding(4, 0, 4, 0);
            title.Name = "title";
            title.Size = new Size(328, 45);
            title.TabIndex = 0;
            title.Text = "HEFDYN STATISTICS";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTrademark
            // 
            panelTrademark.BorderStyle = BorderStyle.FixedSingle;
            panelTrademark.Controls.Add(txtTrademark);
            panelTrademark.Location = new Point(83, 667);
            panelTrademark.Margin = new Padding(4, 5, 4, 5);
            panelTrademark.Name = "panelTrademark";
            panelTrademark.Size = new Size(1191, 91);
            panelTrademark.TabIndex = 4;
            // 
            // txtTrademark
            // 
            txtTrademark.BorderStyle = BorderStyle.None;
            txtTrademark.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTrademark.Location = new Point(28, 6);
            txtTrademark.Margin = new Padding(4, 5, 4, 5);
            txtTrademark.Name = "txtTrademark";
            txtTrademark.ReadOnly = true;
            txtTrademark.Size = new Size(1143, 80);
            txtTrademark.TabIndex = 0;
            txtTrademark.Text = resources.GetString("txtTrademark.Text");
            // 
            // sheetsName
            // 
            sheetsName.DropDownStyle = ComboBoxStyle.DropDownList;
            sheetsName.FormattingEnabled = true;
            sheetsName.Items.AddRange(new object[] { "None" });
            sheetsName.Location = new Point(27, 31);
            sheetsName.Margin = new Padding(4, 5, 4, 5);
            sheetsName.Name = "sheetsName";
            sheetsName.Size = new Size(160, 28);
            sheetsName.TabIndex = 5;
            sheetsName.SelectedIndexChanged += sheetsName_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(359, 27);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(467, 27);
            btnRename.Margin = new Padding(4, 5, 4, 5);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(100, 35);
            btnRename.TabIndex = 6;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(575, 27);
            btnRemove.Margin = new Padding(4, 5, 4, 5);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(100, 35);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtSheetsName
            // 
            txtSheetsName.Location = new Point(205, 31);
            txtSheetsName.Margin = new Padding(4, 5, 4, 5);
            txtSheetsName.Name = "txtSheetsName";
            txtSheetsName.Size = new Size(132, 27);
            txtSheetsName.TabIndex = 7;
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(629, 257);
            labelTotal.Margin = new Padding(4, 0, 4, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(100, 35);
            labelTotal.TabIndex = 8;
            labelTotal.Text = "...";
            labelTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnComp
            // 
            btnComp.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnComp.Location = new Point(1064, 22);
            btnComp.Margin = new Padding(4, 5, 4, 5);
            btnComp.Name = "btnComp";
            btnComp.Size = new Size(220, 43);
            btnComp.TabIndex = 6;
            btnComp.Text = "COMPOSITE RESULT";
            btnComp.UseVisualStyleBackColor = true;
            btnComp.Click += btnComp_Click;
            // 
            // jLabel12
            // 
            jLabel12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            jLabel12.Location = new Point(580, 30);
            jLabel12.Name = "jLabel12";
            jLabel12.Size = new Size(55, 28);
            jLabel12.TabIndex = 0;
            jLabel12.Text = "TOTAL";
            // 
            // labelTitleTotal
            // 
            labelTitleTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleTotal.Location = new Point(629, 201);
            labelTitleTotal.Margin = new Padding(4, 0, 4, 0);
            labelTitleTotal.Name = "labelTitleTotal";
            labelTitleTotal.Size = new Size(100, 43);
            labelTitleTotal.TabIndex = 4;
            labelTitleTotal.Text = "TOTAL";
            labelTitleTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 761);
            Controls.Add(labelTitleTotal);
            Controls.Add(labelTotal);
            Controls.Add(txtSheetsName);
            Controls.Add(btnRemove);
            Controls.Add(btnRename);
            Controls.Add(btnComp);
            Controls.Add(btnAdd);
            Controls.Add(sheetsName);
            Controls.Add(panelTrademark);
            Controls.Add(title);
            Controls.Add(panelTurun);
            Controls.Add(panelNaik);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Hefdyn Statistics";
            ((System.ComponentModel.ISupportInitialize)jScrollPane3).EndInit();
            ((System.ComponentModel.ISupportInitialize)jTableComp).EndInit();
            panelNaik.ResumeLayout(false);
            panelNaik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)jTableNaik).EndInit();
            panelTurun.ResumeLayout(false);
            panelTurun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)jTableTurun).EndInit();
            panelTrademark.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView jScrollPane3;
        private DataGridView jTableComp;
        private Label jLabel13;
        private Label jLabel14;
        private Label labelResComp;
        private Panel panelNaik;
        private TextBox txtDataNaik;
        private Label labelDataNaik;
        private Label labelWeightNaik;
        private TextBox txtWeightNaik;
        private Button btnEditNaik;
        private Button btnDeleteNaik;
        private Button btnAddNaik;
        private DataGridView jTableNaik;
        private Button btnRefreshNaik;
        private Label labelDateNaik;
        private TextBox txtDateNaik;
        private Label labelNaik;
        private Label labelTitleSubNaik;
        private Label labelSubNaik;
        private Panel panelTurun;
        private TextBox txtDataTurun;
        private Label labelDataTurun;
        private Label labelWeightTurun;
        private TextBox txtWeightTurun;
        private Button btnEditTurun;
        private Button btnDeleteTurun;
        private Button btnAddTurun;
        private DataGridView jTableTurun;
        private Button btnRefreshTurun;
        private Label labelDateTurun;
        private TextBox txtDateTurun;
        private Label labelTurun;
        private Label labelTitleSubTurun;
        private Label labelSubTurun;
        private Label title;
        private Panel panelTrademark;
        private RichTextBox txtTrademark;
        private ComboBox sheetsName;
        private Button btnAdd;
        private Button btnRename;
        private Button btnRemove;
        private TextBox txtSheetsName;
        private Label labelTotal;
        private Button btnComp;
        private Label jLabel12;
        private Label labelTitleTotal;
    }
}