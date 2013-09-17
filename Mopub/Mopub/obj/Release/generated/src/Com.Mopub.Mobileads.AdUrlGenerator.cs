using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/AdUrlGenerator", DoNotGenerateAcw=true)]
	public partial class AdUrlGenerator : global::Com.Mopub.Mobileads.BaseUrlGenerator {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator']/field[@name='DEVICE_ORIENTATION_LANDSCAPE']"
		[Register ("DEVICE_ORIENTATION_LANDSCAPE")]
		public const string DeviceOrientationLandscape = (string) "l";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator']/field[@name='DEVICE_ORIENTATION_PORTRAIT']"
		[Register ("DEVICE_ORIENTATION_PORTRAIT")]
		public const string DeviceOrientationPortrait = (string) "p";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator']/field[@name='DEVICE_ORIENTATION_SQUARE']"
		[Register ("DEVICE_ORIENTATION_SQUARE")]
		public const string DeviceOrientationSquare = (string) "s";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator']/field[@name='DEVICE_ORIENTATION_UNKNOWN']"
		[Register ("DEVICE_ORIENTATION_UNKNOWN")]
		public const string DeviceOrientationUnknown = (string) "u";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator']/field[@name='UNKNOWN_NETWORK_TYPE']"
		[Register ("UNKNOWN_NETWORK_TYPE")]
		public const int UnknownNetworkType = (int) 8;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator.MoPubNetworkType']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/AdUrlGenerator$MoPubNetworkType", DoNotGenerateAcw=true)]
		public sealed partial class MoPubNetworkType : global::Java.Lang.Enum {


			static IntPtr ETHERNET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator.MoPubNetworkType']/field[@name='ETHERNET']"
			[Register ("ETHERNET")]
			public static global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType Ethernet {
				get {
					if (ETHERNET_jfieldId == IntPtr.Zero)
						ETHERNET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ETHERNET", "Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ETHERNET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ETHERNET_jfieldId == IntPtr.Zero)
						ETHERNET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ETHERNET", "Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ETHERNET_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MOBILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator.MoPubNetworkType']/field[@name='MOBILE']"
			[Register ("MOBILE")]
			public static global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType Mobile {
				get {
					if (MOBILE_jfieldId == IntPtr.Zero)
						MOBILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE", "Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MOBILE_jfieldId == IntPtr.Zero)
						MOBILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE", "Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MOBILE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator.MoPubNetworkType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNKNOWN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr WIFI_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator.MoPubNetworkType']/field[@name='WIFI']"
			[Register ("WIFI")]
			public static global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType Wifi {
				get {
					if (WIFI_jfieldId == IntPtr.Zero)
						WIFI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIFI", "Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIFI_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (WIFI_jfieldId == IntPtr.Zero)
						WIFI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIFI", "Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, WIFI_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/AdUrlGenerator$MoPubNetworkType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MoPubNetworkType); }
			}

			internal MoPubNetworkType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator.MoPubNetworkType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;", "")]
			public static global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator.MoPubNetworkType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;", "")]
			public static global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mobileads/AdUrlGenerator$MoPubNetworkType;");
				return (global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mobileads.AdUrlGenerator.MoPubNetworkType));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/AdUrlGenerator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdUrlGenerator); }
		}

		protected AdUrlGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator']/constructor[@name='AdUrlGenerator' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public AdUrlGenerator (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AdUrlGenerator)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

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
			global::Com.Mopub.Mobileads.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateUrlString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateUrlString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator']/method[@name='generateUrlString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_withAdUnitId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAdUnitId_Ljava_lang_String_Handler ()
		{
			if (cb_withAdUnitId_Ljava_lang_String_ == null)
				cb_withAdUnitId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAdUnitId_Ljava_lang_String_);
			return cb_withAdUnitId_Ljava_lang_String_;
		}

		static IntPtr n_WithAdUnitId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdUnitId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAdUnitId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator']/method[@name='withAdUnitId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAdUnitId", "(Ljava/lang/String;)Lcom/mopub/mobileads/AdUrlGenerator;", "GetWithAdUnitId_Ljava_lang_String_Handler")]
		public virtual global::Com.Mopub.Mobileads.AdUrlGenerator WithAdUnitId (string p0)
		{
			if (id_withAdUnitId_Ljava_lang_String_ == IntPtr.Zero)
				id_withAdUnitId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAdUnitId", "(Ljava/lang/String;)Lcom/mopub/mobileads/AdUrlGenerator;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Mopub.Mobileads.AdUrlGenerator __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator> (JNIEnv.CallObjectMethod  (Handle, id_withAdUnitId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_withAdUnitId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_withKeywords_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithKeywords_Ljava_lang_String_Handler ()
		{
			if (cb_withKeywords_Ljava_lang_String_ == null)
				cb_withKeywords_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithKeywords_Ljava_lang_String_);
			return cb_withKeywords_Ljava_lang_String_;
		}

		static IntPtr n_WithKeywords_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithKeywords (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withKeywords_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator']/method[@name='withKeywords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withKeywords", "(Ljava/lang/String;)Lcom/mopub/mobileads/AdUrlGenerator;", "GetWithKeywords_Ljava_lang_String_Handler")]
		public virtual global::Com.Mopub.Mobileads.AdUrlGenerator WithKeywords (string p0)
		{
			if (id_withKeywords_Ljava_lang_String_ == IntPtr.Zero)
				id_withKeywords_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withKeywords", "(Ljava/lang/String;)Lcom/mopub/mobileads/AdUrlGenerator;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Mopub.Mobileads.AdUrlGenerator __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator> (JNIEnv.CallObjectMethod  (Handle, id_withKeywords_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_withKeywords_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_withLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetWithLocation_Landroid_location_Location_Handler ()
		{
			if (cb_withLocation_Landroid_location_Location_ == null)
				cb_withLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLocation_Landroid_location_Location_);
			return cb_withLocation_Landroid_location_Location_;
		}

		static IntPtr n_WithLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withLocation_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdUrlGenerator']/method[@name='withLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("withLocation", "(Landroid/location/Location;)Lcom/mopub/mobileads/AdUrlGenerator;", "GetWithLocation_Landroid_location_Location_Handler")]
		public virtual global::Com.Mopub.Mobileads.AdUrlGenerator WithLocation (global::Android.Locations.Location p0)
		{
			if (id_withLocation_Landroid_location_Location_ == IntPtr.Zero)
				id_withLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "withLocation", "(Landroid/location/Location;)Lcom/mopub/mobileads/AdUrlGenerator;");

			global::Com.Mopub.Mobileads.AdUrlGenerator __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator> (JNIEnv.CallObjectMethod  (Handle, id_withLocation_Landroid_location_Location_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdUrlGenerator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_withLocation_Landroid_location_Location_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
