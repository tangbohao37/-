namespace 员工管理
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.选择 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSelected = new System.Windows.Forms.DataGridView();
            this.选择2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.身份证 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职务 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选择});
            this.dgvInfo.Location = new System.Drawing.Point(12, 12);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(409, 274);
            this.dgvInfo.TabIndex = 0;
            this.dgvInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellContentClick);
            // 
            // 选择
            // 
            this.选择.HeaderText = "选择";
            this.选择.Name = "选择";
            this.选择.ReadOnly = true;
            this.选择.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.选择.Width = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "身份证";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "职务";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(249, 313);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(390, 313);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(531, 313);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 21);
            this.txtSex.TabIndex = 6;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(672, 313);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 21);
            this.txtPosition.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "==>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "<==";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "退出";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(427, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(63, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvSelected
            // 
            this.dgvSelected.AllowUserToAddRows = false;
            this.dgvSelected.AllowUserToDeleteRows = false;
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选择2,
            this.身份证,
            this.姓名,
            this.性别,
            this.职务});
            this.dgvSelected.Location = new System.Drawing.Point(499, 12);
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.ReadOnly = true;
            this.dgvSelected.RowTemplate.Height = 23;
            this.dgvSelected.Size = new System.Drawing.Size(449, 274);
            this.dgvSelected.TabIndex = 13;
            // 
            // 选择2
            // 
            this.选择2.HeaderText = "选择";
            this.选择2.Name = "选择2";
            this.选择2.ReadOnly = true;
            // 
            // 身份证
            // 
            this.身份证.HeaderText = "身份证";
            this.身份证.Name = "身份证";
            this.身份证.ReadOnly = true;
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            // 
            // 性别
            // 
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            // 
            // 职务
            // 
            this.职务.HeaderText = "职务";
            this.职务.Name = "职务";
            this.职务.ReadOnly = true;
            // 
            // Select
            // 
            this.Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Select.FormattingEnabled = true;
            this.Select.Items.AddRange(new object[] {
            "全部",
            "教师",
            "领导",
            "中干",
            "职员"});
            this.Select.Location = new System.Drawing.Point(36, 313);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(121, 20);
            this.Select.TabIndex = 15;
            this.Select.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(824, 311);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "设置考勤时间";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 349);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSelected);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = ".";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择;
        private System.Windows.Forms.DataGridView dgvSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职务;
        private System.Windows.Forms.ComboBox Select;
        private System.Windows.Forms.Button button6;
    }
}

