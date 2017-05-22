using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Addresses
{
   public static class AddressInformation
   {
      private List<AddressData> All {
         get 
         {
            try {
               return File.ReadAllLines(Path.Combine(Assembly.GetExecutingAssembly().Location, "zipcodes.csv"))
                  .Skip(1)
                  .Select(v => AddressData.FromCsv(v))
                  .ToList();
            } catch {
               return new List<AddressData>();
            }
         }
      }

      public static List<AddressData> CitiesByState(string stateAbbreviation) 
      {
            try {
               return File.ReadAllLines(Path.Combine(Assembly.GetExecutingAssembly().Location, "zipcodes.csv"))
                  .Skip(1)
                  .Select(v => AddressData.FromCsv(v))
                  .Where(a => a.State == stateAbbreviation)
                  .ToList();
            } catch {
               return new List<AddressData>();
            }
      }
   }
}
