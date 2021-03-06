/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Copyright (c) 2003-2012 by AG-Software 											 *
 * All Rights Reserved.																 *
 * Contact information for AG-Software is available at http://www.ag-software.de	 *
 *																					 *
 * Licence:																			 *
 * The agsXMPP SDK is released under a dual licence									 *
 * agsXMPP can be used under either of two licences									 *
 * 																					 *
 * A commercial licence which is probably the most appropriate for commercial 		 *
 * corporate use and closed source projects. 										 *
 *																					 *
 * The GNU Public License (GPL) is probably most appropriate for inclusion in		 *
 * other open source projects.														 *
 *																					 *
 * See README.html for details.														 *
 *																					 *
 * For general enquiries visit our website at:										 *
 * http://www.ag-software.de														 *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;

namespace agsXMPP.Util
{
	/// <summary>
	/// Class handles the XMPP time format
	/// </summary>
	public class Time
	{
        /// <summary>
        /// The new standard used by XMPP in JEP-82 (ISO-8601)
        /// <example>1970-01-01T00:00Z</example>
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
		public static DateTime ISO_8601Date(string date)
		{
			// .NET does a great Job parsing this Date profile
			try
			{
				return DateTime.Parse(date);
			}
			catch
			{
				return DateTime.MinValue;
			}
		}

        /// <summary>
        /// The new standard used by XMPP in JEP-82 (ISO-8601)
        /// converts a local DateTime to a ISO-8601 formatted date in UTC format.
        /// <example>1970-01-01T00:00Z</example>
        /// </summary>
		/// <param name="date">local Datetime</param>
		/// <returns></returns>
        public static string ISO_8601Date(DateTime date)
		{
            return date.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
		}

        public static TimeSpan UtcOffset()
        {
            var localZone = TimeZone.CurrentTimeZone;
            var currentDate = DateTime.Now;
            return localZone.GetUtcOffset(currentDate);
        }
	}
}