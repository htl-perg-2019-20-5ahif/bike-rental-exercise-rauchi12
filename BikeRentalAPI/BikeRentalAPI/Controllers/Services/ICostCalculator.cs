using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRentalAPI.Controllers.Services
{
    interface ICostCalculator
    {
        public decimal Calculate(DateTime start, DateTime end, decimal rentalPriceFirstHour, decimal rentalPriceAdditionalHours);
    }
}
