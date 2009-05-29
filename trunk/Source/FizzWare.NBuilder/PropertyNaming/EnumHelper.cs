﻿using System;

namespace FizzWare.NBuilder.PropertyNaming
{
    public static class EnumHelper
    {
        public static int[] GetArrayOf(Type enumType)
        {
            var enumArray = Enum.GetValues(enumType) as int[];
            return enumArray;
        }
    }
}