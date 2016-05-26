using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Linq;
using Xamarin.Forms;
using Plugin.Toasts;

namespace PMF.Droid
{
    [Activity(Label = "PMF", Icon = "@drawable/dmi", Theme = "@style/MyTheme", MainLauncher = true)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            Xamarin.FormsMaps.Init(this, bundle);

            LoadApplication(new App());

            HideIcon();

            DependencyService.Register<ToastNotificatorImplementation>();
            ToastNotificatorImplementation.Init(this);

            Acr.UserDialogs.UserDialogs.Init(this);
        }
        /// <summary>
        /// Warning
        /// Can't disable the activity icon on the MainActivity from XAML
        /// so it has to be done this way
        /// </summary>
        void HideIcon()
        {            
            #pragma warning disable CS0618 // Type or member is obsolete
            ActionBar.SetIcon(new Android.Graphics.Drawables.ColorDrawable(Resources.GetColor(Android.Resource.Color.Transparent)));
            #pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}

