using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticsBCApp.EF_Classes;
using System.Data.Entity;
using System.ComponentModel;

namespace LogisticsBCApp
{
    class BackgroundActivity
    {
        /// <summary>
        /// Updates the TotalEarnings of a driver by $10
        /// </summary>
        /// <param name="driverId">DriverId</param>
        public void UpdateDriverEarnings(int driverId)
        {
            using (var context = new LogisticsDbEntities())
            {
                var findDriverQuery = context.Drivers.Where(p => p.DriverId==driverId).First();
                findDriverQuery.TotalEarnings += 10;
                context.SaveChanges();
            }
        }
    }
}
