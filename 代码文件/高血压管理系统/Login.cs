using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 高血压管理系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lab_密码_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=PatientAccessManagement;Integrated Security=sspi";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $"SELECT COUNT(1) " +
                $"FROM dbo.Users " +
                $"WHERE Number =@Number" +
                $"  AND   Password=@Password";
            SqlParameter sqlParameter1 = new SqlParameter();
            sqlParameter1.ParameterName = "@Number";
            sqlParameter1.Value = this.txb_Number.Text;
            sqlParameter1.SqlDbType = SqlDbType.Char;
            sqlParameter1.Size = 10;
            sqlCommand.Parameters.Add(sqlParameter1);
            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text);
            int rowCount = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (rowCount == 1)
            {
                MessageBox.Show("登录成功。");

            }
            else
            {
                MessageBox.Show("账号/密码有误！");
                this.txb_Password.Focus();
                this.txb_Password.SelectAll();
            }
        }
    }
}
