using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Attentio.Infrastructure.Models;

namespace Attentio.Infrastructure.Extensions
{
    public static class EnumExtensions
    {
        public static string EnumDescription<T>(this T type)
        {
            var fi = type.GetType().GetField(type.ToString());
            var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof (DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : type.ToString();
        }

        public static List<SimpleTextModel> GetEnumValues(this Enum type)
        {
            var values = Enum.GetValues(type.GetType());
            return (from object value in values
                select new SimpleTextModel
                {
                    Value = value,
                    Text = value.EnumDescription()
                }).ToList();
        }
    }
}
