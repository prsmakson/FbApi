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
			return (t.GetProperty(paramName).GetCustomAttribute(typeof(JsonPropertyAttribute), false) as JsonPropertyAttribute)?.PropertyName;
		}

		public static string GetRequestGetstring(this Type t)
		{

			return (string.Join(","
				, t.GetProperties()
				.Where(prop => (prop.PropertyType == typeof(string)
							|| (prop.PropertyType == typeof(IEnumerable<string>)
							|| prop.PropertyType.IsPrimitive
							|| prop.PropertyType.IsValueType)) && prop.GetCustomAttribute(typeof(JsonPropertyAttribute), false) != null)
				.Select(r => GetDisplayName(t, r.Name)))).Trim(',');

		}
		private static string GetEnumIsString(this Type t, string value)
		{

			return (t.GetField(value).GetCustomAttribute(typeof(JsonPropertyAttribute), false)) as JsonPropertyAttribute != null ? value : "";

		}
		public static string GetRequestPostString(this Type t, object obj)
		{
			string result = "";
			var props = t.GetProperties().Where(prop => prop.GetCustomAttribute(typeof(JsonPropertyAttribute), false) != null);
			foreach (var p in props)
			{
				if ((p.PropertyType == typeof(string) || p.PropertyType == typeof(bool?) || p.PropertyType == typeof(long?)))
				{
					var val = p.GetValue(obj);
					if (val != null)
						result += GetDisplayName(t, p.Name) + "=" + val + "&";
				}
				if (p.PropertyType == typeof(DateTime?))
				{
					var val = p.GetValue(obj);
					if (val != null)
						result += GetDisplayName(t, p.Name) + "=" + val.ToString() + "&";
				}
				if (p.PropertyType == typeof(IEnumerable<string>))
				{
					var val = p.GetValue(obj);
					if (val != null)
						result += GetDisplayName(t, p.Name) + "=" + string.Join(",", val) + "&";
				}
				if (Nullable.GetUnderlyingType(p.PropertyType)?.IsEnum ?? false)
				{
					var val = p.GetValue(obj);
					if (val != null)
					{
						var enumT = Nullable.GetUnderlyingType(p.PropertyType);
						var valueIsString = GetEnumIsString(enumT, val.ToString());
						int valueOfenum = (int)Convert.ChangeType(Enum.Parse(enumT, val.ToString()),enumT);
						result += GetDisplayName(t,p.Name) + "=";
						result += valueIsString !=null ? valueIsString : valueOfenum.ToString();
						result += "&";
					}
				}
				if (!p.PropertyType.IsValueType && !p.PropertyType.IsPrimitive && !(Nullable.GetUnderlyingType(p.PropertyType)?.IsEnum ?? false)&&p.PropertyType != typeof(string) && p.PropertyType != typeof(bool?) && p.PropertyType != typeof(long?))
				{
					var val = p.GetValue(obj);
					if (val != null)
					{
						result += GetDisplayName(t, p.Name) + "=" + JsonConvert.SerializeObject(val, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }) + "&";
					}

				}
			}
			return result.Trim('&');
		}
		private static IEnumerable<string> Getstrings(JToken jToken)
		{
			var list = new List<string>();
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
		//				prop.SetValue(obj, Getstrings(jtoken.SelectToken(displayName)));
		//			else
		//				prop.SetValue(obj, GetValuesFromJson(prop.PropertyType, jtoken.SelectToken(displayName)) )	 ;
		//			continue;
		//		}
		//		var val = jtoken.SelectToken(displayName);
		//		prop.SetValue(obj, Convert.ChangeType(val, prop.PropertyType));
		//	}
		//	return (T)obj;
		//}




	}
}
