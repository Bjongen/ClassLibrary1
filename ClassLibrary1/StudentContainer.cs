using System.Collections.Generic;

namespace ClassLibrary1
{
    public class StudentContainer
    {
        public List<Student> Students;

        public StudentContainer(List<Student> students)
        {
            Students = students;
        }

        public List<Course> GetCoursesForStudent(Student student)
        {
            foreach (var x in (Students))
            {
                if (x.Id == student.Id)
                {
                    return student.Courses;
                }
            }

            return null;
        }
    }
}