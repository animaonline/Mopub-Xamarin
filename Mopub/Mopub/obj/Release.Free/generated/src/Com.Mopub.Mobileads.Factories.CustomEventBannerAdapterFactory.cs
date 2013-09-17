using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventBannerAdapterFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/CustomEventBannerAdapterFactory", DoNotGenerateAcw=true)]
	public partial class CustomEventBannerAdapterFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventBannerAdapterFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Mobileads.Factories.CustomEventBannerAdapterFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/CustomEventBannerAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.CustomEventBannerAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/CustomEventBannerAdapterFactory;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/CustomEventBannerAdapterFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventBannerAdapterFactory); }
		}

		protected CustomEventBannerAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventBannerAdapterFactory']/constructor[@name='CustomEventBannerAdapterFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CustomEventBannerAdapterFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CustomEventBannerAdapterFactory)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_create_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventBannerAdapterFactory']/method[@name='create' and count(parameter)=3 and parameter[1][@type='com.mopub.mobileads.MoPubView'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("create", "(Lcom/mopub/mobileads/MoPubView;Ljava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/CustomEventBannerAdapter;", "")]
		public static global::Com.Mopub.Mobileads.CustomEventBannerAdapter Create (global::Com.Mopub.Mobileads.MoPubView p0, string p1, string p2)
		{
			if (id_create_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/mopub/mobileads/MoPubView;Ljava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/CustomEventBannerAdapter;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Com.Mopub.Mobileads.CustomEventBannerAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBannerAdapter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_internalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_internalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_internalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_);
			return cb_internalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_InternalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Mobileads.Factories.CustomEventBannerAdapterFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.CustomEventBannerAdapterFactory> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventBannerAdapterFactory']/method[@name='internalCreate' and count(parameter)=3 and parameter[1][@type='com.mopub.mobileads.MoPubView'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("internalCreate", "(Lcom/mopub/mobileads/MoPubView;Ljava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/CustomEventBannerAdapter;", "GetInternalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual global::Com.Mopub.Mobileads.CustomEventBannerAdapter InternalCreate (global::Com.Mopub.Mobileads.MoPubView p0, string p1, string p2)
		{
			if (id_internalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_internalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Lcom/mopub/mobileads/MoPubView;Ljava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/CustomEventBannerAdapter;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			global::Com.Mopub.Mobileads.CustomEventBannerAdapter __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBannerAdapter> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBannerAdapter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_internalCreate_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_CustomEventBannerAdapterFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventBannerAdapterFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.CustomEventBannerAdapterFactory']]"
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/CustomEventBannerAdapterFactory;)V", "")]
		public static void SetInstance (global::Com.Mopub.Mobileads.Factories.CustomEventBannerAdapterFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_CustomEventBannerAdapterFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_CustomEventBannerAdapterFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/CustomEventBannerAdapterFactory;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_CustomEventBannerAdapterFactory_, new JValue (p0));
		}

	}
}
