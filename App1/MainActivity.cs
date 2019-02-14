using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView vnum1, vnum2, vresult;
        EditText tnum1, tnum2, tresult;
        Button bplus, bsub, bmul, bdiv;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            vnum1 = (TextView)FindViewById(Resource.Id.tvnum1);
            vnum2 = (TextView)FindViewById(Resource.Id.tvnum2);
            
            vresult = (TextView)FindViewById(Resource.Id.tvresult);
            tnum1 = (EditText)FindViewById(Resource.Id.etnum1);
            tnum2 = (EditText)FindViewById(Resource.Id.etnum2);
            tresult = (EditText)FindViewById(Resource.Id.etresult);
            bplus = (Button)FindViewById(Resource.Id.btnPlus);
            bsub = (Button)FindViewById(Resource.Id.btnSub);
            bmul = (Button)FindViewById(Resource.Id.btnMul);
            bdiv = (Button)FindViewById(Resource.Id.btnDiv);

            bplus.Click += delegate
            {
                double a = double.Parse(tnum1.Text);
                double b = double.Parse(tnum2.Text);
                double r = a + b;
                tresult.Text = r.ToString();
            };
            bsub.Click += delegate
            {
                double a = double.Parse(tnum1.Text);
                double b = double.Parse(tnum2.Text);
                double r = a - b;
                tresult.Text = r.ToString();
            };
            bmul.Click += delegate
            {
                double a = double.Parse(tnum1.Text);
                double b = double.Parse(tnum2.Text);
                double r = a * b;
                tresult.Text = r.ToString();
            };
            bdiv.Click += delegate
            {
                double a = double.Parse(tnum1.Text);
                double b = double.Parse(tnum2.Text);
                double r = a / b;
                tresult.Text = r.ToString();
            };
        }
    }
}