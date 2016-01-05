using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/network/NetworkHelper", DoNotGenerateAcw=true)]
	public partial class NetworkHelper : global::Java.Lang.Object {


		static IntPtr connectionTimeout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/field[@name='connectionTimeout']"
		[Register ("connectionTimeout")]
		public static int ConnectionTimeout {
			get {
				if (connectionTimeout_jfieldId == IntPtr.Zero)
					connectionTimeout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "connectionTimeout", "I");
				return JNIEnv.GetStaticIntField (class_ref, connectionTimeout_jfieldId);
			}
			set {
				if (connectionTimeout_jfieldId == IntPtr.Zero)
					connectionTimeout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "connectionTimeout", "I");
				try {
					JNIEnv.SetStaticField (class_ref, connectionTimeout_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr readTimout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/field[@name='readTimout']"
		[Register ("readTimout")]
		public static int ReadTimout {
			get {
				if (readTimout_jfieldId == IntPtr.Zero)
					readTimout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "readTimout", "I");
				return JNIEnv.GetStaticIntField (class_ref, readTimout_jfieldId);
			}
			set {
				if (readTimout_jfieldId == IntPtr.Zero)
					readTimout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "readTimout", "I");
				try {
					JNIEnv.SetStaticField (class_ref, readTimout_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/network/NetworkHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkHelper); }
		}

		protected NetworkHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/constructor[@name='NetworkHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetworkHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NetworkHelper)) {
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

		static Delegate cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetDownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_DownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static IntPtr n_DownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DownloadCache (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='downloadCache' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("downloadCache", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;", "GetDownloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe string DownloadCache (global::Android.Content.Context p0, string p1, string p2, bool p3)
		{
			if (id_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "downloadCache", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_downloadCache_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadCache", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_;
#pragma warning disable 0169
		static Delegate GetGetHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_Handler ()
		{
			if (cb_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_ == null)
				cb_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_);
			return cb_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_;
		}

		static void n_GetHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.KVPair p2 = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.KVPair> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.IHttpResponseCallback p5 = (global::CN.Smssdk.Framework.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IHttpResponseCallback> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.GetHttpPostResponse (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='getHttpPostResponse' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;?&gt;&gt;'] and parameter[6][@type='cn.smssdk.framework.network.HttpResponseCallback']]"
		[Register ("getHttpPostResponse", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HttpResponseCallback;)V", "GetGetHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_Handler")]
		public virtual unsafe void GetHttpPostResponse (string p0, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p1, global::CN.Smssdk.Framework.Network.KVPair p2, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p3, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p4, global::CN.Smssdk.Framework.Network.IHttpResponseCallback p5)
		{
			if (id_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_ == IntPtr.Zero)
				id_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_ = JNIEnv.GetMethodID (class_ref, "getHttpPostResponse", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HttpResponseCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getHttpPostResponse_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHttpPostResponse", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HttpResponseCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetHttpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
		{
			if (cb_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
				cb_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_);
			return cb_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		}

		static IntPtr n_HttpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpGet (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='httpGet' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;?&gt;&gt;']]"
		[Register ("httpGet", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;", "GetHttpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler")]
		public virtual unsafe string HttpGet (string p0, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p1, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p2, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p3)
		{
			if (id_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "httpGet", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_httpGet_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "httpGet", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetHttpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
		{
			if (cb_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
				cb_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_);
			return cb_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		}

		static IntPtr n_HttpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.KVPair p2 = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.KVPair> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (__this.HttpHead (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='httpHead' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;?&gt;&gt;']]"
		[Register ("httpHead", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/util/ArrayList;", "GetHttpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> HttpHead (string p0, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p1, global::CN.Smssdk.Framework.Network.KVPair p2, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p3, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p4)
		{
			if (id_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "httpHead", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/util/ArrayList;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_httpHead_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "httpHead", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/util/ArrayList;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_;
#pragma warning disable 0169
		static Delegate GetHttpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_Handler ()
		{
			if (cb_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_ == null)
				cb_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_);
			return cb_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_;
		}

		static IntPtr n_HttpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.KVPair p2 = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.KVPair> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p5, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.IOnReadListener p6 = (global::CN.Smssdk.Framework.Network.IOnReadListener)global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IOnReadListener> (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPatch (p0, p1, p2, p3, p4, p5, p6));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='httpPatch' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='long'] and parameter[5][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[6][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;?&gt;&gt;'] and parameter[7][@type='cn.smssdk.framework.network.OnReadListener']]"
		[Register ("httpPatch", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;JLjava/util/ArrayList;Ljava/util/ArrayList;Lcn/smssdk/framework/network/OnReadListener;)Ljava/lang/String;", "GetHttpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_Handler")]
		public virtual unsafe string HttpPatch (string p0, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p1, global::CN.Smssdk.Framework.Network.KVPair p2, long p3, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p4, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p5, global::CN.Smssdk.Framework.Network.IOnReadListener p6)
		{
			if (id_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_ == IntPtr.Zero)
				id_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_ = JNIEnv.GetMethodID (class_ref, "httpPatch", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;JLjava/util/ArrayList;Ljava/util/ArrayList;Lcn/smssdk/framework/network/OnReadListener;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p1);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p4);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_httpPatch_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_JLjava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_OnReadListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "httpPatch", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;JLjava/util/ArrayList;Ljava/util/ArrayList;Lcn/smssdk/framework/network/OnReadListener;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
		{
			if (cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
				cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_);
			return cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		}

		static IntPtr n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.KVPair p2 = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.KVPair> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPost (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='httpPost' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;?&gt;&gt;']]"
		[Register ("httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;", "GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler")]
		public virtual unsafe string HttpPost (string p0, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p1, global::CN.Smssdk.Framework.Network.KVPair p2, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p3, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p4)
		{
			if (id_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_;
#pragma warning disable 0169
		static Delegate GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_Handler ()
		{
			if (cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_ == null)
				cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_);
			return cb_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_;
		}

		static void n_HttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.IHttpResponseCallback p5 = (global::CN.Smssdk.Framework.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IHttpResponseCallback> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.HttpPost (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='httpPost' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;?&gt;&gt;'] and parameter[6][@type='cn.smssdk.framework.network.HttpResponseCallback']]"
		[Register ("httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HttpResponseCallback;)V", "GetHttpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_Handler")]
		public virtual unsafe void HttpPost (string p0, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p1, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p2, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p3, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p4, global::CN.Smssdk.Framework.Network.IHttpResponseCallback p5)
		{
			if (id_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_ == IntPtr.Zero)
				id_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_ = JNIEnv.GetMethodID (class_ref, "httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HttpResponseCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_httpPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HttpResponseCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "httpPost", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HttpResponseCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetHttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
		{
			if (cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
				cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_);
			return cb_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		}

		static IntPtr n_HttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPostFiles (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='httpPostFiles' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;?&gt;&gt;']]"
		[Register ("httpPostFiles", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;", "GetHttpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler")]
		public virtual unsafe string HttpPostFiles (string p0, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p1, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p2, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p3, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p4)
		{
			if (id_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "httpPostFiles", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_httpPostFiles_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "httpPostFiles", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetHttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
		{
			if (cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
				cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_);
			return cb_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		}

		static IntPtr n_HttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.KVPair p2 = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.KVPair> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HttpPut (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='httpPut' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[5][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;?&gt;&gt;']]"
		[Register ("httpPut", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;", "GetHttpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler")]
		public virtual unsafe string HttpPut (string p0, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p1, global::CN.Smssdk.Framework.Network.KVPair p2, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p3, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p4)
		{
			if (id_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "httpPut", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_httpPut_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_KVPair_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "httpPut", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/KVPair;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetJsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
		{
			if (cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
				cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_JsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_);
			return cb_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		}

		static IntPtr n_JsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.JsonPost (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='jsonPost' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;?&gt;&gt;']]"
		[Register ("jsonPost", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;", "GetJsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler")]
		public virtual unsafe string JsonPost (string p0, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p1, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p2, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p3)
		{
			if (id_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "jsonPost", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_jsonPost_Ljava_lang_String_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "jsonPost", "(Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_rawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_;
#pragma warning disable 0169
		static Delegate GetRawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_Handler ()
		{
			if (cb_rawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_ == null)
				cb_rawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_);
			return cb_rawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_;
		}

		static void n_RawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.IRawNetworkCallback p1 = (global::CN.Smssdk.Framework.Network.IRawNetworkCallback)global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IRawNetworkCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RawGet (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_rawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='rawGet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='cn.smssdk.framework.network.RawNetworkCallback']]"
		[Register ("rawGet", "(Ljava/lang/String;Lcn/smssdk/framework/network/RawNetworkCallback;)V", "GetRawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_Handler")]
		public virtual unsafe void RawGet (string p0, global::CN.Smssdk.Framework.Network.IRawNetworkCallback p1)
		{
			if (id_rawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_ == IntPtr.Zero)
				id_rawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_ = JNIEnv.GetMethodID (class_ref, "rawGet", "(Ljava/lang/String;Lcn/smssdk/framework/network/RawNetworkCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_rawGet_Ljava_lang_String_Lcn_smssdk_framework_network_RawNetworkCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rawGet", "(Ljava/lang/String;Lcn/smssdk/framework/network/RawNetworkCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_;
#pragma warning disable 0169
		static Delegate GetRawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_Handler ()
		{
			if (cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_ == null)
				cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_);
			return cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_;
		}

		static void n_RawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.HTTPPart p2 = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.HTTPPart> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.IHttpResponseCallback p3 = (global::CN.Smssdk.Framework.Network.IHttpResponseCallback)global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IHttpResponseCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.RawPost (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='rawPost' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='cn.smssdk.framework.network.HTTPPart'] and parameter[4][@type='cn.smssdk.framework.network.HttpResponseCallback']]"
		[Register ("rawPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HTTPPart;Lcn/smssdk/framework/network/HttpResponseCallback;)V", "GetRawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_Handler")]
		public virtual unsafe void RawPost (string p0, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p1, global::CN.Smssdk.Framework.Network.HTTPPart p2, global::CN.Smssdk.Framework.Network.IHttpResponseCallback p3)
		{
			if (id_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_ == IntPtr.Zero)
				id_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_ = JNIEnv.GetMethodID (class_ref, "rawPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HTTPPart;Lcn/smssdk/framework/network/HttpResponseCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_HttpResponseCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rawPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HTTPPart;Lcn/smssdk/framework/network/HttpResponseCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_;
#pragma warning disable 0169
		static Delegate GetRawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_Handler ()
		{
			if (cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_ == null)
				cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_);
			return cb_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_;
		}

		static void n_RawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::CN.Smssdk.Framework.Network.NetworkHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.NetworkHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.HTTPPart p2 = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.HTTPPart> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::CN.Smssdk.Framework.Network.IRawNetworkCallback p3 = (global::CN.Smssdk.Framework.Network.IRawNetworkCallback)global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IRawNetworkCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.RawPost (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='NetworkHelper']/method[@name='rawPost' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='cn.smssdk.framework.network.HTTPPart'] and parameter[4][@type='cn.smssdk.framework.network.RawNetworkCallback']]"
		[Register ("rawPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HTTPPart;Lcn/smssdk/framework/network/RawNetworkCallback;)V", "GetRawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_Handler")]
		public virtual unsafe void RawPost (string p0, global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p1, global::CN.Smssdk.Framework.Network.HTTPPart p2, global::CN.Smssdk.Framework.Network.IRawNetworkCallback p3)
		{
			if (id_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_ == IntPtr.Zero)
				id_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_ = JNIEnv.GetMethodID (class_ref, "rawPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HTTPPart;Lcn/smssdk/framework/network/RawNetworkCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_rawPost_Ljava_lang_String_Ljava_util_ArrayList_Lcn_smssdk_framework_network_HTTPPart_Lcn_smssdk_framework_network_RawNetworkCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rawPost", "(Ljava/lang/String;Ljava/util/ArrayList;Lcn/smssdk/framework/network/HTTPPart;Lcn/smssdk/framework/network/RawNetworkCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
