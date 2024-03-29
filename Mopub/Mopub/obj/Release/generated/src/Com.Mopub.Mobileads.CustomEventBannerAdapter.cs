using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBannerAdapter']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventBannerAdapter", DoNotGenerateAcw=true)]
	public partial class CustomEventBannerAdapter : global::Java.Lang.Object, global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBannerAdapter']/field[@name='TIMEOUT_DELAY']"
		[Register ("TIMEOUT_DELAY")]
		public const int TimeoutDelay = (int) 10000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/CustomEventBannerAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventBannerAdapter); }
		}

		protected CustomEventBannerAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBannerAdapter']/constructor[@name='CustomEventBannerAdapter' and count(parameter)=3 and parameter[1][@type='com.mopub.mobileads.MoPubView'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/mopub/mobileads/MoPubView;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public CustomEventBannerAdapter (global::Com.Mopub.Mobileads.MoPubView p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (CustomEventBannerAdapter)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/mopub/mobileads/MoPubView;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/MoPubView;Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onBannerClicked;
#pragma warning disable 0169
		static Delegate GetOnBannerClickedHandler ()
		{
			if (cb_onBannerClicked == null)
				cb_onBannerClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBannerClicked);
			return cb_onBannerClicked;
		}

		static void n_OnBannerClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.CustomEventBannerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBannerAdapter> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_onBannerClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBannerAdapter']/method[@name='onBannerClicked' and count(parameter)=0]"
		[Register ("onBannerClicked", "()V", "GetOnBannerClickedHandler")]
		public virtual void OnBannerClicked ()
		{
			if (id_onBannerClicked == IntPtr.Zero)
				id_onBannerClicked = JNIEnv.GetMethodID (class_ref, "onBannerClicked", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onBannerClicked);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onBannerClicked);
		}

		static Delegate cb_onBannerCollapsed;
#pragma warning disable 0169
		static Delegate GetOnBannerCollapsedHandler ()
		{
			if (cb_onBannerCollapsed == null)
				cb_onBannerCollapsed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBannerCollapsed);
			return cb_onBannerCollapsed;
		}

		static void n_OnBannerCollapsed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.CustomEventBannerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBannerAdapter> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerCollapsed ();
		}
#pragma warning restore 0169

		static IntPtr id_onBannerCollapsed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBannerAdapter']/method[@name='onBannerCollapsed' and count(parameter)=0]"
		[Register ("onBannerCollapsed", "()V", "GetOnBannerCollapsedHandler")]
		public virtual void OnBannerCollapsed ()
		{
			if (id_onBannerCollapsed == IntPtr.Zero)
				id_onBannerCollapsed = JNIEnv.GetMethodID (class_ref, "onBannerCollapsed", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onBannerCollapsed);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onBannerCollapsed);
		}

		static Delegate cb_onBannerExpanded;
#pragma warning disable 0169
		static Delegate GetOnBannerExpandedHandler ()
		{
			if (cb_onBannerExpanded == null)
				cb_onBannerExpanded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBannerExpanded);
			return cb_onBannerExpanded;
		}

		static void n_OnBannerExpanded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.CustomEventBannerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBannerAdapter> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerExpanded ();
		}
#pragma warning restore 0169

		static IntPtr id_onBannerExpanded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBannerAdapter']/method[@name='onBannerExpanded' and count(parameter)=0]"
		[Register ("onBannerExpanded", "()V", "GetOnBannerExpandedHandler")]
		public virtual void OnBannerExpanded ()
		{
			if (id_onBannerExpanded == IntPtr.Zero)
				id_onBannerExpanded = JNIEnv.GetMethodID (class_ref, "onBannerExpanded", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onBannerExpanded);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onBannerExpanded);
		}

		static Delegate cb_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetOnBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_OnBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.CustomEventBannerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBannerAdapter> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBannerAdapter']/method[@name='onBannerFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("onBannerFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
		public virtual void OnBannerFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
		{
			if (id_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onBannerFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0));
		}

		static Delegate cb_onBannerLoaded_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnBannerLoaded_Landroid_view_View_Handler ()
		{
			if (cb_onBannerLoaded_Landroid_view_View_ == null)
				cb_onBannerLoaded_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerLoaded_Landroid_view_View_);
			return cb_onBannerLoaded_Landroid_view_View_;
		}

		static void n_OnBannerLoaded_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.CustomEventBannerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBannerAdapter> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerLoaded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBannerLoaded_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBannerAdapter']/method[@name='onBannerLoaded' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onBannerLoaded", "(Landroid/view/View;)V", "GetOnBannerLoaded_Landroid_view_View_Handler")]
		public virtual void OnBannerLoaded (global::Android.Views.View p0)
		{
			if (id_onBannerLoaded_Landroid_view_View_ == IntPtr.Zero)
				id_onBannerLoaded_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onBannerLoaded", "(Landroid/view/View;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onBannerLoaded_Landroid_view_View_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onBannerLoaded_Landroid_view_View_, new JValue (p0));
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
			global::Com.Mopub.Mobileads.CustomEventBannerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBannerAdapter> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLeaveApplication ();
		}
#pragma warning restore 0169

		static IntPtr id_onLeaveApplication;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBannerAdapter']/method[@name='onLeaveApplication' and count(parameter)=0]"
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
}
