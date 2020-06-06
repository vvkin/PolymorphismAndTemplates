using System;
using System.Linq;

namespace LAB_6_2_
{
    static class Color
    {
       private static string[] colors = new string[]
       { "Red", "Blue", "Black", "Yellow", "Green", "White" };
       private static int colorsNumber = 6;

        public static string GetRandomColor()
        {
            var rd = new Random(Guid.NewGuid().GetHashCode());
            return colors[rd.Next(colorsNumber)];
        }

        public static int GetColorsNumber()
        {
            return colorsNumber;
        }

        public static string[] GetRandomColorArray()
        {
            Random rd = new Random(Guid.NewGuid().GetHashCode());
            var size = rd.Next(colorsNumber);
            var result = new string[size];
            for (var i = 0; i < size; ++i)
            {
                var color = GetRandomColor();
                if (!result.Contains(color))
                {
                    result[i] = color;
                }
            }
            return result;
        }
    }
}
