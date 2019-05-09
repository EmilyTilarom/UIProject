using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UI_Project
{
    class DBQueries
    {
        SqlConnection connection;

        public DBQueries()
        {
            this.connection = CreateConnection();
        }

        public static SqlConnection CreateConnection()
        {
            string constring = "Data Source=DESKTOP-JIHVB1Q\\MSSQLSERVER01;Initial Catalog = PersonalFinance; Integrated Security = True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = constring; 
            return con;
        }

        public static DataTable SelectAllFromTableWithValue(string row, string search)
        {
            DataTable dt = new DataTable();
            SqlConnection con = CreateConnection();
            using (con)
            {
                /*
                SqlCommand command = new SqlCommand("SELECT * FROM CLIENT WHERE @row LIKE @value", con);
                SqlParameter par1 = new SqlParameter("@row", SqlDbType.NVarChar);
                SqlParameter par2 = new SqlParameter("@value", SqlDbType.NVarChar);
                par1.Value = row;
                par2.Value = search;
                command.Parameters.Add(par1);
                command.Parameters.Add(par2);
                */
                SqlCommand command = new SqlCommand("SELECT CLIENT_ID, CLIENT_EGN, CLIENT_NAME, CLIENT_SURNAME, CLIENT_LASTNAME, CLIENT_EMAIL, CLIENT_PHONE FROM CLIENT", con);

                try {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                    else
                    {
                        //error = "No rows";
                    }
                    reader.Close();
                } catch (Exception e)
                {
                    //error = e.Message;
                }

            }
            return dt;
        }

        //public static 




    }
}
