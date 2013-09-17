using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='DateAndTime']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/util/DateAndTime", DoNotGenerateAcw=true)]
	public partial class DateAndTime : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='DateAndTime']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Mobileads.Util.DateAndTime Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/util/DateAndTime;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.DateAndTime> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/util/DateAndTime;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/util/DateAndTime", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateAndTime); }
		}

		protected DateAndTime (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='DateAndTime']/constructor[@name='DateAndTime' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DateAndTime () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DateAndTime)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_internalLocalTimeZone;
#pragma warning disable 0169
		static Delegate GetInternalLocalTimeZoneHandler ()
		{
			if (cb_internalLocalTimeZone == null)
				cb_internalLocalTimeZone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InternalLocalTimeZone);
			return cb_internalLocalTimeZone;
		}

		static IntPtr n_InternalLocalTimeZone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.Util.DateAndTime __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.DateAndTime> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InternalLocalTimeZone ());
		}
#pragma warning restore 0169

		static IntPtr id_internalLocalTimeZone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='DateAndTime']/method[@name='internalLocalTimeZone' and count(parameter)=0]"
		[Register ("internalLocalTimeZone", "()Ljava/util/TimeZone;", "GetInternalLocalTimeZoneHandler")]
		public virtual global::Java.Util.TimeZone InternalLocalTimeZone ()
		{
			if (id_internalLocalTimeZone == IntPtr.Zero)
				id_internalLocalTimeZone = JNIEnv.GetMethodID (class_ref, "internalLocalTimeZone", "()Ljava/util/TimeZone;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallObjectMethod  (Handle, id_internalLocalTimeZone), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_internalLocalTimeZone), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_internalNow;
#pragma warning disable 0169
		static Delegate GetInternalNowHandler ()
		{
			if (cb_internalNow == null)
				cb_internalNow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InternalNow);
			return cb_internalNow;
		}

		static IntPtr n_InternalNow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.Util.DateAndTime __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.DateAndTime> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InternalNow ());
		}
#pragma warning restore 0169

		static IntPtr id_internalNow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='DateAndTime']/method[@name='internalNow' and count(parameter)=0]"
		[Register ("internalNow", "()Ljava/util/Date;", "GetInternalNowHandler")]
		public virtual global::Java.Util.Date InternalNow ()
		{
			if (id_internalNow == IntPtr.Zero)
				id_internalNow = JNIEnv.GetMethodID (class_ref, "internalNow", "()Ljava/util/Date;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_internalNow), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_internalNow), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_localTimeZone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='DateAndTime']/method[@name='localTimeZone' and count(parameter)=0]"
		[Register ("localTimeZone", "()Ljava/util/TimeZone;", "")]
		public static global::Java.Util.TimeZone LocalTimeZone ()
		{
			if (id_localTimeZone == IntPtr.Zero)
				id_localTimeZone = JNIEnv.GetStaticMethodID (class_ref, "localTimeZone", "()Ljava/util/TimeZone;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallStaticObjectMethod  (class_ref, id_localTimeZone), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_now;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='DateAndTime']/method[@name='now' and count(parameter)=0]"
		[Register ("now", "()Ljava/util/Date;", "")]
		public static global::Java.Util.Date Now ()
		{
			if (id_now == IntPtr.Zero)
				id_now = JNIEnv.GetStaticMethodID (class_ref, "now", "()Ljava/util/Date;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_now), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_util_DateAndTime_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='DateAndTime']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.util.DateAndTime']]"
		[Register ("setInstance", "(Lcom/mopub/mobileads/util/DateAndTime;)V", "")]
		public static void SetInstance (global::Com.Mopub.Mobileads.Util.DateAndTime p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_util_DateAndTime_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_util_DateAndTime_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/util/DateAndTime;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_util_DateAndTime_, new JValue (p0));
		}

	}
}
