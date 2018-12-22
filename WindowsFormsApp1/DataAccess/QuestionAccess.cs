using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataAccess
{
    class QuestionAccess
    {
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-C7J5RLQ; DataBase=Masro2; Integrated Security=true;");
        private SqlCommand cmd;
        public void AddQuestion(Entity.Question ques , int IID)
        {
            try
            {
                cmd = new SqlCommand(

                "insert into Masro2.dbo.Question (IID , Question) values ('" + IID +"','" + ques.getQues() + "')", cn);
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
        public int GetNumberOfQuestion()
        {
            SqlDataReader dr;
            cmd = new SqlCommand("Select count(*) From Masro2.dbo.Question", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            int count = 0;
            if (dr.Read())
            {
                count = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
            return count;
        }

    }
}
