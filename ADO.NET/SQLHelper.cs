using System;

using System.Data;
using System.Data.SqlClient;

namespace ADO.NET
{
    class SQLHelper
    {
        private static string connString = "Server=127.0.0.1,1433;DataBase=StudentManageDB;Uid=sa;Pwd=Sa123456";

        /// <summary>
        /// 执行增删改方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //TODO 可以在这里写日志
                throw new Exception("执行public static int Update(string sql)时报错，错误信息：" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 返回单一结果查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                //TODO 可以在这里写日志
                throw new Exception("执行public object GetSingleResult(string sql)时报错，错误信息：" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 返回只读结果集查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            try
            {
                conn.Open();
                //返回一个关闭时同时关闭connection的只读结果集
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                //TODO 可以在这里写日志
                throw new Exception("执行public object GetSingleResult(string sql)时报错，错误信息：" + e.Message);
            }
        }

        /// <summary>
        /// 返回内存结果集查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                //TODO 可以在这里写日志
                throw new Exception("执行public object GetSingleResult(string sql)时报错，错误信息：" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
