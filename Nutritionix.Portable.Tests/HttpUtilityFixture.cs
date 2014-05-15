using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using NUnit.Framework;

namespace Nutritionix.Portable.Tests
{
	[TestFixture]
	class HttpUtilityFixture
	{
		[Test]
		public void UrlEncode_ContainsSpaces()
		{
			string url = "http://example.com/path with spaces/";
			string actual = Portable.Web.HttpUtility.UrlEncode(url);
			string expected = System.Web.HttpUtility.UrlEncode(url);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void UrlEncode_ContainsLessThanGreaterThan()
		{
			
		}
	}
}
