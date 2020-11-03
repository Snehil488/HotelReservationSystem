﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Operation
    {
        private static int totalCost = 0;
        public static int GetMonthInDigits(string month)
        {
            switch (month.ToLower())
            {
                case "jan":
                    return 1;
                case "feb":
                    return 2;
                case "mar":
                    return 3;
                case "apr":
                    return 4;
                case "may":
                    return 5;
                case "jun":
                    return 6;
                case "jul":
                    return 7;
                case "aug":
                    return 8;
                case "sep":
                    return 9;
                case "oct":
                    return 10;
                case "nov":
                    return 11;
                case "dec":
                    return 12;
                default:
                    Console.WriteLine("Invalid Month");
                    return 0;
            }
        }
        public static string GetDay(string date)
        {
            int day = Convert.ToInt32(date.Substring(0, 2));
            string month = date.Substring(2, 3);
            int year = Convert.ToInt32(date.Substring(5));
            DateTime d = new DateTime(year, Operation.GetMonthInDigits(month), day);
            return d.DayOfWeek.ToString();
        }
        public static int GetLakewoodCost(string checkInDate, string checkOutDate)
        {
            totalCost = 0;
            Hotel lakeWood = new Hotel();
            lakeWood.WeekdayRateForRegularCustomer = 110;
            lakeWood.WeekendRateForRegularCustomer = 90;
            string checkInDay = GetDay(checkInDate);
            string checkOutDay = GetDay(checkOutDate);
            if (checkInDay.Equals("Saturday") || checkInDay.Equals("Sunday"))
            {
                totalCost += lakeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += lakeWood.WeekdayRateForRegularCustomer;
            }
            if (checkOutDay.Equals("Saturday") || checkOutDay.Equals("Sunday"))
            {
                totalCost += lakeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += lakeWood.WeekdayRateForRegularCustomer;
            }
            return totalCost;
        }
        public static int GetBridgewoodCost(string checkInDate, string checkOutDate)
        {
            totalCost = 0;
            Hotel bridgeWood = new Hotel();
            bridgeWood.WeekdayRateForRegularCustomer = 150;
            bridgeWood.WeekendRateForRegularCustomer = 50;
            string checkInDay = GetDay(checkInDate);
            string checkOutDay = GetDay(checkOutDate);
            if (checkInDay.Equals("Saturday") || checkInDay.Equals("Sunday"))
            {
                totalCost += bridgeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += bridgeWood.WeekdayRateForRegularCustomer;
            }
            if (checkOutDay.Equals("Saturday") || checkOutDay.Equals("Sunday"))
            {
                totalCost += bridgeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += bridgeWood.WeekdayRateForRegularCustomer;
            }
            return totalCost;
        }
        public static int GetRidgewoodCost(string checkInDate, string checkOutDate)
        {
            totalCost = 0;
            Hotel ridgeWood = new Hotel();
            ridgeWood.WeekdayRateForRegularCustomer = 220;
            ridgeWood.WeekendRateForRegularCustomer = 150;
            string checkInDay = GetDay(checkInDate);
            string checkOutDay = GetDay(checkOutDate);
            if (checkInDay.Equals("Saturday") || checkInDay.Equals("Sunday"))
            {
                totalCost += ridgeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += ridgeWood.WeekdayRateForRegularCustomer;
            }
            if (checkOutDay.Equals("Saturday") || checkOutDay.Equals("Sunday"))
            {
                totalCost += ridgeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += ridgeWood.WeekdayRateForRegularCustomer;
            }
            return totalCost;
        }
        public static int FindCheapestHotelRate(string checkInDate, string checkOutDate)
        {
            int lakeWoodCost = GetLakewoodCost(checkInDate, checkOutDate);
            int bridgeWoodCost = GetBridgewoodCost(checkInDate, checkOutDate);
            int ridgeWoodCost = GetRidgewoodCost(checkInDate, checkOutDate);
            int leastCost = lakeWoodCost < bridgeWoodCost ? lakeWoodCost : bridgeWoodCost;
            leastCost = leastCost < ridgeWoodCost ? leastCost : ridgeWoodCost;
            return leastCost;
        }
        public static string FindCheapestHotelName(string checkInDate, string checkOutDate)
        {
            int leastCost = FindCheapestHotelRate(checkInDate, checkOutDate);
            if (leastCost == GetLakewoodCost(checkInDate, checkOutDate))
            {
                if (leastCost == GetBridgewoodCost(checkInDate, checkOutDate))
                {
                    return "Lakewood and Bridgewood";
                }
                return "Lakewood";
            }
            else if (leastCost == GetBridgewoodCost(checkInDate, checkOutDate))
            {
                if (leastCost == GetRidgewoodCost(checkInDate, checkOutDate))
                {
                    return "Bridgewood and Ridgewood";
                }
                return "Bridgewood";
            }
            else
            {
                if (leastCost == GetLakewoodCost(checkInDate, checkOutDate))
                {
                    return "Ridgewood and Lakewood";
                }
                return "Ridgewood";
            }
        }
        public static int GetRatingOfHotel(string hotel)
        {
            Hotel lakeWood = new Hotel
            {
                Rating = 3
            };
            Hotel bridgeWood = new Hotel
            {
                Rating = 4
            };
            Hotel ridgeWood = new Hotel
            {
                Rating = 5
            };
            if (hotel.Equals("Lakewood"))
            {
                return lakeWood.Rating;
            }
            else if (hotel.Equals("Bridgewood"))
            {
                return bridgeWood.Rating;
            }
            else
            {
                return ridgeWood.Rating;
            }
        }
        public static string FindCheapestBestRatedHotelName(string checkInDate, string checkOutDate)
        {
            string hotelName = FindCheapestHotelName(checkInDate, checkOutDate);
            if (hotelName.Contains("and"))
            {
                string[] hotels = hotelName.Split(" and ");
                int rating1 = GetRatingOfHotel(hotels[0]);
                int rating2 = GetRatingOfHotel(hotels[1]);
                if (rating1 > rating2)
                {
                    return hotels[0];
                }
                else
                {
                    return hotels[1];
                }
            }
            else
            {
                return hotelName;
            }
        }
        public static int FindBestRatedHotelRate(string checkInDate, string checkOutDate)
        {
            int lakewoodRating = GetRatingOfHotel("Lakewood");
            int bridgewoodRating = GetRatingOfHotel("Bridgewood");
            int ridgewoodRating = GetRatingOfHotel("Ridgewood");
            int maxRating = lakewoodRating > bridgewoodRating ? lakewoodRating : bridgewoodRating;
            maxRating = maxRating > ridgewoodRating ? maxRating : ridgewoodRating;
            if(maxRating == GetRatingOfHotel("Ridgewood"))
            {
                return GetRidgewoodCost(checkInDate, checkOutDate);
            }
            else if(maxRating == GetRatingOfHotel("Bridgewood"))
            {
                return GetBridgewoodCost(checkInDate, checkOutDate);
            }
            else
            {
                return GetLakewoodCost(checkInDate, checkOutDate);
            }
        }
        public static string FindBestRatedHotelName(string checkInDate, string checkOutDate)
        {
            int cost = FindBestRatedHotelRate(checkInDate, checkOutDate);
            if (cost == GetRidgewoodCost(checkInDate, checkOutDate))
            {
                return "Ridgewood";
            }
            else if(cost == GetRidgewoodCost(checkInDate, checkOutDate))
            {
                return "Bridgewood";
            }
            else
            {
                return "Lakewood";
            }
        }
    }
}