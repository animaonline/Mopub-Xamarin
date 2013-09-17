using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView", DoNotGenerateAcw=true)]
	public partial class MraidView : global::Com.Mopub.Mobileads.BaseWebView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.BaseMraidListener']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView$BaseMraidListener", DoNotGenerateAcw=true)]
		public partial class BaseMraidListener : global::Java.Lang.Object, global::Com.Mopub.Mobileads.MraidView.IMraidListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MraidView$BaseMraidListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BaseMraidListener); }
			}

			protected BaseMraidListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.BaseMraidListener']/constructor[@name='MraidView.BaseMraidListener' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public BaseMraidListener () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (BaseMraidListener)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_;
#pragma warning disable 0169
			static Delegate GetOnClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_Handler ()
			{
				if (cb_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_ == null)
					cb_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_);
				return cb_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_;
			}

			static void n_OnClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Mobileads.MraidView.BaseMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.BaseMraidListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView.ViewState p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.ViewState> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnClose (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.BaseMraidListener']/method[@name='onClose' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.MraidView'] and parameter[2][@type='com.mopub.mobileads.MraidView.ViewState']]"
			[Register ("onClose", "(Lcom/mopub/mobileads/MraidView;Lcom/mopub/mobileads/MraidView$ViewState;)V", "GetOnClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_Handler")]
			public virtual void OnClose (global::Com.Mopub.Mobileads.MraidView p0, global::Com.Mopub.Mobileads.MraidView.ViewState p1)
			{
				if (id_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_ == IntPtr.Zero)
					id_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_ = JNIEnv.GetMethodID (class_ref, "onClose", "(Lcom/mopub/mobileads/MraidView;Lcom/mopub/mobileads/MraidView$ViewState;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onExpand_Lcom_mopub_mobileads_MraidView_;
#pragma warning disable 0169
			static Delegate GetOnExpand_Lcom_mopub_mobileads_MraidView_Handler ()
			{
				if (cb_onExpand_Lcom_mopub_mobileads_MraidView_ == null)
					cb_onExpand_Lcom_mopub_mobileads_MraidView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnExpand_Lcom_mopub_mobileads_MraidView_);
				return cb_onExpand_Lcom_mopub_mobileads_MraidView_;
			}

			static void n_OnExpand_Lcom_mopub_mobileads_MraidView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MraidView.BaseMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.BaseMraidListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnExpand (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onExpand_Lcom_mopub_mobileads_MraidView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.BaseMraidListener']/method[@name='onExpand' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MraidView']]"
			[Register ("onExpand", "(Lcom/mopub/mobileads/MraidView;)V", "GetOnExpand_Lcom_mopub_mobileads_MraidView_Handler")]
			public virtual void OnExpand (global::Com.Mopub.Mobileads.MraidView p0)
			{
				if (id_onExpand_Lcom_mopub_mobileads_MraidView_ == IntPtr.Zero)
					id_onExpand_Lcom_mopub_mobileads_MraidView_ = JNIEnv.GetMethodID (class_ref, "onExpand", "(Lcom/mopub/mobileads/MraidView;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onExpand_Lcom_mopub_mobileads_MraidView_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onExpand_Lcom_mopub_mobileads_MraidView_, new JValue (p0));
			}

			static Delegate cb_onFailure_Lcom_mopub_mobileads_MraidView_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lcom_mopub_mobileads_MraidView_Handler ()
			{
				if (cb_onFailure_Lcom_mopub_mobileads_MraidView_ == null)
					cb_onFailure_Lcom_mopub_mobileads_MraidView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_mopub_mobileads_MraidView_);
				return cb_onFailure_Lcom_mopub_mobileads_MraidView_;
			}

			static void n_OnFailure_Lcom_mopub_mobileads_MraidView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MraidView.BaseMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.BaseMraidListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onFailure_Lcom_mopub_mobileads_MraidView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.BaseMraidListener']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MraidView']]"
			[Register ("onFailure", "(Lcom/mopub/mobileads/MraidView;)V", "GetOnFailure_Lcom_mopub_mobileads_MraidView_Handler")]
			public virtual void OnFailure (global::Com.Mopub.Mobileads.MraidView p0)
			{
				if (id_onFailure_Lcom_mopub_mobileads_MraidView_ == IntPtr.Zero)
					id_onFailure_Lcom_mopub_mobileads_MraidView_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/mopub/mobileads/MraidView;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFailure_Lcom_mopub_mobileads_MraidView_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onFailure_Lcom_mopub_mobileads_MraidView_, new JValue (p0));
			}

			static Delegate cb_onReady_Lcom_mopub_mobileads_MraidView_;
#pragma warning disable 0169
			static Delegate GetOnReady_Lcom_mopub_mobileads_MraidView_Handler ()
			{
				if (cb_onReady_Lcom_mopub_mobileads_MraidView_ == null)
					cb_onReady_Lcom_mopub_mobileads_MraidView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReady_Lcom_mopub_mobileads_MraidView_);
				return cb_onReady_Lcom_mopub_mobileads_MraidView_;
			}

			static void n_OnReady_Lcom_mopub_mobileads_MraidView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MraidView.BaseMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.BaseMraidListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReady (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onReady_Lcom_mopub_mobileads_MraidView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.BaseMraidListener']/method[@name='onReady' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MraidView']]"
			[Register ("onReady", "(Lcom/mopub/mobileads/MraidView;)V", "GetOnReady_Lcom_mopub_mobileads_MraidView_Handler")]
			public virtual void OnReady (global::Com.Mopub.Mobileads.MraidView p0)
			{
				if (id_onReady_Lcom_mopub_mobileads_MraidView_ == IntPtr.Zero)
					id_onReady_Lcom_mopub_mobileads_MraidView_ = JNIEnv.GetMethodID (class_ref, "onReady", "(Lcom/mopub/mobileads/MraidView;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onReady_Lcom_mopub_mobileads_MraidView_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onReady_Lcom_mopub_mobileads_MraidView_, new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ExpansionStyle']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView$ExpansionStyle", DoNotGenerateAcw=true)]
		public sealed partial class ExpansionStyle : global::Java.Lang.Enum {


			static IntPtr DISABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ExpansionStyle']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Com.Mopub.Mobileads.MraidView.ExpansionStyle Disabled {
				get {
					if (DISABLED_jfieldId == IntPtr.Zero)
						DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISABLED", "Lcom/mopub/mobileads/MraidView$ExpansionStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.ExpansionStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DISABLED_jfieldId == IntPtr.Zero)
						DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISABLED", "Lcom/mopub/mobileads/MraidView$ExpansionStyle;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DISABLED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ENABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ExpansionStyle']/field[@name='ENABLED']"
			[Register ("ENABLED")]
			public static global::Com.Mopub.Mobileads.MraidView.ExpansionStyle Enabled {
				get {
					if (ENABLED_jfieldId == IntPtr.Zero)
						ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENABLED", "Lcom/mopub/mobileads/MraidView$ExpansionStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.ExpansionStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ENABLED_jfieldId == IntPtr.Zero)
						ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENABLED", "Lcom/mopub/mobileads/MraidView$ExpansionStyle;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ENABLED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MraidView$ExpansionStyle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExpansionStyle); }
			}

			internal ExpansionStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ExpansionStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MraidView$ExpansionStyle;", "")]
			public static global::Com.Mopub.Mobileads.MraidView.ExpansionStyle ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MraidView$ExpansionStyle;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Mopub.Mobileads.MraidView.ExpansionStyle __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.ExpansionStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ExpansionStyle']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/mobileads/MraidView$ExpansionStyle;", "")]
			public static global::Com.Mopub.Mobileads.MraidView.ExpansionStyle[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mobileads/MraidView$ExpansionStyle;");
				return (global::Com.Mopub.Mobileads.MraidView.ExpansionStyle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mobileads.MraidView.ExpansionStyle));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MraidView.MraidListener']"
		[Register ("com/mopub/mobileads/MraidView$MraidListener", "", "Com.Mopub.Mobileads.MraidView/IMraidListenerInvoker")]
		public partial interface IMraidListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MraidView.MraidListener']/method[@name='onClose' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.MraidView'] and parameter[2][@type='com.mopub.mobileads.MraidView.ViewState']]"
			[Register ("onClose", "(Lcom/mopub/mobileads/MraidView;Lcom/mopub/mobileads/MraidView$ViewState;)V", "GetOnClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_Handler:Com.Mopub.Mobileads.MraidView/IMraidListenerInvoker, Mopub")]
			void OnClose (global::Com.Mopub.Mobileads.MraidView p0, global::Com.Mopub.Mobileads.MraidView.ViewState p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MraidView.MraidListener']/method[@name='onExpand' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MraidView']]"
			[Register ("onExpand", "(Lcom/mopub/mobileads/MraidView;)V", "GetOnExpand_Lcom_mopub_mobileads_MraidView_Handler:Com.Mopub.Mobileads.MraidView/IMraidListenerInvoker, Mopub")]
			void OnExpand (global::Com.Mopub.Mobileads.MraidView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MraidView.MraidListener']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MraidView']]"
			[Register ("onFailure", "(Lcom/mopub/mobileads/MraidView;)V", "GetOnFailure_Lcom_mopub_mobileads_MraidView_Handler:Com.Mopub.Mobileads.MraidView/IMraidListenerInvoker, Mopub")]
			void OnFailure (global::Com.Mopub.Mobileads.MraidView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MraidView.MraidListener']/method[@name='onReady' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MraidView']]"
			[Register ("onReady", "(Lcom/mopub/mobileads/MraidView;)V", "GetOnReady_Lcom_mopub_mobileads_MraidView_Handler:Com.Mopub.Mobileads.MraidView/IMraidListenerInvoker, Mopub")]
			void OnReady (global::Com.Mopub.Mobileads.MraidView p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView$MraidListener", DoNotGenerateAcw=true)]
		internal class IMraidListenerInvoker : global::Java.Lang.Object, IMraidListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MraidView$MraidListener");
			IntPtr class_ref;

			public static IMraidListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMraidListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MraidView.MraidListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMraidListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IMraidListenerInvoker); }
			}

			static Delegate cb_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_;
#pragma warning disable 0169
			static Delegate GetOnClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_Handler ()
			{
				if (cb_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_ == null)
					cb_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_);
				return cb_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_;
			}

			static void n_OnClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Mobileads.MraidView.IMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IMraidListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView.ViewState p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.ViewState> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnClose (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_;
			public void OnClose (global::Com.Mopub.Mobileads.MraidView p0, global::Com.Mopub.Mobileads.MraidView.ViewState p1)
			{
				if (id_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_ == IntPtr.Zero)
					id_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_ = JNIEnv.GetMethodID (class_ref, "onClose", "(Lcom/mopub/mobileads/MraidView;Lcom/mopub/mobileads/MraidView$ViewState;)V");
				JNIEnv.CallVoidMethod (Handle, id_onClose_Lcom_mopub_mobileads_MraidView_Lcom_mopub_mobileads_MraidView_ViewState_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onExpand_Lcom_mopub_mobileads_MraidView_;
#pragma warning disable 0169
			static Delegate GetOnExpand_Lcom_mopub_mobileads_MraidView_Handler ()
			{
				if (cb_onExpand_Lcom_mopub_mobileads_MraidView_ == null)
					cb_onExpand_Lcom_mopub_mobileads_MraidView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnExpand_Lcom_mopub_mobileads_MraidView_);
				return cb_onExpand_Lcom_mopub_mobileads_MraidView_;
			}

			static void n_OnExpand_Lcom_mopub_mobileads_MraidView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MraidView.IMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IMraidListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnExpand (p0);
			}
#pragma warning restore 0169

			IntPtr id_onExpand_Lcom_mopub_mobileads_MraidView_;
			public void OnExpand (global::Com.Mopub.Mobileads.MraidView p0)
			{
				if (id_onExpand_Lcom_mopub_mobileads_MraidView_ == IntPtr.Zero)
					id_onExpand_Lcom_mopub_mobileads_MraidView_ = JNIEnv.GetMethodID (class_ref, "onExpand", "(Lcom/mopub/mobileads/MraidView;)V");
				JNIEnv.CallVoidMethod (Handle, id_onExpand_Lcom_mopub_mobileads_MraidView_, new JValue (p0));
			}

			static Delegate cb_onFailure_Lcom_mopub_mobileads_MraidView_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lcom_mopub_mobileads_MraidView_Handler ()
			{
				if (cb_onFailure_Lcom_mopub_mobileads_MraidView_ == null)
					cb_onFailure_Lcom_mopub_mobileads_MraidView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_mopub_mobileads_MraidView_);
				return cb_onFailure_Lcom_mopub_mobileads_MraidView_;
			}

			static void n_OnFailure_Lcom_mopub_mobileads_MraidView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MraidView.IMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IMraidListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Lcom_mopub_mobileads_MraidView_;
			public void OnFailure (global::Com.Mopub.Mobileads.MraidView p0)
			{
				if (id_onFailure_Lcom_mopub_mobileads_MraidView_ == IntPtr.Zero)
					id_onFailure_Lcom_mopub_mobileads_MraidView_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/mopub/mobileads/MraidView;)V");
				JNIEnv.CallVoidMethod (Handle, id_onFailure_Lcom_mopub_mobileads_MraidView_, new JValue (p0));
			}

			static Delegate cb_onReady_Lcom_mopub_mobileads_MraidView_;
#pragma warning disable 0169
			static Delegate GetOnReady_Lcom_mopub_mobileads_MraidView_Handler ()
			{
				if (cb_onReady_Lcom_mopub_mobileads_MraidView_ == null)
					cb_onReady_Lcom_mopub_mobileads_MraidView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReady_Lcom_mopub_mobileads_MraidView_);
				return cb_onReady_Lcom_mopub_mobileads_MraidView_;
			}

			static void n_OnReady_Lcom_mopub_mobileads_MraidView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MraidView.IMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IMraidListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_onReady_Lcom_mopub_mobileads_MraidView_;
			public void OnReady (global::Com.Mopub.Mobileads.MraidView p0)
			{
				if (id_onReady_Lcom_mopub_mobileads_MraidView_ == IntPtr.Zero)
					id_onReady_Lcom_mopub_mobileads_MraidView_ = JNIEnv.GetMethodID (class_ref, "onReady", "(Lcom/mopub/mobileads/MraidView;)V");
				JNIEnv.CallVoidMethod (Handle, id_onReady_Lcom_mopub_mobileads_MraidView_, new JValue (p0));
			}

		}

		public partial class CloseEventArgs : global::System.EventArgs {

			public CloseEventArgs (global::Com.Mopub.Mobileads.MraidView p0, global::Com.Mopub.Mobileads.MraidView.ViewState p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Mopub.Mobileads.MraidView p0;
			public global::Com.Mopub.Mobileads.MraidView P0 {
				get { return p0; }
			}

			global::Com.Mopub.Mobileads.MraidView.ViewState p1;
			public global::Com.Mopub.Mobileads.MraidView.ViewState P1 {
				get { return p1; }
			}
		}

		public partial class ExpandEventArgs : global::System.EventArgs {

			public ExpandEventArgs (global::Com.Mopub.Mobileads.MraidView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MraidView p0;
			public global::Com.Mopub.Mobileads.MraidView P0 {
				get { return p0; }
			}
		}

		public partial class FailureEventArgs : global::System.EventArgs {

			public FailureEventArgs (global::Com.Mopub.Mobileads.MraidView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MraidView p0;
			public global::Com.Mopub.Mobileads.MraidView P0 {
				get { return p0; }
			}
		}

		public partial class ReadyEventArgs : global::System.EventArgs {

			public ReadyEventArgs (global::Com.Mopub.Mobileads.MraidView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MraidView p0;
			public global::Com.Mopub.Mobileads.MraidView P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MraidView_MraidListenerImplementor")]
		internal sealed class IMraidListenerImplementor : global::Java.Lang.Object, IMraidListener {

			object sender;

			public IMraidListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MraidView_MraidListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CloseEventArgs> OnCloseHandler;
#pragma warning restore 0649

			public void OnClose (global::Com.Mopub.Mobileads.MraidView p0, global::Com.Mopub.Mobileads.MraidView.ViewState p1)
			{
				var __h = OnCloseHandler;
				if (__h != null)
					__h (sender, new CloseEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<ExpandEventArgs> OnExpandHandler;
#pragma warning restore 0649

			public void OnExpand (global::Com.Mopub.Mobileads.MraidView p0)
			{
				var __h = OnExpandHandler;
				if (__h != null)
					__h (sender, new ExpandEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<FailureEventArgs> OnFailureHandler;
#pragma warning restore 0649

			public void OnFailure (global::Com.Mopub.Mobileads.MraidView p0)
			{
				var __h = OnFailureHandler;
				if (__h != null)
					__h (sender, new FailureEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ReadyEventArgs> OnReadyHandler;
#pragma warning restore 0649

			public void OnReady (global::Com.Mopub.Mobileads.MraidView p0)
			{
				var __h = OnReadyHandler;
				if (__h != null)
					__h (sender, new ReadyEventArgs (p0));
			}

			internal static bool __IsEmpty (IMraidListenerImplementor value)
			{
				return value.OnCloseHandler == null && value.OnExpandHandler == null && value.OnFailureHandler == null && value.OnReadyHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.MraidListenerInfo']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView$MraidListenerInfo", DoNotGenerateAcw=true)]
		public partial class MraidListenerInfo : global::Java.Lang.Object {

			protected MraidListenerInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.MraidWebChromeClient']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView$MraidWebChromeClient", DoNotGenerateAcw=true)]
		public partial class MraidWebChromeClient : global::Android.Webkit.WebChromeClient {

			protected MraidWebChromeClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.MraidWebViewClient']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView$MraidWebViewClient", DoNotGenerateAcw=true)]
		public partial class MraidWebViewClient : global::Android.Webkit.WebViewClient {

			protected MraidWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.NativeCloseButtonStyle']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView$NativeCloseButtonStyle", DoNotGenerateAcw=true)]
		public sealed partial class NativeCloseButtonStyle : global::Java.Lang.Enum {


			static IntPtr AD_CONTROLLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.NativeCloseButtonStyle']/field[@name='AD_CONTROLLED']"
			[Register ("AD_CONTROLLED")]
			public static global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle AdControlled {
				get {
					if (AD_CONTROLLED_jfieldId == IntPtr.Zero)
						AD_CONTROLLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_CONTROLLED", "Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_CONTROLLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (AD_CONTROLLED_jfieldId == IntPtr.Zero)
						AD_CONTROLLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_CONTROLLED", "Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, AD_CONTROLLED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ALWAYS_HIDDEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.NativeCloseButtonStyle']/field[@name='ALWAYS_HIDDEN']"
			[Register ("ALWAYS_HIDDEN")]
			public static global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle AlwaysHidden {
				get {
					if (ALWAYS_HIDDEN_jfieldId == IntPtr.Zero)
						ALWAYS_HIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALWAYS_HIDDEN", "Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALWAYS_HIDDEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ALWAYS_HIDDEN_jfieldId == IntPtr.Zero)
						ALWAYS_HIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALWAYS_HIDDEN", "Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ALWAYS_HIDDEN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ALWAYS_VISIBLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.NativeCloseButtonStyle']/field[@name='ALWAYS_VISIBLE']"
			[Register ("ALWAYS_VISIBLE")]
			public static global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle AlwaysVisible {
				get {
					if (ALWAYS_VISIBLE_jfieldId == IntPtr.Zero)
						ALWAYS_VISIBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALWAYS_VISIBLE", "Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALWAYS_VISIBLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ALWAYS_VISIBLE_jfieldId == IntPtr.Zero)
						ALWAYS_VISIBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALWAYS_VISIBLE", "Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ALWAYS_VISIBLE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MraidView$NativeCloseButtonStyle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NativeCloseButtonStyle); }
			}

			internal NativeCloseButtonStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.NativeCloseButtonStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;", "")]
			public static global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.NativeCloseButtonStyle']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;", "")]
			public static global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;");
				return (global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MraidView.OnCloseButtonStateChangeListener']"
		[Register ("com/mopub/mobileads/MraidView$OnCloseButtonStateChangeListener", "", "Com.Mopub.Mobileads.MraidView/IOnCloseButtonStateChangeListenerInvoker")]
		public partial interface IOnCloseButtonStateChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MraidView.OnCloseButtonStateChangeListener']/method[@name='onCloseButtonStateChange' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.MraidView'] and parameter[2][@type='boolean']]"
			[Register ("onCloseButtonStateChange", "(Lcom/mopub/mobileads/MraidView;Z)V", "GetOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_ZHandler:Com.Mopub.Mobileads.MraidView/IOnCloseButtonStateChangeListenerInvoker, Mopub")]
			void OnCloseButtonStateChange (global::Com.Mopub.Mobileads.MraidView p0, bool p1);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView$OnCloseButtonStateChangeListener", DoNotGenerateAcw=true)]
		internal class IOnCloseButtonStateChangeListenerInvoker : global::Java.Lang.Object, IOnCloseButtonStateChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MraidView$OnCloseButtonStateChangeListener");
			IntPtr class_ref;

			public static IOnCloseButtonStateChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCloseButtonStateChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MraidView.OnCloseButtonStateChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCloseButtonStateChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnCloseButtonStateChangeListenerInvoker); }
			}

			static Delegate cb_onCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_Z;
#pragma warning disable 0169
			static Delegate GetOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_ZHandler ()
			{
				if (cb_onCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_Z == null)
					cb_onCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_Z);
				return cb_onCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_Z;
			}

			static void n_OnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCloseButtonStateChange (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_Z;
			public void OnCloseButtonStateChange (global::Com.Mopub.Mobileads.MraidView p0, bool p1)
			{
				if (id_onCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_Z == IntPtr.Zero)
					id_onCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_Z = JNIEnv.GetMethodID (class_ref, "onCloseButtonStateChange", "(Lcom/mopub/mobileads/MraidView;Z)V");
				JNIEnv.CallVoidMethod (Handle, id_onCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_Z, new JValue (p0), new JValue (p1));
			}

		}

		public partial class CloseButtonStateChangeEventArgs : global::System.EventArgs {

			public CloseButtonStateChangeEventArgs (global::Com.Mopub.Mobileads.MraidView p0, bool p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Mopub.Mobileads.MraidView p0;
			public global::Com.Mopub.Mobileads.MraidView P0 {
				get { return p0; }
			}

			bool p1;
			public bool P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MraidView_OnCloseButtonStateChangeListenerImplementor")]
		internal sealed class IOnCloseButtonStateChangeListenerImplementor : global::Java.Lang.Object, IOnCloseButtonStateChangeListener {

			object sender;

			public IOnCloseButtonStateChangeListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MraidView_OnCloseButtonStateChangeListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CloseButtonStateChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnCloseButtonStateChange (global::Com.Mopub.Mobileads.MraidView p0, bool p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CloseButtonStateChangeEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnCloseButtonStateChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MraidView.OnOpenListener']"
		[Register ("com/mopub/mobileads/MraidView$OnOpenListener", "", "Com.Mopub.Mobileads.MraidView/IOnOpenListenerInvoker")]
		public partial interface IOnOpenListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MraidView.OnOpenListener']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MraidView']]"
			[Register ("onOpen", "(Lcom/mopub/mobileads/MraidView;)V", "GetOnOpen_Lcom_mopub_mobileads_MraidView_Handler:Com.Mopub.Mobileads.MraidView/IOnOpenListenerInvoker, Mopub")]
			void OnOpen (global::Com.Mopub.Mobileads.MraidView p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView$OnOpenListener", DoNotGenerateAcw=true)]
		internal class IOnOpenListenerInvoker : global::Java.Lang.Object, IOnOpenListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MraidView$OnOpenListener");
			IntPtr class_ref;

			public static IOnOpenListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnOpenListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MraidView.OnOpenListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnOpenListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnOpenListenerInvoker); }
			}

			static Delegate cb_onOpen_Lcom_mopub_mobileads_MraidView_;
#pragma warning disable 0169
			static Delegate GetOnOpen_Lcom_mopub_mobileads_MraidView_Handler ()
			{
				if (cb_onOpen_Lcom_mopub_mobileads_MraidView_ == null)
					cb_onOpen_Lcom_mopub_mobileads_MraidView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOpen_Lcom_mopub_mobileads_MraidView_);
				return cb_onOpen_Lcom_mopub_mobileads_MraidView_;
			}

			static void n_OnOpen_Lcom_mopub_mobileads_MraidView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MraidView.IOnOpenListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IOnOpenListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MraidView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnOpen (p0);
			}
#pragma warning restore 0169

			IntPtr id_onOpen_Lcom_mopub_mobileads_MraidView_;
			public void OnOpen (global::Com.Mopub.Mobileads.MraidView p0)
			{
				if (id_onOpen_Lcom_mopub_mobileads_MraidView_ == IntPtr.Zero)
					id_onOpen_Lcom_mopub_mobileads_MraidView_ = JNIEnv.GetMethodID (class_ref, "onOpen", "(Lcom/mopub/mobileads/MraidView;)V");
				JNIEnv.CallVoidMethod (Handle, id_onOpen_Lcom_mopub_mobileads_MraidView_, new JValue (p0));
			}

		}

		public partial class OpenEventArgs : global::System.EventArgs {

			public OpenEventArgs (global::Com.Mopub.Mobileads.MraidView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MraidView p0;
			public global::Com.Mopub.Mobileads.MraidView P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MraidView_OnOpenListenerImplementor")]
		internal sealed class IOnOpenListenerImplementor : global::Java.Lang.Object, IOnOpenListener {

			object sender;

			public IOnOpenListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MraidView_OnOpenListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<OpenEventArgs> Handler;
#pragma warning restore 0649

			public void OnOpen (global::Com.Mopub.Mobileads.MraidView p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new OpenEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnOpenListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.PlacementType']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView$PlacementType", DoNotGenerateAcw=true)]
		public sealed partial class PlacementType : global::Java.Lang.Enum {


			static IntPtr INLINE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.PlacementType']/field[@name='INLINE']"
			[Register ("INLINE")]
			public static global::Com.Mopub.Mobileads.MraidView.PlacementType Inline {
				get {
					if (INLINE_jfieldId == IntPtr.Zero)
						INLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INLINE", "Lcom/mopub/mobileads/MraidView$PlacementType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INLINE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.PlacementType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INLINE_jfieldId == IntPtr.Zero)
						INLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INLINE", "Lcom/mopub/mobileads/MraidView$PlacementType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INLINE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.PlacementType']/field[@name='INTERSTITIAL']"
			[Register ("INTERSTITIAL")]
			public static global::Com.Mopub.Mobileads.MraidView.PlacementType Interstitial {
				get {
					if (INTERSTITIAL_jfieldId == IntPtr.Zero)
						INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERSTITIAL", "Lcom/mopub/mobileads/MraidView$PlacementType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.PlacementType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INTERSTITIAL_jfieldId == IntPtr.Zero)
						INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERSTITIAL", "Lcom/mopub/mobileads/MraidView$PlacementType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INTERSTITIAL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MraidView$PlacementType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PlacementType); }
			}

			internal PlacementType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.PlacementType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MraidView$PlacementType;", "")]
			public static global::Com.Mopub.Mobileads.MraidView.PlacementType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MraidView$PlacementType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Mopub.Mobileads.MraidView.PlacementType __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.PlacementType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.PlacementType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/mobileads/MraidView$PlacementType;", "")]
			public static global::Com.Mopub.Mobileads.MraidView.PlacementType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mobileads/MraidView$PlacementType;");
				return (global::Com.Mopub.Mobileads.MraidView.PlacementType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mobileads.MraidView.PlacementType));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ViewState']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MraidView$ViewState", DoNotGenerateAcw=true)]
		public sealed partial class ViewState : global::Java.Lang.Enum {


			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ViewState']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Mopub.Mobileads.MraidView.ViewState Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/mopub/mobileads/MraidView$ViewState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.ViewState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/mopub/mobileads/MraidView$ViewState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEFAULT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EXPANDED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ViewState']/field[@name='EXPANDED']"
			[Register ("EXPANDED")]
			public static global::Com.Mopub.Mobileads.MraidView.ViewState Expanded {
				get {
					if (EXPANDED_jfieldId == IntPtr.Zero)
						EXPANDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPANDED", "Lcom/mopub/mobileads/MraidView$ViewState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPANDED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.ViewState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EXPANDED_jfieldId == IntPtr.Zero)
						EXPANDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPANDED", "Lcom/mopub/mobileads/MraidView$ViewState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EXPANDED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr HIDDEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ViewState']/field[@name='HIDDEN']"
			[Register ("HIDDEN")]
			public static global::Com.Mopub.Mobileads.MraidView.ViewState Hidden {
				get {
					if (HIDDEN_jfieldId == IntPtr.Zero)
						HIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIDDEN", "Lcom/mopub/mobileads/MraidView$ViewState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIDDEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.ViewState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (HIDDEN_jfieldId == IntPtr.Zero)
						HIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIDDEN", "Lcom/mopub/mobileads/MraidView$ViewState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, HIDDEN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LOADING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ViewState']/field[@name='LOADING']"
			[Register ("LOADING")]
			public static global::Com.Mopub.Mobileads.MraidView.ViewState Loading {
				get {
					if (LOADING_jfieldId == IntPtr.Zero)
						LOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADING", "Lcom/mopub/mobileads/MraidView$ViewState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.ViewState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LOADING_jfieldId == IntPtr.Zero)
						LOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADING", "Lcom/mopub/mobileads/MraidView$ViewState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LOADING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MraidView$ViewState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ViewState); }
			}

			internal ViewState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ViewState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MraidView$ViewState;", "")]
			public static global::Com.Mopub.Mobileads.MraidView.ViewState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MraidView$ViewState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Mopub.Mobileads.MraidView.ViewState __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.ViewState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView.ViewState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/mobileads/MraidView$ViewState;", "")]
			public static global::Com.Mopub.Mobileads.MraidView.ViewState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mobileads/MraidView$ViewState;");
				return (global::Com.Mopub.Mobileads.MraidView.ViewState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mobileads.MraidView.ViewState));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MraidView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidView); }
		}

		protected MraidView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/constructor[@name='MraidView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public MraidView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MraidView)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/constructor[@name='MraidView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.MraidView.ExpansionStyle'] and parameter[3][@type='com.mopub.mobileads.MraidView.NativeCloseButtonStyle'] and parameter[4][@type='com.mopub.mobileads.MraidView.PlacementType']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mopub/mobileads/MraidView$ExpansionStyle;Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;Lcom/mopub/mobileads/MraidView$PlacementType;)V", "")]
		public MraidView (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.MraidView.ExpansionStyle p1, global::Com.Mopub.Mobileads.MraidView.NativeCloseButtonStyle p2, global::Com.Mopub.Mobileads.MraidView.PlacementType p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MraidView)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Lcom/mopub/mobileads/MraidView$ExpansionStyle;Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;Lcom/mopub/mobileads/MraidView$PlacementType;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mopub/mobileads/MraidView$ExpansionStyle;Lcom/mopub/mobileads/MraidView$NativeCloseButtonStyle;Lcom/mopub/mobileads/MraidView$PlacementType;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_mobileads_MraidView_ExpansionStyle_Lcom_mopub_mobileads_MraidView_NativeCloseButtonStyle_Lcom_mopub_mobileads_MraidView_PlacementType_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getMraidListener;
#pragma warning disable 0169
		static Delegate GetGetMraidListenerHandler ()
		{
			if (cb_getMraidListener == null)
				cb_getMraidListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMraidListener);
			return cb_getMraidListener;
		}

		static IntPtr n_GetMraidListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MraidListener);
		}
#pragma warning restore 0169

		static Delegate cb_setMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_;
#pragma warning disable 0169
		static Delegate GetSetMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_Handler ()
		{
			if (cb_setMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_ == null)
				cb_setMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_);
			return cb_setMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_;
		}

		static void n_SetMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MraidView.IMraidListener p0 = (global::Com.Mopub.Mobileads.MraidView.IMraidListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IMraidListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMraidListener;
		static IntPtr id_setMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_;
		public virtual global::Com.Mopub.Mobileads.MraidView.IMraidListener MraidListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='getMraidListener' and count(parameter)=0]"
			[Register ("getMraidListener", "()Lcom/mopub/mobileads/MraidView$MraidListener;", "GetGetMraidListenerHandler")]
			get {
				if (id_getMraidListener == IntPtr.Zero)
					id_getMraidListener = JNIEnv.GetMethodID (class_ref, "getMraidListener", "()Lcom/mopub/mobileads/MraidView$MraidListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IMraidListener> (JNIEnv.CallObjectMethod  (Handle, id_getMraidListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IMraidListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMraidListener), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='setMraidListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MraidView.MraidListener']]"
			[Register ("setMraidListener", "(Lcom/mopub/mobileads/MraidView$MraidListener;)V", "GetSetMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_Handler")]
			set {
				if (id_setMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_ == IntPtr.Zero)
					id_setMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_ = JNIEnv.GetMethodID (class_ref, "setMraidListener", "(Lcom/mopub/mobileads/MraidView$MraidListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setMraidListener_Lcom_mopub_mobileads_MraidView_MraidListener_, new JValue (value));
			}
		}

		static Delegate cb_getOnCloseButtonStateChangeListener;
#pragma warning disable 0169
		static Delegate GetGetOnCloseButtonStateChangeListenerHandler ()
		{
			if (cb_getOnCloseButtonStateChangeListener == null)
				cb_getOnCloseButtonStateChangeListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnCloseButtonStateChangeListener);
			return cb_getOnCloseButtonStateChangeListener;
		}

		static IntPtr n_GetOnCloseButtonStateChangeListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnCloseButtonStateChangeListener);
		}
#pragma warning restore 0169

		static IntPtr id_getOnCloseButtonStateChangeListener;
		public virtual global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener OnCloseButtonStateChangeListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='getOnCloseButtonStateChangeListener' and count(parameter)=0]"
			[Register ("getOnCloseButtonStateChangeListener", "()Lcom/mopub/mobileads/MraidView$OnCloseButtonStateChangeListener;", "GetGetOnCloseButtonStateChangeListenerHandler")]
			get {
				if (id_getOnCloseButtonStateChangeListener == IntPtr.Zero)
					id_getOnCloseButtonStateChangeListener = JNIEnv.GetMethodID (class_ref, "getOnCloseButtonStateChangeListener", "()Lcom/mopub/mobileads/MraidView$OnCloseButtonStateChangeListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnCloseButtonStateChangeListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getOnCloseButtonStateChangeListener), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOnOpenListener;
#pragma warning disable 0169
		static Delegate GetGetOnOpenListenerHandler ()
		{
			if (cb_getOnOpenListener == null)
				cb_getOnOpenListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnOpenListener);
			return cb_getOnOpenListener;
		}

		static IntPtr n_GetOnOpenListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnOpenListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_;
#pragma warning disable 0169
		static Delegate GetSetOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_Handler ()
		{
			if (cb_setOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_ == null)
				cb_setOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_);
			return cb_setOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_;
		}

		static void n_SetOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MraidView.IOnOpenListener p0 = (global::Com.Mopub.Mobileads.MraidView.IOnOpenListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IOnOpenListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOpenListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnOpenListener;
		static IntPtr id_setOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_;
		public virtual global::Com.Mopub.Mobileads.MraidView.IOnOpenListener OnOpenListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='getOnOpenListener' and count(parameter)=0]"
			[Register ("getOnOpenListener", "()Lcom/mopub/mobileads/MraidView$OnOpenListener;", "GetGetOnOpenListenerHandler")]
			get {
				if (id_getOnOpenListener == IntPtr.Zero)
					id_getOnOpenListener = JNIEnv.GetMethodID (class_ref, "getOnOpenListener", "()Lcom/mopub/mobileads/MraidView$OnOpenListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IOnOpenListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnOpenListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IOnOpenListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getOnOpenListener), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='setOnOpenListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MraidView.OnOpenListener']]"
			[Register ("setOnOpenListener", "(Lcom/mopub/mobileads/MraidView$OnOpenListener;)V", "GetSetOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_Handler")]
			set {
				if (id_setOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_ == IntPtr.Zero)
					id_setOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_ = JNIEnv.GetMethodID (class_ref, "setOnOpenListener", "(Lcom/mopub/mobileads/MraidView$OnOpenListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOnOpenListener_Lcom_mopub_mobileads_MraidView_OnOpenListener_, new JValue (value));
			}
		}

		static Delegate cb_fireChangeEventForProperties_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetFireChangeEventForProperties_Ljava_util_ArrayList_Handler ()
		{
			if (cb_fireChangeEventForProperties_Ljava_util_ArrayList_ == null)
				cb_fireChangeEventForProperties_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FireChangeEventForProperties_Ljava_util_ArrayList_);
			return cb_fireChangeEventForProperties_Ljava_util_ArrayList_;
		}

		static void n_FireChangeEventForProperties_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Com.Mopub.Mobileads.MraidProperty> p0 = global::Android.Runtime.JavaList<global::Com.Mopub.Mobileads.MraidProperty>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FireChangeEventForProperties (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fireChangeEventForProperties_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='fireChangeEventForProperties' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
		[Register ("fireChangeEventForProperties", "(Ljava/util/ArrayList;)V", "GetFireChangeEventForProperties_Ljava_util_ArrayList_Handler")]
		protected virtual void FireChangeEventForProperties (global::System.Collections.Generic.IList<global::Com.Mopub.Mobileads.MraidProperty> p0)
		{
			if (id_fireChangeEventForProperties_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_fireChangeEventForProperties_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "fireChangeEventForProperties", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mopub.Mobileads.MraidProperty>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_fireChangeEventForProperties_Ljava_util_ArrayList_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_fireChangeEventForProperties_Ljava_util_ArrayList_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_fireErrorEvent_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFireErrorEvent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_fireErrorEvent_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_fireErrorEvent_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_FireErrorEvent_Ljava_lang_String_Ljava_lang_String_);
			return cb_fireErrorEvent_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_FireErrorEvent_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.FireErrorEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_fireErrorEvent_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='fireErrorEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("fireErrorEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "GetFireErrorEvent_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual void FireErrorEvent (string p0, string p1)
		{
			if (id_fireErrorEvent_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_fireErrorEvent_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fireErrorEvent", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_fireErrorEvent_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_fireErrorEvent_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_fireNativeCommandCompleteEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFireNativeCommandCompleteEvent_Ljava_lang_String_Handler ()
		{
			if (cb_fireNativeCommandCompleteEvent_Ljava_lang_String_ == null)
				cb_fireNativeCommandCompleteEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FireNativeCommandCompleteEvent_Ljava_lang_String_);
			return cb_fireNativeCommandCompleteEvent_Ljava_lang_String_;
		}

		static void n_FireNativeCommandCompleteEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FireNativeCommandCompleteEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fireNativeCommandCompleteEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='fireNativeCommandCompleteEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fireNativeCommandCompleteEvent", "(Ljava/lang/String;)V", "GetFireNativeCommandCompleteEvent_Ljava_lang_String_Handler")]
		protected virtual void FireNativeCommandCompleteEvent (string p0)
		{
			if (id_fireNativeCommandCompleteEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_fireNativeCommandCompleteEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fireNativeCommandCompleteEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_fireNativeCommandCompleteEvent_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_fireNativeCommandCompleteEvent_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_fireReadyEvent;
#pragma warning disable 0169
		static Delegate GetFireReadyEventHandler ()
		{
			if (cb_fireReadyEvent == null)
				cb_fireReadyEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FireReadyEvent);
			return cb_fireReadyEvent;
		}

		static void n_FireReadyEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.FireReadyEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_fireReadyEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='fireReadyEvent' and count(parameter)=0]"
		[Register ("fireReadyEvent", "()V", "GetFireReadyEventHandler")]
		protected virtual void FireReadyEvent ()
		{
			if (id_fireReadyEvent == IntPtr.Zero)
				id_fireReadyEvent = JNIEnv.GetMethodID (class_ref, "fireReadyEvent", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_fireReadyEvent);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_fireReadyEvent);
		}

		static Delegate cb_injectJavaScript_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInjectJavaScript_Ljava_lang_String_Handler ()
		{
			if (cb_injectJavaScript_Ljava_lang_String_ == null)
				cb_injectJavaScript_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InjectJavaScript_Ljava_lang_String_);
			return cb_injectJavaScript_Ljava_lang_String_;
		}

		static void n_InjectJavaScript_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InjectJavaScript (p0);
		}
#pragma warning restore 0169

		static IntPtr id_injectJavaScript_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='injectJavaScript' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("injectJavaScript", "(Ljava/lang/String;)V", "GetInjectJavaScript_Ljava_lang_String_Handler")]
		protected virtual void InjectJavaScript (string p0)
		{
			if (id_injectJavaScript_Ljava_lang_String_ == IntPtr.Zero)
				id_injectJavaScript_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "injectJavaScript", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_injectJavaScript_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_injectJavaScript_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_loadHtmlData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadHtmlData_Ljava_lang_String_Handler ()
		{
			if (cb_loadHtmlData_Ljava_lang_String_ == null)
				cb_loadHtmlData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadHtmlData_Ljava_lang_String_);
			return cb_loadHtmlData_Ljava_lang_String_;
		}

		static void n_LoadHtmlData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadHtmlData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadHtmlData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='loadHtmlData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadHtmlData", "(Ljava/lang/String;)V", "GetLoadHtmlData_Ljava_lang_String_Handler")]
		public virtual void LoadHtmlData (string p0)
		{
			if (id_loadHtmlData_Ljava_lang_String_ == IntPtr.Zero)
				id_loadHtmlData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadHtmlData", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadHtmlData_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadHtmlData_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_Handler ()
		{
			if (cb_setOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_ == null)
				cb_setOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_);
			return cb_setOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_;
		}

		static void n_SetOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MraidView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener p0 = (global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCloseButtonStateChange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidView']/method[@name='setOnCloseButtonStateChange' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MraidView.OnCloseButtonStateChangeListener']]"
		[Register ("setOnCloseButtonStateChange", "(Lcom/mopub/mobileads/MraidView$OnCloseButtonStateChangeListener;)V", "GetSetOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_Handler")]
		public virtual void SetOnCloseButtonStateChange (global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener p0)
		{
			if (id_setOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_ == IntPtr.Zero)
				id_setOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnCloseButtonStateChange", "(Lcom/mopub/mobileads/MraidView$OnCloseButtonStateChangeListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOnCloseButtonStateChange_Lcom_mopub_mobileads_MraidView_OnCloseButtonStateChangeListener_, new JValue (p0));
		}

#region "Event implementation for Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener"
		public event EventHandler<global::Com.Mopub.Mobileads.MraidView.CloseButtonStateChangeEventArgs> CloseButtonSta {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener, global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListenerImplementor>(
						ref weak_implementor_SetOnCloseButtonStateChange,
						__CreateIOnCloseButtonStateChangeListenerImplementor,
						SetOnCloseButtonStateChange,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListener, global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListenerImplementor>(
						ref weak_implementor_SetOnCloseButtonStateChange,
						global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListenerImplementor.__IsEmpty,
						__v => SetOnCloseButtonStateChange (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCloseButtonStateChange;

		global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListenerImplementor __CreateIOnCloseButtonStateChangeListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MraidView.IOnCloseButtonStateChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mopub.Mobileads.MraidView.IMraidListener"
		public event EventHandler<global::Com.Mopub.Mobileads.MraidView.CloseEventArgs> Close {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MraidView.IMraidListener, global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor>(
						ref weak_implementor___SetMraidListener,
						__CreateIMraidListenerImplementor,
						__v => MraidListener = __v,
						__h => __h.OnCloseHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MraidView.IMraidListener, global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor>(
						ref weak_implementor___SetMraidListener,
						global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor.__IsEmpty,
						__v => MraidListener = null,
						__h => __h.OnCloseHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.MraidView.ExpandEventArgs> Expand {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MraidView.IMraidListener, global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor>(
						ref weak_implementor___SetMraidListener,
						__CreateIMraidListenerImplementor,
						__v => MraidListener = __v,
						__h => __h.OnExpandHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MraidView.IMraidListener, global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor>(
						ref weak_implementor___SetMraidListener,
						global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor.__IsEmpty,
						__v => MraidListener = null,
						__h => __h.OnExpandHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.MraidView.FailureEventArgs> Failure {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MraidView.IMraidListener, global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor>(
						ref weak_implementor___SetMraidListener,
						__CreateIMraidListenerImplementor,
						__v => MraidListener = __v,
						__h => __h.OnFailureHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MraidView.IMraidListener, global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor>(
						ref weak_implementor___SetMraidListener,
						global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor.__IsEmpty,
						__v => MraidListener = null,
						__h => __h.OnFailureHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.MraidView.ReadyEventArgs> Ready {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MraidView.IMraidListener, global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor>(
						ref weak_implementor___SetMraidListener,
						__CreateIMraidListenerImplementor,
						__v => MraidListener = __v,
						__h => __h.OnReadyHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MraidView.IMraidListener, global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor>(
						ref weak_implementor___SetMraidListener,
						global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor.__IsEmpty,
						__v => MraidListener = null,
						__h => __h.OnReadyHandler -= value);
			}
		}

		WeakReference weak_implementor___SetMraidListener;

		global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor __CreateIMraidListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MraidView.IMraidListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mopub.Mobileads.MraidView.IOnOpenListener"
		public event EventHandler<global::Com.Mopub.Mobileads.MraidView.OpenEventArgs> Open {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MraidView.IOnOpenListener, global::Com.Mopub.Mobileads.MraidView.IOnOpenListenerImplementor>(
						ref weak_implementor___SetOnOpenListener,
						__CreateIOnOpenListenerImplementor,
						__v => OnOpenListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MraidView.IOnOpenListener, global::Com.Mopub.Mobileads.MraidView.IOnOpenListenerImplementor>(
						ref weak_implementor___SetOnOpenListener,
						global::Com.Mopub.Mobileads.MraidView.IOnOpenListenerImplementor.__IsEmpty,
						__v => OnOpenListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnOpenListener;

		global::Com.Mopub.Mobileads.MraidView.IOnOpenListenerImplementor __CreateIOnOpenListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MraidView.IOnOpenListenerImplementor (this);
		}
#endregion
	}
}
