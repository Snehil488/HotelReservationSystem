using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationSystem;

namespace HotelReservationSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adding_Weekday_And_Weekend_RegularCustomerRates_And_Verifying()
        {
            int expectedHotelRate = 200;
            string expectedHotelName = "Lakewood and Bridgewood";
            int actualHotelRate = Operation.FindCheapestHotelRate("11Sep2020", "12Sep2020");
            string actualHotelName = Operation.FindCheapestHotelName("11Sep2020", "12Sep2020");
            Assert.AreEqual(expectedHotelRate, actualHotelRate);
            Assert.AreEqual(expectedHotelName, actualHotelName);
        }
    }
}
