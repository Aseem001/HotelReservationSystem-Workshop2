// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OutputHotel.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aseem Anand"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HotelReservationSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// UC 6 : Class to represent objects of output hotels after filtering to be presented at frontEnd
    /// </summary>
    public class OutputHotel
    {
        public string hotelName;
        public int ratings;
        public int totalRate;

        public OutputHotel(string hotelName,int ratings,int totalRate)
        {
            this.hotelName = hotelName;
            this.ratings = ratings;
            this.totalRate = totalRate;
        }

        /// <summary>
        ///  Overridden to decide if the two instances of the classs are equal on the basis of hotelname and total rate
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is OutputHotel))
            {
                return false;
            }
            return (this.hotelName == ((OutputHotel)obj).hotelName)
                && (this.totalRate == ((OutputHotel)obj).totalRate);
        }
        public override int GetHashCode()
        {
            return hotelName.GetHashCode() ^ totalRate.GetHashCode();
        }
    }

}
