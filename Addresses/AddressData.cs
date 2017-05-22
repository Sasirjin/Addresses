using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addresses
{
   class AddressData
   {
      public string Zipcode { get; set; } //	5 digit Zipcode or military postal code(FPO/APO)
      public string ZipCodeType { get; set; } // Standard, PO BOX Only, Unique, Military(implies APO or FPO)
      public string City { get; set; } // USPS offical city name(s)
      public string State { get; set; } // USPS offical state, territory, or quasi-state (AA, AE, AP) abbreviation code
      public string LocationType { get; set; } // Primary, Acceptable,Not Acceptable
      public decimal Lat { get; set; } // Decimal Latitude, if available
      public decimal Long { get; set; } // Decimal Longitude, if available
      public decimal Xaxis { get; set; }
      public decimal Yaxis { get; set; }
      public decimal Zaxis { get; set; }
      public string WorldRegion { get; set; }
      public string Country { get; set; }
      public string LocationText { get; set; }
      public string Location { get; set; } // Standard Display  (eg Phoenix, AZ ; Pago Pago, AS ; Melbourne, AU )
      public bool Decommisioned { get; set; } // If Primary location, Yes implies historical Zipcode, No Implies current Zipcode; If not Primary, Yes implies Historical Placename
      public long TaxReturnsFiled { get; set; } // Number of Individual Tax Returns Filed in 2008
      public long EstimatedPopulation { get; set; } // Tax returns filed + Married filing jointly + Dependents
      public long TotalWages { get; set; } // Total of Wages Salaries and Tips
      public string Notes { get; set; }

      public static AddressData FromCsv(string csvLine) 
      {
         // Split
         string[] values = csvLine.Split(',');
         AddressData dailyValues = new AddressData();
         
         // Convert
         dailyValues.Zipcode = values[0].ToString();
         dailyValues.ZipCodeType = values[1].ToString();
         dailyValues.City = values[2].ToString();
         dailyValues.State = values[3].ToString();
         dailyValues.LocationType = values[4].ToString();
         dailyValues.Lat = Convert.ToDecimal(values[5]);
         dailyValues.Long = Convert.ToDecimal(values[6]);
         dailyValues.Xaxis = Convert.ToDecimal(values[7]);
         dailyValues.Yaxis = Convert.ToDecimal(values[8]);
         dailyValues.Zaxis = Convert.ToDecimal(values[9]);
         dailyValues.WorldRegion = values[10].ToString();
         dailyValues.Country = values[11].ToString();
         dailyValues.LocationText = values[12].ToString();
         dailyValues.Location = values[13].ToString();
         dailyValues.Decommisioned = bool.Parse(values[14].ToString());
         dailyValues.TaxReturnsFiled = long.Parse(values[15].ToString());
         dailyValues.EstimatedPopulation = long.Parse(values[16].ToString());
         dailyValues.TotalWages = long.Parse(values[17].ToString());
         dailyValues.Notes = values[18].ToString();

         return dailyValues;
      }
   }
}