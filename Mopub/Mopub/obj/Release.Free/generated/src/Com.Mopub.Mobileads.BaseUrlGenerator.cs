using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseUrlGenerator", DoNotGenerateAcw=true)]
	public abstract partial class BaseUrlGenerator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/BaseUrlGenerator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseUrlGenerator); }
		}

		protected BaseUrlGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']/constructor[@name='BaseUrlGenerator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BaseUrlGenerator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BaseUrlGenerator)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getFinalUrlString;
#pragma warning disable 0169
		static Delegate GetGetFinalUrlStringHandler ()
		{
			if (cb_getFinalUrlString == null)
				cb_getFinalUrlString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFinalUrlString);
			return cb_getFinalUrlString;
		}

		static IntPtr n_GetFinalUrlString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FinalUrlString);
		}
#pragma warning restore 0169

		static IntPtr id_getFinalUrlString;
		protected virtual string FinalUrlString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']/method[@name='getFinalUrlString' and count(parameter)=0]"
			[Register ("getFinalUrlString", "()Ljava/lang/String;", "GetGetFinalUrlStringHandler")]
			get {
				if (id_getFinalUrlString == IntPtr.Zero)
					id_getFinalUrlString = JNIEnv.GetMethodID (class_ref, "getFinalUrlString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFinalUrlString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getFinalUrlString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addParam_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddParam_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addParam_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addParam_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddParam_Ljava_lang_String_Ljava_lang_String_);
			return cb_addParam_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddParam_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddParam (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addParam_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']/method[@name='addParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addParam", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddParam_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual void AddParam (string p0, string p1)
		{
			if (id_addParam_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addParam_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addParam", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addParam_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addParam_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_generateUrlString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerateUrlString_Ljava_lang_String_Handler ()
		{
			if (cb_generateUrlString_Ljava_lang_String_ == null)
				cb_generateUrlString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateUrlString_Ljava_lang_String_);
			return cb_generateUrlString_Ljava_lang_String_;
		}

		static IntPtr n_GenerateUrlString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateUrlString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']/method[@name='generateUrlString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("generateUrlString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGenerateUrlString_Ljava_lang_String_Handler")]
		public abstract string GenerateUrlString (string p0);

		static Delegate cb_getAppVersionFromContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAppVersionFromContext_Landroid_content_Context_Handler ()
		{
			if (cb_getAppVersionFromContext_Landroid_content_Context_ == null)
				cb_getAppVersionFromContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppVersionFromContext_Landroid_content_Context_);
			return cb_getAppVersionFromContext_Landroid_content_Context_;
		}

		static IntPtr n_GetAppVersionFromContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAppVersionFromContext (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAppVersionFromContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']/method[@name='getAppVersionFromContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppVersionFromContext", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetAppVersionFromContext_Landroid_content_Context_Handler")]
		protected virtual string GetAppVersionFromContext (global::Android.Content.Context p0)
		{
			if (id_getAppVersionFromContext_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppVersionFromContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getAppVersionFromContext", "(Landroid/content/Context;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppVersionFromContext_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAppVersionFromContext_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getUdidFromContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetUdidFromContext_Landroid_content_Context_Handler ()
		{
			if (cb_getUdidFromContext_Landroid_content_Context_ == null)
				cb_getUdidFromContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUdidFromContext_Landroid_content_Context_);
			return cb_getUdidFromContext_Landroid_content_Context_;
		}

		static IntPtr n_GetUdidFromContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetUdidFromContext (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUdidFromContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']/method[@name='getUdidFromContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUdidFromContext", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetUdidFromContext_Landroid_content_Context_Handler")]
		protected virtual string GetUdidFromContext (global::Android.Content.Context p0)
		{
			if (id_getUdidFromContext_Landroid_content_Context_ == IntPtr.Zero)
				id_getUdidFromContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getUdidFromContext", "(Landroid/content/Context;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUdidFromContext_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getUdidFromContext_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_initUrlString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitUrlString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_initUrlString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_initUrlString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InitUrlString_Ljava_lang_String_Ljava_lang_String_);
			return cb_initUrlString_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_InitUrlString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InitUrlString (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initUrlString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']/method[@name='initUrlString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("initUrlString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetInitUrlString_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual void InitUrlString (string p0, string p1)
		{
			if (id_initUrlString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_initUrlString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initUrlString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initUrlString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_initUrlString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setApiVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApiVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setApiVersion_Ljava_lang_String_ == null)
				cb_setApiVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApiVersion_Ljava_lang_String_);
			return cb_setApiVersion_Ljava_lang_String_;
		}

		static void n_SetApiVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetApiVersion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setApiVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']/method[@name='setApiVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setApiVersion", "(Ljava/lang/String;)V", "GetSetApiVersion_Ljava_lang_String_Handler")]
		protected virtual void SetApiVersion (string p0)
		{
			if (id_setApiVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_setApiVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApiVersion", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setApiVersion_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setApiVersion_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setAppVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setAppVersion_Ljava_lang_String_ == null)
				cb_setAppVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppVersion_Ljava_lang_String_);
			return cb_setAppVersion_Ljava_lang_String_;
		}

		static void n_SetAppVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAppVersion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAppVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']/method[@name='setAppVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppVersion", "(Ljava/lang/String;)V", "GetSetAppVersion_Ljava_lang_String_Handler")]
		protected virtual void SetAppVersion (string p0)
		{
			if (id_setAppVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppVersion", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAppVersion_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAppVersion_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setUdid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUdid_Ljava_lang_String_Handler ()
		{
			if (cb_setUdid_Ljava_lang_String_ == null)
				cb_setUdid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUdid_Ljava_lang_String_);
			return cb_setUdid_Ljava_lang_String_;
		}

		static void n_SetUdid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUdid (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUdid_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']/method[@name='setUdid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUdid", "(Ljava/lang/String;)V", "GetSetUdid_Ljava_lang_String_Handler")]
		protected virtual void SetUdid (string p0)
		{
			if (id_setUdid_Ljava_lang_String_ == IntPtr.Zero)
				id_setUdid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUdid", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setUdid_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setUdid_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseUrlGenerator", DoNotGenerateAcw=true)]
	internal partial class BaseUrlGeneratorInvoker : BaseUrlGenerator {

		public BaseUrlGeneratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseUrlGeneratorInvoker); }
		}

		static IntPtr id_generateUrlString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseUrlGenerator']/method[@name='generateUrlString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("generateUrlString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGenerateUrlString_Ljava_lang_String_Handler")]
		public override string GenerateUrlString (string p0)
		{
			if (id_generateUrlString_Ljava_lang_String_ == IntPtr.Zero)
				id_generateUrlString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generateUrlString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generateUrlString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
