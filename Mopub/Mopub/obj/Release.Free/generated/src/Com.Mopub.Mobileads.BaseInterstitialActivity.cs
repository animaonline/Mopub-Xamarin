using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseInterstitialActivity", DoNotGenerateAcw=true)]
	public abstract partial class BaseInterstitialActivity : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/field[@name='ACTION_INTERSTITIAL_CLICK']"
		[Register ("ACTION_INTERSTITIAL_CLICK")]
		public const string ActionInterstitialClick = (string) "com.mopub.action.interstitial.click";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/field[@name='ACTION_INTERSTITIAL_DISMISS']"
		[Register ("ACTION_INTERSTITIAL_DISMISS")]
		public const string ActionInterstitialDismiss = (string) "com.mopub.action.interstitial.dismiss";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/field[@name='ACTION_INTERSTITIAL_FAIL']"
		[Register ("ACTION_INTERSTITIAL_FAIL")]
		public const string ActionInterstitialFail = (string) "com.mopub.action.interstitial.fail";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/field[@name='ACTION_INTERSTITIAL_SHOW']"
		[Register ("ACTION_INTERSTITIAL_SHOW")]
		public const string ActionInterstitialShow = (string) "com.mopub.action.interstitial.show";

		static IntPtr HTML_INTERSTITIAL_INTENT_FILTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/field[@name='HTML_INTERSTITIAL_INTENT_FILTER']"
		[Register ("HTML_INTERSTITIAL_INTENT_FILTER")]
		public static global::Android.Content.IntentFilter HtmlInterstitialIntentFilter {
			get {
				if (HTML_INTERSTITIAL_INTENT_FILTER_jfieldId == IntPtr.Zero)
					HTML_INTERSTITIAL_INTENT_FILTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTML_INTERSTITIAL_INTENT_FILTER", "Landroid/content/IntentFilter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTML_INTERSTITIAL_INTENT_FILTER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HTML_INTERSTITIAL_INTENT_FILTER_jfieldId == IntPtr.Zero)
					HTML_INTERSTITIAL_INTENT_FILTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTML_INTERSTITIAL_INTENT_FILTER", "Landroid/content/IntentFilter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, HTML_INTERSTITIAL_INTENT_FILTER_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/BaseInterstitialActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseInterstitialActivity); }
		}

		protected BaseInterstitialActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/constructor[@name='BaseInterstitialActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BaseInterstitialActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BaseInterstitialActivity)) {
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
			global::Com.Mopub.Mobileads.BaseInterstitialActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseInterstitialActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdView);
		}
#pragma warning restore 0169

		public abstract global::Android.Views.View AdView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='getAdView' and count(parameter)=0]"
			[Register ("getAdView", "()Landroid/view/View;", "GetGetAdViewHandler")] get;
		}

		static Delegate cb_broadcastInterstitialAction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBroadcastInterstitialAction_Ljava_lang_String_Handler ()
		{
			if (cb_broadcastInterstitialAction_Ljava_lang_String_ == null)
				cb_broadcastInterstitialAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BroadcastInterstitialAction_Ljava_lang_String_);
			return cb_broadcastInterstitialAction_Ljava_lang_String_;
		}

		static void n_BroadcastInterstitialAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.BaseInterstitialActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseInterstitialActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BroadcastInterstitialAction (p0);
		}
#pragma warning restore 0169

		static IntPtr id_broadcastInterstitialAction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='broadcastInterstitialAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("broadcastInterstitialAction", "(Ljava/lang/String;)V", "GetBroadcastInterstitialAction_Ljava_lang_String_Handler")]
		protected virtual void BroadcastInterstitialAction (string p0)
		{
			if (id_broadcastInterstitialAction_Ljava_lang_String_ == IntPtr.Zero)
				id_broadcastInterstitialAction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "broadcastInterstitialAction", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_broadcastInterstitialAction_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_broadcastInterstitialAction_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_hideInterstitialCloseButton;
#pragma warning disable 0169
		static Delegate GetHideInterstitialCloseButtonHandler ()
		{
			if (cb_hideInterstitialCloseButton == null)
				cb_hideInterstitialCloseButton = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideInterstitialCloseButton);
			return cb_hideInterstitialCloseButton;
		}

		static void n_HideInterstitialCloseButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseInterstitialActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseInterstitialActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideInterstitialCloseButton ();
		}
#pragma warning restore 0169

		static IntPtr id_hideInterstitialCloseButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='hideInterstitialCloseButton' and count(parameter)=0]"
		[Register ("hideInterstitialCloseButton", "()V", "GetHideInterstitialCloseButtonHandler")]
		protected virtual void HideInterstitialCloseButton ()
		{
			if (id_hideInterstitialCloseButton == IntPtr.Zero)
				id_hideInterstitialCloseButton = JNIEnv.GetMethodID (class_ref, "hideInterstitialCloseButton", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_hideInterstitialCloseButton);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_hideInterstitialCloseButton);
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.BaseInterstitialActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseInterstitialActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCreate_Landroid_os_Bundle_, new JValue (p0));
		}

		static Delegate cb_showInterstitialCloseButton;
#pragma warning disable 0169
		static Delegate GetShowInterstitialCloseButtonHandler ()
		{
			if (cb_showInterstitialCloseButton == null)
				cb_showInterstitialCloseButton = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowInterstitialCloseButton);
			return cb_showInterstitialCloseButton;
		}

		static void n_ShowInterstitialCloseButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseInterstitialActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseInterstitialActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowInterstitialCloseButton ();
		}
#pragma warning restore 0169

		static IntPtr id_showInterstitialCloseButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='showInterstitialCloseButton' and count(parameter)=0]"
		[Register ("showInterstitialCloseButton", "()V", "GetShowInterstitialCloseButtonHandler")]
		protected virtual void ShowInterstitialCloseButton ()
		{
			if (id_showInterstitialCloseButton == IntPtr.Zero)
				id_showInterstitialCloseButton = JNIEnv.GetMethodID (class_ref, "showInterstitialCloseButton", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showInterstitialCloseButton);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_showInterstitialCloseButton);
		}

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseInterstitialActivity", DoNotGenerateAcw=true)]
	internal partial class BaseInterstitialActivityInvoker : BaseInterstitialActivity {

		public BaseInterstitialActivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseInterstitialActivityInvoker); }
		}

		static IntPtr id_getAdView;
		public override global::Android.Views.View AdView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='getAdView' and count(parameter)=0]"
			[Register ("getAdView", "()Landroid/view/View;", "GetGetAdViewHandler")]
			get {
				if (id_getAdView == IntPtr.Zero)
					id_getAdView = JNIEnv.GetMethodID (class_ref, "getAdView", "()Landroid/view/View;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getAdView), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
