using System.Collections.Generic;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace TestProject1
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void ConstructorEmptyCourse()
        {
            //arrange
            var id = 1;
            var name = "Student2";
            var school = "school3";
            List<Course> courses = new List<Course>();
            //act
            Student student = new Student(id, name, courses, school);
            //assert
            Assert.AreEqual(id, student.Id);
            Assert.AreEqual(name,student.Name);
            Assert.AreEqual(courses,student.Courses);
            Assert.AreEqual(school, student.School);
        }

        [TestMethod]
        public void ConstructorFilledCourse()
        {
            //arrange
            var id = 1;
            var name = "Student2";
            var school = "school3";
            var Cid = 2;
            var package = 1;
            var Cname = "Economy";
            List<Course> courses = new List<Course>();
            courses.Add(new Course(Cid, package, Cname));
            //act
            Student student = new Student(id, name, courses, school);
            //assert
            Assert.AreEqual(id, student.Id);
            Assert.AreEqual(name,student.Name);
            Assert.AreEqual(courses,student.Courses);
            Assert.AreEqual(school, student.School);
        }

        [TestMethod]
        public void AddCourse()
        {
            //arrange
            var id = 1;
            var package = 3;
            var name = "economy";
            Course course = new Course(id, package, name);
            Student student = new Student();
            //act
            student.AddToList(course);
            //assert
            Assert.IsTrue(student.Courses.Contains(course));
        }
    }
}