namespace Bin_BB
{
    partial class TTien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_LP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TCong = new System.Windows.Forms.TextBox();
            this.btn_QLai = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_TTien = new System.Windows.Forms.Button();
            this.grB_2 = new System.Windows.Forms.GroupBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.txt_ThemPhi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SNMoi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SDMoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grB_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 421);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tên Loại:";
            // 
            // cbb_LP
            // 
            this.cbb_LP.BackColor = System.Drawing.SystemColors.Window;
            this.cbb_LP.ForeColor = System.Drawing.Color.White;
            this.cbb_LP.FormattingEnabled = true;
            this.cbb_LP.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbb_LP.Location = new System.Drawing.Point(130, 75);
            this.cbb_LP.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_LP.Name = "cbb_LP";
            this.cbb_LP.Size = new System.Drawing.Size(248, 24);
            this.cbb_LP.TabIndex = 1;
            this.cbb_LP.SelectedIndexChanged += new System.EventHandler(this.cbb_LP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 39);
            this.label1.TabIndex = 66;
            this.label1.Text = "Bảng tiền phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Tổng cộng:";
            // 
            // txt_TCong
            // 
            this.txt_TCong.Location = new System.Drawing.Point(642, 597);
            this.txt_TCong.Name = "txt_TCong";
            this.txt_TCong.ReadOnly = true;
            this.txt_TCong.Size = new System.Drawing.Size(161, 22);
            this.txt_TCong.TabIndex = 3;
            // 
            // btn_QLai
            // 
            this.btn_QLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QLai.Location = new System.Drawing.Point(688, 682);
            this.btn_QLai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_QLai.Name = "btn_QLai";
            this.btn_QLai.Size = new System.Drawing.Size(100, 50);
            this.btn_QLai.TabIndex = 4;
            this.btn_QLai.Text = "Quay lại";
            this.btn_QLai.UseVisualStyleBackColor = false;
            this.btn_QLai.Click += new System.EventHandler(this.btn_QLai_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(355, 747);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 17);
            this.label12.TabIndex = 70;
            this.label12.Text = "Nhóm 2 lớp 15DTH11";
            // 
            // btn_TTien
            // 
            this.btn_TTien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_TTien.Location = new System.Drawing.Point(293, 597);
            this.btn_TTien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TTien.Name = "btn_TTien";
            this.btn_TTien.Size = new System.Drawing.Size(100, 50);
            this.btn_TTien.TabIndex = 71;
            this.btn_TTien.Text = "Tính tiền";
            this.btn_TTien.UseVisualStyleBackColor = false;
            this.btn_TTien.Click += new System.EventHandler(this.btn_TTien_Click);
            // 
            // grB_2
            // 
            this.grB_2.Controls.Add(this.btn_OK);
            this.grB_2.Controls.Add(this.txt_ThemPhi);
            this.grB_2.Controls.Add(this.label4);
            this.grB_2.Controls.Add(this.txt_SNMoi);
            this.grB_2.Controls.Add(this.label9);
            this.grB_2.Controls.Add(this.txt_SDMoi);
            this.grB_2.Controls.Add(this.label8);
            this.grB_2.Enabled = false;
            this.grB_2.Location = new System.Drawing.Point(49, 106);
            this.grB_2.Name = "grB_2";
            this.grB_2.Size = new System.Drawing.Size(717, 331);
            this.grB_2.TabIndex = 72;
            this.grB_2.TabStop = false;
            this.grB_2.Text = "Nhập thông tin:";
            this.grB_2.Visible = false;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OK.Location = new System.Drawing.Point(533, 234);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 50);
            this.btn_OK.TabIndex = 72;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_ThemPhi
            // 
            this.txt_ThemPhi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThemPhi.Location = new System.Drawing.Point(279, 178);
            this.txt_ThemPhi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ThemPhi.Name = "txt_ThemPhi";
            this.txt_ThemPhi.Size = new System.Drawing.Size(195, 22);
            this.txt_ThemPhi.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Chi phí phát sinh:";
            // 
            // txt_SNMoi
            // 
            this.txt_SNMoi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SNMoi.Location = new System.Drawing.Point(517, 84);
            this.txt_SNMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SNMoi.Name = "txt_SNMoi";
            this.txt_SNMoi.Size = new System.Drawing.Size(181, 22);
            this.txt_SNMoi.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Số nước:";
            // 
            // txt_SDMoi
            // 
            this.txt_SDMoi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDMoi.Location = new System.Drawing.Point(110, 84);
            this.txt_SDMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDMoi.Name = "txt_SDMoi";
            this.txt_SDMoi.Size = new System.Drawing.Size(163, 22);
            this.txt_SDMoi.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Số điện:";
            // 
            // TTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 773);
            this.Controls.Add(this.grB_2);
            this.Controls.Add(this.btn_TTien);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_QLai);
            this.Controls.Add(this.txt_TCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_LP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TTien";
            this.Text = "TTien";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grB_2.ResumeLayout(false);
            this.grB_2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_LP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TCong;
        private System.Windows.Forms.Button btn_QLai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grB_2;
        private System.Windows.Forms.Button btn_TTien;
        private System.Windows.Forms.TextBox txt_ThemPhi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SNMoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SDMoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_OK;
    }
}