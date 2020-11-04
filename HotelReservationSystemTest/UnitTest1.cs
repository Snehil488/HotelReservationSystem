using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationSystem;

namespace HotelReservationSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Date_Range_Should_Return_BestRated_Hotel_Ridgewood()
        {
            string expectedHotelName = "Ridgewood";
            int expectedRate = 370;
            int actualRate = Operation.FindBestRatedHotelRate("11Sep2020", "12Sep2020");
            string actualHotelName = Operation.FindBestRatedHotelName("11Sep2020", "12Sep2020");
            Assert.AreEqual(expectedRate, actualRate);
            Assert.AreEqual(expectedHotelName, actualHotelName);
        }
    }
}
