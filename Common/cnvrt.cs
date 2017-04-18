using System;

namespace jPoor.Common
{
    public class cnvrt
    {
        public static string str(object p)
        {
            try
            {
                return p.ToString();
            }
            catch
            {
                return "";
            }
        }
        public static double double0(object p)
        {
            try
            {
                return Convert.ToDouble(p);
            }
            catch
            {
                return 0;
            }
        }
        public static double double1(string p)
        {
            try
            {
                return Convert.ToDouble(p);
            }
            catch
            {
                return 1;
            }
        }
        public static long long0(object p)
        {
            try
            {
                return Convert.ToInt64(p);
            }
            catch
            {
                return 0;
            }
        }
        public static short short0(object p)
        {
            try
            {
                return Convert.ToInt16(p);
            }
            catch
            {
                return 0;
            }
        }
        public static short short1(object p)
        {
            try
            {
                return Convert.ToInt16(p);
            }
            catch
            {
                return 1;
            }
        }
        public static int int0(object p)
        {
            try
            {
                return Convert.ToInt32(p);
            }
            catch
            {
                return 0;
            }
        }
        public static int int1(object p)
        {
            try
            {
                return Convert.ToInt32(p);
            }
            catch
            {
                return 1;
            }
        }
        public static float float0(object p)
        {
            try
            {
                return float.Parse(p.ToString());
            }
            catch
            {
                return 0;
            }
        }
        public static float float1(object p)
        {
            try
            {
                return float.Parse(p.ToString());
            }
            catch
            {
                return 1;
            }
        }
        public static decimal decimal0(object p)
        {
            try
            {
                return Convert.ToDecimal(p);
            }
            catch
            {
                return 0;
            }
        }
        public static decimal decimal1(object p)
        {
            try
            {
                return Convert.ToDecimal(p);
            }
            catch
            {
                return 1;
            }
        }

        public static Boolean boolF(object p)
        {
            try
            {
                return Convert.ToBoolean(p);
            }
            catch
            {
                return false;
            }
        }
        public static Boolean boolT(object p)
        {
            try
            {
                return Convert.ToBoolean(p);
            }
            catch
            {
                return true;
            }
        }

        public static bool IntToBool(int p)
        {
            try
            {
                if (p == 1)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public static int BoolToInt(bool p)
        {
            if (p)
                return 1;
            else
                return 0;
        }
        public static string ByteToString(byte[] p)
        {
            try
            {
                return System.Text.ASCIIEncoding.ASCII.GetString(p);
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// Convert p to DateTime.
        /// default value is : "1999-01-01 00:00:00"
        /// </summary>
        public static DateTime date(object p)
        {
            try
            {
                return Convert.ToDateTime(strDate(p));
            }
            catch
            {
                return Convert.ToDateTime("1999-01-01 00:00:00");
            }
        }
        /// <summary>
        /// Default format is:"yyyy/MM/dd HH:mm:ss" --
        /// default value is : "1999-01-01 00:00:00"
        /// </summary>
        public static string strDate(object StrDate)
        {
            try
            {
                return Convert.ToDateTime(StrDate).ToString("yyyy/MM/dd HH:mm:ss");
            }
            catch
            {
                return "1999-01-01 00:00:00";
            }
        }
        /// <summary>
        /// Standard format is:"yyyy/MM/dd HH:mm:ss" --
        /// default value is : "1999-01-01 00:00:00"
        /// </summary>
        public static string strDate(object StrDate, string format)
        {
            try
            {
                return Convert.ToDateTime(StrDate).ToString(format);
            }
            catch
            {
                return Convert.ToDateTime("1999-01-01 00:00:00").ToString(format);
            }
        }
        /// <summary>
        /// Convert pDate to english date.
        /// pDate is string persian date or datetime format.
        /// default value is : "1999-01-01 00:00:00"
        /// </summary>
        public static DateTime eDate(object pDate)
        {
            System.Globalization.PersianCalendar PClandar = new System.Globalization.PersianCalendar();
            DateTime myDateRes;
            try
            {
                int pYear = Convert.ToInt32(pDate.ToString().Substring(0, 4));
                int pMonth = Convert.ToInt32(pDate.ToString().Substring(5, 2));
                int pDay = Convert.ToInt32(pDate.ToString().Substring(8, 2));
                int pHour = 0, pMin = 0, pSec = 0;

                if (pDate.ToString().Length > 11)
                {
                    pHour = Convert.ToInt32(pDate.ToString().Substring(11, 2));
                    pMin = Convert.ToInt32(pDate.ToString().Substring(14, 2));
                    pSec = Convert.ToInt32(pDate.ToString().Substring(17, 2));
                }

                myDateRes = PClandar.ToDateTime(pYear, pMonth, pDay, pHour, pMin, pSec, 0);
            }
            catch
            {
                myDateRes = Convert.ToDateTime("1999-01-01 00:00:00");
            }

            return myDateRes;
        }
        /// <summary>
        /// Convert eDate to persian date.
        /// eDate is english datetime.
        /// Default format is:"yyyy/MM/dd HH:mm:ss" --
        /// default value is : ""
        /// </summary>
        public static string pDate(object eDate, bool ShowTime)
        {
            try
            {
                System.Globalization.PersianCalendar PClandar = new System.Globalization.PersianCalendar();
                DateTime EDate = date(eDate);

                if (EDate.Date == date("1999/01/01").Date)
                    return "";
                else
                {
                    string Yr = PClandar.GetYear(EDate).ToString("#0000");
                    string Mo = PClandar.GetMonth(EDate).ToString("#00");
                    string Dy = PClandar.GetDayOfMonth(EDate).ToString("#00");
                    string Hr = PClandar.GetHour(EDate).ToString("#00");
                    string Mi = PClandar.GetMinute(EDate).ToString("#00");
                    string Sc = PClandar.GetSecond(EDate).ToString("#00");

                    if (ShowTime)
                        return Yr + "/" + Mo + "/" + Dy + " " + Hr + ":" + Mi + ":" + Sc;
                    else
                        return Yr + "/" + Mo + "/" + Dy;
                }
            }
            catch
            {
                return "";
                //return "1380-01-01 00:00:00";
            }
        }
        /// <summary>
        /// Convert string time to TimeSpan.
        /// Default format is:"HH:mm:ss" --
        /// default value is : "00:00:00"
        /// </summary>
        public static TimeSpan timeSpan0(object p)
        {
            try
            {
                return new TimeSpan(
                    int0(p.ToString().Substring(0, 2)),
                    int0(p.ToString().Substring(3, 2)),
                    int0(p.ToString().Substring(6, 2)));
            }
            catch
            {
                return new TimeSpan(0, 0, 0);
            }
        }
        /// <summary>
        /// Get time part of a date value. p is a date value.
        /// Default format is:"HH:mm:ss" --
        /// default value is : "00:00:00"
        /// </summary>
        public static string time0(object p)
        {
            try
            {
                return date(p).ToString("HH:mm:ss");
            }
            catch
            {
                return "00:00:00";
            }
        }
        /// <summary>
        /// Get time part of a date value. p is a date value.
        /// default value is : "00:00:00"
        /// </summary>
        public static string time0(object p, string format)
        {
            try
            {
                return date(p).ToString(format);
            }
            catch
            {
                return "00:00:00";
            }
        }

        public static bool CompareTwoStringBigger(string FirstValue, string SecondValue)
        {
            bool myRes = false;
            //Both are Numeric
            if ((IsNummeric(FirstValue)) && (IsNummeric(SecondValue)))
                if (double0(FirstValue) > double0(SecondValue))
                    myRes = true;
                else
                    myRes = false;
            //Min SKU is Numertic
            if ((IsNummeric(FirstValue)) && (!IsNummeric(SecondValue)))
                myRes = true;
            //Current SKU is Numeric
            if ((!IsNummeric(FirstValue)) && (IsNummeric(SecondValue)))
                myRes = false;
            //Both are String
            if ((!IsNummeric(FirstValue)) && (!IsNummeric(SecondValue)))
                if (FirstValue.CompareTo(SecondValue) > 0)
                    myRes = true;
                else
                    myRes = false;

            return myRes;
        }

        public static bool IsNummeric(object p)
        {
            if (double0(p).ToString() == str(p))
                return true;
            else
                return false;
        }
    }
}
