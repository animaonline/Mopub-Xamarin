using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubActivity", DoNotGenerateAcw=true)]
	public partial class MoPubActivity : global::Com.Mopub.Mobileads.BaseInterstitialActivity {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubActivity$BroadcastingInterstitialListener", DoNotGenerateAcw=true)]
		public partial class BroadcastingInterstitialListener : global::Java.Lang.Object, global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MoPubActivity$BroadcastingInterstitialListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BroadcastingInterstitialListener); }
			}

			protected BroadcastingInterstitialListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onInterstitialClicked;
#pragma warning disable 0169
			static Delegate GetOnInterstitialClickedHandler ()
			{
				if (cb_onInterstitialClicked == null)
					cb_onInterstitialClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialClicked);
				return cb_onInterstitialClicked;
			}

			static void n_OnInterstitialClicked (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialClicked ();
			}
#pragma warning restore 0169

			static IntPtr id_onInterstitialClicked;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onInterstitialClicked' and count(parameter)=0]"
			[Register ("onInterstitialClicked", "()V", "GetOnInterstitialClickedHandler")]
			public virtual void OnInterstitialClicked ()
			{
				if (id_onInterstitialClicked == IntPtr.Zero)
					id_onInterstitialClicked = JNIEnv.GetMethodID (class_ref, "onInterstitialClicked", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialClicked);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onInterstitialClicked);
			}

			static Delegate cb_onInterstitialDismissed;
#pragma warning disable 0169
			static Delegate GetOnInterstitialDismissedHandler ()
			{
				if (cb_onInterstitialDismissed == null)
					cb_onInterstitialDismissed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialDismissed);
				return cb_onInterstitialDismissed;
			}

			static void n_OnInterstitialDismissed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialDismissed ();
			}
#pragma warning restore 0169

			static IntPtr id_onInterstitialDismissed;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onInterstitialDismissed' and count(parameter)=0]"
			[Register ("onInterstitialDismissed", "()V", "GetOnInterstitialDismissedHandler")]
			public virtual void OnInterstitialDismissed ()
			{
				if (id_onInterstitialDismissed == IntPtr.Zero)
					id_onInterstitialDismissed = JNIEnv.GetMethodID (class_ref, "onInterstitialDismissed", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialDismissed);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onInterstitialDismissed);
			}

			static Delegate cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
			{
				if (cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
					cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
				return cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			}

			static void n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialFailed (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onInterstitialFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
			[Register ("onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
			public virtual void OnInterstitialFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				if (id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
					id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0));
			}

			static Delegate cb_onInterstitialLoaded;
#pragma warning disable 0169
			static Delegate GetOnInterstitialLoadedHandler ()
			{
				if (cb_onInterstitialLoaded == null)
					cb_onInterstitialLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialLoaded);
				return cb_onInterstitialLoaded;
			}

			static void n_OnInterstitialLoaded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialLoaded ();
			}
#pragma warning restore 0169

			static IntPtr id_onInterstitialLoaded;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onInterstitialLoaded' and count(parameter)=0]"
			[Register ("onInterstitialLoaded", "()V", "GetOnInterstitialLoadedHandler")]
			public virtual void OnInterstitialLoaded ()
			{
				if (id_onInterstitialLoaded == IntPtr.Zero)
					id_onInterstitialLoaded = JNIEnv.GetMethodID (class_ref, "onInterstitialLoaded", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialLoaded);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onInterstitialLoaded);
			}

			static Delegate cb_onInterstitialShown;
#pragma warning disable 0169
			static Delegate GetOnInterstitialShownHandler ()
			{
				if (cb_onInterstitialShown == null)
					cb_onInterstitialShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialShown);
				return cb_onInterstitialShown;
			}

			static void n_OnInterstitialShown (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialShown ();
			}
#pragma warning restore 0169

			static IntPtr id_onInterstitialShown;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onInterstitialShown' and count(parameter)=0]"
			[Register ("onInterstitialShown", "()V", "GetOnInterstitialShownHandler")]
			public virtual void OnInterstitialShown ()
			{
				if (id_onInterstitialShown == IntPtr.Zero)
					id_onInterstitialShown = JNIEnv.GetMethodID (class_ref, "onInterstitialShown", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialShown);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onInterstitialShown);
			}

			static Delegate cb_onLeaveApplication;
#pragma warning disable 0169
			static Delegate GetOnLeaveApplicationHandler ()
			{
				if (cb_onLeaveApplication == null)
					cb_onLeaveApplication = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLeaveApplication);
				return cb_onLeaveApplication;
			}

			static void n_OnLeaveApplication (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnLeaveApplication ();
			}
#pragma warning restore 0169

			static IntPtr id_onLeaveApplication;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onLeaveApplication' and count(parameter)=0]"
			[Register ("onLeaveApplication", "()V", "GetOnLeaveApplicationHandler")]
			public virtual void OnLeaveApplication ()
			{
				if (id_onLeaveApplication == IntPtr.Zero)
					id_onLeaveApplication = JNIEnv.GetMethodID (class_ref, "onLeaveApplication", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLeaveApplication);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onLeaveApplication);
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MoPubActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubActivity); }
		}

		protected MoPubActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity']/constructor[@name='MoPubActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MoPubActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MoPubActivity)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getAdView;
#pragma warning disable 0169
		static Delegate GetGetAdViewHandler ()
		{
			if (cb_getAdView == null)
				cb_getAdView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdView);
			return cb_getAdView;
		}

		static IntPtr n_GetAdView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdView);
		}
#pragma warning restore 0169

		static IntPtr id_getAdView;
		public override global::Android.Views.View AdView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity']/method[@name='getAdView' and count(parameter)=0]"
			[Register ("getAdView", "()Landroid/view/View;", "GetGetAdViewHandler")]
			get {
				if (id_getAdView == IntPtr.Zero)
					id_getAdView = JNIEnv.GetMethodID (class_ref, "getAdView", "()Landroid/view/View;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getAdView), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAdView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_createIntent_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity']/method[@name='createIntent' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("createIntent", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent CreateIntent (global::Android.Content.Context p0, string p1, bool p2, string p3, string p4)
		{
			if (id_createIntent_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createIntent_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createIntent", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createIntent_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_start_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity']/method[@name='start' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("start", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;)V", "")]
		public static void Start (global::Android.Content.Context p0, string p1, bool p2, string p3, string p4)
		{
			if (id_start_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_start_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

	}
}
