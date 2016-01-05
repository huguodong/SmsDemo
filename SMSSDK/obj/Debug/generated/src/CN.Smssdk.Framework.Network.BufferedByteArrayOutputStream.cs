using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='BufferedByteArrayOutputStream']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/network/BufferedByteArrayOutputStream", DoNotGenerateAcw=true)]
	public partial class BufferedByteArrayOutputStream : global::Java.IO.ByteArrayOutputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/network/BufferedByteArrayOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BufferedByteArrayOutputStream); }
		}

		protected BufferedByteArrayOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='BufferedByteArrayOutputStream']/constructor[@name='BufferedByteArrayOutputStream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BufferedByteArrayOutputStream ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BufferedByteArrayOutputStream)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='BufferedByteArrayOutputStream']/constructor[@name='BufferedByteArrayOutputStream' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BufferedByteArrayOutputStream (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BufferedByteArrayOutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_getBufferSize;
#pragma warning disable 0169
		static Delegate GetGetBufferSizeHandler ()
		{
			if (cb_getBufferSize == null)
				cb_getBufferSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBufferSize);
			return cb_getBufferSize;
		}

		static int n_GetBufferSize (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.Network.BufferedByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.BufferedByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferSize;
		}
#pragma warning restore 0169

		static IntPtr id_getBufferSize;
		public virtual unsafe int BufferSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='BufferedByteArrayOutputStream']/method[@name='getBufferSize' and count(parameter)=0]"
			[Register ("getBufferSize", "()I", "GetGetBufferSizeHandler")]
			get {
				if (id_getBufferSize == IntPtr.Zero)
					id_getBufferSize = JNIEnv.GetMethodID (class_ref, "getBufferSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getBufferSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBufferSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getBuffer;
#pragma warning disable 0169
		static Delegate GetGetBufferHandler ()
		{
			if (cb_getBuffer == null)
				cb_getBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuffer);
			return cb_getBuffer;
		}

		static IntPtr n_GetBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.Network.BufferedByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.BufferedByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBuffer ());
		}
#pragma warning restore 0169

		static IntPtr id_getBuffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='BufferedByteArrayOutputStream']/method[@name='getBuffer' and count(parameter)=0]"
		[Register ("getBuffer", "()[B", "GetGetBufferHandler")]
		public virtual unsafe byte[] GetBuffer ()
		{
			if (id_getBuffer == IntPtr.Zero)
				id_getBuffer = JNIEnv.GetMethodID (class_ref, "getBuffer", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBuffer), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBuffer", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_switchBuffer_arrayB;
#pragma warning disable 0169
		static Delegate GetSwitchBuffer_arrayBHandler ()
		{
			if (cb_switchBuffer_arrayB == null)
				cb_switchBuffer_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SwitchBuffer_arrayB);
			return cb_switchBuffer_arrayB;
		}

		static bool n_SwitchBuffer_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Network.BufferedByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.BufferedByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SwitchBuffer (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_switchBuffer_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='BufferedByteArrayOutputStream']/method[@name='switchBuffer' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("switchBuffer", "([B)Z", "GetSwitchBuffer_arrayBHandler")]
		public virtual unsafe bool SwitchBuffer (byte[] p0)
		{
			if (id_switchBuffer_arrayB == IntPtr.Zero)
				id_switchBuffer_arrayB = JNIEnv.GetMethodID (class_ref, "switchBuffer", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_switchBuffer_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "switchBuffer", "([B)Z"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_write_Ljava_nio_ByteBuffer_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_ByteBuffer_IHandler ()
		{
			if (cb_write_Ljava_nio_ByteBuffer_I == null)
				cb_write_Ljava_nio_ByteBuffer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_nio_ByteBuffer_I);
			return cb_write_Ljava_nio_ByteBuffer_I;
		}

		static void n_Write_Ljava_nio_ByteBuffer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::CN.Smssdk.Framework.Network.BufferedByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.BufferedByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='BufferedByteArrayOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;I)V", "GetWrite_Ljava_nio_ByteBuffer_IHandler")]
		public virtual unsafe void Write (global::Java.Nio.ByteBuffer p0, int p1)
		{
			if (id_write_Ljava_nio_ByteBuffer_I == IntPtr.Zero)
				id_write_Ljava_nio_ByteBuffer_I = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_nio_ByteBuffer_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/nio/ByteBuffer;I)V"), __args);
			} finally {
			}
		}

	}
}
