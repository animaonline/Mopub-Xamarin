using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidVideoPlayerActivity']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MraidVideoPlayerActivity", DoNotGenerateAcw=true)]
	public partial class MraidVideoPlayerActivity : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidVideoPlayerActivity']/field[@name='MRAID_VIDEO_URL']"
		[Register ("MRAID_VIDEO_URL")]
		protected const string MraidVideoUrl = (string) "mraid_video_url";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MraidVideoPlayerActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidVideoPlayerActivity); }
		}

		protected MraidVideoPlayerActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidVideoPlayerActivity']/constructor[@name='MraidVideoPlayerActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MraidVideoPlayerActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MraidVideoPlayerActivity)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

	}
}
