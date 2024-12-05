using activitiesUtils;
namespace activitiesUtils_Testing_
{
    [TestClass]
    public class UtilsTest
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(60)]
        [DataRow(120)]
        public void IsValidAgeReturnsTrue(int x)
        {
            // Arrange
            bool flag;

            // Act
            flag = activitiesUtils.Utils.IsValidAge(x);

            // Assert
            Assert.IsTrue(flag);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(121)]
        public void IsValidAgeReturnsFalse(int x)
        {
            // Arrange
            bool flag;

            // Act
            flag = activitiesUtils.Utils.IsValidAge(x);

            // Assert
            Assert.IsFalse(flag);
        }
    }
}