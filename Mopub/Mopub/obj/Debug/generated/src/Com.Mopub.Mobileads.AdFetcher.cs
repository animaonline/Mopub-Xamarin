using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/AdFetcher", DoNotGenerateAcw=true)]
	public partial class AdFetcher : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='AD_TYPE_HEADER']"
		[Register ("AD_TYPE_HEADER")]
		public const string AdTypeHeader = (string) "X-Adtype";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='CLICKTHROUGH_URL_HEADER']"
		[Register ("CLICKTHROUGH_URL_HEADER")]
		public const string ClickthroughUrlHeader = (string) "X-Clickthrough";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='CLICKTHROUGH_URL_KEY']"
		[Register ("CLICKTHROUGH_URL_KEY")]
		public const string ClickthroughUrlKey = (string) "Clickthrough-Url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='CUSTOM_EVENT_DATA_HEADER']"
		[Register ("CUSTOM_EVENT_DATA_HEADER")]
		public const string CustomEventDataHeader = (string) "X-Custom-Event-Class-Data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='CUSTOM_EVENT_HTML_DATA']"
		[Register ("CUSTOM_EVENT_HTML_DATA")]
		public const string CustomEventHtmlData = (string) "X-Custom-Event-Html-Data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='CUSTOM_EVENT_NAME_HEADER']"
		[Register ("CUSTOM_EVENT_NAME_HEADER")]
		public const string CustomEventNameHeader = (string) "X-Custom-Event-Class-Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='CUSTOM_SELECTOR_HEADER']"
		[Register ("CUSTOM_SELECTOR_HEADER")]
		[Obsolete ("deprecated")]
		public const string CustomSelectorHeader = (string) "X-Customselector";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='FULL_AD_TYPE_HEADER']"
		[Register ("FULL_AD_TYPE_HEADER")]
		public const string FullAdTypeHeader = (string) "X-Fulladtype";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='HTML_RESPONSE_BODY_KEY']"
		[Register ("HTML_RESPONSE_BODY_KEY")]
		public const string HtmlResponseBodyKey = (string) "Html-Response-Body";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='NATIVE_PARAMS_HEADER']"
		[Register ("NATIVE_PARAMS_HEADER")]
		public const string NativeParamsHeader = (string) "X-Nativeparams";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='REDIRECT_URL_HEADER']"
		[Register ("REDIRECT_URL_HEADER")]
		public const string RedirectUrlHeader = (string) "X-Launchpage";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='REDIRECT_URL_KEY']"
		[Register ("REDIRECT_URL_KEY")]
		public const string RedirectUrlKey = (string) "Redirect-Url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='SCROLLABLE_HEADER']"
		[Register ("SCROLLABLE_HEADER")]
		public const string ScrollableHeader = (string) "X-Scrollable";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='SCROLLABLE_KEY']"
		[Register ("SCROLLABLE_KEY")]
		public const string ScrollableKey = (string) "Scrollable";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='USER_AGENT_HEADER']"
		[Register ("USER_AGENT_HEADER")]
		public const string UserAgentHeader = (string) "User-Agent";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/field[@name='WARMUP_HEADER']"
		[Register ("WARMUP_HEADER")]
		public const string WarmupHeader = (string) "X-Warmup";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher.FetchStatus']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/AdFetcher$FetchStatus", DoNotGenerateAcw=true)]
		public sealed partial class FetchStatus : global::Java.Lang.Enum {


			static IntPtr AD_WARMING_UP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher.FetchStatus']/field[@name='AD_WARMING_UP']"
			[Register ("AD_WARMING_UP")]
			public static global::Com.Mopub.Mobileads.AdFetcher.FetchStatus AdWarmingUp {
				get {
					if (AD_WARMING_UP_jfieldId == IntPtr.Zero)
						AD_WARMING_UP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_WARMING_UP", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_WARMING_UP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher.FetchStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (AD_WARMING_UP_jfieldId == IntPtr.Zero)
						AD_WARMING_UP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_WARMING_UP", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, AD_WARMING_UP_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CLEAR_AD_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher.FetchStatus']/field[@name='CLEAR_AD_TYPE']"
			[Register ("CLEAR_AD_TYPE")]
			public static global::Com.Mopub.Mobileads.AdFetcher.FetchStatus ClearAdType {
				get {
					if (CLEAR_AD_TYPE_jfieldId == IntPtr.Zero)
						CLEAR_AD_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLEAR_AD_TYPE", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLEAR_AD_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher.FetchStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CLEAR_AD_TYPE_jfieldId == IntPtr.Zero)
						CLEAR_AD_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLEAR_AD_TYPE", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CLEAR_AD_TYPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FETCH_CANCELLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher.FetchStatus']/field[@name='FETCH_CANCELLED']"
			[Register ("FETCH_CANCELLED")]
			public static global::Com.Mopub.Mobileads.AdFetcher.FetchStatus FetchCancelled {
				get {
					if (FETCH_CANCELLED_jfieldId == IntPtr.Zero)
						FETCH_CANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FETCH_CANCELLED", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FETCH_CANCELLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher.FetchStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FETCH_CANCELLED_jfieldId == IntPtr.Zero)
						FETCH_CANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FETCH_CANCELLED", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FETCH_CANCELLED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INVALID_SERVER_RESPONSE_BACKOFF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher.FetchStatus']/field[@name='INVALID_SERVER_RESPONSE_BACKOFF']"
			[Register ("INVALID_SERVER_RESPONSE_BACKOFF")]
			public static global::Com.Mopub.Mobileads.AdFetcher.FetchStatus InvalidServerResponseBackoff {
				get {
					if (INVALID_SERVER_RESPONSE_BACKOFF_jfieldId == IntPtr.Zero)
						INVALID_SERVER_RESPONSE_BACKOFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_SERVER_RESPONSE_BACKOFF", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_SERVER_RESPONSE_BACKOFF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher.FetchStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INVALID_SERVER_RESPONSE_BACKOFF_jfieldId == IntPtr.Zero)
						INVALID_SERVER_RESPONSE_BACKOFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_SERVER_RESPONSE_BACKOFF", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INVALID_SERVER_RESPONSE_BACKOFF_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INVALID_SERVER_RESPONSE_NOBACKOFF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher.FetchStatus']/field[@name='INVALID_SERVER_RESPONSE_NOBACKOFF']"
			[Register ("INVALID_SERVER_RESPONSE_NOBACKOFF")]
			public static global::Com.Mopub.Mobileads.AdFetcher.FetchStatus InvalidServerResponseNobackoff {
				get {
					if (INVALID_SERVER_RESPONSE_NOBACKOFF_jfieldId == IntPtr.Zero)
						INVALID_SERVER_RESPONSE_NOBACKOFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_SERVER_RESPONSE_NOBACKOFF", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_SERVER_RESPONSE_NOBACKOFF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher.FetchStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INVALID_SERVER_RESPONSE_NOBACKOFF_jfieldId == IntPtr.Zero)
						INVALID_SERVER_RESPONSE_NOBACKOFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_SERVER_RESPONSE_NOBACKOFF", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INVALID_SERVER_RESPONSE_NOBACKOFF_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NOT_SET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher.FetchStatus']/field[@name='NOT_SET']"
			[Register ("NOT_SET")]
			public static global::Com.Mopub.Mobileads.AdFetcher.FetchStatus NotSet {
				get {
					if (NOT_SET_jfieldId == IntPtr.Zero)
						NOT_SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SET", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_SET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher.FetchStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NOT_SET_jfieldId == IntPtr.Zero)
						NOT_SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SET", "Lcom/mopub/mobileads/AdFetcher$FetchStatus;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NOT_SET_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/AdFetcher$FetchStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FetchStatus); }
			}

			internal FetchStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/AdFetcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdFetcher); }
		}

		protected AdFetcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/constructor[@name='AdFetcher' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.AdViewController'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/mopub/mobileads/AdViewController;Ljava/lang/String;)V", "")]
		public AdFetcher (global::Com.Mopub.Mobileads.AdViewController p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (AdFetcher)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/mopub/mobileads/AdViewController;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/AdViewController;Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_cancelFetch;
#pragma warning disable 0169
		static Delegate GetCancelFetchHandler ()
		{
			if (cb_cancelFetch == null)
				cb_cancelFetch = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelFetch);
			return cb_cancelFetch;
		}

		static void n_CancelFetch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelFetch ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelFetch;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/method[@name='cancelFetch' and count(parameter)=0]"
		[Register ("cancelFetch", "()V", "GetCancelFetchHandler")]
		public virtual void CancelFetch ()
		{
			if (id_cancelFetch == IntPtr.Zero)
				id_cancelFetch = JNIEnv.GetMethodID (class_ref, "cancelFetch", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_cancelFetch);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_cancelFetch);
		}

		static Delegate cb_fetchAdForUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFetchAdForUrl_Ljava_lang_String_Handler ()
		{
			if (cb_fetchAdForUrl_Ljava_lang_String_ == null)
				cb_fetchAdForUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FetchAdForUrl_Ljava_lang_String_);
			return cb_fetchAdForUrl_Ljava_lang_String_;
		}

		static void n_FetchAdForUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.AdFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FetchAdForUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fetchAdForUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/method[@name='fetchAdForUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fetchAdForUrl", "(Ljava/lang/String;)V", "GetFetchAdForUrl_Ljava_lang_String_Handler")]
		public virtual void FetchAdForUrl (string p0)
		{
			if (id_fetchAdForUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_fetchAdForUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fetchAdForUrl", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_fetchAdForUrl_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_fetchAdForUrl_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Mobileads.AdFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdFetcher']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
		protected virtual void SetTimeout (int p0)
		{
			if (id_setTimeout_I == IntPtr.Zero)
				id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTimeout_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTimeout_I, new JValue (p0));
		}

	}
}
