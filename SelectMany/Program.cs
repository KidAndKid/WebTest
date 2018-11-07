using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMany
{
    public class Student
    {
        public string StudentName { get; set; }
        public int Score { get; set; }

        public Student(string StudentName, int Score)
        {
            this.StudentName = StudentName;
            this.Score = Score;
        }
    }
    public class Teacher
    {
        public string TeacherName { get; set; }
        public List<Student> Students { get; set; }
        public Teacher(string TeacherName, List<Student> Students)
        {
            this.TeacherName = TeacherName;
            this.Students = Students;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //运行结果见下图
            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher("张老师",new List<Student>{ new Student("张三1", 100),new Student("李四1", 90),new Student("王五1", 30) }), //
                new Teacher("李老师",new List<Student>{ new Student("张三2", 100),new Student("李四2", 90),new Student("王五2", 60) }),
                new Teacher("赵老师",new List<Student>{ new Student("张三3", 100),new Student("李四3", 90),new Student("王五3", 40) }), //
                new Teacher("孙老师",new List<Student>{ new Student("张三4", 100),new Student("李四4", 90),new Student("王五4", 60) }),
                new Teacher("钱老师",new List<Student>{ new Student("张三5", 100),new Student("李四5", 90),new Student("王五5", 50) }), //
                new Teacher("周老师",new List<Student>{ new Student("张三6", 100),new Student("李四6", 90),new Student("王五6", 60) }),
                new Teacher("吴老师",new List<Student>{ new Student("张三7", 100),new Student("李四7", 90),new Student("王五7", 60) })
            };

            #region 所有任课老师下未及格的学生 方式一
            List<Student> studentList = new List<Student>();
            foreach (var t in teachers)
            {
                foreach (var s in t.Students)
                {
                    if (s.Score < 60)
                    {
                        studentList.Add(s);
                    }
                }
            }
            studentList.ForEach(s => Console.WriteLine(string.Format("{0} - {1}", s.StudentName, s.Score)));
            #endregion

            Console.ReadKey();

            #region 所有任课老师下未及格的学生 方式二
            var list1 = from t in teachers
                        from s in t.Students
                        where s.Score < 60
                        select s;
            foreach (var item in list1)
            {
                Console.WriteLine(string.Format("{0} - {1}", item.StudentName, item.Score));
            }
            #endregion

            Console.ReadKey();

            #region 所有任课老师下未及格的学生 方式三
            var list2 = teachers.SelectMany(t => t.Students).Where(s => s.Score < 60);
            //var list22 = teachers.Select(t => t.Students).Where(s => s.Score < 60);
            foreach (var s in list2)
            {
                Console.WriteLine(string.Format("{0} - {1}", s.StudentName, s.Score));
            }
            #endregion

            Console.ReadKey();

            #region 所有未及格的学生及其授课老师 
            var list3 = teachers.SelectMany(
                t => t.Students,
                (t, s) => new { t.TeacherName, s.StudentName, s.Score })
                .Where(n => n.Score < 60);

            foreach (var item in list3)
            {
                Console.WriteLine(string.Format("任课老师{0} - 学生{1} 分数{2}", item.TeacherName, item.StudentName, item.Score));
            }
            #endregion
            Console.ReadKey();

        }
    }
}
