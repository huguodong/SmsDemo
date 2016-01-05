using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDKUIShell']"
	[global::Android.Runtime.Register ("cn/smssdk/SMSSDKUIShell", DoNotGenerateAcw=true)]
	public partial class SMSSDKUIShell : global::CN.Smssdk.Framework.ShareSDKUIShell {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/SMSSDKUIShell", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SMSSDKUIShell); }
		}

		protected SMSSDKUIShell (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDKUIShell']/constructor[@name='SMSSDKUIShell' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SMSSDKUIShell ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SMSSDKUIShell)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
