using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sena.IntakeAssignment.Data.Repository;

namespace Sena.IntakeAssignment.Tests.Repositories
{
    [TestClass]
    public class RecordRepositoryTest
    {
        [TestMethod]
        public void FetchRecordList()
        {
            // Arrange
            var repository = new RecordRepository();

            // Act
            var result = repository.FetchRecordList();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(15, result.Count());
        }

        [TestMethod]
        public void Update()
        {
            // Arrange
            var repository = new RecordRepository();

            // Act
            var result = repository.Update(null);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Add()
        {
            // Arrange
            var repository = new RecordRepository();

            // Act
            var result = repository.Add(null);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            var repository = new RecordRepository();

            // Act
            var result = repository.Delete(null);

            // Assert
            Assert.IsTrue(result);
        }
    }
}