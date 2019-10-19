using System;
using System.Globalization;
using UIKit;

namespace ResourseGeneration.iOS.Extensions
{
    public static class UIExtensions
    {
        public static UIFont ToUIFont(this string stringDimension) 
            => nfloat.TryParse(stringDimension, out nfloat nfloatDimension) ?
                UIFont.SystemFontOfSize(nfloatDimension) :
                UIFont.PreferredBody;

        public static UIColor FromHex(this string hexString) 
            => int.TryParse(hexString.Replace("#", string.Empty), NumberStyles.AllowHexSpecifier, null, out int hexValue)
                ? UIColor.Clear.FromHex(hexValue)
                : UIColor.Clear;

        public static UIColor FromHex(this UIColor color, int hexValue) 
            => UIColor.FromRGB(
                (((float)((hexValue & 0xFF0000) >> 16)) / 255.0f),
                (((float)((hexValue & 0xFF00) >> 8)) / 255.0f),
                (((float)(hexValue & 0xFF)) / 255.0f));
    }
}