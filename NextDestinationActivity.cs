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
    [Activity(Label = "NextDestinationActivity")]
    public class NextDestinationActivity : Activity
    {
        ListView myList;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.NextDestination);

            myList = FindViewById<ListView>(Resource.Id.nextListView);
            myList.Adapter = new TravelAdapter(this, TravelData.nextTravels);
            myList.ItemClick += Listnames_ItemClick;
        }
        private void Listnames_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = new Intent(this, typeof(NextDestinationDetailActivity));
            intent.PutExtra("position", e.Position.ToString());
            StartActivity(intent);
        }
    }
}