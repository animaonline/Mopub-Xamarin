using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class MoPubErrorCode : global::Java.Lang.Enum {


		static IntPtr ADAPTER_CONFIGURATION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/field[@name='ADAPTER_CONFIGURATION_ERROR']"
		[Register ("ADAPTER_CONFIGURATION_ERROR")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode AdapterConfigurationError {
			get {
				if (ADAPTER_CONFIGURATION_ERROR_jfieldId == IntPtr.Zero)
					ADAPTER_CONFIGURATION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADAPTER_CONFIGURATION_ERROR", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADAPTER_CONFIGURATION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ADAPTER_CONFIGURATION_ERROR_jfieldId == IntPtr.Zero)
					ADAPTER_CONFIGURATION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADAPTER_CONFIGURATION_ERROR", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ADAPTER_CONFIGURATION_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ADAPTER_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/field[@name='ADAPTER_NOT_FOUND']"
		[Register ("ADAPTER_NOT_FOUND")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode AdapterNotFound {
			get {
				if (ADAPTER_NOT_FOUND_jfieldId == IntPtr.Zero)
					ADAPTER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADAPTER_NOT_FOUND", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADAPTER_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ADAPTER_NOT_FOUND_jfieldId == IntPtr.Zero)
					ADAPTER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADAPTER_NOT_FOUND", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ADAPTER_NOT_FOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CANCELLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/field[@name='CANCELLED']"
		[Register ("CANCELLED")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode Cancelled {
			get {
				if (CANCELLED_jfieldId == IntPtr.Zero)
					CANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELLED", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CANCELLED_jfieldId == IntPtr.Zero)
					CANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELLED", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CANCELLED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INTERNAL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode InternalError {
			get {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INTERNAL_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MRAID_LOAD_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/field[@name='MRAID_LOAD_ERROR']"
		[Register ("MRAID_LOAD_ERROR")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode MraidLoadError {
			get {
				if (MRAID_LOAD_ERROR_jfieldId == IntPtr.Zero)
					MRAID_LOAD_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MRAID_LOAD_ERROR", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MRAID_LOAD_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MRAID_LOAD_ERROR_jfieldId == IntPtr.Zero)
					MRAID_LOAD_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MRAID_LOAD_ERROR", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MRAID_LOAD_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NETWORK_INVALID_STATE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/field[@name='NETWORK_INVALID_STATE']"
		[Register ("NETWORK_INVALID_STATE")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode NetworkInvalidState {
			get {
				if (NETWORK_INVALID_STATE_jfieldId == IntPtr.Zero)
					NETWORK_INVALID_STATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_INVALID_STATE", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_INVALID_STATE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NETWORK_INVALID_STATE_jfieldId == IntPtr.Zero)
					NETWORK_INVALID_STATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_INVALID_STATE", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NETWORK_INVALID_STATE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NETWORK_NO_FILL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/field[@name='NETWORK_NO_FILL']"
		[Register ("NETWORK_NO_FILL")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode NetworkNoFill {
			get {
				if (NETWORK_NO_FILL_jfieldId == IntPtr.Zero)
					NETWORK_NO_FILL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_NO_FILL", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_NO_FILL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NETWORK_NO_FILL_jfieldId == IntPtr.Zero)
					NETWORK_NO_FILL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_NO_FILL", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NETWORK_NO_FILL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NETWORK_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/field[@name='NETWORK_TIMEOUT']"
		[Register ("NETWORK_TIMEOUT")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode NetworkTimeout {
			get {
				if (NETWORK_TIMEOUT_jfieldId == IntPtr.Zero)
					NETWORK_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_TIMEOUT", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NETWORK_TIMEOUT_jfieldId == IntPtr.Zero)
					NETWORK_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_TIMEOUT", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NETWORK_TIMEOUT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NO_FILL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/field[@name='NO_FILL']"
		[Register ("NO_FILL")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode NoFill {
			get {
				if (NO_FILL_jfieldId == IntPtr.Zero)
					NO_FILL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_FILL", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_FILL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NO_FILL_jfieldId == IntPtr.Zero)
					NO_FILL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_FILL", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NO_FILL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVER_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/field[@name='SERVER_ERROR']"
		[Register ("SERVER_ERROR")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode ServerError {
			get {
				if (SERVER_ERROR_jfieldId == IntPtr.Zero)
					SERVER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVER_ERROR", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVER_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVER_ERROR_jfieldId == IntPtr.Zero)
					SERVER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVER_ERROR", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVER_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNSPECIFIED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/field[@name='UNSPECIFIED']"
		[Register ("UNSPECIFIED")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode Unspecified {
			get {
				if (UNSPECIFIED_jfieldId == IntPtr.Zero)
					UNSPECIFIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSPECIFIED", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSPECIFIED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNSPECIFIED_jfieldId == IntPtr.Zero)
					UNSPECIFIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSPECIFIED", "Lcom/mopub/mobileads/MoPubErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNSPECIFIED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MoPubErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubErrorCode); }
		}

		internal MoPubErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MoPubErrorCode;", "")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MoPubErrorCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Mopub.Mobileads.MoPubErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/mobileads/MoPubErrorCode;", "")]
		public static global::Com.Mopub.Mobileads.MoPubErrorCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mobileads/MoPubErrorCode;");
			return (global::Com.Mopub.Mobileads.MoPubErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mobileads.MoPubErrorCode));
		}

	}
}
