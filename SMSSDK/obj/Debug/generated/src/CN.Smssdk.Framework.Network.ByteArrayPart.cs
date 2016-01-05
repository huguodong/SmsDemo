using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='ByteArrayPart']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/network/ByteArrayPart", DoNotGenerateAcw=true)]
	public partial class ByteArrayPart : global::CN.Smssdk.Framework.Network.HTTPPart {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/network/ByteArrayPart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteArrayPart); }
		}

		protected ByteArrayPart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='ByteArrayPart']/constructor[@name='ByteArrayPart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ByteArrayPart ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ByteArrayPart)) {
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
			global::CN.Smssdk.Framework.Network.ByteArrayPart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.ByteArrayPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream;
		protected override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='ByteArrayPart']/method[@name='getInputStream' and count(parameter)=0]"
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

		static Delegate cb_append_arrayB;
#pragma warning disable 0169
		static Delegate GetAppend_arrayBHandler ()
		{
			if (cb_append_arrayB == null)
				cb_append_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Append_arrayB);
			return cb_append_arrayB;
		}

		static IntPtr n_Append_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Network.ByteArrayPart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.ByteArrayPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='ByteArrayPart']/method[@name='append' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("append", "([B)Lcn/smssdk/framework/network/ByteArrayPart;", "GetAppend_arrayBHandler")]
		public virtual unsafe global::CN.Smssdk.Framework.Network.ByteArrayPart Append (byte[] p0)
		{
			if (id_append_arrayB == IntPtr.Zero)
				id_append_arrayB = JNIEnv.GetMethodID (class_ref, "append", "([B)Lcn/smssdk/framework/network/ByteArrayPart;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::CN.Smssdk.Framework.Network.ByteArrayPart __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.ByteArrayPart> (JNIEnv.CallObjectMethod  (Handle, id_append_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.ByteArrayPart> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([B)Lcn/smssdk/framework/network/ByteArrayPart;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
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
			global::CN.Smssdk.Framework.Network.ByteArrayPart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.ByteArrayPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='ByteArrayPart']/method[@name='length' and count(parameter)=0]"
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
