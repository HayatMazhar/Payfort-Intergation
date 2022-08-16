using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Platform.Payfort.Payment.Extension
{

    public static class CommonExtension
    {

        /// <summary>
        /// Converts the object to Long.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns long value
        /// </returns>
        private static long ToLong(this object input)
        {

            long output = 0;

            if ((input == null) || (input == DBNull.Value))
                return output;
            try
            {
                if (string.Empty != input.ToString())
                    output = Convert.ToInt64(input);
            }
            catch { return output; }

            return output;
        }

        /// <summary>
        /// Converts the object to Double.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns double value
        /// </returns>
        private static double ToDouble(this object input)
        {
            double output = 0;

            if ((input == null) || (input == DBNull.Value))
                return output;
            try
            {
                if (string.Empty != input.ToString())
                    output = Convert.ToDouble(input);
            }
            catch { return output; }

            return output;
        }

        /// <summary>
        /// Converts the object to int.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns int value
        /// </returns>
        public static int ToInt(this object input)
        {
            var output = 0;

            if ((input == null) || (input == DBNull.Value))
                return output;
            try
            {
                if (string.Empty != input.ToString())
                    output = Convert.ToInt32(input);
            }
            catch { return output; }

            return output;
        }

        /// <summary>
        /// Converts the object to short.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns short value
        /// </returns>
        public static short ToShort(this object input)
        {
            short output = 0;

            if ((input == null) || (input == DBNull.Value))
                return output;
            try
            {
                if (string.Empty != input.ToString())
                    output = Convert.ToInt16(input);
            }
            catch { return output; }

            return output;
        }

        /// <summary>
        /// Converts the object to short.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns short value
        /// </returns>
        public static char ToChar(this object input)
        {
            var output = '\u0000';

            if ((input == null) || (input == DBNull.Value))
                return output;
            try
            {
                if (string.Empty != input.ToString())
                    output = Convert.ToChar(input);
            }
            catch { return output; }

            return output;
        }

        /// <summary>
        /// Converts the object to bool.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns bool value
        /// </returns>
        public static bool ToBoolen(this object input)
        {
            var output = false;

            if ((input == null) || (input == DBNull.Value))
                return false;
            try
            {
                if (string.Empty != input.ToString())
                    output = Convert.ToBoolean(input);
            }
            catch { return output; }

            return output;
        }

        public static string DecimalToN2(this decimal? input)
        {
            return input?.ToString("N2") ?? "";
        }

        /// <summary>
        /// Converts the object to decimal.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns decimal value
        /// </returns>
        public static decimal ToDecimal(this object input)
        {
            var output = 0.0M;

            if ((input == null) || (input == DBNull.Value))
                return output;
            try
            {
                if (string.Empty != input.ToString())
                    output = Convert.ToDecimal(input);
            }
            catch { return output; }

            return output;
        }

        /// <summary>
        /// Converts the object to float.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns decimal value
        /// </returns>
        public static float ToFloat(this object input)
        {
            var output = (float)0.0;

            if ((input == null) || (input == DBNull.Value))
                return output;
            try
            {
                if (string.Empty != input.ToString())
                    output = float.Parse(input.ToSafeString(), CultureInfo.InvariantCulture);
            }
            catch { return output; }

            return output;
        }

        /// <summary>
        /// Converts the object to save string to avoid exception.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns string value
        /// </returns>
        public static string ToSafeString(this object input)
        {
            return (input ?? string.Empty).ToString();
        }

        /// <summary>
        /// Converts the object to save int to avoid exception.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns string value
        /// </returns>
        public static int ToSafeInt(this object input)
        {
            return (input ?? 0).ToInt();
        }
        public static long ToSafeLong(this object input)
        {
            return (input ?? 0).ToLong();
        }

        /// <summary>
        /// Converts the object to save double to avoid exception.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns string value
        /// </returns>
        public static double ToSafeDouble(this object input)
        {
            return (input ?? 0).ToDouble();
        }

        public static decimal ToSafeDecimal(this object input)
        {
            return (input ?? 0).ToDecimal();
        }

        public static float ToSafeFloat(this object input)
        {
            return (input ?? 0).ToFloat();
        }

        /// <summary>
        ///  Converts the object to save sub string to avoid exception.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string SafeSubstring(this string value, int startIndex, int length)
        {
            return new string((value ?? string.Empty).Skip(startIndex).Take(length).ToArray());
        }

        /// <summary>
        /// Safe remove.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="startIndex">The start index.</param>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        public static string SafeRemove(this string value, int startIndex, int length)
        {
            if (startIndex < 0 || length < 0)
                return value;
            return (value ?? string.Empty).Remove(startIndex, length);
        }

        /// <summary>
        /// Replace a sub string in a string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="oldChar"></param>
        /// <param name="newChar"></param>
        /// <returns></returns>
        public static string SafeReplace(this string value, string oldChar, string newChar)
        {
            if (string.IsNullOrEmpty(oldChar))
                return value;
            return (value ?? string.Empty).Replace(oldChar, newChar);
        }


        /// <summary>
        /// Converts the object to datetime, It will return minimum value in case of exception.
        /// </summary>
        /// <param name="input">Object value</param>
        /// <returns>
        /// Retruns datetime value
        /// </returns>
        public static DateTime ToDateTime(this object input)
        {
            var output = DateTime.MinValue;
            string[] format = { "yyyy-MM-ddTHH:mm:ss", "yyyy-MM-dd", "yyyy-MM-ddTH:mm:ss", "dd/MM/yyyy HH:mm:ss", "dd/MM/yyyy", "MM/dd/yyyy HH:mm:ss", "MM/dd/yyyy", "dd MMM yyyy", "ddd, MMM dd, yyyy", "ddd, MMM d, yyyy", "dd MMM yyyy, ddd", "dd/MM/yyyy HH:mm:ss tt", "dd/M/yyyy HH:mm:ss", "dd/MMM/yyyy hh:mm:ss" };
            if ((input == null) || (input == DBNull.Value))
                return output;
            try
            {
                if (string.Empty != input.ToString())
                    output = DateTime.ParseExact(input.ToString() ?? string.Empty, format, CultureInfo.InvariantCulture, DateTimeStyles.None);
                //   output = Convert.ToDateTime(input);
            }
            catch { return output; }

            return output;
        }

        /// <summary>
        /// Json Formatter
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static string ToJsonFormatter(this string json)
        {
            try
            {
                var builder = new StringBuilder();

                var quotes = false;

                var ignore = false;

                var offset = 0;

                if (string.IsNullOrEmpty(json))
                {
                    return string.Empty;
                }

                json = json.Replace(Environment.NewLine, "").Replace("\t", "");

                foreach (var character in json)
                {
                    switch (character)
                    {
                        case '"':
                            if (!ignore)
                            {
                                quotes = !quotes;
                            }
                            break;
                        case '\'':
                            if (quotes)
                            {
                                ignore = !ignore;
                            }
                            break;
                    }

                    if (quotes)
                    {
                        builder.Append(character);
                    }
                    else
                    {
                        switch (character)
                        {
                            case '{':
                            case '[':
                                builder.Append(character);
                                builder.Append(Environment.NewLine);
                                builder.Append(new string(' ', ++offset * 4));
                                break;
                            case '}':
                            case ']':
                                builder.Append(Environment.NewLine);
                                builder.Append(new string(' ', --offset * 4));
                                builder.Append(character);
                                break;
                            case ',':
                                builder.Append(character);
                                builder.Append(Environment.NewLine);
                                builder.Append(new string(' ', offset * 4));
                                break;
                            case ':':
                                builder.Append(character);
                                builder.Append(' ');
                                break;
                            default:
                                if (character != ' ')
                                {
                                    builder.Append(character);
                                }
                                break;
                        }
                    }
                }

                return builder.ToString().Trim();
            }
            catch (Exception)
            {

                return json;
            }

        }


        /// <summary>
        /// To the date string with culture.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string ToDateString(this DateTime input)
        {
            var output = String.Empty;
            try
            {
                output = input.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                return output;
            }
            return output;
        }

        /// <summary>
        /// To the date string with culture.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string ToDateTimString(this DateTime input)
        {
            var output = String.Empty;
            try
            {
                output = input.ToString("dd MMM yyyy HH:mm", CultureInfo.InvariantCulture);
            }
            catch
            {
                return output;
            }
            return output;
        }

        /// <summary>
        /// To the date string with culture.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static bool IsNull(this string input)
        {
            return string.IsNullOrEmpty(input);
        }


        /// <summary>
        /// Get DateTime value and returns DBNull value in case of exception or MinValue.
        /// </summary>
        /// <param name="input">datetime value</param>
        /// <returns>
        /// Retruns object value
        /// </returns>
        public static object ToDbDateTime(this DateTime input)
        {
            if (input == DateTime.MinValue)
            {
                return null;
            }
            else
            {
                return input;
            }
        }

        /// <summary>
        /// Returns the actual value and DBNull in case of Extention.
        /// </summary>
        /// <param name="input">bool</param>
        /// <returns>
        /// Retruns object value
        /// </returns>
        public static object ToDbBool(this bool? input)
        {

            if (input == null)
            {
                return DBNull.Value;
            }
            else
            {
                return input;
            }
        }

        /// <summary>
        /// To the database bool.
        /// </summary>
        /// <param name="input">if set to <c>true</c> [input].</param>
        /// <returns></returns>
        public static object ToDbBool(this bool input)
        {
            if (input == false)
            {
                return DBNull.Value;
            }
            return true;
        }

        /// <summary>
        /// To check the data existence in the dictionary and obviate the unsignficant issues
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TU"></typeparam>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T, TU>(this IDictionary<T, TU> dictionary)
        {
            return (dictionary == null || dictionary.Count < 1);
        }

        /// <summary>
        /// To check whether the data is present in the list and circumvent the major problems
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return (list == null || list.Count < 1);
        }




        /// <summary>
        /// This method will check whether the string is empty or not and will return the default value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string CheckNullAndReturnString(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// This method will check whether the string is empty or not and will return the default value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string value)
        {

            return string.IsNullOrEmpty(value);

        }

        /// <summary>
        /// Check whether the object is null or not
        /// </summary>
        /// <param name="targetObject"></param>
        /// <returns></returns>
        public static bool IsNull(this Object targetObject)
        {
            return targetObject == null;
        }

        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> items, Func<T, TKey> property)
        {

            return items.GroupBy(property).Select(x => x.First());
        }

        /// <summary>
        /// To the date time string with culture.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        /// DateTime.ParseExact(Model.ApiData.Pickupdate, format, CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None).ToString("dd MMM yyyy")
        public static string ToSabreDateTime(this DateTime input)
        {
            var output = String.Empty;
            try
            {
                output = input.ToString("yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            }
            catch
            {
                return output;
            }
            return output;
        }

        public static string ToJsonString(this object input)
        {
            return JsonConvert.SerializeObject(input);
        }

    }

}
