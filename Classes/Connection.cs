using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.Data.Common;
using System.Security.Cryptography;

namespace AppConfig
{

    public class Connection
    {
            string connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            NpgsqlConnection conn;
            NpgsqlCommand cmd;
            
        public Connection()
            {
                conn = new NpgsqlConnection(connectionString);
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
            }
            public void connectTo(String pconStr)
            {
                conn.ConnectionString = pconStr;
            }
            public void connectTo()
            {
                conn.ConnectionString = connectionString;
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

            void FillGreed(DataGridView dg, NpgsqlDataReader r)
            {
                dg.Columns.Clear();
                for (int i = 0; i < r.FieldCount; i++)
                {
                    dg.Columns.Add("col" + i.ToString(), r.GetName(i));
                 }

                while (r.Read())
                {
                    String[] s = new String[r.FieldCount];
                    for(int i=0; i < r.FieldCount; i++)
                    {
                        s[i] = r[i].ToString();
                    }
                    dg.Rows.Add(s);
                };
                conn.Close();
            }

            public DataTable Sellect(String query)
            {
                try
                {                
                    conn.Open();
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    conn.Close();
                    return dataSet.Tables[0];
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
           public void SellectAll(String tablename, DataGridView dg)
            {
                try
                {
                    cmd.CommandText = "select * from " + tablename;
                    conn.Open();
                    NpgsqlDataReader r = cmd.ExecuteReader();
                    FillGreed(dg,r);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            public List<List<Object>> SellectAll(String tablename)
            {
                try
                {
                    var res = new List<List<Object>>();
                    cmd.CommandText = "select * from " + tablename;
                    conn.Open();
                    NpgsqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        List<Object> row = new List<object>();
                        for (int i = 0; i < r.FieldCount; i++)
                        {
                            row.Add(r[i]);
                        }
                        res.Add(row);
                    };
                    conn.Close();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void ExecSQL(String query)
            {
                try
                {
                    cmd.CommandText = query;
                    conn.Open();
                    cmd.ExecuteNonQuery();                
                    conn.Close();                
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void Insert(String tablename, String[] fields, String[] values)
            {
                try
                {
                    cmd.CommandText = "insert into " +tablename+ "("+String.Join(",",fields)+") values("+String.Join(",",values)+")";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void Delete(String tablename, String del)
            {
                try
                {
                    if (del != "")
                        cmd.CommandText = "DELETE FROM " + tablename + " WHERE " + del;
                    else
                        cmd.CommandText = "DELETE FROM " + tablename;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
    }
}
