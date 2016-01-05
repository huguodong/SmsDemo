using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/FakeActivity", DoNotGenerateAcw=true)]
	public partial class FakeActivity : global::Java.Lang.Object {


		static IntPtr activity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/field[@name='activity']"
		[Register ("activity")]
		protected global::Android.App.Activity Activity {
			get {
				if (activity_jfieldId == IntPtr.Zero)
					activity_jfieldId = JNIEnv.GetFieldID (class_ref, "activity", "Landroid/app/Activity;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, activity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (activity_jfieldId == IntPtr.Zero)
					activity_jfieldId = JNIEnv.GetFieldID (class_ref, "activity", "Landroid/app/Activity;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, activity_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/FakeActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FakeActivity); }
		}

		protected FakeActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/constructor[@name='FakeActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FakeActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FakeActivity)) {
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

		static Delegate cb_getContentView;
#pragma warning disable 0169
		static Delegate GetGetContentViewHandler ()
		{
			if (cb_getContentView == null)
				cb_getContentView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentView);
			return cb_getContentView;
		}

		static IntPtr n_GetContentView (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentView);
		}
#pragma warning restore 0169

		static IntPtr id_getContentView;
		public virtual unsafe global::Android.Views.View ContentView {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='getContentView' and count(parameter)=0]"
			[Register ("getContentView", "()Landroid/view/View;", "GetGetContentViewHandler")]
			get {
				if (id_getContentView == IntPtr.Zero)
					id_getContentView = JNIEnv.GetMethodID (class_ref, "getContentView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getContentView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrientation);
			return cb_getOrientation;
		}

		static int n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation;
		public virtual unsafe int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")]
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOrientation);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientation", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getParent;
#pragma warning disable 0169
		static Delegate GetGetParentHandler ()
		{
			if (cb_getParent == null)
				cb_getParent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParent);
			return cb_getParent;
		}

		static IntPtr n_GetParent (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parent);
		}
#pragma warning restore 0169

		static IntPtr id_getParent;
		public virtual unsafe global::CN.Smssdk.Framework.FakeActivity Parent {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='getParent' and count(parameter)=0]"
			[Register ("getParent", "()Lcn/smssdk/framework/FakeActivity;", "GetGetParentHandler")]
			get {
				if (id_getParent == IntPtr.Zero)
					id_getParent = JNIEnv.GetMethodID (class_ref, "getParent", "()Lcn/smssdk/framework/FakeActivity;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (JNIEnv.CallObjectMethod  (Handle, id_getParent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParent", "()Lcn/smssdk/framework/FakeActivity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_findViewById_I;
#pragma warning disable 0169
		static Delegate GetFindViewById_IHandler ()
		{
			if (cb_findViewById_I == null)
				cb_findViewById_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_FindViewById_I);
			return cb_findViewById_I;
		}

		static IntPtr n_FindViewById_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindViewById (p0));
		}
#pragma warning restore 0169

		static IntPtr id_findViewById_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='findViewById' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("findViewById", "(I)Landroid/view/View;", "GetFindViewById_IHandler")]
		public virtual unsafe global::Android.Views.View FindViewById (int p0)
		{
			if (id_findViewById_I == IntPtr.Zero)
				id_findViewById_I = JNIEnv.GetMethodID (class_ref, "findViewById", "(I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_findViewById_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findViewById", "(I)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findViewByResName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindViewByResName_Ljava_lang_String_Handler ()
		{
			if (cb_findViewByResName_Ljava_lang_String_ == null)
				cb_findViewByResName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindViewByResName_Ljava_lang_String_);
			return cb_findViewByResName_Ljava_lang_String_;
		}

		static IntPtr n_FindViewByResName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindViewByResName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findViewByResName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='findViewByResName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findViewByResName", "(Ljava/lang/String;)Landroid/view/View;", "GetFindViewByResName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Views.View FindViewByResName (string p0)
		{
			if (id_findViewByResName_Ljava_lang_String_ == IntPtr.Zero)
				id_findViewByResName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findViewByResName", "(Ljava/lang/String;)Landroid/view/View;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Views.View __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_findViewByResName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findViewByResName", "(Ljava/lang/String;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_finish;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "")]
		public unsafe void Finish ()
		{
			if (id_finish == IntPtr.Zero)
				id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_finish);
			} finally {
			}
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static void n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public virtual unsafe void OnActivityResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onActivityResult_IILandroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResult", "(IILandroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
				cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfigurationChanged_Landroid_content_res_Configuration_);
			return cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		static void n_OnConfigurationChanged_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConfigurationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConfigurationChanged_Landroid_content_res_Configuration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onConfigurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public virtual unsafe void OnConfigurationChanged (global::Android.Content.Res.Configuration p0)
		{
			if (id_onConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_onConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onConfigurationChanged_Landroid_content_res_Configuration_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCreate;
#pragma warning disable 0169
		static Delegate GetOnCreateHandler ()
		{
			if (cb_onCreate == null)
				cb_onCreate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCreate);
			return cb_onCreate;
		}

		static void n_OnCreate (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate ();
		}
#pragma warning restore 0169

		static IntPtr id_onCreate;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()V", "GetOnCreateHandler")]
		public virtual unsafe void OnCreate ()
		{
			if (id_onCreate == IntPtr.Zero)
				id_onCreate = JNIEnv.GetMethodID (class_ref, "onCreate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreate);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "()V"));
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_onFinish;
#pragma warning disable 0169
		static Delegate GetOnFinishHandler ()
		{
			if (cb_onFinish == null)
				cb_onFinish = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnFinish);
			return cb_onFinish;
		}

		static bool n_OnFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnFinish ();
		}
#pragma warning restore 0169

		static IntPtr id_onFinish;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onFinish' and count(parameter)=0]"
		[Register ("onFinish", "()Z", "GetOnFinishHandler")]
		public virtual unsafe bool OnFinish ()
		{
			if (id_onFinish == IntPtr.Zero)
				id_onFinish = JNIEnv.GetMethodID (class_ref, "onFinish", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_onFinish);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFinish", "()Z"));
			} finally {
			}
		}

		static Delegate cb_onKeyEvent_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKeyEvent_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKeyEvent_ILandroid_view_KeyEvent_ == null)
				cb_onKeyEvent_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnKeyEvent_ILandroid_view_KeyEvent_);
			return cb_onKeyEvent_ILandroid_view_KeyEvent_;
		}

		static bool n_OnKeyEvent_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyEvent (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKeyEvent_ILandroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onKeyEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
		[Register ("onKeyEvent", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyEvent_ILandroid_view_KeyEvent_Handler")]
		public virtual unsafe bool OnKeyEvent (int p0, global::Android.Views.KeyEvent p1)
		{
			if (id_onKeyEvent_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_onKeyEvent_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "onKeyEvent", "(ILandroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onKeyEvent_ILandroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyEvent", "(ILandroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onNewIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnNewIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_onNewIntent_Landroid_content_Intent_ == null)
				cb_onNewIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNewIntent_Landroid_content_Intent_);
			return cb_onNewIntent_Landroid_content_Intent_;
		}

		static void n_OnNewIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNewIntent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNewIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onNewIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onNewIntent", "(Landroid/content/Intent;)V", "GetOnNewIntent_Landroid_content_Intent_Handler")]
		protected virtual unsafe void OnNewIntent (global::Android.Content.Intent p0)
		{
			if (id_onNewIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_onNewIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onNewIntent", "(Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onNewIntent_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewIntent", "(Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPause);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPause", "()V"));
			} finally {
			}
		}

		static Delegate cb_onRestart;
#pragma warning disable 0169
		static Delegate GetOnRestartHandler ()
		{
			if (cb_onRestart == null)
				cb_onRestart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRestart);
			return cb_onRestart;
		}

		static void n_OnRestart (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRestart ();
		}
#pragma warning restore 0169

		static IntPtr id_onRestart;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onRestart' and count(parameter)=0]"
		[Register ("onRestart", "()V", "GetOnRestartHandler")]
		public virtual unsafe void OnRestart ()
		{
			if (id_onRestart == IntPtr.Zero)
				id_onRestart = JNIEnv.GetMethodID (class_ref, "onRestart", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRestart);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestart", "()V"));
			} finally {
			}
		}

		static Delegate cb_onResult_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetOnResult_Ljava_util_HashMap_Handler ()
		{
			if (cb_onResult_Ljava_util_HashMap_ == null)
				cb_onResult_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResult_Ljava_util_HashMap_);
			return cb_onResult_Ljava_util_HashMap_;
		}

		static void n_OnResult_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onResult_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("onResult", "(Ljava/util/HashMap;)V", "GetOnResult_Ljava_util_HashMap_Handler")]
		public virtual unsafe void OnResult (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_onResult_Ljava_util_HashMap_ == IntPtr.Zero)
				id_onResult_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Ljava/util/HashMap;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResult_Ljava_util_HashMap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResult", "(Ljava/util/HashMap;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResume);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "()V"));
			} finally {
			}
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStart);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStop", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestLandscapeOrientation;
#pragma warning disable 0169
		static Delegate GetRequestLandscapeOrientationHandler ()
		{
			if (cb_requestLandscapeOrientation == null)
				cb_requestLandscapeOrientation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestLandscapeOrientation);
			return cb_requestLandscapeOrientation;
		}

		static void n_RequestLandscapeOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestLandscapeOrientation ();
		}
#pragma warning restore 0169

		static IntPtr id_requestLandscapeOrientation;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='requestLandscapeOrientation' and count(parameter)=0]"
		[Register ("requestLandscapeOrientation", "()V", "GetRequestLandscapeOrientationHandler")]
		public virtual unsafe void RequestLandscapeOrientation ()
		{
			if (id_requestLandscapeOrientation == IntPtr.Zero)
				id_requestLandscapeOrientation = JNIEnv.GetMethodID (class_ref, "requestLandscapeOrientation", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_requestLandscapeOrientation);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestLandscapeOrientation", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestPortraitOrientation;
#pragma warning disable 0169
		static Delegate GetRequestPortraitOrientationHandler ()
		{
			if (cb_requestPortraitOrientation == null)
				cb_requestPortraitOrientation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestPortraitOrientation);
			return cb_requestPortraitOrientation;
		}

		static void n_RequestPortraitOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestPortraitOrientation ();
		}
#pragma warning restore 0169

		static IntPtr id_requestPortraitOrientation;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='requestPortraitOrientation' and count(parameter)=0]"
		[Register ("requestPortraitOrientation", "()V", "GetRequestPortraitOrientationHandler")]
		public virtual unsafe void RequestPortraitOrientation ()
		{
			if (id_requestPortraitOrientation == IntPtr.Zero)
				id_requestPortraitOrientation = JNIEnv.GetMethodID (class_ref, "requestPortraitOrientation", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_requestPortraitOrientation);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestPortraitOrientation", "()V"));
			} finally {
			}
		}

		static Delegate cb_runOnUIThread_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRunOnUIThread_Ljava_lang_Runnable_Handler ()
		{
			if (cb_runOnUIThread_Ljava_lang_Runnable_ == null)
				cb_runOnUIThread_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RunOnUIThread_Ljava_lang_Runnable_);
			return cb_runOnUIThread_Ljava_lang_Runnable_;
		}

		static void n_RunOnUIThread_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RunOnUIThread (p0);
		}
#pragma warning restore 0169

		static IntPtr id_runOnUIThread_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='runOnUIThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runOnUIThread", "(Ljava/lang/Runnable;)V", "GetRunOnUIThread_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void RunOnUIThread (global::Java.Lang.IRunnable p0)
		{
			if (id_runOnUIThread_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_runOnUIThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "runOnUIThread", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_runOnUIThread_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runOnUIThread", "(Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_runOnUIThread_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetRunOnUIThread_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_runOnUIThread_Ljava_lang_Runnable_J == null)
				cb_runOnUIThread_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_RunOnUIThread_Ljava_lang_Runnable_J);
			return cb_runOnUIThread_Ljava_lang_Runnable_J;
		}

		static void n_RunOnUIThread_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RunOnUIThread (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_runOnUIThread_Ljava_lang_Runnable_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='runOnUIThread' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
		[Register ("runOnUIThread", "(Ljava/lang/Runnable;J)V", "GetRunOnUIThread_Ljava_lang_Runnable_JHandler")]
		public virtual unsafe void RunOnUIThread (global::Java.Lang.IRunnable p0, long p1)
		{
			if (id_runOnUIThread_Ljava_lang_Runnable_J == IntPtr.Zero)
				id_runOnUIThread_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "runOnUIThread", "(Ljava/lang/Runnable;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_runOnUIThread_Ljava_lang_Runnable_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runOnUIThread", "(Ljava/lang/Runnable;J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setActivity_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetSetActivity_Landroid_app_Activity_Handler ()
		{
			if (cb_setActivity_Landroid_app_Activity_ == null)
				cb_setActivity_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivity_Landroid_app_Activity_);
			return cb_setActivity_Landroid_app_Activity_;
		}

		static void n_SetActivity_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActivity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActivity_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='setActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("setActivity", "(Landroid/app/Activity;)V", "GetSetActivity_Landroid_app_Activity_Handler")]
		public virtual unsafe void SetActivity (global::Android.App.Activity p0)
		{
			if (id_setActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_setActivity_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "setActivity", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setActivity_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActivity", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setContentViewLayoutResName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentViewLayoutResName_Ljava_lang_String_Handler ()
		{
			if (cb_setContentViewLayoutResName_Ljava_lang_String_ == null)
				cb_setContentViewLayoutResName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentViewLayoutResName_Ljava_lang_String_);
			return cb_setContentViewLayoutResName_Ljava_lang_String_;
		}

		static void n_SetContentViewLayoutResName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentViewLayoutResName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentViewLayoutResName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='setContentViewLayoutResName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentViewLayoutResName", "(Ljava/lang/String;)V", "GetSetContentViewLayoutResName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetContentViewLayoutResName (string p0)
		{
			if (id_setContentViewLayoutResName_Ljava_lang_String_ == IntPtr.Zero)
				id_setContentViewLayoutResName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentViewLayoutResName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setContentViewLayoutResName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentViewLayoutResName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setRequestedOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetRequestedOrientation_IHandler ()
		{
			if (cb_setRequestedOrientation_I == null)
				cb_setRequestedOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRequestedOrientation_I);
			return cb_setRequestedOrientation_I;
		}

		static void n_SetRequestedOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestedOrientation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRequestedOrientation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='setRequestedOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRequestedOrientation", "(I)V", "GetSetRequestedOrientation_IHandler")]
		public virtual unsafe void SetRequestedOrientation (int p0)
		{
			if (id_setRequestedOrientation_I == IntPtr.Zero)
				id_setRequestedOrientation_I = JNIEnv.GetMethodID (class_ref, "setRequestedOrientation", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRequestedOrientation_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestedOrientation", "(I)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setResult_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='setResult' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setResult", "(Ljava/util/HashMap;)V", "")]
		public unsafe void SetResult (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_setResult_Ljava_util_HashMap_ == IntPtr.Zero)
				id_setResult_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "setResult", "(Ljava/util/HashMap;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_setResult_Ljava_util_HashMap_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setShell_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='setShell' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends cn.smssdk.framework.ShareSDKUIShell&gt;']]"
		[Register ("setShell", "(Ljava/lang/Class;)V", "")]
		public static unsafe void SetShell (global::Java.Lang.Class p0)
		{
			if (id_setShell_Ljava_lang_Class_ == IntPtr.Zero)
				id_setShell_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "setShell", "(Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setShell_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static Delegate cb_show_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_show_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_show_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Show_Landroid_content_Context_Landroid_content_Intent_);
			return cb_show_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_Show_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_show_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='show' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("show", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetShow_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public virtual unsafe void Show (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_show_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_show_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "show", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_show_Landroid_content_Context_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_;
#pragma warning disable 0169
		static Delegate GetShowForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_Handler ()
		{
			if (cb_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_ == null)
				cb_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_);
			return cb_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_;
		}

		static void n_ShowForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.FakeActivity p2 = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShowForResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='showForResult' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='cn.smssdk.framework.FakeActivity']]"
		[Register ("showForResult", "(Landroid/content/Context;Landroid/content/Intent;Lcn/smssdk/framework/FakeActivity;)V", "GetShowForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_Handler")]
		public virtual unsafe void ShowForResult (global::Android.Content.Context p0, global::Android.Content.Intent p1, global::CN.Smssdk.Framework.FakeActivity p2)
		{
			if (id_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_ == IntPtr.Zero)
				id_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_ = JNIEnv.GetMethodID (class_ref, "showForResult", "(Landroid/content/Context;Landroid/content/Intent;Lcn/smssdk/framework/FakeActivity;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showForResult_Landroid_content_Context_Landroid_content_Intent_Lcn_smssdk_framework_FakeActivity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showForResult", "(Landroid/content/Context;Landroid/content/Intent;Lcn/smssdk/framework/FakeActivity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startActivity_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartActivity_Landroid_content_Intent_Handler ()
		{
			if (cb_startActivity_Landroid_content_Intent_ == null)
				cb_startActivity_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartActivity_Landroid_content_Intent_);
			return cb_startActivity_Landroid_content_Intent_;
		}

		static void n_StartActivity_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartActivity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startActivity_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='startActivity' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("startActivity", "(Landroid/content/Intent;)V", "GetStartActivity_Landroid_content_Intent_Handler")]
		public virtual unsafe void StartActivity (global::Android.Content.Intent p0)
		{
			if (id_startActivity_Landroid_content_Intent_ == IntPtr.Zero)
				id_startActivity_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "startActivity", "(Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startActivity_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startActivity", "(Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startActivityForResult_Landroid_content_Intent_I;
#pragma warning disable 0169
		static Delegate GetStartActivityForResult_Landroid_content_Intent_IHandler ()
		{
			if (cb_startActivityForResult_Landroid_content_Intent_I == null)
				cb_startActivityForResult_Landroid_content_Intent_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_StartActivityForResult_Landroid_content_Intent_I);
			return cb_startActivityForResult_Landroid_content_Intent_I;
		}

		static void n_StartActivityForResult_Landroid_content_Intent_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::CN.Smssdk.Framework.FakeActivity __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.FakeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityForResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startActivityForResult_Landroid_content_Intent_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework']/class[@name='FakeActivity']/method[@name='startActivityForResult' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='int']]"
		[Register ("startActivityForResult", "(Landroid/content/Intent;I)V", "GetStartActivityForResult_Landroid_content_Intent_IHandler")]
		public virtual unsafe void StartActivityForResult (global::Android.Content.Intent p0, int p1)
		{
			if (id_startActivityForResult_Landroid_content_Intent_I == IntPtr.Zero)
				id_startActivityForResult_Landroid_content_Intent_I = JNIEnv.GetMethodID (class_ref, "startActivityForResult", "(Landroid/content/Intent;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startActivityForResult_Landroid_content_Intent_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startActivityForResult", "(Landroid/content/Intent;I)V"), __args);
			} finally {
			}
		}

	}
}
