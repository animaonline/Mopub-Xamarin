using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseHtmlWebView']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseHtmlWebView", DoNotGenerateAcw=true)]
	public partial class BaseHtmlWebView : global::Com.Mopub.Mobileads.BaseWebView {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/BaseHtmlWebView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseHtmlWebView); }
		}

		protected BaseHtmlWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseHtmlWebView']/constructor[@name='BaseHtmlWebView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public BaseHtmlWebView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BaseHtmlWebView)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_init_Z;
#pragma warning disable 0169
		static Delegate GetInit_ZHandler ()
		{
			if (cb_init_Z == null)
				cb_init_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Init_Z);
			return cb_init_Z;
		}

		static void n_Init_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Mobileads.BaseHtmlWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseHtmlWebView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseHtmlWebView']/method[@name='init' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("init", "(Z)V", "GetInit_ZHandler")]
		public virtual void Init (bool p0)
		{
			if (id_init_Z == IntPtr.Zero)
				id_init_Z = JNIEnv.GetMethodID (class_ref, "init", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_init_Z, new JValue (p0));
		}

	}
}
