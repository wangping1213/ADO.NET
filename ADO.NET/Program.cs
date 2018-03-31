using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ADO.NET
{
    class Program
    {

        #region 【1】数据库的打开与关闭
        //static void Main(string[] args)
        //{
        //    // [1]定义连接字符串
        //    string connString1 = "Data Source=.;Initial Catalog=StudentManageDB;Integrated Security=True";
        //    string connString2 = "Server=localhost;DataBase=StudentManageDB;Uid=sa;Pwd=Sa123456";

        //    //【2】创建数据库连接对象
        //    SqlConnection conn = new SqlConnection(connString2);

        //    //【3】打开数据库连接
        //    conn.Open();

        //    if (conn.State == ConnectionState.Open)
        //    {
        //        Console.WriteLine("DB is Open!");
        //    }

        //    //【4】关闭数据库连接
        //    conn.Close();

        //    if (conn.State == ConnectionState.Closed)
        //    {
        //        Console.WriteLine("DB is Closed!");
        //    }
        //    Console.Read();
        //}
        #endregion

        #region 【2】添加、修改、删除
        //static void Main(string[] args)
        //{
        //    // [1]定义连接字符串
        //    string connString = "Server=127.0.0.1,1433;DataBase=StudentManageDB;Uid=sa;Pwd=Sa123456";

        //    //【2】创建数据库连接对象
        //    SqlConnection conn = new SqlConnection(connString);

        //    //【3】打开数据库连接
        //    conn.Open();

        //    if (conn.State == ConnectionState.Open)
        //    {
        //        Console.WriteLine("DB is Open!");
        //    }

        //    //【4】封装要执行的操作
        //    string sql = "";
        //    SqlCommand cmd = null;
        //    int result = 0;

        //    //插入操作
        //    //sql = string.Format("insert into Course(CourseName, CourseHour, Teacher) values('{0}', {1}, '{2}')", "操作系统课程", 27, "老师");
        //    //cmd = new SqlCommand(sql, conn);
        //    //result = cmd.ExecuteNonQuery();
        //    //Console.WriteLine("insert rows:{0}", result);

        //    //修改操作
        //    //sql = string.Format("update Course set Teacher='{0}' where CourseId={1}", "翟老师", 10002);
        //    //cmd = new SqlCommand(sql, conn);
        //    //result = cmd.ExecuteNonQuery();
        //    //Console.WriteLine("update rows:{0}", result);

        //    ////删除操作
        //    sql = string.Format("delete from Course where CourseId={0}", 10002);
        //    cmd = new SqlCommand(sql, conn);
        //    result = cmd.ExecuteNonQuery();
        //    Console.WriteLine("delete rows:{0}", result);


        //    //SqlCommand cmd = new SqlCommand();
        //    //cmd.CommandText = sql;
        //    //cmd.Connection = conn;



        //    //【5】关闭数据库连接
        //    conn.Close();

        //    if (conn.State == ConnectionState.Closed)
        //    {
        //        Console.WriteLine("DB is Closed!");
        //    }
        //    Console.Read();
        //}
        #endregion

        #region 【3】执行查询（单一查询）
        //static void Main(string[] args)
        //{
        //    // [1]定义连接字符串
        //    string connString = "Server=127.0.0.1,1433;DataBase=StudentManageDB;Uid=sa;Pwd=Sa123456";

        //    //【2】创建数据库连接对象
        //    SqlConnection conn = new SqlConnection(connString);

        //    //【3】打开数据库连接
        //    conn.Open();

        //    if (conn.State == ConnectionState.Open)
        //    {
        //        Console.WriteLine("DB is Open!");
        //    }

        //    //【4】查询返回结果中第一条数据
        //    string sql = "select count(1) from Course";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    object result = cmd.ExecuteScalar();

        //    Console.WriteLine("Course rows:{0}", result);



        //    //【5】关闭数据库连接
        //    conn.Close();

        //    if (conn.State == ConnectionState.Closed)
        //    {
        //        Console.WriteLine("DB is Closed!");
        //    }
        //    Console.Read();
        //}
        #endregion

        #region 【4】执行insert同时返回标识列的值
        //static void Main(string[] args)
        //{
        //    // [1]定义连接字符串
        //    string connString = "Server=127.0.0.1,1433;DataBase=StudentManageDB;Uid=sa;Pwd=Sa123456";

        //    //【2】创建数据库连接对象
        //    SqlConnection conn = new SqlConnection(connString);

        //    //【3】打开数据库连接
        //    conn.Open();

        //    if (conn.State == ConnectionState.Open)
        //    {
        //        Console.WriteLine("DB is Open!");
        //    }

        //    //【4】查询返回结果中第一条数据
        //    string sql = sql = string.Format("insert into Course(CourseName, CourseHour, Teacher) values('{0}', {1}, '{2}')", "操作系统课程22", 29, "何老师");
        //    sql += ";select @@identity";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    object result = cmd.ExecuteScalar();

        //    Console.WriteLine("new CourseId:{0}", result);



        //    //【5】关闭数据库连接
        //    conn.Close();

        //    if (conn.State == ConnectionState.Closed)
        //    {
        //        Console.WriteLine("DB is Closed!");
        //    }
        //    Console.Read();
        //}
        #endregion

        #region 【5】返回一个只读结果集的查询

        //static void Main(string[] args)
        //{
        //    // [1]定义连接字符串
        //    string connString = "Server=127.0.0.1,1433;DataBase=StudentManageDB;Uid=sa;Pwd=Sa123456";

        //    //【2】创建数据库连接对象
        //    SqlConnection conn = new SqlConnection(connString);

        //    //【3】打开数据库连接
        //    conn.Open();

        //    if (conn.State == ConnectionState.Open)
        //    {
        //        Console.WriteLine("DB is Open!");
        //    }

        //    //【4】查询返回只读结果集
        //    string sql = "select CourseId, CourseName, CourseHour, Teacher from Course";
        //    sql += ";select 课程数量=count(1) from Course";
        //    SqlCommand cmd = new SqlCommand(sql, conn);

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Console.WriteLine("CourseId:{0}, CourseName:{1}, CourseHour:{2}, Tearcher:{3}",
        //            reader["CourseId"], reader["CourseName"], reader["CourseHour"], reader["Teacher"]);
        //    }

        //    //判断是否还有下一个结果集
        //    if (reader.NextResult())
        //    {
        //        while (reader.Read())
        //        {
        //            Console.WriteLine("课程数量:{0}", reader["课程数量"]);
        //        }
        //    }

        //    //【5】关闭数据库连接
        //    conn.Close();

        //    if (conn.State == ConnectionState.Closed)
        //    {
        //        Console.WriteLine("DB is Closed!");
        //    }
        //    Console.Read();
        //}

        #endregion

        #region 【6】返回一个内存结果集的查询，查询结果保存在内存中，合适客户端程序，不适合web程序

        //static void Main(string[] args)
        //{
        //    // [1]定义连接字符串
        //    string connString = "Server=127.0.0.1,1433;DataBase=StudentManageDB;Uid=sa;Pwd=Sa123456";

        //    //【2】创建数据库连接对象
        //    SqlConnection conn = new SqlConnection(connString);

        //    //【3】打开数据库连接
        //    conn.Open();

        //    if (conn.State == ConnectionState.Open)
        //    {
        //        Console.WriteLine("DB is Open!");
        //    }

        //    //【4】查询返回内存结果集
        //    string sql = "select CourseId, CourseName, CourseHour, Teacher from Course";
        //    sql += ";select 课程数量=count(1) from Course";
        //    SqlCommand cmd = new SqlCommand(sql, conn);

        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();//创建一个内存数据库（可以像数据库一样，里面包含若干的数据表、表的结构和表间关系）
        //    adapter.Fill(ds);

        //    DataTable dt1 = ds.Tables[0];
        //    DataTable dt2 = ds.Tables[1];

        //    foreach (DataRow row in dt1.Rows)
        //    {
        //        Console.WriteLine("CourseId:{0}, CourseName:{1}, CourseHour:{2}, Tearcher:{3}",
        //            row["CourseId"], row["CourseName"], row["CourseHour"], row["Teacher"]);
        //    }


        //    foreach (DataRow row in dt2.Rows)
        //    {
        //        Console.WriteLine("课程数量:{0}", row["课程数量"]);
        //    }

        //    //【5】关闭数据库连接
        //    conn.Close();

        //    if (conn.State == ConnectionState.Closed)
        //    {
        //        Console.WriteLine("DB is Closed!");
        //    }
        //    Console.Read();
        //}

        #endregion

        #region 【7】返回一个内存结果集，导入导出xml文件

        static void Main(string[] args)
        {
            // [1]定义连接字符串
            string connString = "Server=127.0.0.1,1433;DataBase=StudentManageDB;Uid=sa;Pwd=Sa123456";

            //【2】创建数据库连接对象
            SqlConnection conn = new SqlConnection(connString);

            //【3】打开数据库连接
            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("DB is Open!");
            }

            //【4】查询返回只读结果集
            string sql = "select CourseId, CourseName, CourseHour, Teacher from Course";
            SqlCommand cmd = new SqlCommand(sql, conn);


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();//创建一个内存数据库（可以像数据库一样，里面包含若干的数据表、表的结构和表间关系）
            adapter.Fill(ds);

            DataTable dt1 = ds.Tables[0];
            dt1.WriteXml("d1.xml", XmlWriteMode.WriteSchema);//将内存结果集的数据和结构写入到xml文件中

            DataTable dt2 = new DataTable();
            dt2.ReadXml("d1.xml");

            Console.WriteLine("-----------------------d1结果集------------------------------");
            foreach (DataRow row in dt1.Rows)
            {
                Console.WriteLine("CourseId:{0}, CourseName:{1}, CourseHour:{2}, Tearcher:{3}",
                    row["CourseId"], row["CourseName"], row["CourseHour"], row["Teacher"]);
            }

            Console.WriteLine("-----------------------d2结果集------------------------------");
            foreach (DataRow row in dt2.Rows)
            {
                Console.WriteLine("CourseId:{0}, CourseName:{1}, CourseHour:{2}, Tearcher:{3}",
                    row["CourseId"], row["CourseName"], row["CourseHour"], row["Teacher"]);
            }


            //【5】关闭数据库连接
            conn.Close();

            if (conn.State == ConnectionState.Closed)
            {
                Console.WriteLine("DB is Closed!");
            }
            Console.Read();
        }

        #endregion
    }
}
