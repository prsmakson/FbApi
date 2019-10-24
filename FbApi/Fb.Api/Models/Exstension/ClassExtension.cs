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
            return (t.GetProperty(paramName).GetCustomAttribute(typeof(DisplayAttribute), false) as DisplayAttribute)?.Name;
        }

        public static string GetRequestGetString(this Type t)
        {

            return (string.Join(","
                , t.GetProperties()
                .Where(prop => prop.PropertyType == typeof(string)
                            || prop.PropertyType.IsPrimitive
                            || prop.PropertyType.IsValueType)
                .Select(r => GetDisplayName(t, r.Name)))).Trim(',');

        }
        public static T GetValuesFromJson<T>(this T obj,JToken jtoken)
        {    var t = typeof(T);
            var props =t.GetProperties().Where(r=>r.GetCustomAttribute(typeof(DisplayAttribute))!=null);
            foreach(var prop in props)
            {
                
                var val =jtoken.SelectToken(GetDisplayName(t, prop.Name));
                prop.SetValue(obj, Convert.ChangeType(val,prop.PropertyType));
            }
            return obj;
        }

        public static string GetRequestPostString(this Type t, object obj)
        {
            return "";
        }


    }
}
