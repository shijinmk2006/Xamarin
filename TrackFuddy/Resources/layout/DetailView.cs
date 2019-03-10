using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Android.Support.V7.AppCompat;

namespace TrackFuddy.Resources.layout
{
    [Activity(Label = "DetailView")]
    public class DetailView : AppCompatActivity
    {
     
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DetailPage);
           
            // Create your application here
        }
    }
}