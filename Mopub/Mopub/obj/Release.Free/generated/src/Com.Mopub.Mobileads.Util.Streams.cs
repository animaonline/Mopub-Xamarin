using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='Streams']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/util/Streams", DoNotGenerateAcw=true)]
	public partial class Streams : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/util/Streams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Streams); }
		}

		protected Streams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='Streams']/constructor[@name='Streams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Streams () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Streams)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='Streams']/method[@name='copyContent' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("copyContent", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "")]
		public static void CopyContent (global::System.IO.Stream p0, global::System.IO.Stream p1)
		{
			if (id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "copyContent", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
