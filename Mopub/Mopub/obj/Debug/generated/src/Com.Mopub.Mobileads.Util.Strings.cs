using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='Strings']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/util/Strings", DoNotGenerateAcw=true)]
	public partial class Strings : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/util/Strings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Strings); }
		}

		protected Strings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='Strings']/constructor[@name='Strings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Strings () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Strings)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_fromStream_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='Strings']/method[@name='fromStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("fromStream", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static string FromStream (global::System.IO.Stream p0)
		{
			if (id_fromStream_Ljava_io_InputStream_ == IntPtr.Zero)
				id_fromStream_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "fromStream", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromStream_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isEmpty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='Strings']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isEmpty", "(Ljava/lang/String;)Z", "")]
		public static bool IsEmpty (string p0)
		{
			if (id_isEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_isEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
