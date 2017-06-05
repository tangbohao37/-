using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 员工管理
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            dgvSelected.AutoGenerateColumns = false;
        }

        public static string str = "";
        public static string strCon = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\考勤+身份验证\考勤系统\员工管理\db_Teacher.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        /// <summary>
        ///  从数据库中导出  资料s
        /// </summary>
        private void showinf()
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select tID as 身份证 , tName as 姓名, tSex as 性别, tPosition as 职务 from tb_TeacherInfo ", conn);
                da.Fill(dt);
                this.dgvInfo.DataSource = dt.DefaultView;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            showinf();
            dgvInfo.Columns[0].ReadOnly = false;
            dgvInfo.Columns[1].ReadOnly = true;
            dgvInfo.Columns[2].ReadOnly = true;
            dgvInfo.Columns[3].ReadOnly = true;
            dgvInfo.Columns[4].ReadOnly = true;
        }
        /// <summary>
        /// 添加人员到数据库 。  并刷新 DGV。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtID.Text=="")
            {
                MessageBox.Show("添加信息不完整");
            }
            if (this.txtName.Text == "")
            {
                MessageBox.Show("添加信息不完整");
            }
            if (this.txtSex.Text == "")
            {
                MessageBox.Show("添加信息不完整");
            }
            if (this.txtPosition.Text == "")
            {
                MessageBox.Show("添加信息不完整");
            }
            using( SqlConnection conn=new SqlConnection(strCon))
            {
                if (conn.State==ConnectionState.Closed)
                {
                    conn.Open();
                }
                try
                {
                    StringBuilder strSQL = new StringBuilder();
                    strSQL.Append("insert into tb_TeacherInfo(tID,tName,tSex,tPosition)");
                    strSQL.Append("values('" + this.txtID.Text.ToString() + "','" + this.txtName.Text.ToString() + "','" + Convert.ToSingle(this.txtSex.Text.Trim().ToString()) + "','" + this.txtPosition.Text.Trim().ToString() + "')");

                    using (SqlCommand cmd = new SqlCommand(strSQL.ToString(), conn))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("添加成功");
                    }
                    strSQL.Remove(0, strSQL.Length);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误" + ex.Message, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                finally
                {
                    if (conn.State==ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
                showinf();
            }
        }
        /// <summary>
        /// 修改 SQL的数据后 刷新DGV
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            using( SqlConnection conn=new SqlConnection(strCon))
            {
                if (this.txtID.Text.ToString()!="")
                {
                    string Str_condition = "";
                    string Str_cmdtxt = "";
                    Str_condition = this.dgvInfo[1, this.dgvInfo.CurrentCell.RowIndex].Value.ToString();
                    Str_cmdtxt = "update tb_TeacherInfo set tName='"+this.txtName.Text.ToString()+"',tSex='"+Convert.ToSingle(this.txtSex.Text.Trim())+"',tPosition='"+this.txtPosition.Text.Trim()+"'"+"where tID='"+Str_condition+"'";
                    try
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        using (SqlCommand com = new SqlCommand(Str_cmdtxt, conn))
                        {
                            com.ExecuteNonQuery();
                            MessageBox.Show("成功");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误", ex.Message);
                    }
                    finally
                    {
                        if (conn.State==ConnectionState.Open)
                        {
                            conn.Close();
                            conn.Dispose();
                        }
                    }
                    showinf();
                }
            }
        }
        /// <summary>
        /// 从数据库 删除 数据 并刷新DGV
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            //重新遍历左边dgv的数据 
            DataTable dt = new DataTable();
            dt = GetDgvToTable(dgvInfo);
            for (int i =dgvSelected.Rows.Count; i > 0; i--)
            {
                //获取行
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgvSelected.Rows[i - 1].Cells[0];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)   // 判断 这一个人是否备选
                {
                    int n = dgvSelected.Rows.Count;
                    //((DataTable)dgvInfo.DataSource).Rows.Add();
                    DataRow r = dt.NewRow();
                    r[0] = dgvSelected[1, i - 1].Value;
                    r[1] = dgvSelected[2, i - 1].Value;
                    r[2] = dgvSelected[3, i - 1].Value;
                    r[3] = dgvSelected[4, i - 1].Value;
                    dt.Rows.Add(r);
                    dgvSelected.Rows.RemoveAt(i - 1);
                    dgvInfo.DataSource = dt.DefaultView;
                    //dgvInfo.Rows.Add(r);
                }
            }
        }
        /// <summary>
        /// 将dgv里的数据 转为datatable
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            for (int count = 1; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                try
                {
                    dt.Columns.Add(dc);
                }
                catch { 
                    
                }
            }
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count-1; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub+1].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        /// <summary>
        /// txt 里显示 鼠标所指 人员的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                str = this.dgvInfo.SelectedCells[0].Value.ToString();
            }
            catch
            { }
            this.txtID.Text = this.dgvInfo[1, this.dgvInfo.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtName.Text = this.dgvInfo[2, this.dgvInfo.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtSex.Text = this.dgvInfo[3, this.dgvInfo.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtPosition.Text = this.dgvInfo[4, this.dgvInfo.CurrentCell.RowIndex].Value.ToString().Trim();
       }
        /// <summary>
        /// 移除 DGVinfor中的 数据 并在 selectedDGV中添加。
        /// 点击时 dgvSelected 和dgvInfo 分别生成一个 datatable   并分别在自己的datatable中操作 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    //n = dgvSelected.Rows.Count;
        //    dt = setTable(dgvSelected);
        //    for (int i = dgvInfo.Rows.Count; i > 0; i--)
        //    {
        //        //获取行
        //        DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgvInfo.Rows[i - 1].Cells[0];
        //        Boolean flag = Convert.ToBoolean(checkCell.Value);
        //        if (flag == true)   // 判断 这一个人是否备选
        //        {
        //            //dgvSelected[0, n - 1].Value = dgvInfo[1, i-1].Value;
        //            //dgvSelected[1, n - 1].Value = dgvInfo[2, i-1].Value;
        //            //dgvSelected[2, n - 1].Value = dgvInfo[3, i-1].Value;
        //            //dgvSelected[3, n - 1].Value = dgvInfo[4, i-1].Value;
        //            DataRow r = dt.NewRow();
        //            r[0] = dgvInfo.Rows[i - 1].Cells[1].Value;
        //            r[1] = dgvInfo.Rows[i - 1].Cells[2].Value;
        //            r[2] = dgvInfo.Rows[i - 1].Cells[3].Value;
        //            r[3] = dgvInfo.Rows[i - 1].Cells[4].Value;
        //            dt.Rows.Add(r);
        //            dgvInfo.Rows.RemoveAt(i - 1);
        //        }
        //    }
        //    //int n = dgvSelected.Rows.Count;
        //    this.dgvSelected.Rows.Clear();
        //    //dgvSelected.DataSource = dt;
        //    //dgvSelected.DataSource = dt.DefaultView;
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        dgvSelected.Rows.Add();
        //        dgvSelected[0, i].Value = dt.Rows[i][0];
        //        dgvSelected[1, i].Value = dt.Rows[i][1];
        //        dgvSelected[2, i].Value = dt.Rows[i][2];
        //        dgvSelected[3, i].Value = dt.Rows[i][3];
        //    }
        //    dt.Rows.Clear();
        //    dt.Dispose();
        //}


        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvInfo.Rows.Count<=0)
            {
                MessageBox.Show("没有被选数据");
                return;
            }
            for (int i = dgvInfo.Rows.Count; i > 0; i--)
            {
                //获取行
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgvInfo.Rows[i - 1].Cells[0];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)   // 判断 这一个人是否备选
                {
                    int n = dgvSelected.Rows.Count;
                    dgvSelected.Rows.Add();
                    dgvSelected[1, n].Value = dgvInfo[1, i - 1].Value;
                    dgvSelected[2, n].Value = dgvInfo[2, i - 1].Value;
                    dgvSelected[3, n].Value = dgvInfo[3, i - 1].Value;
                    dgvSelected[4, n].Value = dgvInfo[4, i - 1].Value;
                    dgvInfo.Rows.RemoveAt(i-1);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Select.SelectedItem.ToString() == "全部")
            {
                showinf();
            }
            else
            {
                show(this.Select.SelectedItem.ToString());
            }
        }

        private void show(string strSql)
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select tID as 身份证 , tName as 姓名, tSex as 性别, tPosition as 职务 from tb_TeacherInfo where tPosition='"+ strSql.Trim()+"'", conn);
                da.Fill(dt);
                this.dgvInfo.DataSource = dt.DefaultView;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = GetDgvToTable(dgvSelected);
            AttInfo att = new AttInfo();
            att.StartPosition = FormStartPosition.CenterParent;
            att.Owner = this;
            att.Staff = dt; 
            att.ShowDialog();

        }
    }
}
