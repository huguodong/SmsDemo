using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk.Framework.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.smssdk.framework.network']/interface[@name='HttpResponseCallback']"
	[Register ("cn/smssdk/framework/network/HttpResponseCallback", "", "CN.Smssdk.Framework.Network.IHttpResponseCallbackInvoker")]
	public partial interface IHttpResponseCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.framework.network']/interface[@name='HttpResponseCallback']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register ("onResponse", "(Lorg/apache/http/HttpResponse;)V", "GetOnResponse_Lorg_apache_http_HttpResponse_Handler:CN.Smssdk.Framework.Network.IHttpResponseCallbackInvoker, SMSSDK")]
		void OnResponse (global::Org.Apache.Http.IHttpResponse p0);

	}

	[global::Android.Runtime.Register ("cn/smssdk/framework/network/HttpResponseCallback", DoNotGenerateAcw=true)]
	internal class IHttpResponseCallbackInvoker : global::Java.Lang.Object, IHttpResponseCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("cn/smssdk/framework/network/HttpResponseCallback");
		IntPtr class_ref;

		public static IHttpResponseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpResponseCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.smssdk.framework.network.HttpResponseCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpResponseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHttpResponseCallbackInvoker); }
		}

		static Delegate cb_onResponse_Lorg_apache_http_HttpResponse_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Lorg_apache_http_HttpResponse_Handler ()
		{
			if (cb_onResponse_Lorg_apache_http_HttpResponse_ == null)
				cb_onResponse_Lorg_apache_http_HttpResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponse_Lorg_apache_http_HttpResponse_);
			return cb_onResponse_Lorg_apache_http_HttpResponse_;
		}

		static void n_OnResponse_Lorg_apache_http_HttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Framework.Network.IHttpResponseCallback __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Framework.Network.IHttpResponseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Http.IHttpResponse p0 = (global::Org.Apache.Http.IHttpResponse)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_Lorg_apache_http_HttpResponse_;
		public unsafe void OnResponse (global::Org.Apache.Http.IHttpResponse p0)
		{
			if (id_onResponse_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
				id_onResponse_Lorg_apache_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Lorg/apache/http/HttpResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onResponse_Lorg_apache_http_HttpResponse_, __args);
		}

	}

}
