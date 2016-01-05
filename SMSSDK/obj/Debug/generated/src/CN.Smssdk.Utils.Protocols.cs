using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='Protocols']"
	[global::Android.Runtime.Register ("cn/smssdk/utils/Protocols", DoNotGenerateAcw=true)]
	public partial class Protocols : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/utils/Protocols", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Protocols); }
		}

		protected Protocols (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.Protocols __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.Protocols> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (__this.A ());
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='Protocols']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/util/ArrayList;", "GetAHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>> A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/util/ArrayList;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='Protocols']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Lcn/smssdk/utils/Protocols;", "")]
		public static unsafe global::CN.Smssdk.Utils.Protocols A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)Lcn/smssdk/utils/Protocols;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::CN.Smssdk.Utils.Protocols __ret = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.Protocols> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_a_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_A_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Smssdk.Utils.Protocols __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.Protocols> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='Protocols']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)V", "GetA_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void A (string p0, string p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_A_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Smssdk.Utils.Protocols __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.Protocols> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.A (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='Protocols']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/HashMap;", "GetA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> A (string p0, string p1, string p2)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/HashMap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/HashMap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_A_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::CN.Smssdk.Utils.Protocols __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.Protocols> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='Protocols']/method[@name='a' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void A (string p0, string p1, string p2, string p3, string p4)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_a_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_arrayLjava_lang_String_Handler ()
		{
			if (cb_a_arrayLjava_lang_String_ == null)
				cb_a_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_arrayLjava_lang_String_);
			return cb_a_arrayLjava_lang_String_;
		}

		static IntPtr n_A_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.Protocols __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.Protocols> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (__this.A (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='Protocols']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("a", "([Ljava/lang/String;)Ljava/util/ArrayList;", "GetA_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>> A (string[] p0)
		{
			if (id_a_arrayLjava_lang_String_ == IntPtr.Zero)
				id_a_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "([Ljava/lang/String;)Ljava/util/ArrayList;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "([Ljava/lang/String;)Ljava/util/ArrayList;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_a_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_ArrayList_Handler ()
		{
			if (cb_a_Ljava_util_ArrayList_ == null)
				cb_a_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_ArrayList_);
			return cb_a_Ljava_util_ArrayList_;
		}

		static void n_A_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.Protocols __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.Protocols> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='Protocols']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;&gt;']]"
		[Register ("a", "(Ljava/util/ArrayList;)V", "GetA_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void A (global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>> p0)
		{
			if (id_a_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_a_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_b_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetB_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_b_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_b_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_B_Ljava_lang_String_Ljava_lang_String_);
			return cb_b_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_B_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Smssdk.Utils.Protocols __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.Protocols> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.B (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_b_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='Protocols']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;Ljava/lang/String;)V", "GetB_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void B (string p0, string p1)
		{
			if (id_b_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
