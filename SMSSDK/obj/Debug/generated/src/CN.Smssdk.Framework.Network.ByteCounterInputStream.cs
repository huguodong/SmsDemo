using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='ByteCounterInputStream']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/network/ByteCounterInputStream", DoNotGenerateAcw=true)]
	public partial class ByteCounterInputStream : global::Java.IO.InputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/network/ByteCounterInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteCounterInputStream); }
		}

		protected ByteCounterInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='ByteCounterInputStream']/constructor[@name='ByteCounterInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe ByteCounterInputStream (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ByteCounterInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
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
			global::CN.Smssdk.Framework.Network.ByteCounterInputStream __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.ByteCounterInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		static IntPtr id_read;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='ByteCounterInputStream']/method[@name='read' and count(parameter)=0]"
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

		static Delegate cb_setOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_;
#pragma warning disable 0169
		static Delegate GetSetOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_Handler ()
		{
			if (cb_setOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_ == null)
				cb_setOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_);
			return cb_setOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_;
		}

		static void n_SetOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Network.ByteCounterInputStream __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.ByteCounterInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.IOnReadListener p0 = (global::CN.Smssdk.Framework.Network.IOnReadListener)global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IOnReadListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnInputStreamReadListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='ByteCounterInputStream']/method[@name='setOnInputStreamReadListener' and count(parameter)=1 and parameter[1][@type='cn.smssdk.framework.network.OnReadListener']]"
		[Register ("setOnInputStreamReadListener", "(Lcn/smssdk/framework/network/OnReadListener;)V", "GetSetOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_Handler")]
		public virtual unsafe void SetOnInputStreamReadListener (global::CN.Smssdk.Framework.Network.IOnReadListener p0)
		{
			if (id_setOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_ == IntPtr.Zero)
				id_setOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_ = JNIEnv.GetMethodID (class_ref, "setOnInputStreamReadListener", "(Lcn/smssdk/framework/network/OnReadListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnInputStreamReadListener_Lcn_smssdk_framework_network_OnReadListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnInputStreamReadListener", "(Lcn/smssdk/framework/network/OnReadListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for CN.Smssdk.Framework.Network.IOnReadListener"
		public event EventHandler<global::CN.Smssdk.Framework.Network.ReadEventArgs> InputStreamRead {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Smssdk.Framework.Network.IOnReadListener, global::CN.Smssdk.Framework.Network.IOnReadListenerImplementor>(
						ref weak_implementor_SetOnInputStreamReadListener,
						__CreateIOnReadListenerImplementor,
						SetOnInputStreamReadListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Smssdk.Framework.Network.IOnReadListener, global::CN.Smssdk.Framework.Network.IOnReadListenerImplementor>(
						ref weak_implementor_SetOnInputStreamReadListener,
						global::CN.Smssdk.Framework.Network.IOnReadListenerImplementor.__IsEmpty,
						__v => SetOnInputStreamReadListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnInputStreamReadListener;

		global::CN.Smssdk.Framework.Network.IOnReadListenerImplementor __CreateIOnReadListenerImplementor ()
		{
			return new global::CN.Smssdk.Framework.Network.IOnReadListenerImplementor (this);
		}
#endregion
	}
}
