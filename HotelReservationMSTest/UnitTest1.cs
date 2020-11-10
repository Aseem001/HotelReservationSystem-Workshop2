// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aseem Anand"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HotelReservationMSTest
{
    using HotelReservationSystem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 2 : Given the date range regular customer find cheapest hotel.
        /// </summary>
        [TestMethod]
        public void GivenDateRange_RegularCustomer_FindCheapestHotel()
        {
            //Arrange
            HotelReservation.AddRatingsAndHotel();
            List<OutputHotel> expected = new List<OutputHotel> { new OutputHotel("Lakewood", 3, 220) };        
            DateTime checkinDate = Convert.ToDateTime("10sep2020");
            DateTime checkoutDate = Convert.ToDateTime("11sep2020");

            //Act
            List<OutputHotel> actual = HotelReservation.FindCheapestHotel(checkinDate, checkoutDate, CustomerType.REGULAR_CUSTOMER);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 4 : Givens the weekday and weekend dates and regular customer returns cheapest hotel.
        /// </summary>
        [TestMethod]
        public void GivenWeekdayAndWeekendDates_RegularCustomer_ReturnCheapestHotel()
        {
            //Arrange
            HotelReservation.AddRatingsAndHotel();
            List<OutputHotel> expected = new List<OutputHotel> { new OutputHotel("Lakewood", 3, 200), new OutputHotel("Bridgewood", 4, 200) };
            DateTime checkinDate = Convert.ToDateTime("11sep2020");
            DateTime checkoutDate = Convert.ToDateTime("12sep2020");

            //Act
            List<OutputHotel> actual = HotelReservation.FindCheapestHotel(checkinDate, checkoutDate, CustomerType.REGULAR_CUSTOMER);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 6 : Given the weekday and weekend dates and regular customer should return cheapest best rated hotel.
        /// </summary>
        [TestMethod]
        public void GivenWeekdayAndWeekendDates_RegularCustomer_ReturnCheapestBestRatedHotel()
        {
            //Arrange
            HotelReservation.AddRatingsAndHotel();
            List<OutputHotel> expected = new List<OutputHotel> { new OutputHotel("Bridgewood", 4, 200) };
            DateTime checkinDate = Convert.ToDateTime("11sep2020");
            DateTime checkoutDate = Convert.ToDateTime("12sep2020");

            //Act
            List<OutputHotel> actual = HotelReservation.FindCheapestBestRatedHotel(checkinDate, checkoutDate, CustomerType.REGULAR_CUSTOMER);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 7 : Given the weekday and weekend dates for regular customer should return best rated hotel.
        /// </summary>
        [TestMethod]
        public void GivenWeekdayAndWeekendDates_RegularCustomer_ReturnBestRatedHotel()
        {
            //Arrange
            HotelReservation.AddRatingsAndHotel();
            List<OutputHotel> expected = new List<OutputHotel> { new OutputHotel("Ridgewood", 5, 370) };
            DateTime checkinDate = Convert.ToDateTime("11sep2020");
            DateTime checkoutDate = Convert.ToDateTime("12sep2020");

            //Act
            List<OutputHotel> actual = HotelReservation.FindBestRatedHotel(checkinDate, checkoutDate, CustomerType.REGULAR_CUSTOMER);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 10 : Given the weekday and weekend dates for Rewards customer return cheapest best rated hotel.
        /// </summary>
        [TestMethod]
        public void GivenWeekdayAndWeekendDates_RewardsCustomer_ReturnCheapestBestRatedHotel()
        {
            //Arrange
            HotelReservation.AddRatingsAndHotel();
            List<OutputHotel> expected = new List<OutputHotel> { new OutputHotel("Ridgewood", 5, 140) };
            DateTime checkinDate = Convert.ToDateTime("11sep2020");
            DateTime checkoutDate = Convert.ToDateTime("12sep2020");

            //Act
            List<OutputHotel> actual = HotelReservation.FindCheapestBestRatedHotel(checkinDate, checkoutDate, CustomerType.REWARDS_CUSTOMER);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
