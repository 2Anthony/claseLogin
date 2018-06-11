using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnAuth;
        String username="anthony";
        String password="123";
        String token = "12345678";
        EditText txtuser;
        EditText txtpass;
        EditText txttok;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnAuth = FindViewById<Button>(Resource.Id.btnAuth);
            txtuser = FindViewById<EditText>(Resource.Id.editText1);
            txtpass = FindViewById<EditText> (Resource.Id.editText2);
            txttok = FindViewById<EditText>(Resource.Id.editText3);
            btnAuth.Click += DoAuthentication;
        }
        private void DoAuthentication(object sender, EventArgs e)
        {
       
            if (Convert.ToString(txtuser.Text) == username && (Convert.ToString(txtpass.Text)== password) && (Convert.ToString(txttok.Text) == token))
            {
                Toast.MakeText(this, "Usuario Válido", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "Usuario Inválido", ToastLength.Short).Show();
            }
        }
    }
}

