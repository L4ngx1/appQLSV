namespace appQLSV
{
    partial class FormTimKiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.cbbNoiSinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.qLSinhVienDataSet = new appQLSV.QLSinhVienDataSet();
            this.qLSinhVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new appQLSV.QLSinhVienDataSetTableAdapters.SinhVienTableAdapter();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã SV:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSV.Location = new System.Drawing.Point(100, 47);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(363, 25);
            this.txtMaSV.TabIndex = 2;
            // 
            // cbbNoiSinh
            // 
            this.cbbNoiSinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbNoiSinh.FormattingEnabled = true;
            this.cbbNoiSinh.Items.AddRange(new object[] {
            "",
            "Hà Nội",
            "TP Hồ Chí Minh"});
            this.cbbNoiSinh.Location = new System.Drawing.Point(100, 94);
            this.cbbNoiSinh.Name = "cbbNoiSinh";
            this.cbbNoiSinh.Size = new System.Drawing.Size(363, 25);
            this.cbbNoiSinh.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nơi Sinh:";
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(178, 143);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(44, 21);
            this.radioNu.TabIndex = 19;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(100, 143);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(54, 21);
            this.radioNam.TabIndex = 18;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giới Tính:";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoGenerateColumns = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.noiSinhDataGridViewTextBoxColumn});
            this.dgvSinhVien.DataSource = this.sinhVienBindingSource;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 226);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.Size = new System.Drawing.Size(526, 214);
            this.dgvSinhVien.TabIndex = 20;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTimKiem.Location = new System.Drawing.Point(0, 195);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(526, 31);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // qLSinhVienDataSet
            // 
            this.qLSinhVienDataSet.DataSetName = "QLSinhVienDataSet";
            this.qLSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLSinhVienDataSetBindingSource
            // 
            this.qLSinhVienDataSetBindingSource.DataSource = this.qLSinhVienDataSet;
            this.qLSinhVienDataSetBindingSource.Position = 0;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLSinhVienDataSetBindingSource;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noiSinhDataGridViewTextBoxColumn
            // 
            this.noiSinhDataGridViewTextBoxColumn.DataPropertyName = "NoiSinh";
            this.noiSinhDataGridViewTextBoxColumn.HeaderText = "NoiSinh";
            this.noiSinhDataGridViewTextBoxColumn.Name = "noiSinhDataGridViewTextBoxColumn";
            this.noiSinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 440);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.radioNu);
            this.Controls.Add(this.radioNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbNoiSinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaSV);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTimKiem";
            this.Load += new System.EventHandler(this.FormTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cbbNoiSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.BindingSource qLSinhVienDataSetBindingSource;
        private QLSinhVienDataSet qLSinhVienDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLSinhVienDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiSinhDataGridViewTextBoxColumn;
    }
}