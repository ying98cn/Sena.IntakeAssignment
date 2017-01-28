using System.Web.Mvc;
using Sena.IntakeAssignment.Controllers;
using Sena.IntakeAssignment.Data.Interface;
using NUnit.Framework;
using Moq;

namespace Sena.IntakeAssignment.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        private Mock<IRecordRepository> _recordRepositoryMock;

        [SetUp]
        public void Initialize()
        {
            _recordRepositoryMock = new Mock<IRecordRepository>();
        }

        [TearDown]
        public void Terminate()
        {
            _recordRepositoryMock = null;
        }

        [Test]
        public void Index()
        {
            // Arrange
            var controller = new HomeController(_recordRepositoryMock.Object);

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void About()
        {
            // Arrange
            var controller = new HomeController(_recordRepositoryMock.Object);

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [Test]
        public void Contact()
        {
            // Arrange
            var controller = new HomeController(_recordRepositoryMock.Object);

            // Act
            var result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void Records()
        {
            // Arrange
            var controller = new HomeController(_recordRepositoryMock.Object);

            // Act
            var result = controller.Records() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}