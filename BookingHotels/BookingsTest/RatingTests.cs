using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookingHotels;

namespace BookingsTest
{
    [TestClass]
    public class RatingTests
    {
        [TestMethod]
        public void Compare_Hotel1BiggerRating_ReturnsHotel1()
        {
            Hotel hotel1 =  new HotelRidgewood(); // bigger rating
            Hotel hotel2 =  new HotelLakewood();

            Hotel result = Rating.Compare(hotel1, hotel2);

            Assert.AreEqual(hotel1, result);
        }
        
        [TestMethod]
        public void Compare_Hotel2BiggerRating_ReturnsHotel2()
        {
            Hotel hotel1 =  new HotelBridgewood();
            Hotel hotel2 = new HotelRidgewood(); // bigger rating

            Hotel result = Rating.Compare(hotel1, hotel2);

            Assert.AreEqual(hotel2, result);
        }

        [TestMethod]
        public void Compare_EqualRating_ReturnsHotel1()
        {
            Hotel hotel1 =  new HotelRidgewood();// same rating
            Hotel hotel2 = new HotelRidgewood(); // same rating

            Hotel result = Rating.Compare(hotel1, hotel2);

            Assert.AreEqual(hotel1, result);
        }
        
       
    }
}
