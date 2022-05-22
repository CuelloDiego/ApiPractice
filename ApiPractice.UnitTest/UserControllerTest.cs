using NUnit.Framework;
using Moq;
using ApiPractice.Models;
using System.Collections.Generic;
using ApiPractice.Controllers;
using System.Linq;

namespace ApiPractice.UnitTest
{
    public class UserControllerTest

    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetUsers_should_returnok()
        {
            var users = new List<User>() { new User { Id=1,Name="Diego",Age=26} };
            var mockUsers= new Mock<IUsers>();
            mockUsers.Setup(x => x.GetUsers()).Returns(users);
            var controller = new UserController(mockUsers.Object);

            var result= controller.GetUsers();



            Assert.AreEqual(users.First().Id, result.First().Id);

        }
    }
}