using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System;

namespace finalTravelBlogger
{
    [Activity(Label = "finalTravelBlogger", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button btnMenu = FindViewById<Button>(Resource.Id.btnMenu);
            ImageView imgMain = FindViewById<ImageView>(Resource.Id.imgMain);
            imgMain.SetImageResource(Resource.Drawable.android);
            ImageView imgMain1 = FindViewById<ImageView>(Resource.Id.imgMain1);
            imgMain1.SetImageResource(Resource.Drawable.travel);
            TextView tvIntorduction = FindViewById<TextView>(Resource.Id.tvIntroduction);
            string str = "";
            str += "Hello, Welcome to my blogger.\n";
            str += "My name is Lei Zhang from China.\n";
            str += "I like to travel.";
            tvIntorduction.Text = str;

            btnMenu.Click += delegate
            {
                PopupMenu popupMenu = new PopupMenu(this, btnMenu);
                popupMenu.Inflate(Resource.Menu.menu);


                popupMenu.MenuItemClick += (s1, arg1) => {
                    Toast.MakeText(this, arg1.Item.TitleFormatted,ToastLength.Short).Show();
                    switch (arg1.Item.TitleFormatted.ToString())
                    {
                        case "Visited Location":
                            StartActivity(new Intent(Application.Context, typeof(VisitedLocationActivity)));
                            break;
                        case "Next Destinations":
                            StartActivity(new Intent(Application.Context, typeof(NextDestinationActivity)));
                            break;
                        case "About Blogger":
                            StartActivity(new Intent(Application.Context, typeof(AboutBloggerActivity)));
                            break;
                        default:
                            break;
                    }
                };
                popupMenu.Show();
            };
        }

        

    }
}

