/*
 * This namespace exists to provide PCL-compatible solutions that mirror the
 * Microsoft System.Web namespace - which isn't currently part of the PCL.
 * It is my hope that System.Web (or portions thereof) will be ported to PCL,
 * at which point this code can be removed from the project with no other
 * refactoring being needed.
 *				- shawn@codemastershawn.com, 5/14/2014
 */
namespace System.Collections.Specialized
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// The code for this class was originally obtained from
	/// http://stackoverflow.com/a/20284635/1058872
	/// </remarks>
	public sealed class HttpValue
	{
		public HttpValue()
		{
		}

		public HttpValue(string key, string value)
		{
			this.Key = key;
			this.Value = value;
		}

		public string Key { get; set; }
		public string Value { get; set; }
	}
}