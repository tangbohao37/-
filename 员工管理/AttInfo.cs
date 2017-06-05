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
    public partial class AttInfo : Form
    {
        private DataTable _staff;

        public DataTable Staff
        {
            get { return _staff; }
            set { _staff = value; }
        }
        public AttInfo()
        {
            InitializeComponent();
        }

        private void AttInfo_Load(object sender, EventArgs e)
        {
            this.dgvStaff.DataSource = Staff.DefaultView;
            this.dtpStar.Value = DateTime.Now;
            this.dtpEnd.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Star = dtpStar.Value;  //开始打卡时间
            DateTime End= dtpEnd.Value;     //结束打卡时间
            SqlConnection con=new SqlConnection();
            con=DB.connection();
            con.Open();
            for (int i = 0; i < dgvStaff.Rows.Count; i++)
            {
                string id = dgvStaff[2,i].Value.ToString();      //获取相应的值
                string name = dgvStaff[3, i ].Value.ToString();
                string sex = dgvStaff[4, i ].Value.ToString();
                string position = dgvStaff[5, i ].Value.ToString();
                string sqlcmd2 = @"select count(*) from tb_CheckInfo where tName='" + name + "'";
                string sqlcmd = @"insert into tb_CheckInfo (tID ,tName,tSex,tPosition , tCheckStart ,tCheckEnd, tMeeting) values('"+id+"','"+name+"','"+sex+"','"+position+"','"+Star+"','"+End+"','"+textBox1.Text+"')";
                SqlCommand cmd2 = new SqlCommand(sqlcmd2, con);
                int temp= Convert.ToInt32(cmd2.ExecuteScalar());
                if (temp>0)
                {
                    DialogResult dr=MessageBox.Show("已经存在于考勤表，是否跳过","提示",MessageBoxButtons.YesNo);
                    if (dr==DialogResult.OK)
                    {
                        break;
                    }
                    else
                    {
                        return;
                        //string sqlcmd3 = @"update ";
                    }
                }

                SqlCommand cmd = new SqlCommand(sqlcmd, con);
                try
                {   
                    int n = cmd.ExecuteNonQuery();
                    if (n>=0)
                    {
                        MessageBox.Show("存储成功");
                    }
                }
                catch 
                {
                    MessageBox.Show("数据库存储错误");
                }
            }
            con.Close();
            con.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = "现在时间是：" + DateTime.Now ;
        }

        private void dtpStar_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvStaff.Rows.Count; i++)
            {
                dgvStaff[0, i].Value = dtpStar.Value;
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvStaff.Rows.Count; i++)
            {
                dgvStaff[1, i].Value = dtpEnd.Value;
            }
        }

    }
}
