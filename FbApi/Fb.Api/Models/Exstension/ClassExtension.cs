using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Fb.Api.Models.Exstension
{
	static class ClassExtension
	{
		public static string GetDisplayName(this Type t, string paramName)
		{
			return (t.GetProperty(paramName).GetCustomAttribute(typeof(JsonPropertyAttribute), false) as JsonPropertyAttribute).PropertyName;
		}
	
		public static string GetRequestGetString(this Type t)
		{

			return (string.Join(","
				, t.GetProperties()
				.Where(prop =>( prop.PropertyType == typeof(string)
							|| (prop.PropertyType == typeof(IEnumerable<string>)
							|| prop.PropertyType.IsPrimitive
							|| prop.PropertyType.IsValueType))&& prop.GetCustomAttribute(typeof(JsonPropertyAttribute), false) != null)
				.Select(r => GetDisplayName(t, r.Name)))).Trim(',');

		}
		private static IEnumerable<string> GetStrings(JToken jToken)
		{ var list = new List<string>();
			foreach (var j in jToken)
				list.Add((string)j);
			return list;
		}
		//public static T GetValuesFromJson<T>(this T obj, JToken jtoken)
		//{
		//	var t = typeof(T);
		//	var props = t.GetProperties().Where(r => r.GetCustomAttribute(typeof(DisplayAttribute)) != null).ToList() ;
		//	foreach (var prop in props)
		//	{
		//		var displayName = GetDisplayName(t, prop.Name);

		//		if (prop.PropertyType != typeof(string) && !prop.PropertyType.IsPrimitive && !prop.PropertyType.IsValueType)
		//		{
		//			var type = prop.PropertyType;
		//			if (typeof(IEnumerable<string>) == prop.PropertyType)
		//				prop.SetValue(obj, GetStrings(jtoken.SelectToken(displayName)));
		//			else
		//				prop.SetValue(obj, GetValuesFromJson(prop.PropertyType, jtoken.SelectToken(displayName)) )	 ;
		//			continue;
		//		}
		//		var val = jtoken.SelectToken(displayName);
		//		prop.SetValue(obj, Convert.ChangeType(val, prop.PropertyType));
		//	}
		//	return (T)obj;
		//}

		public static string GetRequestPostString(this Type t, object obj)
		{
			return "";
		}


	}
}
