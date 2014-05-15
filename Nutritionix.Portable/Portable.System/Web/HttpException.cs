using System;
using System.Net;

namespace Portable.System.Web
{
	/// <summary>
	/// 
	/// </summary>
	public class HttpException : Exception
	{
		private string errorMessage;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="statusCode"></param>
		/// <param name="message"></param>
		public HttpException(int statusCode, string message)
		{
			WebEventCode = statusCode;
			errorMessage = message;
		}

		/// <summary>
		/// 
		/// </summary>
		public int WebEventCode { get; protected set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public int GetHttpCode()
		{
			return WebEventCode;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetHtmlErrorMessage()
		{
			return errorMessage;
		}
	}
}