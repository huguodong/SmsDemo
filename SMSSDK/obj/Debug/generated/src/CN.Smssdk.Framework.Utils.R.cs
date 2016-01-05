using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/utils/R", DoNotGenerateAcw=true)]
	public partial class R : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/utils/R", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (R); }
		}

		protected R (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/constructor[@name='R' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe R ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (R)) {
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

		static IntPtr id_clearCache_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='clearCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearCache", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearCache (global::Android.Content.Context p0)
		{
			if (id_clearCache_Landroid_content_Context_ == IntPtr.Zero)
				id_clearCache_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearCache", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearCache_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_contentUriToPath_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='contentUriToPath' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("contentUriToPath", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static unsafe string ContentUriToPath (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_contentUriToPath_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_contentUriToPath_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "contentUriToPath", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_contentUriToPath_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_copyFile_Ljava_io_FileInputStream_Ljava_io_FileOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='copyFile' and count(parameter)=2 and parameter[1][@type='java.io.FileInputStream'] and parameter[2][@type='java.io.FileOutputStream']]"
		[Register ("copyFile", "(Ljava/io/FileInputStream;Ljava/io/FileOutputStream;)V", "")]
		public static unsafe void CopyFile (global::System.IO.Stream p0, global::System.IO.Stream p1)
		{
			if (id_copyFile_Ljava_io_FileInputStream_Ljava_io_FileOutputStream_ == IntPtr.Zero)
				id_copyFile_Ljava_io_FileInputStream_Ljava_io_FileOutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "copyFile", "(Ljava/io/FileInputStream;Ljava/io/FileOutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copyFile_Ljava_io_FileInputStream_Ljava_io_FileOutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_covertTimeInYears_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='covertTimeInYears' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("covertTimeInYears", "(J)[I", "")]
		public static unsafe int[] CovertTimeInYears (long p0)
		{
			if (id_covertTimeInYears_J == IntPtr.Zero)
				id_covertTimeInYears_J = JNIEnv.GetStaticMethodID (class_ref, "covertTimeInYears", "(J)[I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_covertTimeInYears_J, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_dateStrToLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='dateStrToLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dateStrToLong", "(Ljava/lang/String;)J", "")]
		public static unsafe long DateStrToLong (string p0)
		{
			if (id_dateStrToLong_Ljava_lang_String_ == IntPtr.Zero)
				id_dateStrToLong_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "dateStrToLong", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_dateStrToLong_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='decodeUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeUrl", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle DecodeUrl (string p0)
		{
			if (id_decodeUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeUrl", "(Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_dipToPx_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='dipToPx' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("dipToPx", "(Landroid/content/Context;I)I", "")]
		public static unsafe int DipToPx (global::Android.Content.Context p0, int p1)
		{
			if (id_dipToPx_Landroid_content_Context_I == IntPtr.Zero)
				id_dipToPx_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "dipToPx", "(Landroid/content/Context;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_dipToPx_Landroid_content_Context_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_encodeUrl_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='encodeUrl' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("encodeUrl", "(Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public static unsafe string EncodeUrl (global::Android.OS.Bundle p0)
		{
			if (id_encodeUrl_Landroid_os_Bundle_ == IntPtr.Zero)
				id_encodeUrl_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "encodeUrl", "(Landroid/os/Bundle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeUrl_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_encodeUrl_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='encodeUrl' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;cn.smssdk.framework.network.KVPair&lt;java.lang.String&gt;&gt;']]"
		[Register ("encodeUrl", "(Ljava/util/ArrayList;)Ljava/lang/String;", "")]
		public static unsafe string EncodeUrl (global::System.Collections.Generic.IList<global::CN.Smssdk.Framework.Network.KVPair> p0)
		{
			if (id_encodeUrl_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_encodeUrl_Ljava_util_ArrayList_ = JNIEnv.GetStaticMethodID (class_ref, "encodeUrl", "(Ljava/util/ArrayList;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::CN.Smssdk.Framework.Network.KVPair>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeUrl_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getBitmapRes_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getBitmapRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBitmapRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetBitmapRes (global::Android.Content.Context p0, string p1)
		{
			if (id_getBitmapRes_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getBitmapRes_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBitmapRes", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getBitmapRes_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getCachePath_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getCachePath' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getCachePath", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetCachePath (global::Android.Content.Context p0, string p1)
		{
			if (id_getCachePath_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getCachePath_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCachePath", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCachePath_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getColorRes_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getColorRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getColorRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetColorRes (global::Android.Content.Context p0, string p1)
		{
			if (id_getColorRes_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getColorRes_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getColorRes", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getColorRes_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getIdRes_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getIdRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getIdRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetIdRes (global::Android.Content.Context p0, string p1)
		{
			if (id_getIdRes_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getIdRes_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getIdRes", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getIdRes_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getImageCachePath_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getImageCachePath' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getImageCachePath", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetImageCachePath (global::Android.Content.Context p0)
		{
			if (id_getImageCachePath_Landroid_content_Context_ == IntPtr.Zero)
				id_getImageCachePath_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getImageCachePath", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImageCachePath_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLayoutRes_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getLayoutRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLayoutRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetLayoutRes (global::Android.Content.Context p0, string p1)
		{
			if (id_getLayoutRes_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getLayoutRes_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLayoutRes", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getLayoutRes_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getRawRes_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getRawRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getRawRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetRawRes (global::Android.Content.Context p0, string p1)
		{
			if (id_getRawRes_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getRawRes_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getRawRes", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getRawRes_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getResId_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getResId' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getResId", "(Ljava/lang/Class;Ljava/lang/String;)I", "")]
		public static unsafe int GetResId (global::Java.Lang.Class p0, string p1)
		{
			if (id_getResId_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_getResId_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getResId", "(Ljava/lang/Class;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getResId_Ljava_lang_Class_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getScreenHeight_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getScreenHeight' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScreenHeight", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetScreenHeight (global::Android.Content.Context p0)
		{
			if (id_getScreenHeight_Landroid_content_Context_ == IntPtr.Zero)
				id_getScreenHeight_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getScreenHeight", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getScreenHeight_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getScreenSize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getScreenSize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScreenSize", "(Landroid/content/Context;)[I", "")]
		public static unsafe int[] GetScreenSize (global::Android.Content.Context p0)
		{
			if (id_getScreenSize_Landroid_content_Context_ == IntPtr.Zero)
				id_getScreenSize_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getScreenSize", "(Landroid/content/Context;)[I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScreenSize_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getScreenWidth_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getScreenWidth' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScreenWidth", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetScreenWidth (global::Android.Content.Context p0)
		{
			if (id_getScreenWidth_Landroid_content_Context_ == IntPtr.Zero)
				id_getScreenWidth_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getScreenWidth", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getScreenWidth_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getStringArrayRes_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getStringArrayRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringArrayRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetStringArrayRes (global::Android.Content.Context p0, string p1)
		{
			if (id_getStringArrayRes_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringArrayRes_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStringArrayRes", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getStringArrayRes_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getStringRes_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getStringRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetStringRes (global::Android.Content.Context p0, string p1)
		{
			if (id_getStringRes_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringRes_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStringRes", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getStringRes_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getStyleRes_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='getStyleRes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStyleRes", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int GetStyleRes (global::Android.Content.Context p0, string p1)
		{
			if (id_getStyleRes_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getStyleRes_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStyleRes", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getStyleRes_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_longToDate_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='longToDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("longToDate", "(J)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date LongToDate (long p0)
		{
			if (id_longToDate_J == IntPtr.Zero)
				id_longToDate_J = JNIEnv.GetStaticMethodID (class_ref, "longToDate", "(J)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_longToDate_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_longToTime_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='longToTime' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("longToTime", "(JI)Ljava/lang/String;", "")]
		public static unsafe string LongToTime (long p0, int p1)
		{
			if (id_longToTime_JI == IntPtr.Zero)
				id_longToTime_JI = JNIEnv.GetStaticMethodID (class_ref, "longToTime", "(JI)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_longToTime_JI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_parseTwitterDate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='parseTwitterDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseTwitterDate", "(Ljava/lang/String;)J", "")]
		public static unsafe long ParseTwitterDate (string p0)
		{
			if (id_parseTwitterDate_Ljava_lang_String_ == IntPtr.Zero)
				id_parseTwitterDate_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseTwitterDate", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_parseTwitterDate_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_pathToContentUri_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='pathToContentUri' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("pathToContentUri", "(Landroid/content/Context;Ljava/lang/String;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri PathToContentUri (global::Android.Content.Context p0, string p1)
		{
			if (id_pathToContentUri_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_pathToContentUri_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "pathToContentUri", "(Landroid/content/Context;Ljava/lang/String;)Landroid/net/Uri;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_pathToContentUri_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_pxToDip_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='pxToDip' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("pxToDip", "(Landroid/content/Context;I)I", "")]
		public static unsafe int PxToDip (global::Android.Content.Context p0, int p1)
		{
			if (id_pxToDip_Landroid_content_Context_I == IntPtr.Zero)
				id_pxToDip_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "pxToDip", "(Landroid/content/Context;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_pxToDip_Landroid_content_Context_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setCacheRoot_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='setCacheRoot' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCacheRoot", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetCacheRoot (string p0)
		{
			if (id_setCacheRoot_Ljava_lang_String_ == IntPtr.Zero)
				id_setCacheRoot_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setCacheRoot", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCacheRoot_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_strToDate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='strToDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("strToDate", "(Ljava/lang/String;)J", "")]
		public static unsafe long StrToDate (string p0)
		{
			if (id_strToDate_Ljava_lang_String_ == IntPtr.Zero)
				id_strToDate_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "strToDate", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_strToDate_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toWordText_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='toWordText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("toWordText", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string ToWordText (string p0, int p1)
		{
			if (id_toWordText_Ljava_lang_String_I == IntPtr.Zero)
				id_toWordText_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "toWordText", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toWordText_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_urlToBundle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='R']/method[@name='urlToBundle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlToBundle", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle UrlToBundle (string p0)
		{
			if (id_urlToBundle_Ljava_lang_String_ == IntPtr.Zero)
				id_urlToBundle_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "urlToBundle", "(Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_urlToBundle_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
