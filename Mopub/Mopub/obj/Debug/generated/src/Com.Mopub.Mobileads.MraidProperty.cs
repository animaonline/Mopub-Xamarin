using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidProperty']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MraidProperty", DoNotGenerateAcw=true)]
	public abstract partial class MraidProperty : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MraidProperty", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidProperty); }
		}

		protected MraidProperty (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_toJsonPair;
#pragma warning disable 0169
		static Delegate GetToJsonPairHandler ()
		{
			if (cb_toJsonPair == null)
				cb_toJsonPair = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJsonPair);
			return cb_toJsonPair;
		}

		static IntPtr n_ToJsonPair (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MraidProperty __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidProperty> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJsonPair ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidProperty']/method[@name='toJsonPair' and count(parameter)=0]"
		[Register ("toJsonPair", "()Ljava/lang/String;", "GetToJsonPairHandler")]
		public abstract string ToJsonPair ();

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/MraidProperty", DoNotGenerateAcw=true)]
	internal partial class MraidPropertyInvoker : MraidProperty {

		public MraidPropertyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidPropertyInvoker); }
		}

		static IntPtr id_toJsonPair;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidProperty']/method[@name='toJsonPair' and count(parameter)=0]"
		[Register ("toJsonPair", "()Ljava/lang/String;", "GetToJsonPairHandler")]
		public override string ToJsonPair ()
		{
			if (id_toJsonPair == IntPtr.Zero)
				id_toJsonPair = JNIEnv.GetMethodID (class_ref, "toJsonPair", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toJsonPair), JniHandleOwnership.TransferLocalRef);
		}

	}

}
