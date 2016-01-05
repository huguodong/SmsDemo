using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='UIHandler']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/utils/UIHandler", DoNotGenerateAcw=true)]
	public partial class UIHandler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/utils/UIHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UIHandler); }
		}

		protected UIHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='UIHandler']/constructor[@name='UIHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UIHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UIHandler)) {
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

		static IntPtr id_prepare;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='UIHandler']/method[@name='prepare' and count(parameter)=0]"
		[Register ("prepare", "()V", "")]
		public static unsafe void Prepare ()
		{
			if (id_prepare == IntPtr.Zero)
				id_prepare = JNIEnv.GetStaticMethodID (class_ref, "prepare", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_prepare);
			} finally {
			}
		}

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='UIHandler']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public static unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetStaticMethodID (class_ref, "reset", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reset);
			} finally {
			}
		}

		static IntPtr id_sendEmptyMessage_ILandroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='UIHandler']/method[@name='sendEmptyMessage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("sendEmptyMessage", "(ILandroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendEmptyMessage (int p0, global::Android.OS.Handler.ICallback p1)
		{
			if (id_sendEmptyMessage_ILandroid_os_Handler_Callback_ == IntPtr.Zero)
				id_sendEmptyMessage_ILandroid_os_Handler_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "sendEmptyMessage", "(ILandroid/os/Handler$Callback;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_sendEmptyMessage_ILandroid_os_Handler_Callback_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sendEmptyMessageAtTime_IJLandroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='UIHandler']/method[@name='sendEmptyMessageAtTime' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='android.os.Handler.Callback']]"
		[Register ("sendEmptyMessageAtTime", "(IJLandroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendEmptyMessageAtTime (int p0, long p1, global::Android.OS.Handler.ICallback p2)
		{
			if (id_sendEmptyMessageAtTime_IJLandroid_os_Handler_Callback_ == IntPtr.Zero)
				id_sendEmptyMessageAtTime_IJLandroid_os_Handler_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "sendEmptyMessageAtTime", "(IJLandroid/os/Handler$Callback;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_sendEmptyMessageAtTime_IJLandroid_os_Handler_Callback_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sendEmptyMessageDelayed_IJLandroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='UIHandler']/method[@name='sendEmptyMessageDelayed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='android.os.Handler.Callback']]"
		[Register ("sendEmptyMessageDelayed", "(IJLandroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendEmptyMessageDelayed (int p0, long p1, global::Android.OS.Handler.ICallback p2)
		{
			if (id_sendEmptyMessageDelayed_IJLandroid_os_Handler_Callback_ == IntPtr.Zero)
				id_sendEmptyMessageDelayed_IJLandroid_os_Handler_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "sendEmptyMessageDelayed", "(IJLandroid/os/Handler$Callback;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_sendEmptyMessageDelayed_IJLandroid_os_Handler_Callback_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sendMessage_Landroid_os_Message_Landroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='UIHandler']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='android.os.Message'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("sendMessage", "(Landroid/os/Message;Landroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendMessage (global::Android.OS.Message p0, global::Android.OS.Handler.ICallback p1)
		{
			if (id_sendMessage_Landroid_os_Message_Landroid_os_Handler_Callback_ == IntPtr.Zero)
				id_sendMessage_Landroid_os_Message_Landroid_os_Handler_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "sendMessage", "(Landroid/os/Message;Landroid/os/Handler$Callback;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_sendMessage_Landroid_os_Message_Landroid_os_Handler_Callback_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sendMessageAtFrontOfQueue_Landroid_os_Message_Landroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='UIHandler']/method[@name='sendMessageAtFrontOfQueue' and count(parameter)=2 and parameter[1][@type='android.os.Message'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("sendMessageAtFrontOfQueue", "(Landroid/os/Message;Landroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendMessageAtFrontOfQueue (global::Android.OS.Message p0, global::Android.OS.Handler.ICallback p1)
		{
			if (id_sendMessageAtFrontOfQueue_Landroid_os_Message_Landroid_os_Handler_Callback_ == IntPtr.Zero)
				id_sendMessageAtFrontOfQueue_Landroid_os_Message_Landroid_os_Handler_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "sendMessageAtFrontOfQueue", "(Landroid/os/Message;Landroid/os/Handler$Callback;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_sendMessageAtFrontOfQueue_Landroid_os_Message_Landroid_os_Handler_Callback_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sendMessageAtTime_Landroid_os_Message_JLandroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='UIHandler']/method[@name='sendMessageAtTime' and count(parameter)=3 and parameter[1][@type='android.os.Message'] and parameter[2][@type='long'] and parameter[3][@type='android.os.Handler.Callback']]"
		[Register ("sendMessageAtTime", "(Landroid/os/Message;JLandroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendMessageAtTime (global::Android.OS.Message p0, long p1, global::Android.OS.Handler.ICallback p2)
		{
			if (id_sendMessageAtTime_Landroid_os_Message_JLandroid_os_Handler_Callback_ == IntPtr.Zero)
				id_sendMessageAtTime_Landroid_os_Message_JLandroid_os_Handler_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "sendMessageAtTime", "(Landroid/os/Message;JLandroid/os/Handler$Callback;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_sendMessageAtTime_Landroid_os_Message_JLandroid_os_Handler_Callback_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sendMessageDelayed_Landroid_os_Message_JLandroid_os_Handler_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.utils']/class[@name='UIHandler']/method[@name='sendMessageDelayed' and count(parameter)=3 and parameter[1][@type='android.os.Message'] and parameter[2][@type='long'] and parameter[3][@type='android.os.Handler.Callback']]"
		[Register ("sendMessageDelayed", "(Landroid/os/Message;JLandroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendMessageDelayed (global::Android.OS.Message p0, long p1, global::Android.OS.Handler.ICallback p2)
		{
			if (id_sendMessageDelayed_Landroid_os_Message_JLandroid_os_Handler_Callback_ == IntPtr.Zero)
				id_sendMessageDelayed_Landroid_os_Message_JLandroid_os_Handler_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "sendMessageDelayed", "(Landroid/os/Message;JLandroid/os/Handler$Callback;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_sendMessageDelayed_Landroid_os_Message_JLandroid_os_Handler_Callback_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
