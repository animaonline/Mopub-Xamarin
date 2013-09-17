using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/util/VersionCode", DoNotGenerateAcw=true)]
	public sealed partial class VersionCode : global::Java.Lang.Enum {


		static IntPtr BASE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='BASE']"
		[Register ("BASE")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode Base {
			get {
				if (BASE_jfieldId == IntPtr.Zero)
					BASE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BASE", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BASE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BASE_jfieldId == IntPtr.Zero)
					BASE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BASE", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, BASE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr BASE_1_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='BASE_1_1']"
		[Register ("BASE_1_1")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode Base11 {
			get {
				if (BASE_1_1_jfieldId == IntPtr.Zero)
					BASE_1_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BASE_1_1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BASE_1_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BASE_1_1_jfieldId == IntPtr.Zero)
					BASE_1_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BASE_1_1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, BASE_1_1_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CUPCAKE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='CUPCAKE']"
		[Register ("CUPCAKE")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode Cupcake {
			get {
				if (CUPCAKE_jfieldId == IntPtr.Zero)
					CUPCAKE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUPCAKE", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUPCAKE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CUPCAKE_jfieldId == IntPtr.Zero)
					CUPCAKE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUPCAKE", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CUPCAKE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CUR_DEVELOPMENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='CUR_DEVELOPMENT']"
		[Register ("CUR_DEVELOPMENT")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode CurDevelopment {
			get {
				if (CUR_DEVELOPMENT_jfieldId == IntPtr.Zero)
					CUR_DEVELOPMENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUR_DEVELOPMENT", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUR_DEVELOPMENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CUR_DEVELOPMENT_jfieldId == IntPtr.Zero)
					CUR_DEVELOPMENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUR_DEVELOPMENT", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CUR_DEVELOPMENT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DONUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='DONUT']"
		[Register ("DONUT")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode Donut {
			get {
				if (DONUT_jfieldId == IntPtr.Zero)
					DONUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DONUT", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DONUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DONUT_jfieldId == IntPtr.Zero)
					DONUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DONUT", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DONUT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ECLAIR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='ECLAIR']"
		[Register ("ECLAIR")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode Eclair {
			get {
				if (ECLAIR_jfieldId == IntPtr.Zero)
					ECLAIR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECLAIR", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ECLAIR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ECLAIR_jfieldId == IntPtr.Zero)
					ECLAIR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECLAIR", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ECLAIR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ECLAIR_0_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='ECLAIR_0_1']"
		[Register ("ECLAIR_0_1")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode Eclair01 {
			get {
				if (ECLAIR_0_1_jfieldId == IntPtr.Zero)
					ECLAIR_0_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECLAIR_0_1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ECLAIR_0_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ECLAIR_0_1_jfieldId == IntPtr.Zero)
					ECLAIR_0_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECLAIR_0_1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ECLAIR_0_1_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ECLAIR_MR1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='ECLAIR_MR1']"
		[Register ("ECLAIR_MR1")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode EclairMr1 {
			get {
				if (ECLAIR_MR1_jfieldId == IntPtr.Zero)
					ECLAIR_MR1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECLAIR_MR1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ECLAIR_MR1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ECLAIR_MR1_jfieldId == IntPtr.Zero)
					ECLAIR_MR1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECLAIR_MR1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ECLAIR_MR1_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FROYO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='FROYO']"
		[Register ("FROYO")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode Froyo {
			get {
				if (FROYO_jfieldId == IntPtr.Zero)
					FROYO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FROYO", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FROYO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FROYO_jfieldId == IntPtr.Zero)
					FROYO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FROYO", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FROYO_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GINGERBREAD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='GINGERBREAD']"
		[Register ("GINGERBREAD")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode Gingerbread {
			get {
				if (GINGERBREAD_jfieldId == IntPtr.Zero)
					GINGERBREAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GINGERBREAD", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GINGERBREAD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GINGERBREAD_jfieldId == IntPtr.Zero)
					GINGERBREAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GINGERBREAD", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GINGERBREAD_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GINGERBREAD_MR1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='GINGERBREAD_MR1']"
		[Register ("GINGERBREAD_MR1")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode GingerbreadMr1 {
			get {
				if (GINGERBREAD_MR1_jfieldId == IntPtr.Zero)
					GINGERBREAD_MR1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GINGERBREAD_MR1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GINGERBREAD_MR1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GINGERBREAD_MR1_jfieldId == IntPtr.Zero)
					GINGERBREAD_MR1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GINGERBREAD_MR1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GINGERBREAD_MR1_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr HONEYCOMB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='HONEYCOMB']"
		[Register ("HONEYCOMB")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode Honeycomb {
			get {
				if (HONEYCOMB_jfieldId == IntPtr.Zero)
					HONEYCOMB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HONEYCOMB", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HONEYCOMB_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HONEYCOMB_jfieldId == IntPtr.Zero)
					HONEYCOMB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HONEYCOMB", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, HONEYCOMB_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr HONEYCOMB_MR1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='HONEYCOMB_MR1']"
		[Register ("HONEYCOMB_MR1")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode HoneycombMr1 {
			get {
				if (HONEYCOMB_MR1_jfieldId == IntPtr.Zero)
					HONEYCOMB_MR1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HONEYCOMB_MR1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HONEYCOMB_MR1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HONEYCOMB_MR1_jfieldId == IntPtr.Zero)
					HONEYCOMB_MR1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HONEYCOMB_MR1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, HONEYCOMB_MR1_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr HONEYCOMB_MR2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='HONEYCOMB_MR2']"
		[Register ("HONEYCOMB_MR2")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode HoneycombMr2 {
			get {
				if (HONEYCOMB_MR2_jfieldId == IntPtr.Zero)
					HONEYCOMB_MR2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HONEYCOMB_MR2", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HONEYCOMB_MR2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HONEYCOMB_MR2_jfieldId == IntPtr.Zero)
					HONEYCOMB_MR2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HONEYCOMB_MR2", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, HONEYCOMB_MR2_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ICE_CREAM_SANDWICH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='ICE_CREAM_SANDWICH']"
		[Register ("ICE_CREAM_SANDWICH")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode IceCreamSandwich {
			get {
				if (ICE_CREAM_SANDWICH_jfieldId == IntPtr.Zero)
					ICE_CREAM_SANDWICH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ICE_CREAM_SANDWICH", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ICE_CREAM_SANDWICH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ICE_CREAM_SANDWICH_jfieldId == IntPtr.Zero)
					ICE_CREAM_SANDWICH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ICE_CREAM_SANDWICH", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ICE_CREAM_SANDWICH_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ICE_CREAM_SANDWICH_MR1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='ICE_CREAM_SANDWICH_MR1']"
		[Register ("ICE_CREAM_SANDWICH_MR1")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode IceCreamSandwichMr1 {
			get {
				if (ICE_CREAM_SANDWICH_MR1_jfieldId == IntPtr.Zero)
					ICE_CREAM_SANDWICH_MR1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ICE_CREAM_SANDWICH_MR1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ICE_CREAM_SANDWICH_MR1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ICE_CREAM_SANDWICH_MR1_jfieldId == IntPtr.Zero)
					ICE_CREAM_SANDWICH_MR1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ICE_CREAM_SANDWICH_MR1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ICE_CREAM_SANDWICH_MR1_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr JELLY_BEAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='JELLY_BEAN']"
		[Register ("JELLY_BEAN")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode JellyBean {
			get {
				if (JELLY_BEAN_jfieldId == IntPtr.Zero)
					JELLY_BEAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JELLY_BEAN", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JELLY_BEAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (JELLY_BEAN_jfieldId == IntPtr.Zero)
					JELLY_BEAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JELLY_BEAN", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, JELLY_BEAN_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr JELLY_BEAN_MR1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='JELLY_BEAN_MR1']"
		[Register ("JELLY_BEAN_MR1")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode JellyBeanMr1 {
			get {
				if (JELLY_BEAN_MR1_jfieldId == IntPtr.Zero)
					JELLY_BEAN_MR1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JELLY_BEAN_MR1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JELLY_BEAN_MR1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (JELLY_BEAN_MR1_jfieldId == IntPtr.Zero)
					JELLY_BEAN_MR1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JELLY_BEAN_MR1", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, JELLY_BEAN_MR1_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr JELLY_BEAN_MR2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/field[@name='JELLY_BEAN_MR2']"
		[Register ("JELLY_BEAN_MR2")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode JellyBeanMr2 {
			get {
				if (JELLY_BEAN_MR2_jfieldId == IntPtr.Zero)
					JELLY_BEAN_MR2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JELLY_BEAN_MR2", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JELLY_BEAN_MR2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (JELLY_BEAN_MR2_jfieldId == IntPtr.Zero)
					JELLY_BEAN_MR2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JELLY_BEAN_MR2", "Lcom/mopub/mobileads/util/VersionCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, JELLY_BEAN_MR2_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/util/VersionCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VersionCode); }
		}

		internal VersionCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getApiLevel;
		public int ApiLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/method[@name='getApiLevel' and count(parameter)=0]"
			[Register ("getApiLevel", "()I", "GetGetApiLevelHandler")]
			get {
				if (id_getApiLevel == IntPtr.Zero)
					id_getApiLevel = JNIEnv.GetMethodID (class_ref, "getApiLevel", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getApiLevel);
			}
		}

		static IntPtr id_currentApiLevel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/method[@name='currentApiLevel' and count(parameter)=0]"
		[Register ("currentApiLevel", "()Lcom/mopub/mobileads/util/VersionCode;", "")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode CurrentApiLevel ()
		{
			if (id_currentApiLevel == IntPtr.Zero)
				id_currentApiLevel = JNIEnv.GetStaticMethodID (class_ref, "currentApiLevel", "()Lcom/mopub/mobileads/util/VersionCode;");
			return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_currentApiLevel), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_isAtLeast_Lcom_mopub_mobileads_util_VersionCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/method[@name='isAtLeast' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.util.VersionCode']]"
		[Register ("isAtLeast", "(Lcom/mopub/mobileads/util/VersionCode;)Z", "")]
		public bool IsAtLeast (global::Com.Mopub.Mobileads.Util.VersionCode p0)
		{
			if (id_isAtLeast_Lcom_mopub_mobileads_util_VersionCode_ == IntPtr.Zero)
				id_isAtLeast_Lcom_mopub_mobileads_util_VersionCode_ = JNIEnv.GetMethodID (class_ref, "isAtLeast", "(Lcom/mopub/mobileads/util/VersionCode;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_isAtLeast_Lcom_mopub_mobileads_util_VersionCode_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isAtMost_Lcom_mopub_mobileads_util_VersionCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/method[@name='isAtMost' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.util.VersionCode']]"
		[Register ("isAtMost", "(Lcom/mopub/mobileads/util/VersionCode;)Z", "")]
		public bool IsAtMost (global::Com.Mopub.Mobileads.Util.VersionCode p0)
		{
			if (id_isAtMost_Lcom_mopub_mobileads_util_VersionCode_ == IntPtr.Zero)
				id_isAtMost_Lcom_mopub_mobileads_util_VersionCode_ = JNIEnv.GetMethodID (class_ref, "isAtMost", "(Lcom/mopub/mobileads/util/VersionCode;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_isAtMost_Lcom_mopub_mobileads_util_VersionCode_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isBelow_Lcom_mopub_mobileads_util_VersionCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/method[@name='isBelow' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.util.VersionCode']]"
		[Register ("isBelow", "(Lcom/mopub/mobileads/util/VersionCode;)Z", "")]
		public bool IsBelow (global::Com.Mopub.Mobileads.Util.VersionCode p0)
		{
			if (id_isBelow_Lcom_mopub_mobileads_util_VersionCode_ == IntPtr.Zero)
				id_isBelow_Lcom_mopub_mobileads_util_VersionCode_ = JNIEnv.GetMethodID (class_ref, "isBelow", "(Lcom/mopub/mobileads/util/VersionCode;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_isBelow_Lcom_mopub_mobileads_util_VersionCode_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/util/VersionCode;", "")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/util/VersionCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Mopub.Mobileads.Util.VersionCode __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Util.VersionCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='VersionCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/mobileads/util/VersionCode;", "")]
		public static global::Com.Mopub.Mobileads.Util.VersionCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mobileads/util/VersionCode;");
			return (global::Com.Mopub.Mobileads.Util.VersionCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mobileads.Util.VersionCode));
		}

	}
}
