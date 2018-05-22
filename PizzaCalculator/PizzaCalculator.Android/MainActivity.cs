using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PizzaCalculator.Droid
{
    [Activity(Label = "PizzaCalculator", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            var peopleEntry = FindViewById<EditText>(Resource.Id.peopleEntry);
            var calculate = FindViewById<Button>(Resource.Id.caculateButton);
            var pizzaCount = FindViewById<TextView>(Resource.Id.pizzaCountLabel);

            calculate.Click += delegate
            {
                var count = int.Parse(peopleEntry.Text);
                var pizzas = count / 3;
                pizzaCount.Text = pizzas.ToString();
            };
            //global::Xamarin.Forms.Forms.Init(this, bundle);
            // LoadApplication(new App());
        }
    }
}

