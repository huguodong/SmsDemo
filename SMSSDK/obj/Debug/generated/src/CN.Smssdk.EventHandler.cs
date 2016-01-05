using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']"
	[global::Android.Runtime.Register ("cn/smssdk/EventHandler", DoNotGenerateAcw=true)]
	public partial class EventHandler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/EventHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventHandler); }
		}

		protected EventHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']/constructor[@name='EventHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EventHandler)) {
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

		static Delegate cb_afterEvent_IILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAfterEvent_IILjava_lang_Object_Handler ()
		{
			if (cb_afterEvent_IILjava_lang_Object_ == null)
				cb_afterEvent_IILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_AfterEvent_IILjava_lang_Object_);
			return cb_afterEvent_IILjava_lang_Object_;
		}

		static void n_AfterEvent_IILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::CN.Smssdk.EventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.EventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AfterEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_afterEvent_IILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']/method[@name='afterEvent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("afterEvent", "(IILjava/lang/Object;)V", "GetAfterEvent_IILjava_lang_Object_Handler")]
		public virtual unsafe void AfterEvent (int p0, int p1, global::Java.Lang.Object p2)
		{
			if (id_afterEvent_IILjava_lang_Object_ == IntPtr.Zero)
				id_afterEvent_IILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "afterEvent", "(IILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_afterEvent_IILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "afterEvent", "(IILjava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_beforeEvent_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetBeforeEvent_ILjava_lang_Object_Handler ()
		{
			if (cb_beforeEvent_ILjava_lang_Object_ == null)
				cb_beforeEvent_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_BeforeEvent_ILjava_lang_Object_);
			return cb_beforeEvent_ILjava_lang_Object_;
		}

		static void n_BeforeEvent_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Smssdk.EventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.EventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BeforeEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_beforeEvent_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']/method[@name='beforeEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("beforeEvent", "(ILjava/lang/Object;)V", "GetBeforeEvent_ILjava_lang_Object_Handler")]
		public virtual unsafe void BeforeEvent (int p0, global::Java.Lang.Object p1)
		{
			if (id_beforeEvent_ILjava_lang_Object_ == IntPtr.Zero)
				id_beforeEvent_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "beforeEvent", "(ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_beforeEvent_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beforeEvent", "(ILjava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRegister;
#pragma warning disable 0169
		static Delegate GetOnRegisterHandler ()
		{
			if (cb_onRegister == null)
				cb_onRegister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRegister);
			return cb_onRegister;
		}

		static void n_OnRegister (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.EventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.EventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRegister ();
		}
#pragma warning restore 0169

		static IntPtr id_onRegister;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']/method[@name='onRegister' and count(parameter)=0]"
		[Register ("onRegister", "()V", "GetOnRegisterHandler")]
		public virtual unsafe void OnRegister ()
		{
			if (id_onRegister == IntPtr.Zero)
				id_onRegister = JNIEnv.GetMethodID (class_ref, "onRegister", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRegister);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRegister", "()V"));
			} finally {
			}
		}

		static Delegate cb_onUnregister;
#pragma warning disable 0169
		static Delegate GetOnUnregisterHandler ()
		{
			if (cb_onUnregister == null)
				cb_onUnregister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUnregister);
			return cb_onUnregister;
		}

		static void n_OnUnregister (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.EventHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.EventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnregister ();
		}
#pragma warning restore 0169

		static IntPtr id_onUnregister;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='EventHandler']/method[@name='onUnregister' and count(parameter)=0]"
		[Register ("onUnregister", "()V", "GetOnUnregisterHandler")]
		public virtual unsafe void OnUnregister ()
		{
			if (id_onUnregister == IntPtr.Zero)
				id_onUnregister = JNIEnv.GetMethodID (class_ref, "onUnregister", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onUnregister);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUnregister", "()V"));
			} finally {
			}
		}

	}
}
