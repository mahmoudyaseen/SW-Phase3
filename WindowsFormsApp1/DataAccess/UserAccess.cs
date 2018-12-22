using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataAccess
{
    class UserAccess
    {
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-C7J5RLQ; DataBase=Masro2; Integrated Security=true;");
        SqlCommand cmd;
        public string GetUserPassword (string UserName)
        {
            SqlDataReader dr;
            string password;
            cmd = new SqlCommand("Select Password From Masro2.dbo.Users Where UserName = '" + UserName + "'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
                password = dr["Password"].ToString();
            else
                password = null;
            dr.Close();
            cn.Close();
            return password;
        }
        public void SetNewUser(Entity.User user1)
        {
            try
            {
                cmd = new SqlCommand("insert into Masro2.dbo.Users (Name,Phone,UserName,Password) values ('" + user1.getName() + "','" + user1.getPhone() + "','" + user1.getUserName() + "','" + user1.getPassword() + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //
            }
            finally  
            {
                cn.Close();
            }
        }
        /*public string GetPostOwnerPhone(string UserName)
        {
            SqlDataReader dr;
            string password;
            cmd = new SqlCommand("Select Phone from Masro2.dbo.Users where UID = '" + UserName + "'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
                password = dr["Phone"].ToString();
            else
                password = null;
            dr.Close();
            cn.Close();
            return password;
        }*/

    }
}
