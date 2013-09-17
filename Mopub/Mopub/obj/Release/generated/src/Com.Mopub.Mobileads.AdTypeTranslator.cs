using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/AdTypeTranslator", DoNotGenerateAcw=true)]
	public partial class AdTypeTranslator : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/field[@name='ADMOB_BANNER']"
		[Register ("ADMOB_BANNER")]
		public const string AdmobBanner = (string) "com.mopub.mobileads.GoogleAdMobBanner";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/field[@name='ADMOB_INTERSTITIAL']"
		[Register ("ADMOB_INTERSTITIAL")]
		public const string AdmobInterstitial = (string) "com.mopub.mobileads.GoogleAdMobInterstitial";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/field[@name='HTML_BANNER']"
		[Register ("HTML_BANNER")]
		public const string HtmlBanner = (string) "com.mopub.mobileads.HtmlBanner";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/field[@name='HTML_INTERSTITIAL']"
		[Register ("HTML_INTERSTITIAL")]
		public const string HtmlInterstitial = (string) "com.mopub.mobileads.HtmlInterstitial";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/field[@name='MILLENNIAL_BANNER']"
		[Register ("MILLENNIAL_BANNER")]
		public const string MillennialBanner = (string) "com.mopub.mobileads.MillennialBanner";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/field[@name='MILLENNIAL_INTERSTITIAL']"
		[Register ("MILLENNIAL_INTERSTITIAL")]
		public const string MillennialInterstitial = (string) "com.mopub.mobileads.MillennialInterstitial";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/field[@name='MRAID_BANNER']"
		[Register ("MRAID_BANNER")]
		public const string MraidBanner = (string) "com.mopub.mobileads.MraidBanner";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/field[@name='MRAID_INTERSTITIAL']"
		[Register ("MRAID_INTERSTITIAL")]
		public const string MraidInterstitial = (string) "com.mopub.mobileads.MraidInterstitial";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/AdTypeTranslator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdTypeTranslator); }
		}

		protected AdTypeTranslator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/constructor[@name='AdTypeTranslator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AdTypeTranslator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AdTypeTranslator)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

	}
}
