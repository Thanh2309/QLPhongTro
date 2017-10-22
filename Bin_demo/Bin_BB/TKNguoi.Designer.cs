using System;

namespace Bin_BB
{
    partial class TKNguoi
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
            this.btn_TK = new System.Windows.Forms.Button();
            this.cb_CMND = new System.Windows.Forms.CheckBox();
            this.btn_QLai = new System.Windows.Forms.Button();
            this.cb_Ten = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TK
            // 
            this.btn_TK.Enabled = false;
            this.btn_TK.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TK.Location = new System.Drawing.Point(523, 34);
            this.btn_TK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.Size = new System.Drawing.Size(107, 25);
            this.btn_TK.TabIndex = 5;
            this.btn_TK.Text = "Tìm kiếm";
            this.btn_TK.UseVisualStyleBackColor = true;
            this.btn_TK.Click += new System.EventHandler(this.btn_TK_Click);
            // 
            // cb_CMND
            // 
            this.cb_CMND.AutoSize = true;
            this.cb_CMND.Location = new System.Drawing.Point(53, 33);
            this.cb_CMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_CMND.Name = "cb_CMND";
            this.cb_CMND.Size = new System.Drawing.Size(74, 21);
            this.cb_CMND.TabIndex = 1;
            this.cb_CMND.Text = "CMND:";
            this.cb_CMND.UseVisualStyleBackColor = true;
            this.cb_CMND.CheckedChanged += new System.EventHandler(this.cb_CMND_CheckedChanged);
            // 
            // btn_QLai
            // 
            this.btn_QLai.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLai.Location = new System.Drawing.Point(523, 71);
            this.btn_QLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLai.Name = "btn_QLai";
            this.btn_QLai.Size = new System.Drawing.Size(107, 25);
            this.btn_QLai.TabIndex = 6;
            this.btn_QLai.Text = "Quay lại";
            this.btn_QLai.UseVisualStyleBackColor = true;
            this.btn_QLai.Click += new System.EventHandler(this.btn_QLai_Click);
            // 
            // cb_Ten
            // 
            this.cb_Ten.AutoSize = true;
            this.cb_Ten.Location = new System.Drawing.Point(53, 73);
            this.cb_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Ten.Name = "cb_Ten";
            this.cb_Ten.Size = new System.Drawing.Size(95, 21);
            this.cb_Ten.TabIndex = 3;
            this.cb_Ten.Text = "Họ và tên:";
            this.cb_Ten.UseVisualStyleBackColor = true;
            this.cb_Ten.CheckedChanged += new System.EventHandler(this.cb_Ten_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(212, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 39);
            this.label1.TabIndex = 74;
            this.label1.Text = "Tìm Kiếm Người Trọ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 175);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(756, 467);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Ten);
            this.groupBox1.Controls.Add(this.txt_CMND);
            this.groupBox1.Controls.Add(this.btn_TK);
            this.groupBox1.Controls.Add(this.cb_CMND);
            this.groupBox1.Controls.Add(this.btn_QLai);
            this.groupBox1.Controls.Add(this.cb_Ten);
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(756, 116);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_Ten
            // 
            this.txt_Ten.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Ten.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txt_Ten.Enabled = false;
            this.txt_Ten.Location = new System.Drawing.Point(185, 72);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(241, 22);
            this.txt_Ten.TabIndex = 4;
            this.txt_Ten.TextChanged += new System.EventHandler(this.txt_Ten_TextChanged);
            // 
            // txt_CMND
            // 
            this.txt_CMND.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_CMND.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txt_CMND.Enabled = false;
            this.txt_CMND.Location = new System.Drawing.Point(185, 32);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(129, 22);
            this.txt_CMND.TabIndex = 2;
            this.txt_CMND.TextChanged += new System.EventHandler(this.txt_CMND_TextChanged);
            // 
            // TKNguoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TKNguoi";
            this.Text = "Tìm Kiếm Người";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.Button btn_TK;
        private System.Windows.Forms.CheckBox cb_CMND;
        private System.Windows.Forms.Button btn_QLai;
        private System.Windows.Forms.CheckBox cb_Ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.BindingSource quanLyPhongTroDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNguoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}