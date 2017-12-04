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
    class ViewHolder : Java.Lang.Object
    {
        public ImageView Photo { get; set; }
        public TextView Country { get; set; }
        public TextView Blogger { get; set; }

    }
}