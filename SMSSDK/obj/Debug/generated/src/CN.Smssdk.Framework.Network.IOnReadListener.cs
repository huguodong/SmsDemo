using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.smssdk.framework.network']/interface[@name='OnReadListener']"
	[Register ("cn/smssdk/framework/network/OnReadListener", "", "CN.Smssdk.Framework.Network.IOnReadListenerInvoker")]
	public partial interface IOnReadListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/interface[@name='OnReadListener']/method[@name='onRead' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onRead", "(J)V", "GetOnRead_JHandler:CN.Smssdk.Framework.Network.IOnReadListenerInvoker, SMSSDK")]
		void OnRead (long p0);

	}

	[global::Android.Runtime.Register ("cn/smssdk/framework/network/OnReadListener", DoNotGenerateAcw=true)]
	internal class IOnReadListenerInvoker : global::Java.Lang.Object, IOnReadListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("cn/smssdk/framework/network/OnReadListener");
		IntPtr class_ref;

		public static IOnReadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnReadListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.smssdk.framework.network.OnReadListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnReadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnReadListenerInvoker); }
		}

		static Delegate cb_onRead_J;
#pragma warning disable 0169
		static Delegate GetOnRead_JHandler ()
		{
			if (cb_onRead_J == null)
				cb_onRead_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnRead_J);
			return cb_onRead_J;
		}

		static void n_OnRead_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Smssdk.Framework.Network.IOnReadListener __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IOnReadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRead (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRead_J;
		public unsafe void OnRead (long p0)
		{
			if (id_onRead_J == IntPtr.Zero)
				id_onRead_J = JNIEnv.GetMethodID (class_ref, "onRead", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onRead_J, __args);
		}

	}

	public partial class ReadEventArgs : global::System.EventArgs {

		public ReadEventArgs (long p0)
		{
			this.p0 = p0;
		}

		long p0;
		public long P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/cn/smssdk/framework/network/OnReadListenerImplementor")]
	internal sealed partial class IOnReadListenerImplementor : global::Java.Lang.Object, IOnReadListener {

		object sender;

		public IOnReadListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/cn/smssdk/framework/network/OnReadListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ReadEventArgs> Handler;
#pragma warning restore 0649

		public void OnRead (long p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ReadEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnReadListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
