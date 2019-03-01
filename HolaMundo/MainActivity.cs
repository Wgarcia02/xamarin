using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace HolaMundo
{
    [Activity(Label = "HolaMundoApp", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            HacerTexto(this, "Bienvenido a mi primera aplicación");


        }
        public void HacerTexto(Context ctx, string str)
        {
            Toast.MakeText(ctx, str, ToastLength.Long).Show();
        }

    }
}