using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='SSLSocketFactoryEx']"
	[global::Android.Runtime.Register ("cn/smssdk/framework/network/SSLSocketFactoryEx", DoNotGenerateAcw=true)]
	public partial class SSLSocketFactoryEx : global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/framework/network/SSLSocketFactoryEx", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SSLSocketFactoryEx); }
		}

		protected SSLSocketFactoryEx (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_security_KeyStore_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk.framework.network']/class[@name='SSLSocketFactoryEx']/constructor[@name='SSLSocketFactoryEx' and count(parameter)=1 and parameter[1][@type='java.security.KeyStore']]"
		[Register (".ctor", "(Ljava/security/KeyStore;)V", "")]
		public unsafe SSLSocketFactoryEx (global::Java.Security.KeyStore p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SSLSocketFactoryEx)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/security/KeyStore;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/security/KeyStore;)V", __args);
					return;
				}

				if (id_ctor_Ljava_security_KeyStore_ == IntPtr.Zero)
					id_ctor_Ljava_security_KeyStore_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/security/KeyStore;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_security_KeyStore_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_security_KeyStore_, __args);
			} finally {
			}
		}

	}
}
