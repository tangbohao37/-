namespace 员工管理
{
    partial class AttInfo
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.开始时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dtpStar = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.开始时间,
            this.结束时间});
            this.dgvStaff.Location = new System.Drawing.Point(13, 13);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowTemplate.Height = 23;
            this.dgvStaff.Size = new System.Drawing.Size(444, 352);
            this.dgvStaff.TabIndex = 0;
            // 
            // 开始时间
            // 
            this.开始时间.HeaderText = "开始时间";
            this.开始时间.Name = "开始时间";
            // 
            // 结束时间
            // 
            this.结束时间.HeaderText = "结束时间";
            this.结束时间.Name = "结束时间";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "添加到数据库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpStar
            // 
            this.dtpStar.CustomFormat = "yyyy\'-\'MM\'-\'dd  HH\':\'mm ";
            this.dtpStar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStar.Location = new System.Drawing.Point(502, 53);
            this.dtpStar.Name = "dtpStar";
            this.dtpStar.Size = new System.Drawing.Size(200, 21);
            this.dtpStar.TabIndex = 7;
            this.dtpStar.Value = new System.DateTime(2015, 12, 2, 17, 56, 18, 0);
            this.dtpStar.ValueChanged += new System.EventHandler(this.dtpStar_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy\'-\'MM\'-\'dd  HH\':\'mm ";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(502, 112);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 21);
            this.dtpEnd.TabIndex = 7;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "开始考勤时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "结束考勤时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "label7";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(527, 165);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 45);
            this.textBox1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "会议名称:";
            // 
            // AttInfo
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvStaff);
            this.Name = "AttInfo";
            this.Text = "考勤表";
            this.Load += new System.EventHandler(this.AttInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpStar;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束时间;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}