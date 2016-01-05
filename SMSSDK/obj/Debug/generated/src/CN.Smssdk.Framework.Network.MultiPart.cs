using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='MultiPart']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/network/MultiPart", DoNotGenerateAcw=true)]
	public partial class MultiPart : global::CN.Smssdk.Framework.Network.HTTPPart {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/network/MultiPart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiPart); }
		}

		protected MultiPart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='MultiPart']/constructor[@name='MultiPart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MultiPart ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MultiPart)) {
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
			global::CN.Smssdk.Framework.Network.MultiPart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.MultiPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream;
		protected override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='MultiPart']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_append_Lcn_smssdk_framework_network_HTTPPart_;
#pragma warning disable 0169
		static Delegate GetAppend_Lcn_smssdk_framework_network_HTTPPart_Handler ()
		{
			if (cb_append_Lcn_smssdk_framework_network_HTTPPart_ == null)
				cb_append_Lcn_smssdk_framework_network_HTTPPart_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Append_Lcn_smssdk_framework_network_HTTPPart_);
			return cb_append_Lcn_smssdk_framework_network_HTTPPart_;
		}

		static IntPtr n_Append_Lcn_smssdk_framework_network_HTTPPart_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Network.MultiPart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.MultiPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.HTTPPart p0 = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.HTTPPart> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Lcn_smssdk_framework_network_HTTPPart_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='MultiPart']/method[@name='append' and count(parameter)=1 and parameter[1][@type='cn.smssdk.framework.network.HTTPPart']]"
		[Register ("append", "(Lcn/smssdk/framework/network/HTTPPart;)Lcn/smssdk/framework/network/MultiPart;", "GetAppend_Lcn_smssdk_framework_network_HTTPPart_Handler")]
		public virtual unsafe global::CN.Smssdk.Framework.Network.MultiPart Append (global::CN.Smssdk.Framework.Network.HTTPPart p0)
		{
			if (id_append_Lcn_smssdk_framework_network_HTTPPart_ == IntPtr.Zero)
				id_append_Lcn_smssdk_framework_network_HTTPPart_ = JNIEnv.GetMethodID (class_ref, "append", "(Lcn/smssdk/framework/network/HTTPPart;)Lcn/smssdk/framework/network/MultiPart;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::CN.Smssdk.Framework.Network.MultiPart __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.MultiPart> (JNIEnv.CallObjectMethod  (Handle, id_append_Lcn_smssdk_framework_network_HTTPPart_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.MultiPart> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Lcn/smssdk/framework/network/HTTPPart;)Lcn/smssdk/framework/network/MultiPart;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::CN.Smssdk.Framework.Network.MultiPart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.MultiPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='MultiPart']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()J", "GetLengthHandler")]
		protected override unsafe long Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_length);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()J"));
			} finally {
			}
		}

	}
}
