using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataAccess
{
    class ItemAccess
    {
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-C7J5RLQ; DataBase=Masro2; Integrated Security=true;");
        SqlCommand cmd;
        public List<Entity.Item> GetByAll(string word)
        {
            SqlDataReader dr;
            cmd = new SqlCommand("Select * From Masro2.dbo.Item where [Type]+[Location]+[Description] like '%"+word+ "%'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            List<Entity.Item> list = new List<Entity.Item>();
            while (dr.Read())
            {
                list.Add(new Entity.Item(Convert.ToInt32(dr["IID"].ToString()),
                    dr["Type"].ToString(), dr["Location"].ToString(), Convert.ToDateTime(dr["Date"].ToString()), dr["Description"].ToString(), (byte[])dr["Image"]));
            }
            dr.Close();
            cn.Close();
            return list;
        }
        public Entity.Item GetByID(int id)
        {
            /*
            SqlDataReader dr;
            cmd = new SqlCommand("Select * From Masro2.dbo.Item where IID = '" + id + "'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            Entity.Item item = null;
            if (dr.Read())
            {
                item = new Entity.Item(Convert.ToInt32(dr["IID"].ToString()),
                    dr["Type"].ToString(), dr["Location"].ToString(), Convert.ToDateTime(dr["Date"].ToString()), dr["Description"].ToString(), (byte[])dr["Image"]);
            }
            dr.Close();
            cn.Close();
            return item;
            */
            Entity.Item item = null;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            da = new SqlDataAdapter("Select * From Masro2.dbo.Item where IID = '" + id + "'", cn);
            da.Fill(ds);
            
            item = new Entity.Item(Convert.ToInt32(ds.Tables[0].Rows[0]["IID"].ToString()),
            ds.Tables[0].Rows[0]["Type"].ToString(), ds.Tables[0].Rows[0]["Location"].ToString(), 
            Convert.ToDateTime(ds.Tables[0].Rows[0]["Date"].ToString()), ds.Tables[0].Rows[0]["Description"].ToString(),
            (byte[])ds.Tables[0].Rows[0]["Image"]);
            return item;
        }

        public int GetNumberOfItems()
        {
            SqlDataReader dr;
            cmd = new SqlCommand("Select count(*) From Masro2.dbo.Item", cn);
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

        public void AddItem(Entity.Item item1)
        {
            try
            {
                cmd = new SqlCommand(

                "insert into Masro2.dbo.Item (UserName,Type,Location,Date,Image,Description) values ('"+ Program.username +
                "','" + item1.getType() + "','" + item1.getLocation() + "','" + item1.getDate() + "','" + item1.getImage() +
                "','"+ item1.getDescription() + "')", cn);
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

    }

}
