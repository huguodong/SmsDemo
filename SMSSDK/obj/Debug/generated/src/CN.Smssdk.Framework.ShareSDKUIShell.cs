using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='ShareSDKUIShell']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/ShareSDKUIShell", DoNotGenerateAcw=true)]
	public partial class ShareSDKUIShell : global::Android.App.Activity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/ShareSDKUIShell", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShareSDKUIShell); }
		}

		protected ShareSDKUIShell (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='ShareSDKUIShell']/constructor[@name='ShareSDKUIShell' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShareSDKUIShell ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ShareSDKUIShell)) {
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

		static IntPtr id_registerExecutor_Lcn_smssdk_framework_FakeActivity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='ShareSDKUIShell']/method[@name='registerExecutor' and count(parameter)=1 and parameter[1][@type='cn.smssdk.framework.FakeActivity']]"
		[Register ("registerExecutor", "(Lcn/smssdk/framework/FakeActivity;)Ljava/lang/String;", "")]
		public static unsafe string RegisterExecutor (global::CN.Smssdk.Framework.FakeActivity p0)
		{
			if (id_registerExecutor_Lcn_smssdk_framework_FakeActivity_ == IntPtr.Zero)
				id_registerExecutor_Lcn_smssdk_framework_FakeActivity_ = JNIEnv.GetStaticMethodID (class_ref, "registerExecutor", "(Lcn/smssdk/framework/FakeActivity;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_registerExecutor_Lcn_smssdk_framework_FakeActivity_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_registerExecutor_Ljava_lang_String_Lcn_smssdk_framework_FakeActivity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='ShareSDKUIShell']/method[@name='registerExecutor' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='cn.smssdk.framework.FakeActivity']]"
		[Register ("registerExecutor", "(Ljava/lang/String;Lcn/smssdk/framework/FakeActivity;)Ljava/lang/String;", "")]
		public static unsafe string RegisterExecutor (string p0, global::CN.Smssdk.Framework.FakeActivity p1)
		{
			if (id_registerExecutor_Ljava_lang_String_Lcn_smssdk_framework_FakeActivity_ == IntPtr.Zero)
				id_registerExecutor_Ljava_lang_String_Lcn_smssdk_framework_FakeActivity_ = JNIEnv.GetStaticMethodID (class_ref, "registerExecutor", "(Ljava/lang/String;Lcn/smssdk/framework/FakeActivity;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_registerExecutor_Ljava_lang_String_Lcn_smssdk_framework_FakeActivity_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
