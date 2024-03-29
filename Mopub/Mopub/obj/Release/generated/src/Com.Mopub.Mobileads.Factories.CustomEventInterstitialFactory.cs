using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventInterstitialFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/CustomEventInterstitialFactory", DoNotGenerateAcw=true)]
	public partial class CustomEventInterstitialFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/CustomEventInterstitialFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventInterstitialFactory); }
		}

		protected CustomEventInterstitialFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventInterstitialFactory']/constructor[@name='CustomEventInterstitialFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CustomEventInterstitialFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CustomEventInterstitialFactory)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_create_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventInterstitialFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;)Lcom/mopub/mobileads/CustomEventInterstitial;", "")]
		public static global::Com.Mopub.Mobileads.CustomEventInterstitial Create (string p0)
		{
			if (id_create_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/mopub/mobileads/CustomEventInterstitial;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Mopub.Mobileads.CustomEventInterstitial __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_internalCreate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Ljava_lang_String_Handler ()
		{
			if (cb_internalCreate_Ljava_lang_String_ == null)
				cb_internalCreate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Ljava_lang_String_);
			return cb_internalCreate_Ljava_lang_String_;
		}

		static IntPtr n_InternalCreate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.Factories.CustomEventInterstitialFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.CustomEventInterstitialFactory> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventInterstitialFactory']/method[@name='internalCreate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("internalCreate", "(Ljava/lang/String;)Lcom/mopub/mobileads/CustomEventInterstitial;", "GetInternalCreate_Ljava_lang_String_Handler")]
		protected virtual global::Com.Mopub.Mobileads.CustomEventInterstitial InternalCreate (string p0)
		{
			if (id_internalCreate_Ljava_lang_String_ == IntPtr.Zero)
				id_internalCreate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Ljava/lang/String;)Lcom/mopub/mobileads/CustomEventInterstitial;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Mopub.Mobileads.CustomEventInterstitial __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_internalCreate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_CustomEventInterstitialFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventInterstitialFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.CustomEventInterstitialFactory']]"
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/CustomEventInterstitialFactory;)V", "")]
		public static void SetInstance (global::Com.Mopub.Mobileads.Factories.CustomEventInterstitialFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_CustomEventInterstitialFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_CustomEventInterstitialFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/CustomEventInterstitialFactory;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_CustomEventInterstitialFactory_, new JValue (p0));
		}

	}
}
