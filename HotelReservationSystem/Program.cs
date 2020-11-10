// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aseem Anand"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HotelReservationSystem
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation Program:\n");
            //Addition of hotel with ratings into records
            HotelReservation.AddRatingsAndHotel();
            //Choosing if the user is regular or rewards
            Console.WriteLine("Enter:\n1.If you are a REGULAR customer\n2.If you are a REWARDS customer");
            int customerTypeChoice = Convert.ToInt32(Console.ReadLine());
            CustomerType customerType;
            if (customerTypeChoice == 1)
                customerType = CustomerType.REGULAR_CUSTOMER;
            else
                customerType = CustomerType.REWARDS_CUSTOMER;
            //Getting dates from user
            Console.WriteLine("Enter the check-in date(DDMMMYYYY):");
            DateTime checkinDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the check-out date(DDMMMYYYY):");
            DateTime checkoutDate = DateTime.Parse(Console.ReadLine());
            
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("\nEnter:\n1.To find cheapest hotels\n2.To find best rated hotel\n3.To find cheapest best rated hotel\n4.To exit\n");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        //UC 2
                        HotelReservation.FindCheapestHotel(checkinDate,checkoutDate,customerType);
                        break;
                    case 2:
                        //UC 7
                        HotelReservation.FindBestRatedHotel(checkinDate, checkoutDate, customerType);
                        break;
                    case 3:
                        //UC 6
                        HotelReservation.FindCheapestBestRatedHotel(checkinDate, checkoutDate, customerType);
                        break;
                    case 4:
                        flag = false;
                        break;                        
                }
            }                    
        }
    }
}
