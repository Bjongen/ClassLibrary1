using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Student
    {
        public int Id;
        public string Name;
        public List<Course> Courses;
        public string School;

        public Student()
        {
            
        }
        public Student(int id, string name, List<Course> courses, string school)
        {
            Id = id;
            Name = name;
            Courses = courses;
            School = school;
        }

        public void AddToList(Course course)
        {
            Courses.Add(course);
        }
    }
}