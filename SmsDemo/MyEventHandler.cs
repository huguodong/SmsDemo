using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CN.Smssdk;

namespace SmsDemo
{
    public class MyEventHandler : CN.Smssdk.EventHandler
    {
        private Handler mHandler;

        public MyEventHandler(Handler handler)
        {
            this.mHandler = handler;
        }

        public override void AfterEvent(int p0, int p1, Java.Lang.Object p2)
        {
            Message msg = new Message();
            msg.Arg1 = p0;
            msg.Arg2 = p1;
            msg.Obj = p2;
            mHandler.SendMessage(msg);
        }
    }
}