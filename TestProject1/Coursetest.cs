
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void Constructor()
        {
            //arrange
            var id = 1;
            var package = 2;
            var name = "economy";
            //act
            var course = new Course(id, package, name);
            //assert
            Assert.AreEqual(id, course.Id);
            Assert.AreEqual(package, course.Package);
            Assert.AreEqual(name, course.Name);
        }
    }
}