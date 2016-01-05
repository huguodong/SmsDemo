using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']"
	[global::Android.Runtime.Register ("cn/smssdk/ReflectableEnventHandler", DoNotGenerateAcw=true)]
	public partial class ReflectableEnventHandler : global::CN.Smssdk.EventHandler {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/ReflectableEnventHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReflectableEnventHandler); }
		}

		protected ReflectableEnventHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']/constructor[@name='ReflectableEnventHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReflectableEnventHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ReflectableEnventHandler)) {
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

		static Delegate cb_setAfterEventCallback_ILandroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetSetAfterEventCallback_ILandroid_os_Handler_Callback_Handler ()
		{
			if (cb_setAfterEventCallback_ILandroid_os_Handler_Callback_ == null)
				cb_setAfterEventCallback_ILandroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetAfterEventCallback_ILandroid_os_Handler_Callback_);
			return cb_setAfterEventCallback_ILandroid_os_Handler_Callback_;
		}

		static void n_SetAfterEventCallback_ILandroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Smssdk.ReflectableEnventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.ReflectableEnventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler.ICallback p1 = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAfterEventCallback (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAfterEventCallback_ILandroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']/method[@name='setAfterEventCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("setAfterEventCallback", "(ILandroid/os/Handler$Callback;)V", "GetSetAfterEventCallback_ILandroid_os_Handler_Callback_Handler")]
		public virtual unsafe void SetAfterEventCallback (int p0, global::Android.OS.Handler.ICallback p1)
		{
			if (id_setAfterEventCallback_ILandroid_os_Handler_Callback_ == IntPtr.Zero)
				id_setAfterEventCallback_ILandroid_os_Handler_Callback_ = JNIEnv.GetMethodID (class_ref, "setAfterEventCallback", "(ILandroid/os/Handler$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAfterEventCallback_ILandroid_os_Handler_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAfterEventCallback", "(ILandroid/os/Handler$Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBeforeEventCallback_ILandroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetSetBeforeEventCallback_ILandroid_os_Handler_Callback_Handler ()
		{
			if (cb_setBeforeEventCallback_ILandroid_os_Handler_Callback_ == null)
				cb_setBeforeEventCallback_ILandroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetBeforeEventCallback_ILandroid_os_Handler_Callback_);
			return cb_setBeforeEventCallback_ILandroid_os_Handler_Callback_;
		}

		static void n_SetBeforeEventCallback_ILandroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Smssdk.ReflectableEnventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.ReflectableEnventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler.ICallback p1 = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetBeforeEventCallback (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setBeforeEventCallback_ILandroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']/method[@name='setBeforeEventCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("setBeforeEventCallback", "(ILandroid/os/Handler$Callback;)V", "GetSetBeforeEventCallback_ILandroid_os_Handler_Callback_Handler")]
		public virtual unsafe void SetBeforeEventCallback (int p0, global::Android.OS.Handler.ICallback p1)
		{
			if (id_setBeforeEventCallback_ILandroid_os_Handler_Callback_ == IntPtr.Zero)
				id_setBeforeEventCallback_ILandroid_os_Handler_Callback_ = JNIEnv.GetMethodID (class_ref, "setBeforeEventCallback", "(ILandroid/os/Handler$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBeforeEventCallback_ILandroid_os_Handler_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeforeEventCallback", "(ILandroid/os/Handler$Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnRegisterCallback_ILandroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetSetOnRegisterCallback_ILandroid_os_Handler_Callback_Handler ()
		{
			if (cb_setOnRegisterCallback_ILandroid_os_Handler_Callback_ == null)
				cb_setOnRegisterCallback_ILandroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetOnRegisterCallback_ILandroid_os_Handler_Callback_);
			return cb_setOnRegisterCallback_ILandroid_os_Handler_Callback_;
		}

		static void n_SetOnRegisterCallback_ILandroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Smssdk.ReflectableEnventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.ReflectableEnventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler.ICallback p1 = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRegisterCallback (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setOnRegisterCallback_ILandroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']/method[@name='setOnRegisterCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("setOnRegisterCallback", "(ILandroid/os/Handler$Callback;)V", "GetSetOnRegisterCallback_ILandroid_os_Handler_Callback_Handler")]
		public virtual unsafe void SetOnRegisterCallback (int p0, global::Android.OS.Handler.ICallback p1)
		{
			if (id_setOnRegisterCallback_ILandroid_os_Handler_Callback_ == IntPtr.Zero)
				id_setOnRegisterCallback_ILandroid_os_Handler_Callback_ = JNIEnv.GetMethodID (class_ref, "setOnRegisterCallback", "(ILandroid/os/Handler$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnRegisterCallback_ILandroid_os_Handler_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnRegisterCallback", "(ILandroid/os/Handler$Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnUnregisterCallback_ILandroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetSetOnUnregisterCallback_ILandroid_os_Handler_Callback_Handler ()
		{
			if (cb_setOnUnregisterCallback_ILandroid_os_Handler_Callback_ == null)
				cb_setOnUnregisterCallback_ILandroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetOnUnregisterCallback_ILandroid_os_Handler_Callback_);
			return cb_setOnUnregisterCallback_ILandroid_os_Handler_Callback_;
		}

		static void n_SetOnUnregisterCallback_ILandroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Smssdk.ReflectableEnventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.ReflectableEnventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler.ICallback p1 = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOnUnregisterCallback (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setOnUnregisterCallback_ILandroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='ReflectableEnventHandler']/method[@name='setOnUnregisterCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("setOnUnregisterCallback", "(ILandroid/os/Handler$Callback;)V", "GetSetOnUnregisterCallback_ILandroid_os_Handler_Callback_Handler")]
		public virtual unsafe void SetOnUnregisterCallback (int p0, global::Android.OS.Handler.ICallback p1)
		{
			if (id_setOnUnregisterCallback_ILandroid_os_Handler_Callback_ == IntPtr.Zero)
				id_setOnUnregisterCallback_ILandroid_os_Handler_Callback_ = JNIEnv.GetMethodID (class_ref, "setOnUnregisterCallback", "(ILandroid/os/Handler$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnUnregisterCallback_ILandroid_os_Handler_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnUnregisterCallback", "(ILandroid/os/Handler$Callback;)V"), __args);
			} finally {
			}
		}

	}
}
