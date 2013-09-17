using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utils); }
		}

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_invokeInstanceMethod_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='Utils']/method[@name='invokeInstanceMethod' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("invokeInstanceMethod", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public static void InvokeInstanceMethod (global::Java.Lang.Object p0, string p1)
		{
			if (id_invokeInstanceMethod_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_invokeInstanceMethod_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "invokeInstanceMethod", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_invokeInstanceMethod_Ljava_lang_Object_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_jsonStringToMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='Utils']/method[@name='jsonStringToMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("jsonStringToMap", "(Ljava/lang/String;)Ljava/util/Map;", "")]
		public static global::System.Collections.Generic.IDictionary<string, string> JsonStringToMap (string p0)
		{
			if (id_jsonStringToMap_Ljava_lang_String_ == IntPtr.Zero)
				id_jsonStringToMap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "jsonStringToMap", "(Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_jsonStringToMap_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_mapToJsonString_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='Utils']/method[@name='mapToJsonString' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("mapToJsonString", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static string MapToJsonString (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_mapToJsonString_Ljava_util_Map_ == IntPtr.Zero)
				id_mapToJsonString_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "mapToJsonString", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_mapToJsonString_Ljava_util_Map_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha1_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='Utils']/method[@name='sha1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha1", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Sha1 (string p0)
		{
			if (id_sha1_Ljava_lang_String_ == IntPtr.Zero)
				id_sha1_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha1", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha1_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
