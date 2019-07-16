using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SacramentPlanner.Models;

namespace SacramentPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(SacramentContext context)
        {
            if (context.SacramentPlan.Any())
            {
                return;
            }

            var plans = new SacramentPlan[]
            {
                
            };

            foreach (SacramentPlan p in plans)
            {
                context.SacramentPlan.Add(p);
            }
            context.SaveChanges();

            var speakers = new Speaker[]
            {
                
            };

            foreach (Speaker s in speakers)
            {
                context.Speaker.Add(s);
            }
            context.SaveChanges();
        }
    }
}
