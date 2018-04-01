using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ADO.NET
{
    /// <summary>
    /// 课程数据访问类
    /// </summary>
    class CourseService
    {
        /// <summary>
        /// 封装添加课程代码
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int AddCourse(Course course)
        {
            string sql = string.Format("insert into Course(CourseName, CourseHour, Teacher) values('{0}', {1}, '{2}')", 
                course.CourseName, course.CourseHour, course.Teacher);
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 封装修改课程代码
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int UpdateCourse(Course course)
        {
            string sql = string.Format("update Course set Teacher='{0}' where CourseId={1}",
                course.Teacher, course.CourseId);
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 封装删除课程代码
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int DeleteCourse(Course course)
        {
            string sql = string.Format("delete from Course where CourseId={0}", course.CourseId);
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 通过只读结果集的方式封装查询方法
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public List<Course> GetCourseListByReader(Course course)
        {
            string sql = "select CourseId, CourseName, CourseHour, Teacher from Course";
            sql += string.Format(" where CourseId>{0}", course.CourseId);
            SqlDataReader reader = SQLHelper.GetReader(sql);
            List<Course> courseList = new List<Course>();
            while (reader.Read())
            {
                courseList.Add(new Course()
                {
                    CourseId = Convert.ToInt32(reader["CourseId"]),
                    CourseHour = Convert.ToInt32(reader["CourseHour"]),
                    Teacher = reader["Teacher"].ToString(),
                    CourseName = reader["CourseName"].ToString()
                });
            }

            reader.Close();
            return courseList;
        }

        /// <summary>
        /// 通过内存数据库的方式查询课程信息（客户端使用）
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public List<Course> GetCourseListByDataSet(Course course)
        {

            string sql = "select CourseId, CourseName, CourseHour, Teacher from Course";
            sql += string.Format(" where CourseId>{0}", course.CourseId);
            DataSet ds = SQLHelper.GetDataSet(sql);
            DataTable dt = ds.Tables[0];
            List<Course> courseList = new List<Course>();

            foreach (DataRow item in dt.Rows)
            {
                courseList.Add(new Course()
                {
                    CourseId = Convert.ToInt32(item["CourseId"]),
                    CourseHour = Convert.ToInt32(item["CourseHour"]),
                    Teacher = item["Teacher"].ToString(),
                    CourseName = item["CourseName"].ToString()
                });
            }


            return courseList;
        }

        /// <summary>
        /// 根据条件查询课程数量
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int GetCourseCount(Course course)
        {
            string sql = "select 课程数量=count(1) from Course";
            sql += string.Format(" where CourseId>{0}", course.CourseId);
            object result = SQLHelper.GetSingleResult(sql);
            return Convert.ToInt32(result);
        }
      
    }
}
