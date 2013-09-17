using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='FacebookKeywordProvider']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/FacebookKeywordProvider", DoNotGenerateAcw=true)]
	public partial class FacebookKeywordProvider : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/FacebookKeywordProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FacebookKeywordProvider); }
		}

		protected FacebookKeywordProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='FacebookKeywordProvider']/constructor[@name='FacebookKeywordProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public FacebookKeywordProvider () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FacebookKeywordProvider)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getKeyword_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='FacebookKeywordProvider']/method[@name='getKeyword' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getKeyword", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetKeyword (global::Android.Content.Context p0)
		{
			if (id_getKeyword_Landroid_content_Context_ == IntPtr.Zero)
				id_getKeyword_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getKeyword", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getKeyword_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
