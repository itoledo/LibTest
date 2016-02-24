﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using CL.Birdie.Demolibreria;

namespace LibTest
{
    [Activity(Label = "LibTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            button.Click += (sender, args) =>
            {
                var i = new Intent(this.ApplicationContext, typeof(LibraryActivity));
                StartActivity(i);
                //var i = new Intent(this.ApplicationContext, LibraryActivity.class)
                //;

            };
        }
    }
}

