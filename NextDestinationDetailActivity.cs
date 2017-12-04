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
    [Activity(Label = "NextDestinationDetailActivity")]
    public class NextDestinationDetailActivity : Activity
    {
        TextView tvNextCountry;
        ImageView imgNextImage;
        TextView tvNextBlogger;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.NextDestinationDetail);

            tvNextCountry = FindViewById<TextView>(Resource.Id.tv_NextCountry);
            imgNextImage = FindViewById<ImageView>(Resource.Id.imgNextImage);
            tvNextBlogger = FindViewById<TextView>(Resource.Id.tvNextBlogger);

            int position = Convert.ToInt32(Intent.GetStringExtra("position"));

            tvNextCountry.Text = TravelData.nextTravels[position].Country;
            imgNextImage.SetImageResource(TravelData.nextTravels[position].Image);
            tvNextBlogger.Text = TravelData.nextTravels[position].Blogger;
        }
    }
}