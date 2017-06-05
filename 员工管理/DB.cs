using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace 员工管理
{
    class DB
    {
        public DB()
        { }
        public static SqlConnection connection()
        {
            string strCon = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\考勤+身份验证\考勤系统\员工管理\db_Teacher.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection con = new SqlConnection(strCon);
            return con;
        }
    }
}
