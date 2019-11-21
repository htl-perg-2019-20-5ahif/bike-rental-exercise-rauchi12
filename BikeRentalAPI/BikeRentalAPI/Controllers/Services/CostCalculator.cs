using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRentalAPI.Controllers.Services
{
    public class CostCalculator
    {
        public decimal Calculate(DateTime start, DateTime end, decimal priceFirstHour, decimal priceAdditionalHours)
        {
            //
            // Get the duration
            //
            if (end < start)
            {
                Console.WriteLine("Invalid duration");
            }

            var duration = end - start;
            if (duration < TimeSpan.Zero)
            {
                Console.WriteLine("Invalid duration");
            }

            //
            // Calculate first hour
            //
            decimal totalPrice = 0;
            if (duration.TotalMinutes >= 15)
            {
                totalPrice += priceFirstHour;
            }

            //
            // Calculate the additional hours
            // 
            var additionalHours = (int)Math.Ceiling((duration - TimeSpan.FromHours(1)).TotalHours);
            if (additionalHours > 0)
            {
                totalPrice += additionalHours * priceAdditionalHours;
            }

            return totalPrice;
        }
    }
}
