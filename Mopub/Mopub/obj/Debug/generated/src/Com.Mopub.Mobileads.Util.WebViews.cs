using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='WebViews']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/util/WebViews", DoNotGenerateAcw=true)]
	public partial class WebViews : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/util/WebViews", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebViews); }
		}

		protected WebViews (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='WebViews']/constructor[@name='WebViews' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public WebViews () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WebViews)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_onPause_Landroid_webkit_WebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='WebViews']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("onPause", "(Landroid/webkit/WebView;)V", "")]
		public static void OnPause (global::Android.Webkit.WebView p0)
		{
			if (id_onPause_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_onPause_Landroid_webkit_WebView_ = JNIEnv.GetStaticMethodID (class_ref, "onPause", "(Landroid/webkit/WebView;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onPause_Landroid_webkit_WebView_, new JValue (p0));
		}

		static IntPtr id_onResume_Landroid_webkit_WebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='WebViews']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("onResume", "(Landroid/webkit/WebView;)V", "")]
		public static void OnResume (global::Android.Webkit.WebView p0)
		{
			if (id_onResume_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_onResume_Landroid_webkit_WebView_ = JNIEnv.GetStaticMethodID (class_ref, "onResume", "(Landroid/webkit/WebView;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onResume_Landroid_webkit_WebView_, new JValue (p0));
		}

	}
}
