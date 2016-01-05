using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Smssdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']"
	[global::Android.Runtime.Register ("cn/smssdk/SMSSDK", DoNotGenerateAcw=true)]
	public partial class SMSSDK : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_GET_CONTACTS']"
		[Register ("EVENT_GET_CONTACTS")]
		public const int EventGetContacts = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_GET_FRIENDS_IN_APP']"
		[Register ("EVENT_GET_FRIENDS_IN_APP")]
		public const int EventGetFriendsInApp = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_GET_NEW_FRIENDS_COUNT']"
		[Register ("EVENT_GET_NEW_FRIENDS_COUNT")]
		public const int EventGetNewFriendsCount = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_GET_SUPPORTED_COUNTRIES']"
		[Register ("EVENT_GET_SUPPORTED_COUNTRIES")]
		public const int EventGetSupportedCountries = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_GET_VERIFICATION_CODE']"
		[Register ("EVENT_GET_VERIFICATION_CODE")]
		public const int EventGetVerificationCode = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_SUBMIT_USER_INFO']"
		[Register ("EVENT_SUBMIT_USER_INFO")]
		public const int EventSubmitUserInfo = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_SUBMIT_VERIFICATION_CODE']"
		[Register ("EVENT_SUBMIT_VERIFICATION_CODE")]
		public const int EventSubmitVerificationCode = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='RESULT_COMPLETE']"
		[Register ("RESULT_COMPLETE")]
		public const int ResultComplete = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='RESULT_ERROR']"
		[Register ("RESULT_ERROR")]
		public const int ResultError = (int) 0;
		// Metadata.xml XPath interface reference: path="/api/package[@name='cn.smssdk']/interface[@name='SMSSDK.VerifyCodeReadListener']"
		[Register ("cn/smssdk/SMSSDK$VerifyCodeReadListener", "", "CN.Smssdk.SMSSDK/IVerifyCodeReadListenerInvoker")]
		public partial interface IVerifyCodeReadListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/interface[@name='SMSSDK.VerifyCodeReadListener']/method[@name='onReadVerifyCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onReadVerifyCode", "(Ljava/lang/String;)V", "GetOnReadVerifyCode_Ljava_lang_String_Handler:CN.Smssdk.SMSSDK/IVerifyCodeReadListenerInvoker, SMSSDK")]
			void OnReadVerifyCode (string p0);

		}

		[global::Android.Runtime.Register ("cn/smssdk/SMSSDK$VerifyCodeReadListener", DoNotGenerateAcw=true)]
		internal class IVerifyCodeReadListenerInvoker : global::Java.Lang.Object, IVerifyCodeReadListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("cn/smssdk/SMSSDK$VerifyCodeReadListener");
			IntPtr class_ref;

			public static IVerifyCodeReadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IVerifyCodeReadListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "cn.smssdk.SMSSDK.VerifyCodeReadListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IVerifyCodeReadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IVerifyCodeReadListenerInvoker); }
			}

			static Delegate cb_onReadVerifyCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnReadVerifyCode_Ljava_lang_String_Handler ()
			{
				if (cb_onReadVerifyCode_Ljava_lang_String_ == null)
					cb_onReadVerifyCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReadVerifyCode_Ljava_lang_String_);
				return cb_onReadVerifyCode_Ljava_lang_String_;
			}

			static void n_OnReadVerifyCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::CN.Smssdk.SMSSDK.IVerifyCodeReadListener __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.SMSSDK.IVerifyCodeReadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReadVerifyCode (p0);
			}
#pragma warning restore 0169

			IntPtr id_onReadVerifyCode_Ljava_lang_String_;
			public unsafe void OnReadVerifyCode (string p0)
			{
				if (id_onReadVerifyCode_Ljava_lang_String_ == IntPtr.Zero)
					id_onReadVerifyCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReadVerifyCode", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (Handle, id_onReadVerifyCode_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class VerifyCodeReadEventArgs : global::System.EventArgs {

			public VerifyCodeReadEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/cn/smssdk/SMSSDK_VerifyCodeReadListenerImplementor")]
		internal sealed partial class IVerifyCodeReadListenerImplementor : global::Java.Lang.Object, IVerifyCodeReadListener {

			object sender;

			public IVerifyCodeReadListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/cn/smssdk/SMSSDK_VerifyCodeReadListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<VerifyCodeReadEventArgs> Handler;
#pragma warning restore 0649

			public void OnReadVerifyCode (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new VerifyCodeReadEventArgs (p0));
			}

			internal static bool __IsEmpty (IVerifyCodeReadListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/smssdk/SMSSDK", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SMSSDK); }
		}

		protected SMSSDK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/constructor[@name='SMSSDK' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SMSSDK ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SMSSDK)) {
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

		static IntPtr id_getGroupedCountryList;
		public static unsafe global::System.Collections.Generic.IDictionary<global::Java.Lang.Character, global::System.Collections.Generic.IList<string[]>> GroupedCountryList {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getGroupedCountryList' and count(parameter)=0]"
			[Register ("getGroupedCountryList", "()Ljava/util/HashMap;", "GetGetGroupedCountryListHandler")]
			get {
				if (id_getGroupedCountryList == IntPtr.Zero)
					id_getGroupedCountryList = JNIEnv.GetStaticMethodID (class_ref, "getGroupedCountryList", "()Ljava/util/HashMap;");
				try {
					return global::Android.Runtime.JavaDictionary<global::Java.Lang.Character, global::System.Collections.Generic.IList<string[]>>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGroupedCountryList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getContacts_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getContacts' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getContacts", "(Z)V", "")]
		public static unsafe void GetContacts (bool p0)
		{
			if (id_getContacts_Z == IntPtr.Zero)
				id_getContacts_Z = JNIEnv.GetStaticMethodID (class_ref, "getContacts", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getContacts_Z, __args);
			} finally {
			}
		}

		static IntPtr id_getCountry_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCountry", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetCountry (string p0)
		{
			if (id_getCountry_Ljava_lang_String_ == IntPtr.Zero)
				id_getCountry_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCountry", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCountry_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getCountryByMCC_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getCountryByMCC' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCountryByMCC", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetCountryByMCC (string p0)
		{
			if (id_getCountryByMCC_Ljava_lang_String_ == IntPtr.Zero)
				id_getCountryByMCC_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCountryByMCC", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCountryByMCC_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFriendsInApp;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getFriendsInApp' and count(parameter)=0]"
		[Register ("getFriendsInApp", "()V", "")]
		public static unsafe void GetFriendsInApp ()
		{
			if (id_getFriendsInApp == IntPtr.Zero)
				id_getFriendsInApp = JNIEnv.GetStaticMethodID (class_ref, "getFriendsInApp", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getFriendsInApp);
			} finally {
			}
		}

		static IntPtr id_getNewFriendsCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getNewFriendsCount' and count(parameter)=0]"
		[Register ("getNewFriendsCount", "()V", "")]
		public static unsafe void GetNewFriendsCount ()
		{
			if (id_getNewFriendsCount == IntPtr.Zero)
				id_getNewFriendsCount = JNIEnv.GetStaticMethodID (class_ref, "getNewFriendsCount", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getNewFriendsCount);
			} finally {
			}
		}

		static IntPtr id_getSupportedCountries;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getSupportedCountries' and count(parameter)=0]"
		[Register ("getSupportedCountries", "()V", "")]
		public static unsafe void GetSupportedCountries ()
		{
			if (id_getSupportedCountries == IntPtr.Zero)
				id_getSupportedCountries = JNIEnv.GetStaticMethodID (class_ref, "getSupportedCountries", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getSupportedCountries);
			} finally {
			}
		}

		static IntPtr id_getVerificationCode_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getVerificationCode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getVerificationCode", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void GetVerificationCode (string p0, string p1)
		{
			if (id_getVerificationCode_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getVerificationCode_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getVerificationCode", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getVerificationCode_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_initSDK_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='initSDK' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("initSDK", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void InitSDK (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_initSDK_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_initSDK_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "initSDK", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initSDK_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_readVerificationCode_Landroid_telephony_SmsMessage_Lcn_smssdk_SMSSDK_VerifyCodeReadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='readVerificationCode' and count(parameter)=2 and parameter[1][@type='android.telephony.SmsMessage'] and parameter[2][@type='cn.smssdk.SMSSDK.VerifyCodeReadListener']]"
		[Register ("readVerificationCode", "(Landroid/telephony/SmsMessage;Lcn/smssdk/SMSSDK$VerifyCodeReadListener;)V", "")]
		public static unsafe void ReadVerificationCode (global::Android.Telephony.SmsMessage p0, global::CN.Smssdk.SMSSDK.IVerifyCodeReadListener p1)
		{
			if (id_readVerificationCode_Landroid_telephony_SmsMessage_Lcn_smssdk_SMSSDK_VerifyCodeReadListener_ == IntPtr.Zero)
				id_readVerificationCode_Landroid_telephony_SmsMessage_Lcn_smssdk_SMSSDK_VerifyCodeReadListener_ = JNIEnv.GetStaticMethodID (class_ref, "readVerificationCode", "(Landroid/telephony/SmsMessage;Lcn/smssdk/SMSSDK$VerifyCodeReadListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_readVerificationCode_Landroid_telephony_SmsMessage_Lcn_smssdk_SMSSDK_VerifyCodeReadListener_, __args);
			} finally {
			}
		}

		static IntPtr id_registerEventHandler_Lcn_smssdk_EventHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='registerEventHandler' and count(parameter)=1 and parameter[1][@type='cn.smssdk.EventHandler']]"
		[Register ("registerEventHandler", "(Lcn/smssdk/EventHandler;)V", "")]
		public static unsafe void RegisterEventHandler (global::CN.Smssdk.EventHandler p0)
		{
			if (id_registerEventHandler_Lcn_smssdk_EventHandler_ == IntPtr.Zero)
				id_registerEventHandler_Lcn_smssdk_EventHandler_ = JNIEnv.GetStaticMethodID (class_ref, "registerEventHandler", "(Lcn/smssdk/EventHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerEventHandler_Lcn_smssdk_EventHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_submitUserInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='submitUserInfo' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("submitUserInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SubmitUserInfo (string p0, string p1, string p2, string p3, string p4)
		{
			if (id_submitUserInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_submitUserInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "submitUserInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
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
				JNIEnv.CallStaticVoidMethod  (class_ref, id_submitUserInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_submitVerificationCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='submitVerificationCode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("submitVerificationCode", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SubmitVerificationCode (string p0, string p1, string p2)
		{
			if (id_submitVerificationCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_submitVerificationCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "submitVerificationCode", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_submitVerificationCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_unregisterAllEventHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='unregisterAllEventHandler' and count(parameter)=0]"
		[Register ("unregisterAllEventHandler", "()V", "")]
		public static unsafe void UnregisterAllEventHandler ()
		{
			if (id_unregisterAllEventHandler == IntPtr.Zero)
				id_unregisterAllEventHandler = JNIEnv.GetStaticMethodID (class_ref, "unregisterAllEventHandler", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unregisterAllEventHandler);
			} finally {
			}
		}

		static IntPtr id_unregisterEventHandler_Lcn_smssdk_EventHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='unregisterEventHandler' and count(parameter)=1 and parameter[1][@type='cn.smssdk.EventHandler']]"
		[Register ("unregisterEventHandler", "(Lcn/smssdk/EventHandler;)V", "")]
		public static unsafe void UnregisterEventHandler (global::CN.Smssdk.EventHandler p0)
		{
			if (id_unregisterEventHandler_Lcn_smssdk_EventHandler_ == IntPtr.Zero)
				id_unregisterEventHandler_Lcn_smssdk_EventHandler_ = JNIEnv.GetStaticMethodID (class_ref, "unregisterEventHandler", "(Lcn/smssdk/EventHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unregisterEventHandler_Lcn_smssdk_EventHandler_, __args);
			} finally {
			}
		}

	}
}
