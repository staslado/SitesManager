﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SitesManager.Common.Extensions
{
    public static class EnumExtensions
    {
        public static string GetName(this Enum e)
        {
            var attributes = (DisplayAttribute[])e.GetType().GetField(e.ToString()).GetCustomAttributes(typeof(DisplayAttribute), false);
            return attributes.Length > 0 ? attributes[0].Name : string.Empty;
        }
    }
}
