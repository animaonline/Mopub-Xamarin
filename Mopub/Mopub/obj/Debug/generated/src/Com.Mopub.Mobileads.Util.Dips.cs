using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='Dips']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/util/Dips", DoNotGenerateAcw=true)]
	public partial class Dips : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/util/Dips", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Dips); }
		}

		protected Dips (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='Dips']/constructor[@name='Dips' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Dips () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Dips)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_asFloatPixels_FLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='Dips']/method[@name='asFloatPixels' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("asFloatPixels", "(FLandroid/content/Context;)F", "")]
		public static float AsFloatPixels (float p0, global::Android.Content.Context p1)
		{
			if (id_asFloatPixels_FLandroid_content_Context_ == IntPtr.Zero)
				id_asFloatPixels_FLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "asFloatPixels", "(FLandroid/content/Context;)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_asFloatPixels_FLandroid_content_Context_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_asIntPixels_FLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='Dips']/method[@name='asIntPixels' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("asIntPixels", "(FLandroid/content/Context;)I", "")]
		public static int AsIntPixels (float p0, global::Android.Content.Context p1)
		{
			if (id_asIntPixels_FLandroid_content_Context_ == IntPtr.Zero)
				id_asIntPixels_FLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "asIntPixels", "(FLandroid/content/Context;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_asIntPixels_FLandroid_content_Context_, new JValue (p0), new JValue (p1));
			return __ret;
		}

	}
}
