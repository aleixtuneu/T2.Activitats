using activitiesUtils;
namespace Exercici_19_Testing_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(6)]
        [DataRow(12)]
        public void AppliedDiscountReturns50(int x)
        {
            // Arrange
            int flag = 50;

            // Act
            flag = activitiesUtils.Utils.AppliedDiscount(x);

            // Assert
            Assert.AreEqual(flag, x);
        }

        [TestMethod]
        [DataRow(13)]
        [DataRow(15)]
        [DataRow(17)]
        public void AppliedDiscountReturns25(int x)
        {
            // Arrange
            int flag = 25;

            // Act
            flag = activitiesUtils.Utils.AppliedDiscount(x);

            // Assert
            Assert.AreEqual(flag, x);
        }

        [TestMethod]
        [DataRow(18)]
        [DataRow(32)]
        [DataRow(64)]
        public void AppliedDiscountReturns0(int x)
        {
            // Arrange
            int flag = 0;

            // Act
            flag = activitiesUtils.Utils.AppliedDiscount(x);

            // Assert
            Assert.AreEqual(flag, x);
        }

        [TestMethod]
        [DataRow(65)]
        public void AppliedDiscountReturns30(int x)
        {
            // Arrange
            int flag = 30;

            // Act
            flag = activitiesUtils.Utils.AppliedDiscount(x);

            // Assert
            Assert.AreEqual(flag, x);
        }
    }
}