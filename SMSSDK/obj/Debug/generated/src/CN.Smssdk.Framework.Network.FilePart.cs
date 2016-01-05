using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='FilePart']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/network/FilePart", DoNotGenerateAcw=true)]
	public partial class FilePart : global::CN.Smssdk.Framework.Network.HTTPPart {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/network/FilePart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FilePart); }
		}

		protected FilePart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='FilePart']/constructor[@name='FilePart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FilePart ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FilePart)) {
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
			global::CN.Smssdk.Framework.Network.FilePart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.FilePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream;
		protected override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='FilePart']/method[@name='getInputStream' and count(parameter)=0]"
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
			global::CN.Smssdk.Framework.Network.FilePart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.FilePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='FilePart']/method[@name='length' and count(parameter)=0]"
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

		static Delegate cb_setFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetFile_Ljava_io_File_Handler ()
		{
			if (cb_setFile_Ljava_io_File_ == null)
				cb_setFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFile_Ljava_io_File_);
			return cb_setFile_Ljava_io_File_;
		}

		static void n_SetFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Network.FilePart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.FilePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='FilePart']/method[@name='setFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setFile", "(Ljava/io/File;)V", "GetSetFile_Ljava_io_File_Handler")]
		public virtual unsafe void SetFile (global::Java.IO.File p0)
		{
			if (id_setFile_Ljava_io_File_ == IntPtr.Zero)
				id_setFile_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "setFile", "(Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFile_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFile", "(Ljava/io/File;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFile_Ljava_lang_String_Handler ()
		{
			if (cb_setFile_Ljava_lang_String_ == null)
				cb_setFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFile_Ljava_lang_String_);
			return cb_setFile_Ljava_lang_String_;
		}

		static void n_SetFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Network.FilePart __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.FilePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='FilePart']/method[@name='setFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFile", "(Ljava/lang/String;)V", "GetSetFile_Ljava_lang_String_Handler")]
		public virtual unsafe void SetFile (string p0)
		{
			if (id_setFile_Ljava_lang_String_ == IntPtr.Zero)
				id_setFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFile", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFile_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFile", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
