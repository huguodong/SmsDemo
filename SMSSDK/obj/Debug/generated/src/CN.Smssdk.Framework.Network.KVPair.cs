using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='KVPair']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/network/KVPair", DoNotGenerateAcw=true)]
	public partial class KVPair : global::Java.Lang.Object {


		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='KVPair']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr value_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='KVPair']/field[@name='value']"
		[Register ("value")]
		public global::Java.Lang.Object Value {
			get {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, value_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, value_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/network/KVPair", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KVPair); }
		}

		protected KVPair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='KVPair']/constructor[@name='KVPair' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe KVPair (string p0, global::Java.Lang.Object p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (KVPair)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
