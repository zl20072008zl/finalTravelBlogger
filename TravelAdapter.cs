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
using Java.Lang;
using Android.Provider;
using Android.Database;

namespace finalTravelBlogger
{
    class TravelAdapter : BaseAdapter<Travel>
    {
        List<Travel> travelList;
        Activity context;
        public TravelAdapter(Activity context,List<Travel> travelList)
        {
            this.travelList = travelList;
            this.context = context;
        }

        public override Travel this[int position]
        {
            get
            {
                return travelList[position];
            }
        }

        public override int Count
        {
            get
            {
                return travelList.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.TravelListItem, parent, false);

                var photo = view.FindViewById<ImageView>(Resource.Id.photoImageView);
                var country = view.FindViewById<TextView>(Resource.Id.countryTextView);
                var blogger = view.FindViewById<TextView>(Resource.Id.bloggerTextView);

                view.Tag = new ViewHolder() { Photo = photo, Country = country, Blogger = blogger };
            }

            var holder = (ViewHolder)view.Tag;

            holder.Photo.SetImageResource(travelList[position].Image);
            holder.Country.Text = travelList[position].Country;
            holder.Blogger.Text = travelList[position].Blogger;

            return view;

        }

    }
}