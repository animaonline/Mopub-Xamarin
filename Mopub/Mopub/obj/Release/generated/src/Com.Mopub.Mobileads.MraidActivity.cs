using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MraidActivity", DoNotGenerateAcw=true)]
	public partial class MraidActivity : global::Com.Mopub.Mobileads.BaseInterstitialActivity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MraidActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidActivity); }
		}

		protected MraidActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']/constructor[@name='MraidActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MraidActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MraidActivity)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getAdView;
#pragma warning disable 0169
		static Delegate GetGetAdViewHandler ()
		{
			if (cb_getAdView == null)
				cb_getAdView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdView);
			return cb_getAdView;
		}

		static IntPtr n_GetAdView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MraidActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdView);
		}
#pragma warning restore 0169

		static IntPtr id_getAdView;
		public override global::Android.Views.View AdView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']/method[@name='getAdView' and count(parameter)=0]"
			[Register ("getAdView", "()Landroid/view/View;", "GetGetAdViewHandler")]
			get {
				if (id_getAdView == IntPtr.Zero)
					id_getAdView = JNIEnv.GetMethodID (class_ref, "getAdView", "()Landroid/view/View;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getAdView), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAdView), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
