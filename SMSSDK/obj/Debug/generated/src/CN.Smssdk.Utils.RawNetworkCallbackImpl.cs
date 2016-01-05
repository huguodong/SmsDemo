using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='RawNetworkCallbackImpl']"
	[global::Android.Runtime.Register ("cn/smssdk/utils/RawNetworkCallbackImpl", DoNotGenerateAcw=true)]
	public partial class RawNetworkCallbackImpl : global::Java.Lang.Object, global::CN.Smssdk.Framework.Network.IRawNetworkCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/utils/RawNetworkCallbackImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RawNetworkCallbackImpl); }
		}

		protected RawNetworkCallbackImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_HashMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='RawNetworkCallbackImpl']/constructor[@name='RawNetworkCallbackImpl' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Ljava/util/HashMap;)V", "")]
		public unsafe RawNetworkCallbackImpl (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (RawNetworkCallbackImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/HashMap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/HashMap;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_HashMap_ == IntPtr.Zero)
					id_ctor_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/HashMap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_HashMap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_HashMap_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onResponse_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Ljava_io_InputStream_Handler ()
		{
			if (cb_onResponse_Ljava_io_InputStream_ == null)
				cb_onResponse_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponse_Ljava_io_InputStream_);
			return cb_onResponse_Ljava_io_InputStream_;
		}

		static void n_OnResponse_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.RawNetworkCallbackImpl __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.RawNetworkCallbackImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onResponse_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='RawNetworkCallbackImpl']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("onResponse", "(Ljava/io/InputStream;)V", "GetOnResponse_Ljava_io_InputStream_Handler")]
		public virtual unsafe void OnResponse (global::System.IO.Stream p0)
		{
			if (id_onResponse_Ljava_io_InputStream_ == IntPtr.Zero)
				id_onResponse_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResponse_Ljava_io_InputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResponse", "(Ljava/io/InputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
