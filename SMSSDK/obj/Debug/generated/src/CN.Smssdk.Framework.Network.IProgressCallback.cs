using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.smssdk.framework.network']/interface[@name='ProgressCallback']"
	[Register ("cn/smssdk/framework/network/ProgressCallback", "", "CN.Smssdk.Framework.Network.IProgressCallbackInvoker")]
	public partial interface IProgressCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/interface[@name='ProgressCallback']/method[@name='onProgress' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onProgress", "(JJ)V", "GetOnProgress_JJHandler:CN.Smssdk.Framework.Network.IProgressCallbackInvoker, SMSSDK")]
		void OnProgress (long p0, long p1);

	}

	[global::Android.Runtime.Register ("cn/smssdk/framework/network/ProgressCallback", DoNotGenerateAcw=true)]
	internal class IProgressCallbackInvoker : global::Java.Lang.Object, IProgressCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("cn/smssdk/framework/network/ProgressCallback");
		IntPtr class_ref;

		public static IProgressCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProgressCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.smssdk.framework.network.ProgressCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProgressCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IProgressCallbackInvoker); }
		}

		static Delegate cb_onProgress_JJ;
#pragma warning disable 0169
		static Delegate GetOnProgress_JJHandler ()
		{
			if (cb_onProgress_JJ == null)
				cb_onProgress_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_OnProgress_JJ);
			return cb_onProgress_JJ;
		}

		static void n_OnProgress_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::CN.Smssdk.Framework.Network.IProgressCallback __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IProgressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onProgress_JJ;
		public unsafe void OnProgress (long p0, long p1)
		{
			if (id_onProgress_JJ == IntPtr.Zero)
				id_onProgress_JJ = JNIEnv.GetMethodID (class_ref, "onProgress", "(JJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onProgress_JJ, __args);
		}

	}

}
