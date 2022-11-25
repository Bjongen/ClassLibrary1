using System.Collections.Generic;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace TestProject1
{
    [TestClass]
    public class StudentContainerTest
    {
        [TestMethod]
        public void GetCoursesFromStudent()
        {
            //arrange
            Course course1 = new Course(1, 1, "Economy");
            Course course2 = new Course(2, 4, "Biology");
            Course course3 = new Course(3, 3, "Math");
            List<Course> courses1 = new List<Course>();
            List<Course> courses2 = new List<Course>();
            courses1.Add(course1);
            courses1.Add(course2);
            courses2.Add(course2);
            courses2.Add(course3);
            Student student1 = new Student(1, "name1", courses1, "school1");
            Student student2 = new Student(2, "name3", courses2, "school1");
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            StudentContainer studentContainer = new StudentContainer(students);
            //act
            List<Course> actual = studentContainer.GetCoursesForStudent(student1);
            //assert
            Assert.AreEqual(student1.Courses, actual);
        }
    }
}