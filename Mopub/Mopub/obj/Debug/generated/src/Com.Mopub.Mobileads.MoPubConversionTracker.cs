using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubConversionTracker']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubConversionTracker", DoNotGenerateAcw=true)]
	public partial class MoPubConversionTracker : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubConversionTracker.ConversionUrlGenerator']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubConversionTracker$ConversionUrlGenerator", DoNotGenerateAcw=true)]
		public partial class ConversionUrlGenerator : global::Com.Mopub.Mobileads.BaseUrlGenerator {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MoPubConversionTracker$ConversionUrlGenerator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConversionUrlGenerator); }
			}

			protected ConversionUrlGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Mopub.Mobileads.MoPubConversionTracker.ConversionUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubConversionTracker.ConversionUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.GenerateUrlString (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_generateUrlString_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubConversionTracker.ConversionUrlGenerator']/method[@name='generateUrlString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("generateUrlString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGenerateUrlString_Ljava_lang_String_Handler")]
			public override string GenerateUrlString (string p0)
			{
				if (id_generateUrlString_Ljava_lang_String_ == IntPtr.Zero)
					id_generateUrlString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generateUrlString", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generateUrlString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_generateUrlString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubConversionTracker.TrackOpen']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubConversionTracker$TrackOpen", DoNotGenerateAcw=true)]
		public partial class TrackOpen : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MoPubConversionTracker$TrackOpen", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TrackOpen); }
			}

			protected TrackOpen (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubConversionTracker.TrackOpen __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubConversionTracker.TrackOpen> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubConversionTracker.TrackOpen']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_run);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MoPubConversionTracker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubConversionTracker); }
		}

		protected MoPubConversionTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubConversionTracker']/constructor[@name='MoPubConversionTracker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MoPubConversionTracker () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MoPubConversionTracker)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_reportAppOpen_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetReportAppOpen_Landroid_content_Context_Handler ()
		{
			if (cb_reportAppOpen_Landroid_content_Context_ == null)
				cb_reportAppOpen_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReportAppOpen_Landroid_content_Context_);
			return cb_reportAppOpen_Landroid_content_Context_;
		}

		static void n_ReportAppOpen_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubConversionTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubConversionTracker> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReportAppOpen (p0);
		}
#pragma warning restore 0169

		static IntPtr id_reportAppOpen_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubConversionTracker']/method[@name='reportAppOpen' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("reportAppOpen", "(Landroid/content/Context;)V", "GetReportAppOpen_Landroid_content_Context_Handler")]
		public virtual void ReportAppOpen (global::Android.Content.Context p0)
		{
			if (id_reportAppOpen_Landroid_content_Context_ == IntPtr.Zero)
				id_reportAppOpen_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "reportAppOpen", "(Landroid/content/Context;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_reportAppOpen_Landroid_content_Context_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_reportAppOpen_Landroid_content_Context_, new JValue (p0));
		}

	}
}
