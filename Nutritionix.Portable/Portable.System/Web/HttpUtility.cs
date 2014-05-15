using System;
using Portable.System.Collections.Specialized;

/*
 * This namespace exists to provide PCL-compatible solutions that mirror the
 * Microsoft System.Web namespace - which isn't currently part of the PCL.
 *				- shawn@codemastershawn.com, 5/14/2014
 */
namespace Portable.System.Web
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// The code for this class was originally obtained from
	/// http://stackoverflow.com/a/20284635/1058872
	/// </remarks>
	public sealed class HttpUtility
	{
		public static HttpValueCollection ParseQueryString(string query)
		{
			if (query == null)
			{
				throw new ArgumentNullException("query");
			}

			if ((query.Length > 0) && (query[0] == '?'))
			{
				query = query.Substring(1);
			}

			return new HttpValueCollection(query, true);
		}

		public static string UrlEncode(string query)
		{
			return Uri.EscapeDataString(query);
		}
	}
}
