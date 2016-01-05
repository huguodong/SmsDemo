using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/utils/BitmapHelper", DoNotGenerateAcw=true)]
	public partial class BitmapHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/utils/BitmapHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapHelper); }
		}

		protected BitmapHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/constructor[@name='BitmapHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitmapHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BitmapHelper)) {
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

		static IntPtr id_blur_Landroid_graphics_Bitmap_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='blur' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("blur", "(Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap Blur (global::Android.Graphics.Bitmap p0, int p1, int p2)
		{
			if (id_blur_Landroid_graphics_Bitmap_II == IntPtr.Zero)
				id_blur_Landroid_graphics_Bitmap_II = JNIEnv.GetStaticMethodID (class_ref, "blur", "(Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_blur_Landroid_graphics_Bitmap_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_captureView_Landroid_view_View_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='captureView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("captureView", "(Landroid/view/View;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CaptureView (global::Android.Views.View p0, int p1, int p2)
		{
			if (id_captureView_Landroid_view_View_II == IntPtr.Zero)
				id_captureView_Landroid_view_View_II = JNIEnv.GetStaticMethodID (class_ref, "captureView", "(Landroid/view/View;II)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_captureView_Landroid_view_View_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_downloadBitmap_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='downloadBitmap' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("downloadBitmap", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DownloadBitmap (global::Android.Content.Context p0, string p1)
		{
			if (id_downloadBitmap_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_downloadBitmap_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "downloadBitmap", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_downloadBitmap_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_fixRect_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='fixRect' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("fixRect", "([I[I)[I", "")]
		public static unsafe int[] FixRect (int[] p0, int[] p1)
		{
			if (id_fixRect_arrayIarrayI == IntPtr.Zero)
				id_fixRect_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "fixRect", "([I[I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fixRect_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
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

		static IntPtr id_getBitmap_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='getBitmap' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBitmap", "(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmap (global::Android.Content.Context p0, string p1)
		{
			if (id_getBitmap_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getBitmap_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBitmap", "(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBitmap_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getBitmap_Ljava_io_File_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='getBitmap' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register ("getBitmap", "(Ljava/io/File;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmap (global::Java.IO.File p0, int p1)
		{
			if (id_getBitmap_Ljava_io_File_I == IntPtr.Zero)
				id_getBitmap_Ljava_io_File_I = JNIEnv.GetStaticMethodID (class_ref, "getBitmap", "(Ljava/io/File;I)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBitmap_Ljava_io_File_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBitmap_Ljava_io_InputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='getBitmap' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("getBitmap", "(Ljava/io/InputStream;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmap (global::System.IO.Stream p0, int p1)
		{
			if (id_getBitmap_Ljava_io_InputStream_I == IntPtr.Zero)
				id_getBitmap_Ljava_io_InputStream_I = JNIEnv.GetStaticMethodID (class_ref, "getBitmap", "(Ljava/io/InputStream;I)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBitmap_Ljava_io_InputStream_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getBitmap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='getBitmap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmap (string p0)
		{
			if (id_getBitmap_Ljava_lang_String_ == IntPtr.Zero)
				id_getBitmap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBitmap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getBitmap_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='getBitmap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getBitmap", "(Ljava/lang/String;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmap (string p0, int p1)
		{
			if (id_getBitmap_Ljava_lang_String_I == IntPtr.Zero)
				id_getBitmap_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getBitmap", "(Ljava/lang/String;I)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBitmap_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getBmpFormat_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='getBmpFormat' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getBmpFormat", "([B)Landroid/graphics/Bitmap$CompressFormat;", "")]
		public static unsafe global::Android.Graphics.Bitmap.CompressFormat GetBmpFormat (byte[] p0)
		{
			if (id_getBmpFormat_arrayB == IntPtr.Zero)
				id_getBmpFormat_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getBmpFormat", "([B)Landroid/graphics/Bitmap$CompressFormat;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Graphics.Bitmap.CompressFormat __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBmpFormat_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getBmpFormat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='getBmpFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBmpFormat", "(Ljava/lang/String;)Landroid/graphics/Bitmap$CompressFormat;", "")]
		public static unsafe global::Android.Graphics.Bitmap.CompressFormat GetBmpFormat (string p0)
		{
			if (id_getBmpFormat_Ljava_lang_String_ == IntPtr.Zero)
				id_getBmpFormat_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBmpFormat", "(Ljava/lang/String;)Landroid/graphics/Bitmap$CompressFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Graphics.Bitmap.CompressFormat __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBmpFormat_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_roundBitmap_Landroid_graphics_Bitmap_IIFFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='roundBitmap' and count(parameter)=7 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float']]"
		[Register ("roundBitmap", "(Landroid/graphics/Bitmap;IIFFFF)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap RoundBitmap (global::Android.Graphics.Bitmap p0, int p1, int p2, float p3, float p4, float p5, float p6)
		{
			if (id_roundBitmap_Landroid_graphics_Bitmap_IIFFFF == IntPtr.Zero)
				id_roundBitmap_Landroid_graphics_Bitmap_IIFFFF = JNIEnv.GetStaticMethodID (class_ref, "roundBitmap", "(Landroid/graphics/Bitmap;IIFFFF)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_roundBitmap_Landroid_graphics_Bitmap_IIFFFF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_saveBitmap_Landroid_content_Context_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='saveBitmap' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("saveBitmap", "(Landroid/content/Context;Landroid/graphics/Bitmap;)Ljava/lang/String;", "")]
		public static unsafe string SaveBitmap (global::Android.Content.Context p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_saveBitmap_Landroid_content_Context_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_saveBitmap_Landroid_content_Context_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "saveBitmap", "(Landroid/content/Context;Landroid/graphics/Bitmap;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveBitmap_Landroid_content_Context_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_saveBitmap_Landroid_content_Context_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_CompressFormat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='saveBitmap' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap.CompressFormat'] and parameter[4][@type='int']]"
		[Register ("saveBitmap", "(Landroid/content/Context;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap$CompressFormat;I)Ljava/lang/String;", "")]
		public static unsafe string SaveBitmap (global::Android.Content.Context p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap.CompressFormat p2, int p3)
		{
			if (id_saveBitmap_Landroid_content_Context_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_CompressFormat_I == IntPtr.Zero)
				id_saveBitmap_Landroid_content_Context_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_CompressFormat_I = JNIEnv.GetStaticMethodID (class_ref, "saveBitmap", "(Landroid/content/Context;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap$CompressFormat;I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveBitmap_Landroid_content_Context_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_CompressFormat_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_saveViewToImage_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='saveViewToImage' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("saveViewToImage", "(Landroid/view/View;)Ljava/lang/String;", "")]
		public static unsafe string SaveViewToImage (global::Android.Views.View p0)
		{
			if (id_saveViewToImage_Landroid_view_View_ == IntPtr.Zero)
				id_saveViewToImage_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "saveViewToImage", "(Landroid/view/View;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveViewToImage_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_saveViewToImage_Landroid_view_View_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='BitmapHelper']/method[@name='saveViewToImage' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("saveViewToImage", "(Landroid/view/View;II)Ljava/lang/String;", "")]
		public static unsafe string SaveViewToImage (global::Android.Views.View p0, int p1, int p2)
		{
			if (id_saveViewToImage_Landroid_view_View_II == IntPtr.Zero)
				id_saveViewToImage_Landroid_view_View_II = JNIEnv.GetStaticMethodID (class_ref, "saveViewToImage", "(Landroid/view/View;II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveViewToImage_Landroid_view_View_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
