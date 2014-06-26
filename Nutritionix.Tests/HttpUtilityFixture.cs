using NUnit.Framework;
using Portable.System.Web;

namespace Nutritionix.Tests
{
	[TestFixture]
	class HttpUtilityFixture
	{
		[Test]
		public void UrlEncode_NullValue()
		{
			string urlpart = null;
			string actual = HttpUtility.UrlEncode(urlpart);
			string expected = string.Empty;

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void UrlEncode_ContainsSpaces()
		{
			string url = "http://example.com/path with spaces/";
			string actual = HttpUtility.UrlEncode(url);
			string expected = System.Web.HttpUtility.UrlEncode(url);

			// TODO: Our code is encoding spaces as entities instead of '+'
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void UrlEncode_ContainsLessThanGreaterThan()
		{
			Assert.Fail("Test not written");
		}
	}
}
