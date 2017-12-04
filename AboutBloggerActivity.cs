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
    [Activity(Label = "AboutBloggerActivity")]
    public class AboutBloggerActivity : Activity
    {
        EditText txtMessage;
        Button btnCall;
        Button btnSms;
        Button btnEmail;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AboutBlogger);

            btnCall = FindViewById<Button>(Resource.Id.btnCall);
            btnSms = FindViewById<Button>(Resource.Id.btnSms);
            btnEmail = FindViewById<Button>(Resource.Id.btnEmail);
            txtMessage = FindViewById<EditText>(Resource.Id.txtMessage);
             

            btnCall.Click += BtnCall_Click;
            btnSms.Click += BtnSms_Click;
            btnEmail.Click += BtnEmail_Click;
        }
        private void BtnCall_Click(object sender, EventArgs e)
        {
            var uri1 = Android.Net.Uri.Parse("tel:123456789");
            var intent = new Intent(Intent.ActionDial, uri1);
            //var intent = new Intent(Intent.ActionCall, uri1); //take call
            StartActivity(intent);
        }

        private void BtnSms_Click(object sender, EventArgs e)
        {
            //string txtNumber = "tel:" + txtMessage.Text;
            var smsUri = Android.Net.Uri.Parse("smsto:123456789");
            var smsIntent = new Intent(Intent.ActionSendto, smsUri);
            var smsContent = txtMessage.Text;
            smsIntent.PutExtra("sms_body", smsContent);
            StartActivity(smsIntent);
        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            Intent email = new Intent(Intent.ActionSend);
            email.SetType("message/rfc822");
            email.PutExtra(Intent.ExtraEmail,
                new String[] { "123456789@gmail.com", "123456789@gmail.com" });

            email.PutExtra(Intent.ExtraCc,
                new String[] { "person3@gmail.com" });

            email.PutExtra(Intent.ExtraSubject, "Hello Email");

            email.PutExtra(Intent.ExtraText,
            "Hello from Lambton");

            StartActivity(Intent.CreateChooser(email, "Send mail"));
        }
    }
}