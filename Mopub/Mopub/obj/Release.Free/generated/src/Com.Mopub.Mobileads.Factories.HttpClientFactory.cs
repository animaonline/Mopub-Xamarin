using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HttpClientFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/HttpClientFactory", DoNotGenerateAcw=true)]
	public partial class HttpClientFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/HttpClientFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpClientFactory); }
		}

		protected HttpClientFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HttpClientFactory']/constructor[@name='HttpClientFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public HttpClientFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HttpClientFactory)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_HttpClientFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HttpClientFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.HttpClientFactory']]"
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/HttpClientFactory;)V", "")]
		public static void SetInstance (global::Com.Mopub.Mobileads.Factories.HttpClientFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_HttpClientFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_HttpClientFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/HttpClientFactory;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_HttpClientFactory_, new JValue (p0));
		}

	}
}
