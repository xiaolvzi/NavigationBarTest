using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App12.Droid
{
    [Activity(Label = "App12", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity,View.IOnSystemUiVisibilityChangeListener
    {

        int uiOptions;
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
            this.Window.AddFlags(WindowManagerFlags.Fullscreen); // hide the status bar

            uiOptions = (int)Window.DecorView.SystemUiVisibility;

            uiOptions |= (int)SystemUiFlags.LowProfile;
            uiOptions |= (int)SystemUiFlags.Fullscreen;
            uiOptions |= (int)SystemUiFlags.HideNavigation;
            uiOptions |= (int)SystemUiFlags.ImmersiveSticky;

            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)uiOptions;

            Window.DecorView.SetOnSystemUiVisibilityChangeListener(this);
        }

        public void OnSystemUiVisibilityChange([GeneratedEnum] StatusBarVisibility visibility)
        {
            if (((int)visibility & (int)SystemUiFlags.Fullscreen) == 0)
            {
                Window.DecorView.SystemUiVisibility = (StatusBarVisibility)uiOptions;
            }
            
        }
        public override void OnWindowFocusChanged(bool hasFocus)
        {
            base.OnWindowFocusChanged(hasFocus);
            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)((int)SystemUiFlags.Fullscreen
                | (int)SystemUiFlags.ImmersiveSticky
                | (int)SystemUiFlags.LayoutHideNavigation
                | (int)SystemUiFlags.LayoutStable
                | (int)SystemUiFlags.HideNavigation);
        }
    }
}

