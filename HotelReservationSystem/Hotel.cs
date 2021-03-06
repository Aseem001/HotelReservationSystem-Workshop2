﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hotel.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aseem Anand"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HotelReservationSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Hotel
    {
        public string hotelName;
        //UC 3 Refactor to add weekend and weekdays rate
        public int weekdayRate;
        public int weekendRate;
        //UC 5 Refactor to add ratings to each hotel
        public int ratings;   

        public Hotel(string hotelName,int weekdayRate,int weekendRate)
        {
            this.hotelName = hotelName;
            this.weekdayRate = weekdayRate;
            this.weekendRate = weekendRate;            
        }              
    }
}
