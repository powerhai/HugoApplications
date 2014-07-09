using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace Sagua.Global.Common
{
	public static class EnumExtension
	{

//		public static LocDescriptionAttribute GetLocDescription(this Enum enumObj)
//		{
//			var field = enumObj.GetType().GetField(enumObj.ToString());
//			var attrs = Attribute.GetCustomAttributes(field, typeof(LocDescriptionAttribute), false);
//			if (attrs.Length <= 0 && attrs.Length <=0 )
//				return null;
//			return attrs.First() as LocDescriptionAttribute;
//		}
//
//		public static string GetLocalizationString(this Enum enumObj)
//		{
//			var rv =  GetLocDescription(enumObj);
//			return rv != null ? rv.Value : enumObj.ToString();
//		}

		public static List<Enum> GetChildren(Type type)
		{
			var items = type
				.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static)
				.Select((info, i) => (Enum) info.GetValue(info)).ToList();

			return items;
		}
		public static List<Enum> GetChildren(this Enum enumObj)
		{
			return GetChildren(enumObj.GetType());
		}
	}

}
