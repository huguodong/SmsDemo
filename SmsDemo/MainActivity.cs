using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CN.Smssdk;

namespace SmsDemo
{
    [Activity(Label = "SmsDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button sensmsButton, verificationButton, countryButton;
        private TextView countryTextView, textView2;
        private EditText phoneEditText, verEditText;
        private Handler mHandler;

        private static string APPKEY = "be4b245278a0";
        private static string APPSECRET = "c86ea6bf186063b7e90b30fdc7c1f355";

        public string phString;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            sensmsButton = FindViewById<Button>(Resource.Id.button1);
            verificationButton = FindViewById<Button>(Resource.Id.button2);
            countryButton = FindViewById<Button>(Resource.Id.button3);
            countryTextView = FindViewById<TextView>(Resource.Id.textView1);
            textView2 = FindViewById<TextView>(Resource.Id.textView2);
            phoneEditText = FindViewById<EditText>(Resource.Id.editText1);
            verEditText = FindViewById<EditText>(Resource.Id.editText2);
            
            sensmsButton.Click += sensmsButton_Click;
            verificationButton.Click += sensmsButton_Click;
            countryButton.Click += sensmsButton_Click;

            mHandler = new Handler(x =>
            {
                int ev = x.Arg1;
                int result = x.Arg2;
                var data = x.Obj;
                if (result == SMSSDK.ResultComplete)
                {
                    if (ev == SMSSDK.EventSubmitVerificationCode)
                    {
                        Toast.MakeText(this, "提交验证码成功", ToastLength.Short).Show();
                        textView2.Text = "提交验证码成功";
                    }
                    else if (ev == SMSSDK.EventGetVerificationCode)
                    {
                        Toast.MakeText(this, "验证码已经发送", ToastLength.Short).Show();
                        textView2.Text = "验证码已经发送";
                    }
                    else if (ev == SMSSDK.EventGetSupportedCountries)
                    {
                        Toast.MakeText(this, "获取国家列表成功", ToastLength.Short).Show();
                        countryTextView.Text = data.ToString();
                    }
                }
                else
                {
                    Toast.MakeText(this, "验证码错误", ToastLength.Short).Show();
                }
            });

            SMSSDK.InitSDK(this, APPKEY, APPSECRET);
            var eh = new MyEventHandler(mHandler);
            SMSSDK.RegisterEventHandler(eh);
        }

        protected void sensmsButton_Click(object sender, EventArgs e)
        {
            View v = sender as View;
            if (v != null)
            {
                switch (v.Id)
                {
                    case Resource.Id.button1:
                        {
                            if (String.IsNullOrEmpty(phoneEditText.Text))
                            {
                                Toast.MakeText(this, "电话不能为空", ToastLength.Short).Show();
                            }
                            else
                            {
                                SMSSDK.GetVerificationCode("86", phoneEditText.Text);
                                phString = phoneEditText.Text;
                            }
                        }
                        break;
                    case Resource.Id.button2:
                        {
                            if (String.IsNullOrEmpty(verEditText.Text))
                            {
                                Toast.MakeText(this, "验证码不能为空", ToastLength.Short).Show();
                            }
                            else
                            {
                                SMSSDK.SubmitVerificationCode("86", phString, verEditText.Text);
                            }
                        }
                        break;
                    case Resource.Id.button3:
                        {
                            SMSSDK.GetSupportedCountries();
                            var s = SMSSDK.GroupedCountryList;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            SMSSDK.UnregisterAllEventHandler();
        }
    }
}