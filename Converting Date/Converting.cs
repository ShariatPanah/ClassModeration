using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Converting_Date
{
    public class Converting
    {
        public string ConvertDay()
        {
            PersianCalendar PD = new PersianCalendar();
            switch (Convert.ToString(PD.GetDayOfWeek(DateTime.Now)))
            {
                case "Saturday":
                    return "شنبه";
                case "Sunday":
                    return "یکشنبه";
                case "Monday":
                    return "دوشنبه";
                case "Tuesday":
                    return "سه شنبه";
                case "Wednesday":
                    return "چهارشنبه";
                case "Thursday":
                    return "پنجشنبه";
                case "Friday":
                    return "جمعه";

                default:
                    return "Null";
            }
        }

        public string ConvertMonth()
        {
            PersianCalendar PD = new PersianCalendar();
            switch (Convert.ToString(PD.GetMonth(DateTime.Now)))
            {
                case "1":
                    return "فروردین";
                case "2":
                    return "اردیبهشت";
                case "3":
                    return "خرداد";
                case "4":
                    return "تیر";
                case "5":
                    return "مرداد";
                case "6":
                    return "شهریور";
                case "7":
                    return "مهر";
                case "8":
                    return "آبان";
                case "9":
                    return "آذر";
                case "10":
                    return "دی";
                case "11":
                    return "بهمن";
                case "12":
                    return "اسفند";
                default:
                    return "Null";
            }
        }

        public static string PersianDate(string ChristianDate, bool showClock, bool rightToLeft)
        {
            DateTime dateTime = DateTime.Parse(ChristianDate);
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();
            string str = string.Empty;
            if (rightToLeft)
            {
                str = persianCalendar.GetDayOfMonth(dateTime).ToString("00") + "/" +
                      persianCalendar.GetMonth(dateTime).ToString("00") + "/" +
                      persianCalendar.GetYear(dateTime).ToString("0000");

                if (showClock)
                {
                    str += " " +
                    persianCalendar.GetHour(dateTime).ToString("00") + ":" +
                    persianCalendar.GetMinute(dateTime).ToString("00") + ":" +
                    persianCalendar.GetSecond(dateTime).ToString("00");
                }
            }
            else
            {
                if (showClock)
                {
                    str = persianCalendar.GetHour(dateTime).ToString("00") +
                      ":" + persianCalendar.GetMinute(dateTime).ToString("00") +
                      ":" + persianCalendar.GetSecond(dateTime).ToString("00");
                }
                str += " " +
                      persianCalendar.GetYear(dateTime).ToString("0000") + "-" +
                      persianCalendar.GetMonth(dateTime).ToString("00") + "-" +
                      persianCalendar.GetDayOfMonth(dateTime).ToString("00");
            }
            return str;
        }
    }
}
