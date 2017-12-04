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
    [Activity(Label = "VisitedLocationDetailActivity")]
    public class VisitedLocationDetailActivity : Activity
    {
        TextView tvCountry;
        ImageView imgImage;
        TextView tvVisitedBlogger;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VisitedLocationDetail);

            tvCountry = FindViewById<TextView>(Resource.Id.tvCountry);
            imgImage = FindViewById<ImageView>(Resource.Id.imgImage);
            tvVisitedBlogger = FindViewById<TextView>(Resource.Id.tvVisitedBlogger);

            int position = Convert.ToInt32(Intent.GetStringExtra("position"));

            tvCountry.Text = TravelData.visitedTravels[position].Country;
            imgImage.SetImageResource(TravelData.visitedTravels[position].Image);
            tvVisitedBlogger.Text = TravelData.visitedTravels[position].Blogger;
        }
    }
}