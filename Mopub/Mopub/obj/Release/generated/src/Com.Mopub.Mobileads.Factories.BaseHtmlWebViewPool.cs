using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='BaseHtmlWebViewPool']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/BaseHtmlWebViewPool", DoNotGenerateAcw=true)]
	public abstract partial class BaseHtmlWebViewPool : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='BaseHtmlWebViewPool']/field[@name='POOL_SIZE']"
		[Register ("POOL_SIZE")]
		public const int PoolSize = (int) 3;

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='BaseHtmlWebViewPool']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mContext_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/BaseHtmlWebViewPool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseHtmlWebViewPool); }
		}

		protected BaseHtmlWebViewPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_createNewHtmlWebView;
#pragma warning disable 0169
		static Delegate GetCreateNewHtmlWebViewHandler ()
		{
			if (cb_createNewHtmlWebView == null)
				cb_createNewHtmlWebView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateNewHtmlWebView);
			return cb_createNewHtmlWebView;
		}

		static IntPtr n_CreateNewHtmlWebView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.Factories.BaseHtmlWebViewPool __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.BaseHtmlWebViewPool> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateNewHtmlWebView ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='BaseHtmlWebViewPool']/method[@name='createNewHtmlWebView' and count(parameter)=0]"
		[Register ("createNewHtmlWebView", "()Lcom/mopub/mobileads/BaseHtmlWebView;", "GetCreateNewHtmlWebViewHandler")]
		protected abstract global::Java.Lang.Object CreateNewHtmlWebView ();

		static Delegate cb_getNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_ == null)
				cb_getNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_GetNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_);
			return cb_getNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mopub.Mobileads.Factories.BaseHtmlWebViewPool __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.BaseHtmlWebViewPool> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNextHtmlWebView (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='BaseHtmlWebViewPool']/method[@name='getNextHtmlWebView' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getNextHtmlWebView", "(Ljava/lang/Object;ZLjava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/BaseHtmlWebView;", "GetGetNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Java.Lang.Object GetNextHtmlWebView (global::Java.Lang.Object p0, bool p1, string p2, string p3)
		{
			if (id_getNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getNextHtmlWebView", "(Ljava/lang/Object;ZLjava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/BaseHtmlWebView;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getNextHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_initializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_initializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_ == null)
				cb_initializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr>) n_InitializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_);
			return cb_initializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_;
		}

		static void n_InitializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Mopub.Mobileads.Factories.BaseHtmlWebViewPool __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.BaseHtmlWebViewPool> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.InitializeHtmlWebView (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='BaseHtmlWebViewPool']/method[@name='initializeHtmlWebView' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("initializeHtmlWebView", "(Lcom/mopub/mobileads/BaseHtmlWebView;Ljava/lang/Object;ZLjava/lang/String;Ljava/lang/String;)V", "GetInitializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_Handler")]
		protected abstract void InitializeHtmlWebView (global::Java.Lang.Object p0, global::Java.Lang.Object p1, bool p2, string p3, string p4);

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/BaseHtmlWebViewPool", DoNotGenerateAcw=true)]
	internal partial class BaseHtmlWebViewPoolInvoker : BaseHtmlWebViewPool {

		public BaseHtmlWebViewPoolInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseHtmlWebViewPoolInvoker); }
		}

		static IntPtr id_createNewHtmlWebView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='BaseHtmlWebViewPool']/method[@name='createNewHtmlWebView' and count(parameter)=0]"
		[Register ("createNewHtmlWebView", "()Lcom/mopub/mobileads/BaseHtmlWebView;", "GetCreateNewHtmlWebViewHandler")]
		protected override global::Java.Lang.Object CreateNewHtmlWebView ()
		{
			if (id_createNewHtmlWebView == IntPtr.Zero)
				id_createNewHtmlWebView = JNIEnv.GetMethodID (class_ref, "createNewHtmlWebView", "()Lcom/mopub/mobileads/BaseHtmlWebView;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_createNewHtmlWebView), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_initializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='BaseHtmlWebViewPool']/method[@name='initializeHtmlWebView' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("initializeHtmlWebView", "(Lcom/mopub/mobileads/BaseHtmlWebView;Ljava/lang/Object;ZLjava/lang/String;Ljava/lang/String;)V", "GetInitializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_Handler")]
		protected override void InitializeHtmlWebView (global::Java.Lang.Object p0, global::Java.Lang.Object p1, bool p2, string p3, string p4)
		{
			if (id_initializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_initializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initializeHtmlWebView", "(Lcom/mopub/mobileads/BaseHtmlWebView;Ljava/lang/Object;ZLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JNIEnv.CallVoidMethod  (Handle, id_initializeHtmlWebView_Lcom_mopub_mobileads_BaseHtmlWebView_Ljava_lang_Object_ZLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

	}

}
