using System;
using System.Windows.Forms;
using Hotel;
namespace Hotel.Tests
{
    public class HotelTests
    {
        private Hotel hotel;

        [SetUp]
        public void Setup()
        {
            hotel = new Hotel();
        }
    }

}