using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Hashon']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/utils/Hashon", DoNotGenerateAcw=true)]
	public partial class Hashon : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/utils/Hashon", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Hashon); }
		}

		protected Hashon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Hashon']/constructor[@name='Hashon' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Hashon ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Hashon)) {
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

		static Delegate cb_format_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_lang_String_Handler ()
		{
			if (cb_format_Ljava_lang_String_ == null)
				cb_format_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Format_Ljava_lang_String_);
			return cb_format_Ljava_lang_String_;
		}

		static IntPtr n_Format_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Utils.Hashon __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Utils.Hashon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Format (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Hashon']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("format", "(Ljava/lang/String;)Ljava/lang/String;", "GetFormat_Ljava_lang_String_Handler")]
		public virtual unsafe string Format (string p0)
		{
			if (id_format_Ljava_lang_String_ == IntPtr.Zero)
				id_format_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_format_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_fromHashMap_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetFromHashMap_Ljava_util_HashMap_Handler ()
		{
			if (cb_fromHashMap_Ljava_util_HashMap_ == null)
				cb_fromHashMap_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromHashMap_Ljava_util_HashMap_);
			return cb_fromHashMap_Ljava_util_HashMap_;
		}

		static IntPtr n_FromHashMap_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Utils.Hashon __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Utils.Hashon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.FromHashMap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fromHashMap_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Hashon']/method[@name='fromHashMap' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("fromHashMap", "(Ljava/util/HashMap;)Ljava/lang/String;", "GetFromHashMap_Ljava_util_HashMap_Handler")]
		public virtual unsafe string FromHashMap (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_fromHashMap_Ljava_util_HashMap_ == IntPtr.Zero)
				id_fromHashMap_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "fromHashMap", "(Ljava/util/HashMap;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_fromHashMap_Ljava_util_HashMap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromHashMap", "(Ljava/util/HashMap;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_fromJson_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFromJson_Ljava_lang_String_Handler ()
		{
			if (cb_fromJson_Ljava_lang_String_ == null)
				cb_fromJson_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromJson_Ljava_lang_String_);
			return cb_fromJson_Ljava_lang_String_;
		}

		static IntPtr n_FromJson_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Utils.Hashon __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Utils.Hashon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.FromJson (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fromJson_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Hashon']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Ljava/util/HashMap;", "GetFromJson_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> FromJson (string p0)
		{
			if (id_fromJson_Ljava_lang_String_ == IntPtr.Zero)
				id_fromJson_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Ljava/lang/String;)Ljava/util/HashMap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_fromJson_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromJson", "(Ljava/lang/String;)Ljava/util/HashMap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
