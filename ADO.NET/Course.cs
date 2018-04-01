using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADO.NET
{
    /// <summary>
    /// 课程实体类
    /// </summary>
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseHour { get; set; }
        public string Teacher { get; set; }
    }
}
