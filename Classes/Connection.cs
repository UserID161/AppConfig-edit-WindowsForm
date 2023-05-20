using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace AppConfig
{
    
    public class Connection
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        NpgsqlConnection conn = new NpgsqlConnection();

        public Connection()
        {
            conn = new NpgsqlConnection(connectionString);
        }

        public bool isConnection
        {
            get
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                return true;
            }
        }

        public void Execute(string Query)
        {
            
            try
            {
                
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            

        }

        public NpgsqlDataReader Select(string Query)
        {
            try
            {

                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(Query, conn);
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        //public NpgsqlDataAdapter 

    }


}
