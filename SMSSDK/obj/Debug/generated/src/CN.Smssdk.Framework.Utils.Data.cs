using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/utils/Data", DoNotGenerateAcw=true)]
	public partial class Data : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/utils/Data", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Data); }
		}

		protected Data (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/constructor[@name='Data' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Data ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Data)) {
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

		static IntPtr id_AES128Decode_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='AES128Decode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("AES128Decode", "([B[B)[B", "")]
		public static unsafe byte[] AES128Decode (byte[] p0, byte[] p1)
		{
			if (id_AES128Decode_arrayBarrayB == IntPtr.Zero)
				id_AES128Decode_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "AES128Decode", "([B[B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_AES128Decode_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_AES128Decode_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='AES128Decode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("AES128Decode", "(Ljava/lang/String;[B)Ljava/lang/String;", "")]
		public static unsafe string AES128Decode (string p0, byte[] p1)
		{
			if (id_AES128Decode_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_AES128Decode_Ljava_lang_String_arrayB = JNIEnv.GetStaticMethodID (class_ref, "AES128Decode", "(Ljava/lang/String;[B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_AES128Decode_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_AES128Encode_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='AES128Encode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("AES128Encode", "([BLjava/lang/String;)[B", "")]
		public static unsafe byte[] AES128Encode (byte[] p0, string p1)
		{
			if (id_AES128Encode_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_AES128Encode_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "AES128Encode", "([BLjava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_AES128Encode_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_AES128Encode_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='AES128Encode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("AES128Encode", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] AES128Encode (string p0, string p1)
		{
			if (id_AES128Encode_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_AES128Encode_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "AES128Encode", "(Ljava/lang/String;Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_AES128Encode_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Base64AES_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='Base64AES' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Base64AES", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Base64AES (string p0, string p1)
		{
			if (id_Base64AES_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Base64AES_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Base64AES", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_Base64AES_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_CRC32_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='CRC32' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("CRC32", "([B)Ljava/lang/String;", "")]
		public static unsafe string CRC32 (byte[] p0)
		{
			if (id_CRC32_arrayB == IntPtr.Zero)
				id_CRC32_arrayB = JNIEnv.GetStaticMethodID (class_ref, "CRC32", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_CRC32_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_MD5_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='MD5' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("MD5", "([B)Ljava/lang/String;", "")]
		public static unsafe string MD5 (byte[] p0)
		{
			if (id_MD5_arrayB == IntPtr.Zero)
				id_MD5_arrayB = JNIEnv.GetStaticMethodID (class_ref, "MD5", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_MD5_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_MD5_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='MD5' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("MD5", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string MD5 (global::Java.IO.File p0)
		{
			if (id_MD5_Ljava_io_File_ == IntPtr.Zero)
				id_MD5_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "MD5", "(Ljava/io/File;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_MD5_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_MD5_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='MD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("MD5", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string MD5 (string p0)
		{
			if (id_MD5_Ljava_lang_String_ == IntPtr.Zero)
				id_MD5_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "MD5", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_MD5_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_SHA1_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='SHA1' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("SHA1", "([B)[B", "")]
		public static unsafe byte[] SHA1 (byte[] p0)
		{
			if (id_SHA1_arrayB == IntPtr.Zero)
				id_SHA1_arrayB = JNIEnv.GetStaticMethodID (class_ref, "SHA1", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_SHA1_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_SHA1_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='SHA1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SHA1", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] SHA1 (string p0)
		{
			if (id_SHA1_Ljava_lang_String_ == IntPtr.Zero)
				id_SHA1_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SHA1", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_SHA1_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_base62_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='base62' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("base62", "(J)Ljava/lang/String;", "")]
		public static unsafe string Base62 (long p0)
		{
			if (id_base62_J == IntPtr.Zero)
				id_base62_J = JNIEnv.GetStaticMethodID (class_ref, "base62", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_base62_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_byteToHex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='byteToHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byteToHex", "([B)Ljava/lang/String;", "")]
		public static unsafe string ByteToHex (byte[] p0)
		{
			if (id_byteToHex_arrayB == IntPtr.Zero)
				id_byteToHex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byteToHex", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteToHex_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_byteToHex_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='byteToHex' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("byteToHex", "([BII)Ljava/lang/String;", "")]
		public static unsafe string ByteToHex (byte[] p0, int p1, int p2)
		{
			if (id_byteToHex_arrayBII == IntPtr.Zero)
				id_byteToHex_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "byteToHex", "([BII)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteToHex_arrayBII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_parseJson_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='parseJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseJson", "(Ljava/lang/String;)Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ParseJson (string p0)
		{
			if (id_parseJson_Ljava_lang_String_ == IntPtr.Zero)
				id_parseJson_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseJson", "(Ljava/lang/String;)Ljava/util/HashMap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseJson_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseJson_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='parseJson' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("parseJson", "(Ljava/util/HashMap;)Ljava/lang/String;", "")]
		public static unsafe string ParseJson (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_parseJson_Ljava_util_HashMap_ == IntPtr.Zero)
				id_parseJson_Ljava_util_HashMap_ = JNIEnv.GetStaticMethodID (class_ref, "parseJson", "(Ljava/util/HashMap;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseJson_Ljava_util_HashMap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_rawMD5_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='rawMD5' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("rawMD5", "([B)[B", "")]
		public static unsafe byte[] RawMD5 (byte[] p0)
		{
			if (id_rawMD5_arrayB == IntPtr.Zero)
				id_rawMD5_arrayB = JNIEnv.GetStaticMethodID (class_ref, "rawMD5", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_rawMD5_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_rawMD5_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='rawMD5' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("rawMD5", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] RawMD5 (global::System.IO.Stream p0)
		{
			if (id_rawMD5_Ljava_io_InputStream_ == IntPtr.Zero)
				id_rawMD5_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "rawMD5", "(Ljava/io/InputStream;)[B");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_rawMD5_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_rawMD5_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='rawMD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("rawMD5", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] RawMD5 (string p0)
		{
			if (id_rawMD5_Ljava_lang_String_ == IntPtr.Zero)
				id_rawMD5_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "rawMD5", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_rawMD5_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_urlEncode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='urlEncode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlEncode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlEncode (string p0)
		{
			if (id_urlEncode_Ljava_lang_String_ == IntPtr.Zero)
				id_urlEncode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "urlEncode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_urlEncode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_urlEncode_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='Data']/method[@name='urlEncode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("urlEncode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlEncode (string p0, string p1)
		{
			if (id_urlEncode_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_urlEncode_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "urlEncode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_urlEncode_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
