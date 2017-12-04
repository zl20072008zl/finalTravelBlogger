using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace finalTravelBlogger
{
    class Travel
    {
        public string Country { get; set; }
        public string Blogger { get; set; }
        public int Image { get; set; }
        public Travel() { }
        public Travel(string country, string blogger, int image)
        {
            this.Country = country;
            this.Blogger = blogger;
            this.Image = image;
        }
    }
}