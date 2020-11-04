using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Operation
    {
        private const string REWARD_CUSTOMER = "Reward";
        private const string REGULAR_CUSTOMER = "Regular";
        private static Hotel lakeWood = new Hotel
        {
            WeekdayRateForRegularCustomer = 110,
            WeekendRateForRegularCustomer = 90,
            WeekdayRateForRewardCustomer = 80,
            WeekendRateForRewardCustomer = 80,
            Rating = 3
        };
        private static Hotel bridgeWood = new Hotel
        {
            WeekdayRateForRegularCustomer = 150,
            WeekendRateForRegularCustomer = 50,
            WeekdayRateForRewardCustomer = 110,
            WeekendRateForRewardCustomer = 50,
            Rating = 4
        };
        private static Hotel ridgeWood = new Hotel
        {
            WeekdayRateForRegularCustomer = 220,
            WeekendRateForRegularCustomer = 150,
            WeekdayRateForRewardCustomer = 100,
            WeekendRateForRewardCustomer = 40,
            Rating = 5
        };
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
        public static int GetLakewoodCost(string checkInDate, string checkOutDate, string customerType)
        {
            totalCost = 0;
            string checkInDay = GetDay(checkInDate);
            string checkOutDay = GetDay(checkOutDate);
            switch (customerType)
            {
                case REGULAR_CUSTOMER:
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
                    break;
                case REWARD_CUSTOMER:
                    if (checkInDay.Equals("Saturday") || checkInDay.Equals("Sunday"))
                    {
                        totalCost += lakeWood.WeekendRateForRewardCustomer;
                    }
                    else
                    {
                        totalCost += lakeWood.WeekdayRateForRewardCustomer;
                    }
                    if (checkOutDay.Equals("Saturday") || checkOutDay.Equals("Sunday"))
                    {
                        totalCost += lakeWood.WeekendRateForRewardCustomer;
                    }
                    else
                    {
                        totalCost += lakeWood.WeekdayRateForRewardCustomer;
                    }
                    break;
            }
            return totalCost;
        }
        public static int GetBridgewoodCost(string checkInDate, string checkOutDate, string customerType)
        {
            totalCost = 0;
            string checkInDay = GetDay(checkInDate);
            string checkOutDay = GetDay(checkOutDate);
            switch (customerType)
            {
                case REGULAR_CUSTOMER:
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
                    break;
                case REWARD_CUSTOMER:
                    if (checkInDay.Equals("Saturday") || checkInDay.Equals("Sunday"))
                    {
                        totalCost += bridgeWood.WeekendRateForRewardCustomer;
                    }
                    else
                    {
                        totalCost += bridgeWood.WeekdayRateForRewardCustomer;
                    }
                    if (checkOutDay.Equals("Saturday") || checkOutDay.Equals("Sunday"))
                    {
                        totalCost += bridgeWood.WeekendRateForRewardCustomer;
                    }
                    else
                    {
                        totalCost += bridgeWood.WeekdayRateForRewardCustomer;
                    }
                    break;
            }
            return totalCost;
        }
        public static int GetRidgewoodCost(string checkInDate, string checkOutDate, string customerType)
        {
            totalCost = 0;
            string checkInDay = GetDay(checkInDate);
            string checkOutDay = GetDay(checkOutDate);
            switch (customerType)
            {
                case REGULAR_CUSTOMER:
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
                    break;
                case REWARD_CUSTOMER:
                    if (checkInDay.Equals("Saturday") || checkInDay.Equals("Sunday"))
                    {
                        totalCost += ridgeWood.WeekendRateForRewardCustomer;
                    }
                    else
                    {
                        totalCost += ridgeWood.WeekdayRateForRewardCustomer;
                    }
                    if (checkOutDay.Equals("Saturday") || checkOutDay.Equals("Sunday"))
                    {
                        totalCost += ridgeWood.WeekendRateForRewardCustomer;
                    }
                    else
                    {
                        totalCost += ridgeWood.WeekdayRateForRewardCustomer;
                    }
                    break;
            }
            return totalCost;
        }
        public static int FindCheapestHotelRate(string checkInDate, string checkOutDate, string customerType)
        {
            int lakeWoodCost = GetLakewoodCost(checkInDate, checkOutDate, customerType);
            int bridgeWoodCost = GetBridgewoodCost(checkInDate, checkOutDate, customerType);
            int ridgeWoodCost = GetRidgewoodCost(checkInDate, checkOutDate, customerType);
            int leastCost = lakeWoodCost < bridgeWoodCost ? lakeWoodCost : bridgeWoodCost;
            leastCost = leastCost < ridgeWoodCost ? leastCost : ridgeWoodCost;
            return leastCost;
        }
        public static string FindCheapestHotelName(string checkInDate, string checkOutDate, string customerType)
        {
            int leastCost = FindCheapestHotelRate(checkInDate, checkOutDate, customerType);
            if (leastCost == GetLakewoodCost(checkInDate, checkOutDate, customerType))
            {
                if (leastCost == GetBridgewoodCost(checkInDate, checkOutDate, customerType))
                {
                    return "Lakewood and Bridgewood";
                }
                return "Lakewood";
            }
            else if (leastCost == GetBridgewoodCost(checkInDate, checkOutDate, customerType))
            {
                if (leastCost == GetRidgewoodCost(checkInDate, checkOutDate, customerType))
                {
                    return "Bridgewood and Ridgewood";
                }
                return "Bridgewood";
            }
            else
            {
                if (leastCost == GetLakewoodCost(checkInDate, checkOutDate, customerType))
                {
                    return "Ridgewood and Lakewood";
                }
                return "Ridgewood";
            }
        }
        public static int GetRatingOfHotel(string hotel)
        {
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
        public static string FindCheapestBestRatedHotelName(string checkInDate, string checkOutDate,string customerType)
        {
            string hotelName = FindCheapestHotelName(checkInDate, checkOutDate, customerType);
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
        public static int FindBestRatedHotelRate(string checkInDate, string checkOutDate, string customerType)
        {
            int lakewoodRating = GetRatingOfHotel("Lakewood");
            int bridgewoodRating = GetRatingOfHotel("Bridgewood");
            int ridgewoodRating = GetRatingOfHotel("Ridgewood");
            int maxRating = lakewoodRating > bridgewoodRating ? lakewoodRating : bridgewoodRating;
            maxRating = maxRating > ridgewoodRating ? maxRating : ridgewoodRating;
            if(maxRating == GetRatingOfHotel("Ridgewood"))
            {
                return GetRidgewoodCost(checkInDate, checkOutDate, customerType);
            }
            else if(maxRating == GetRatingOfHotel("Bridgewood"))
            {
                return GetBridgewoodCost(checkInDate, checkOutDate, customerType);
            }
            else
            {
                return GetLakewoodCost(checkInDate, checkOutDate, customerType);
            }
        }
        public static string FindBestRatedHotelName(string checkInDate, string checkOutDate, string customerType)
        {
            int cost = FindBestRatedHotelRate(checkInDate, checkOutDate, customerType);
            if (cost == GetRidgewoodCost(checkInDate, checkOutDate, customerType))
            {
                return "Ridgewood";
            }
            else if(cost == GetRidgewoodCost(checkInDate, checkOutDate, customerType))
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