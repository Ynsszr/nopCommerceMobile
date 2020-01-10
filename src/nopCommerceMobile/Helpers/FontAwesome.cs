﻿using Xamarin.Forms;

namespace nopCommerceMobile.Helpers
{
    //https://fontawesome.com/cheatsheet/free/solid
    //version 5.12.0

    public class FontAwesomeLabel : Label
    {
        //Todo add all free type
        public static readonly string FontAwesomeFileName = "fa-solid-900";

        public FontAwesomeLabel(string fontAwesomeLabel = null)
        {
            Text = fontAwesomeLabel;
        }
    }

    public class FontAwesomeFontImage : FontImageSource
    {
        public static readonly string FontAwesomeFamilyName =
            Device.RuntimePlatform == Device.Android ? "fa-solid-900.ttf#Font Awesome 5 Free Solid" : "fa-solid-900.ttf";

        public FontAwesomeFontImage()
        {
            FontFamily = FontAwesomeFamilyName;
        }

        public FontAwesomeFontImage(string fontAwesomeLabel = null)
        {
            FontFamily = FontAwesomeFamilyName;
            Glyph = fontAwesomeLabel;
            Size = 22;
        }
    }

    public static class Icon
    {
        //ToDo add pro icons

        // icon code must start with \u
        public static string FaHome = "\uf015";
        public static string FaBars = "\uf0c9";
        public static string FaHearth = "\uf004";
        public static string FaShoppingCart = "\uf07a";
    }
}