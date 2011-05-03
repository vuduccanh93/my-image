using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using Peekaboo2008.model;


namespace Peekaboo2008.util
{
    public class DataUtil
    {
        protected static SqlConnection conn;
        private static SqlTransaction trans;
        public static Boolean connect()
        {            
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];            
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();                
            }            
            catch (Exception ex)
            {
               // log.Error(ex.Message, ex);
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }


        public static SqlConnection getConnection()
        {
            if (conn == null)
                connect();
            return conn;
        }


        public static DataTable executeStore(string spName, SqlParameter[] arrParam)
        {
            DataTable dt = null;
            if (connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.CommandText = spName;
                    cmd.CommandTimeout = 1000;

                    if (arrParam != null)
                    {
                        foreach (SqlParameter param in arrParam)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    
                    dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);                    
                }
                catch (Exception ex)
                {
                    //log.Error(ex.Message, ex);
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }
            return dt;
        }

        public static Boolean executeNonStore(string spName, SqlParameter[] arrParam)
        {            
            if (connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.CommandText = spName;
                    cmd.CommandTimeout = 1000;

                    if (arrParam != null)
                    {
                        foreach (SqlParameter param in arrParam)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //log.Error(ex.Message, ex);
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }

        public static Boolean executeMultiNonStore(List<QueryModel> _ListQuery)
        {
            SqlCommand cmd = null;
            if (connect())
            {
                try
                {
                    trans = conn.BeginTransaction();
                    foreach (QueryModel _Query in _ListQuery)
                    {
                        cmd = new SqlCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        cmd.CommandText = _Query.SpName;
                        cmd.Transaction = trans;
                        cmd.CommandTimeout = 500;
                        if (_Query.ArrParam != null)
                        {
                            foreach (SqlParameter param in _Query.ArrParam)
                            {
                                cmd.Parameters.Add(param);
                            }
                        }
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    if (trans != null)
                        trans.Rollback();
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }
    }
}
