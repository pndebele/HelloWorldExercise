using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.HelloWorldAPI;

namespace HelloWorldApiTest
{
    [TestClass]
    public class HelloWorldApiUnitTest
    {
        [TestMethod]
        public void TestConsoleSysTargetAndMsg()
        {
            //Arrange
            var app = new ApiInterface();
            var targetSys = new ConsoleSys();

            //Act
            app.setTarget(new ConsoleSys());
            app.GetMsg("Hello World");

            //Assert
            Assert.AreEqual("Hello World", app.GetMsg("Hello World"));
            Assert.IsInstanceOfType(targetSys, typeof(ConsoleSys));
        }

        [TestMethod]
        public void TestDatabaseSysTargetAndMsg()
        {
            //Arrange
            var app = new ApiInterface();
            var targetSys = new DatabaseSys();

            //Act
            app.setTarget(new DatabaseSys());
            app.GetMsg("Hello World");

            //Assert
            Assert.AreEqual("Hello World", app.GetMsg("Hello World"));
            Assert.IsInstanceOfType(targetSys, typeof(DatabaseSys));
        }

    }
}
