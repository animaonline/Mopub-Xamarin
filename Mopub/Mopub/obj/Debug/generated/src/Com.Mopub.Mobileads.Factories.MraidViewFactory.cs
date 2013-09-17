using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidViewFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/MraidViewFactory", DoNotGenerateAcw=true)]
	public partial class MraidViewFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidViewFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Mobileads.Factories.MraidViewFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/MraidViewFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.MraidViewFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/MraidViewFactory;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/MraidViewFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidViewFactory); }
		}

		protected MraidViewFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidViewFactory']/constructor[@name='MraidViewFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MraidViewFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MraidViewFactory)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_create_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidViewFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("create", "(Landroid/content/Context;)Lcom/mopub/mobileads/MraidView;", "")]
		public static global::Com.Mopub.Mobileads.MraidView Create (global::Android.Content.Context p0)
		{
			if (id_create_Landroid_content_Context_ == IntPtr.Zero)
				id_create_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Landroid/content/Context;)Lcom/mopub/mobileads/MraidView;");
			global::Com.Mopub.Mobileads.MraidView __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_create_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidViewFactory']/method[@name='create' and count(parameter)=4 and parameter[1][@type='com.mopub.mobileads.MraidActivity'] and parameter[2][@type='com.mopub.mobileads.MraidView.ExpansionStyle'] and parameter[3][@type='com.mopub.mobileads.MraidView.NativeCloseButtonStyle'] and parameter[4][@type='com.mopub.mobileads.MraidView.PlacementType']]"
		[Register ("create", "(Lcom/mopub/mobileads/MraidActivity;Lcom/mopub/mobileads/MraidView$ExpansionStyle;Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;Lcom/mopub/mobileads/MraidView$PlacementType;)Lcom/mopub/mobileads/MraidView;", "")]
		public static global::Com.Mopub.Mobileads.MraidView Create (global::Com.Mopub.Mobileads.MraidActivity p0, global::Com.Mopub.Mobileads.MraidView.ExpansionStyle p1, global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle p2, global::Com.Mopub.Mobileads.MraidView.PlacementType p3)
		{
			if (id_create_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_ == IntPtr.Zero)
				id_create_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/mopub/mobileads/MraidActivity;Lcom/mopub/mobileads/MraidView$ExpansionStyle;Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;Lcom/mopub/mobileads/MraidView$PlacementType;)Lcom/mopub/mobileads/MraidView;");
			global::Com.Mopub.Mobileads.MraidView __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_internalCreate_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Landroid_content_Context_Handler ()
		{
			if (cb_internalCreate_Landroid_content_Context_ == null)
				cb_internalCreate_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Landroid_content_Context_);
			return cb_internalCreate_Landroid_content_Context_;
		}

		static IntPtr n_InternalCreate_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.Factories.MraidViewFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.MraidViewFactory> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidViewFactory']/method[@name='internalCreate' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("internalCreate", "(Landroid/content/Context;)Lcom/mopub/mobileads/MraidView;", "GetInternalCreate_Landroid_content_Context_Handler")]
		protected virtual global::Com.Mopub.Mobileads.MraidView InternalCreate (global::Android.Content.Context p0)
		{
			if (id_internalCreate_Landroid_content_Context_ == IntPtr.Zero)
				id_internalCreate_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Landroid/content/Context;)Lcom/mopub/mobileads/MraidView;");

			global::Com.Mopub.Mobileads.MraidView __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_internalCreate_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_internalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_Handler ()
		{
			if (cb_internalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_ == null)
				cb_internalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_);
			return cb_internalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_;
		}

		static IntPtr n_InternalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mopub.Mobileads.Factories.MraidViewFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.MraidViewFactory> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MraidActivity p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MraidView.ExpansionStyle p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.ExpansionStyle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle p2 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MraidView.PlacementType p3 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.PlacementType> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidViewFactory']/method[@name='internalCreate' and count(parameter)=4 and parameter[1][@type='com.mopub.mobileads.MraidActivity'] and parameter[2][@type='com.mopub.mobileads.MraidView.ExpansionStyle'] and parameter[3][@type='com.mopub.mobileads.MraidView.NativeCloseButtonStyle'] and parameter[4][@type='com.mopub.mobileads.MraidView.PlacementType']]"
		[Register ("internalCreate", "(Lcom/mopub/mobileads/MraidActivity;Lcom/mopub/mobileads/MraidView$ExpansionStyle;Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;Lcom/mopub/mobileads/MraidView$PlacementType;)Lcom/mopub/mobileads/MraidView;", "GetInternalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_Handler")]
		protected virtual global::Com.Mopub.Mobileads.MraidView InternalCreate (global::Com.Mopub.Mobileads.MraidActivity p0, global::Com.Mopub.Mobileads.MraidView.ExpansionStyle p1, global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle p2, global::Com.Mopub.Mobileads.MraidView.PlacementType p3)
		{
			if (id_internalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_ == IntPtr.Zero)
				id_internalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Lcom/mopub/mobileads/MraidActivity;Lcom/mopub/mobileads/MraidView$ExpansionStyle;Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;Lcom/mopub/mobileads/MraidView$PlacementType;)Lcom/mopub/mobileads/MraidView;");

			global::Com.Mopub.Mobileads.MraidView __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_internalCreate_Lcom_mopub_mobileads_MraidActivity_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_MraidViewFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidViewFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.MraidViewFactory']]"
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/MraidViewFactory;)V", "")]
		public static void SetInstance (global::Com.Mopub.Mobileads.Factories.MraidViewFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_MraidViewFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_MraidViewFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/MraidViewFactory;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_MraidViewFactory_, new JValue (p0));
		}

	}
}
