using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdFetcherFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/AdFetcherFactory", DoNotGenerateAcw=true)]
	public partial class AdFetcherFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdFetcherFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Mobileads.Factories.AdFetcherFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/AdFetcherFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.AdFetcherFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/AdFetcherFactory;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/AdFetcherFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdFetcherFactory); }
		}

		protected AdFetcherFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdFetcherFactory']/constructor[@name='AdFetcherFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AdFetcherFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AdFetcherFactory)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_create_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdFetcherFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.AdViewController'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "(Lcom/mopub/mobileads/AdViewController;Ljava/lang/String;)Lcom/mopub/mobileads/AdFetcher;", "")]
		public static global::Com.Mopub.Mobileads.AdFetcher Create (global::Com.Mopub.Mobileads.AdViewController p0, string p1)
		{
			if (id_create_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/mopub/mobileads/AdViewController;Ljava/lang/String;)Lcom/mopub/mobileads/AdFetcher;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Mopub.Mobileads.AdFetcher __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_internalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_Handler ()
		{
			if (cb_internalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_ == null)
				cb_internalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_);
			return cb_internalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_;
		}

		static IntPtr n_InternalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.Factories.AdFetcherFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.AdFetcherFactory> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.AdViewController p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdFetcherFactory']/method[@name='internalCreate' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.AdViewController'] and parameter[2][@type='java.lang.String']]"
		[Register ("internalCreate", "(Lcom/mopub/mobileads/AdViewController;Ljava/lang/String;)Lcom/mopub/mobileads/AdFetcher;", "GetInternalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_Handler")]
		protected virtual global::Com.Mopub.Mobileads.AdFetcher InternalCreate (global::Com.Mopub.Mobileads.AdViewController p0, string p1)
		{
			if (id_internalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_ == IntPtr.Zero)
				id_internalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Lcom/mopub/mobileads/AdViewController;Ljava/lang/String;)Lcom/mopub/mobileads/AdFetcher;");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Mopub.Mobileads.AdFetcher __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdFetcher> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_internalCreate_Lcom_mopub_mobileads_AdViewController_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_AdFetcherFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdFetcherFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.AdFetcherFactory']]"
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/AdFetcherFactory;)V", "")]
		public static void SetInstance (global::Com.Mopub.Mobileads.Factories.AdFetcherFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_AdFetcherFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_AdFetcherFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/AdFetcherFactory;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_AdFetcherFactory_, new JValue (p0));
		}

	}
}
