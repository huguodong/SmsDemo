using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='MultiPartInputStream']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/network/MultiPartInputStream", DoNotGenerateAcw=true)]
	public partial class MultiPartInputStream : global::Java.IO.InputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/network/MultiPartInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiPartInputStream); }
		}

		protected MultiPartInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addInputStream_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetAddInputStream_Ljava_io_InputStream_Handler ()
		{
			if (cb_addInputStream_Ljava_io_InputStream_ == null)
				cb_addInputStream_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddInputStream_Ljava_io_InputStream_);
			return cb_addInputStream_Ljava_io_InputStream_;
		}

		static void n_AddInputStream_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Network.MultiPartInputStream __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.MultiPartInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddInputStream (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addInputStream_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='MultiPartInputStream']/method[@name='addInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("addInputStream", "(Ljava/io/InputStream;)V", "GetAddInputStream_Ljava_io_InputStream_Handler")]
		public virtual unsafe void AddInputStream (global::System.IO.Stream p0)
		{
			if (id_addInputStream_Ljava_io_InputStream_ == IntPtr.Zero)
				id_addInputStream_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "addInputStream", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addInputStream_Ljava_io_InputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addInputStream", "(Ljava/io/InputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read);
			return cb_read;
		}

		static int n_Read (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.Network.MultiPartInputStream __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.MultiPartInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		static IntPtr id_read;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='MultiPartInputStream']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "GetReadHandler")]
		public override unsafe int Read ()
		{
			if (id_read == IntPtr.Zero)
				id_read = JNIEnv.GetMethodID (class_ref, "read", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_read);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "()I"));
			} finally {
			}
		}

	}
}
