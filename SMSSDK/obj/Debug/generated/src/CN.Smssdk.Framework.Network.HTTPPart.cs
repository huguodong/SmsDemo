using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='HTTPPart']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/network/HTTPPart", DoNotGenerateAcw=true)]
	public abstract partial class HTTPPart : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/network/HTTPPart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HTTPPart); }
		}

		protected HTTPPart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='HTTPPart']/constructor[@name='HTTPPart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HTTPPart ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HTTPPart)) {
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

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.Network.HTTPPart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.HTTPPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		protected abstract global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='HTTPPart']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")] get;
		}

		static Delegate cb_getInputStreamEntity;
#pragma warning disable 0169
		static Delegate GetGetInputStreamEntityHandler ()
		{
			if (cb_getInputStreamEntity == null)
				cb_getInputStreamEntity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStreamEntity);
			return cb_getInputStreamEntity;
		}

		static IntPtr n_GetInputStreamEntity (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.Network.HTTPPart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.HTTPPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InputStreamEntity);
		}
#pragma warning restore 0169

		static IntPtr id_getInputStreamEntity;
		public virtual unsafe global::Org.Apache.Http.Entity.InputStreamEntity InputStreamEntity {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='HTTPPart']/method[@name='getInputStreamEntity' and count(parameter)=0]"
			[Register ("getInputStreamEntity", "()Lorg/apache/http/entity/InputStreamEntity;", "GetGetInputStreamEntityHandler")]
			get {
				if (id_getInputStreamEntity == IntPtr.Zero)
					id_getInputStreamEntity = JNIEnv.GetMethodID (class_ref, "getInputStreamEntity", "()Lorg/apache/http/entity/InputStreamEntity;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Entity.InputStreamEntity> (JNIEnv.CallObjectMethod  (Handle, id_getInputStreamEntity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Entity.InputStreamEntity> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStreamEntity", "()Lorg/apache/http/entity/InputStreamEntity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Length);
			return cb_length;
		}

		static long n_Length (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.Network.HTTPPart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.HTTPPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='HTTPPart']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()J", "GetLengthHandler")]
		protected abstract long Length ();

		static Delegate cb_setOffset_J;
#pragma warning disable 0169
		static Delegate GetSetOffset_JHandler ()
		{
			if (cb_setOffset_J == null)
				cb_setOffset_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetOffset_J);
			return cb_setOffset_J;
		}

		static void n_SetOffset_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Smssdk.Framework.Network.HTTPPart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.HTTPPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOffset (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOffset_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='HTTPPart']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setOffset", "(J)V", "GetSetOffset_JHandler")]
		public virtual unsafe void SetOffset (long p0)
		{
			if (id_setOffset_J == IntPtr.Zero)
				id_setOffset_J = JNIEnv.GetMethodID (class_ref, "setOffset", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOffset_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOffset", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnReadListener_Lcn_smssdk_framework_network_OnReadListener_;
#pragma warning disable 0169
		static Delegate GetSetOnReadListener_Lcn_smssdk_framework_network_OnReadListener_Handler ()
		{
			if (cb_setOnReadListener_Lcn_smssdk_framework_network_OnReadListener_ == null)
				cb_setOnReadListener_Lcn_smssdk_framework_network_OnReadListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnReadListener_Lcn_smssdk_framework_network_OnReadListener_);
			return cb_setOnReadListener_Lcn_smssdk_framework_network_OnReadListener_;
		}

		static void n_SetOnReadListener_Lcn_smssdk_framework_network_OnReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Network.HTTPPart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.HTTPPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.IOnReadListener p0 = (global::CN.Smssdk.Framework.Network.IOnReadListener)global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IOnReadListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnReadListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnReadListener_Lcn_smssdk_framework_network_OnReadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='HTTPPart']/method[@name='setOnReadListener' and count(parameter)=1 and parameter[1][@type='cn.smssdk.framework.network.OnReadListener']]"
		[Register ("setOnReadListener", "(Lcn/smssdk/framework/network/OnReadListener;)V", "GetSetOnReadListener_Lcn_smssdk_framework_network_OnReadListener_Handler")]
		public virtual unsafe void SetOnReadListener (global::CN.Smssdk.Framework.Network.IOnReadListener p0)
		{
			if (id_setOnReadListener_Lcn_smssdk_framework_network_OnReadListener_ == IntPtr.Zero)
				id_setOnReadListener_Lcn_smssdk_framework_network_OnReadListener_ = JNIEnv.GetMethodID (class_ref, "setOnReadListener", "(Lcn/smssdk/framework/network/OnReadListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnReadListener_Lcn_smssdk_framework_network_OnReadListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnReadListener", "(Lcn/smssdk/framework/network/OnReadListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for CN.Smssdk.Framework.Network.IOnReadListener"
		public event EventHandler<global::CN.Smssdk.Framework.Network.ReadEventArgs> Read {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Smssdk.Framework.Network.IOnReadListener, global::CN.Smssdk.Framework.Network.IOnReadListenerImplementor>(
						ref weak_implementor_SetOnReadListener,
						__CreateIOnReadListenerImplementor,
						SetOnReadListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Smssdk.Framework.Network.IOnReadListener, global::CN.Smssdk.Framework.Network.IOnReadListenerImplementor>(
						ref weak_implementor_SetOnReadListener,
						global::CN.Smssdk.Framework.Network.IOnReadListenerImplementor.__IsEmpty,
						__v => SetOnReadListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnReadListener;

		global::CN.Smssdk.Framework.Network.IOnReadListenerImplementor __CreateIOnReadListenerImplementor ()
		{
			return new global::CN.Smssdk.Framework.Network.IOnReadListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("cn/smssdk/framework/network/HTTPPart", DoNotGenerateAcw=true)]
	internal partial class HTTPPartInvoker : HTTPPart {

		public HTTPPartInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (HTTPPartInvoker); }
		}

		static IntPtr id_getInputStream;
		protected override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='HTTPPart']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				try {
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='HTTPPart']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()J", "GetLengthHandler")]
		protected override unsafe long Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_length);
			} finally {
			}
		}

	}

}
