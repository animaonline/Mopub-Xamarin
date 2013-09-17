using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/HtmlBannerWebViewFactory", DoNotGenerateAcw=true)]
	public partial class HtmlBannerWebViewFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Mobileads.Factories.HtmlBannerWebViewFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/HtmlBannerWebViewFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.HtmlBannerWebViewFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/HtmlBannerWebViewFactory;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/HtmlBannerWebViewFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HtmlBannerWebViewFactory); }
		}

		protected HtmlBannerWebViewFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/constructor[@name='HtmlBannerWebViewFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public HtmlBannerWebViewFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HtmlBannerWebViewFactory)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_cleanup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/method[@name='cleanup' and count(parameter)=0]"
		[Register ("cleanup", "()V", "")]
		public static void Cleanup ()
		{
			if (id_cleanup == IntPtr.Zero)
				id_cleanup = JNIEnv.GetStaticMethodID (class_ref, "cleanup", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_cleanup);
		}

		static IntPtr id_create_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/method[@name='create' and count(parameter)=4 and parameter[1][@type='com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("create", "(Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/HtmlBannerWebView;", "")]
		public static global::Com.Mopub.Mobileads.HtmlBannerWebView Create (global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p0, bool p1, string p2, string p3)
		{
			if (id_create_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/HtmlBannerWebView;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Com.Mopub.Mobileads.HtmlBannerWebView __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBannerWebView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_initialize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)V", "")]
		public static void Initialize (global::Android.Content.Context p0)
		{
			if (id_initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_internalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_internalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ == null)
				cb_internalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_);
			return cb_internalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_InternalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mopub.Mobileads.Factories.HtmlBannerWebViewFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.HtmlBannerWebViewFactory> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p0 = (global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/method[@name='internalCreate' and count(parameter)=4 and parameter[1][@type='com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("internalCreate", "(Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/HtmlBannerWebView;", "GetInternalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Com.Mopub.Mobileads.HtmlBannerWebView InternalCreate (global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p0, bool p1, string p2, string p3)
		{
			if (id_internalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_internalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/HtmlBannerWebView;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);

			global::Com.Mopub.Mobileads.HtmlBannerWebView __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBannerWebView> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBannerWebView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_internalCreate_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_HtmlBannerWebViewFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.HtmlBannerWebViewFactory']]"
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/HtmlBannerWebViewFactory;)V", "")]
		public static void SetInstance (global::Com.Mopub.Mobileads.Factories.HtmlBannerWebViewFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_HtmlBannerWebViewFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_HtmlBannerWebViewFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/HtmlBannerWebViewFactory;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_HtmlBannerWebViewFactory_, new JValue (p0));
		}

	}
}
