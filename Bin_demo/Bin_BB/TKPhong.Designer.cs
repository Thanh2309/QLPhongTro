namespace Bin_BB
{
    partial class TKPhong
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbb_LP = new System.Windows.Forms.ComboBox();
            this.btn_TK = new System.Windows.Forms.Button();
            this.cb_LP = new System.Windows.Forms.CheckBox();
            this.cb_TTrang = new System.Windows.Forms.CheckBox();
            this.btn_QLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_TTrang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TPhong = new System.Windows.Forms.TextBox();
            this.cb_TPhong = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(715, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbb_LP
            // 
            this.cbb_LP.BackColor = System.Drawing.SystemColors.Window;
            this.cbb_LP.Enabled = false;
            this.cbb_LP.ForeColor = System.Drawing.Color.White;
            this.cbb_LP.FormattingEnabled = true;
            this.cbb_LP.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbb_LP.Location = new System.Drawing.Point(195, 75);
            this.cbb_LP.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_LP.Name = "cbb_LP";
            this.cbb_LP.Size = new System.Drawing.Size(248, 24);
            this.cbb_LP.TabIndex = 4;
            this.cbb_LP.SelectedIndexChanged += new System.EventHandler(this.cbb_LP_SelectedIndexChanged);
            // 
            // btn_TK
            // 
            this.btn_TK.Enabled = false;
            this.btn_TK.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TK.Location = new System.Drawing.Point(540, 54);
            this.btn_TK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.Size = new System.Drawing.Size(107, 25);
            this.btn_TK.TabIndex = 7;
            this.btn_TK.Text = "Tìm kiếm";
            this.btn_TK.UseVisualStyleBackColor = true;
            this.btn_TK.Click += new System.EventHandler(this.btn_TK_Click);
            // 
            // cb_LP
            // 
            this.cb_LP.AutoSize = true;
            this.cb_LP.Location = new System.Drawing.Point(53, 75);
            this.cb_LP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_LP.Name = "cb_LP";
            this.cb_LP.Size = new System.Drawing.Size(106, 21);
            this.cb_LP.TabIndex = 3;
            this.cb_LP.Text = "Loại Phòng:";
            this.cb_LP.UseVisualStyleBackColor = true;
            this.cb_LP.CheckedChanged += new System.EventHandler(this.cb_LP_CheckedChanged);
            // 
            // cb_TTrang
            // 
            this.cb_TTrang.AutoSize = true;
            this.cb_TTrang.Location = new System.Drawing.Point(53, 38);
            this.cb_TTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_TTrang.Name = "cb_TTrang";
            this.cb_TTrang.Size = new System.Drawing.Size(104, 21);
            this.cb_TTrang.TabIndex = 1;
            this.cb_TTrang.Text = "Tình Trạng:";
            this.cb_TTrang.UseVisualStyleBackColor = true;
            this.cb_TTrang.CheckedChanged += new System.EventHandler(this.cb_TTrang_CheckedChanged);
            // 
            // btn_QLai
            // 
            this.btn_QLai.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLai.Location = new System.Drawing.Point(540, 91);
            this.btn_QLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLai.Name = "btn_QLai";
            this.btn_QLai.Size = new System.Drawing.Size(107, 25);
            this.btn_QLai.TabIndex = 8;
            this.btn_QLai.Text = "Quay lại";
            this.btn_QLai.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 39);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tìm Kiếm Phòng Trọ";
            // 
            // cbb_TTrang
            // 
            this.cbb_TTrang.BackColor = System.Drawing.SystemColors.Window;
            this.cbb_TTrang.Enabled = false;
            this.cbb_TTrang.ForeColor = System.Drawing.Color.White;
            this.cbb_TTrang.FormattingEnabled = true;
            this.cbb_TTrang.Items.AddRange(new object[] {
            "Còn trống",
            "Có người"});
            this.cbb_TTrang.Location = new System.Drawing.Point(195, 35);
            this.cbb_TTrang.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_TTrang.Name = "cbb_TTrang";
            this.cbb_TTrang.Size = new System.Drawing.Size(248, 24);
            this.cbb_TTrang.TabIndex = 2;
            this.cbb_TTrang.SelectedIndexChanged += new System.EventHandler(this.cbb_TTrang_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TPhong);
            this.groupBox1.Controls.Add(this.cb_TPhong);
            this.groupBox1.Controls.Add(this.btn_TK);
            this.groupBox1.Controls.Add(this.cbb_TTrang);
            this.groupBox1.Controls.Add(this.cb_LP);
            this.groupBox1.Controls.Add(this.btn_QLai);
            this.groupBox1.Controls.Add(this.cb_TTrang);
            this.groupBox1.Controls.Add(this.cbb_LP);
            this.groupBox1.Location = new System.Drawing.Point(13, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(756, 166);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm:";
            // 
            // txt_TPhong
            // 
            this.txt_TPhong.Enabled = false;
            this.txt_TPhong.Location = new System.Drawing.Point(195, 110);
            this.txt_TPhong.Name = "txt_TPhong";
            this.txt_TPhong.Size = new System.Drawing.Size(179, 22);
            this.txt_TPhong.TabIndex = 6;
            this.txt_TPhong.TextChanged += new System.EventHandler(this.txt_TPhong_TextChanged);
            // 
            // cb_TPhong
            // 
            this.cb_TPhong.AutoSize = true;
            this.cb_TPhong.Location = new System.Drawing.Point(53, 112);
            this.cb_TPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_TPhong.Name = "cb_TPhong";
            this.cb_TPhong.Size = new System.Drawing.Size(103, 21);
            this.cb_TPhong.TabIndex = 5;
            this.cb_TPhong.Text = "Tên phòng:";
            this.cb_TPhong.UseVisualStyleBackColor = true;
            this.cb_TPhong.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(756, 522);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả:";
            // 
            // TKPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TKPhong";
            this.Text = "Tìm Kiếm Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb_LP;
        private System.Windows.Forms.Button btn_TK;
        private System.Windows.Forms.CheckBox cb_LP;
        private System.Windows.Forms.CheckBox cb_TTrang;
        private System.Windows.Forms.Button btn_QLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_TTrang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_TPhong;
        private System.Windows.Forms.CheckBox cb_TPhong;
    }
}