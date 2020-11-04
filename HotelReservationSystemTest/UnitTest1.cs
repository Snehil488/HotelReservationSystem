using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationSystem;

namespace HotelReservationSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_DateRange_Should_Return_Cheapest_BestRated_Hotel_As_Ridgewood()
        {
            string expectedHotelName = "Ridgewood";
            int expectedRate = 140;
            int expectedRating = 5;
            string actualHotelName = Operation.FindCheapestBestRatedHotelName("11Sep2020", "12Sep2020", "Reward");
            int actualRate = Operation.FindCheapestHotelRate("11Sep2020", "12Sep2020", "Reward");
            int actualRating = Operation.GetRatingOfHotel(actualHotelName);
            Assert.AreEqual(expectedHotelName, actualHotelName);
            Assert.AreEqual(expectedRate, actualRate);
            Assert.AreEqual(expectedRating, actualRating);
        }
    }
}
