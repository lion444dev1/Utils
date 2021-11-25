using System;

namespace lioncs.Utils
{
    public class DateTimeHelper
    {
        public static Boolean isNull(DateTime? dateTime){
            bool result = true;
            if (dateTime != null)
            {
                result =  ((DateTime)dateTime).Year == 1;
            }
            return result;
        }
        public static string getCurrentCentralTime()
        {
            return getCurrentTimeForZone("Central Standard Time");
        }
        public static string getEasternTimeZone(){
            return getCurrentTimeForZone("Eastern Standard Time");
        }

        /// <summary>
        /// return -1 or 2 depending if chicago is dst
        /// </summary>
        /// <returns></returns>
        public static string getArizonaTime()
        {
            DateTime utc = DateTime.UtcNow;
            TimeZoneInfo zone = TimeZoneInfo.FindSystemTimeZoneById("central Standard Time");
            DateTime chicagoTime = TimeZoneInfo.ConvertTimeFromUtc(utc, zone);
            if (zone.IsDaylightSavingTime(chicagoTime))
            {
                return chicagoTime.AddHours(-2).ToShortTimeString();
 ;
            }
            else
            {
                return chicagoTime.AddHours(-1).ToShortTimeString();
            }
             
        }
         public static string getMountainTimeZone()
        {
            return getCurrentTimeForZone("Mountain Standard Time");
        }
        

        public static string getCurrentTimeForZone(string stringZone){
              DateTime utc = DateTime.UtcNow;
              TimeZoneInfo zone = TimeZoneInfo.FindSystemTimeZoneById(stringZone);
            DateTime localDateTime = TimeZoneInfo.ConvertTimeFromUtc(utc, zone);
            return localDateTime.ToShortTimeString();

        }
    }
}
