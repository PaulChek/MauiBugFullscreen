using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MauiBugFullscreen;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity {
    protected override void OnCreate(Bundle savedInstanceState) {
        base.OnCreate(savedInstanceState);

        Window.SetFlags(Android.Views.WindowManagerFlags.LayoutNoLimits, Android.Views.WindowManagerFlags.LayoutNoLimits);
        Window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);
        Window.AddFlags(Android.Views.WindowManagerFlags.DrawsSystemBarBackgrounds);

    }
}
