using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portable.System.ComponentModel
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// The code for this class was adapted from
	/// http://stackoverflow.com/a/18913016/1058872
	/// </remarks>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class DescriptionAttribute : Attribute
	{
    private readonly string description = string.Empty;
    
		public string Description
		{
			get { return description; }
		}
    
		public DescriptionAttribute(string description)
    {
        this.description = description;
    }
	}
}
