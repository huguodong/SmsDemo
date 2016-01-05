using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.smssdk.framework.network']/interface[@name='RawNetworkCallback']"
	[Register ("cn/smssdk/framework/network/RawNetworkCallback", "", "CN.Smssdk.Framework.Network.IRawNetworkCallbackInvoker")]
	public partial interface IRawNetworkCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/interface[@name='RawNetworkCallback']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("onResponse", "(Ljava/io/InputStream;)V", "GetOnResponse_Ljava_io_InputStream_Handler:CN.Smssdk.Framework.Network.IRawNetworkCallbackInvoker, SMSSDK")]
		void OnResponse (global::System.IO.Stream p0);

	}

	[global::Android.Runtime.Register ("cn/smssdk/framework/network/RawNetworkCallback", DoNotGenerateAcw=true)]
	internal class IRawNetworkCallbackInvoker : global::Java.Lang.Object, IRawNetworkCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("cn/smssdk/framework/network/RawNetworkCallback");
		IntPtr class_ref;

		public static IRawNetworkCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRawNetworkCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.smssdk.framework.network.RawNetworkCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRawNetworkCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRawNetworkCallbackInvoker); }
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
			global::CN.Smssdk.Framework.Network.IRawNetworkCallback __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IRawNetworkCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_Ljava_io_InputStream_;
		public unsafe void OnResponse (global::System.IO.Stream p0)
		{
			if (id_onResponse_Ljava_io_InputStream_ == IntPtr.Zero)
				id_onResponse_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onResponse_Ljava_io_InputStream_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
