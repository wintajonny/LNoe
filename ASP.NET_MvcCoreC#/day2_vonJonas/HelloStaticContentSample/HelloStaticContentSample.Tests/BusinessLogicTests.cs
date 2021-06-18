using NUnit.Framework;
using NSubstitute;

namespace HelloStaticContentSample.Tests
{
    public class BusinessLogicTests
    {

        [Test]
        public void NormalCustomer()
        {
            // A-A-A
            // Arrange
            ICustomerDb db = NSubstitute.Substitute.For<ICustomerDb>();

            db.GetTurnoverForCustomer(1, 100).Returns(999);

            BusinessLogic1 logic = new BusinessLogic1(db);

            // Act

            var actualPrice = logic.ComputePriceForCustomer(1, 100);

            //Assert

            db.Received().GetTurnoverForCustomer(1, 100);
            Assert.AreEqual(100, actualPrice, "Price wrong");
            //Assert.Pass();
            //Assert.Fail("Dummy!");
            //Assert.AreEqual();
        }
        [Test]
        public void HighTurnoverCustomer()
        {
            // A-A-A
            // Arrange
            ICustomerDb db = NSubstitute.Substitute.For<ICustomerDb>();

            db.GetTurnoverForCustomer(1, 100).Returns(1001);

            BusinessLogic1 logic = new BusinessLogic1(db);

            // Act

            var actualPrice = logic.ComputePriceForCustomer(1, 100);

            //Assert

            db.Received().GetTurnoverForCustomer(1, 100);
            Assert.AreEqual(95, actualPrice, "Price wrong");
        }
    }
}