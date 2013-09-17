using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='HttpResponses']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/util/HttpResponses", DoNotGenerateAcw=true)]
	public partial class HttpResponses : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/util/HttpResponses", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpResponses); }
		}

		protected HttpResponses (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='HttpResponses']/constructor[@name='HttpResponses' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public HttpResponses () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HttpResponses)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_extractBooleanHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='HttpResponses']/method[@name='extractBooleanHeader' and count(parameter)=3 and parameter[1][@type='org.apache.http.HttpResponse'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("extractBooleanHeader", "(Lorg/apache/http/HttpResponse;Ljava/lang/String;Z)Z", "")]
		public static bool ExtractBooleanHeader (global::Org.Apache.Http.IHttpResponse p0, string p1, bool p2)
		{
			if (id_extractBooleanHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_Z == IntPtr.Zero)
				id_extractBooleanHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "extractBooleanHeader", "(Lorg/apache/http/HttpResponse;Ljava/lang/String;Z)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_extractBooleanHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_Z, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_extractHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='HttpResponses']/method[@name='extractHeader' and count(parameter)=2 and parameter[1][@type='org.apache.http.HttpResponse'] and parameter[2][@type='java.lang.String']]"
		[Register ("extractHeader", "(Lorg/apache/http/HttpResponse;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string ExtractHeader (global::Org.Apache.Http.IHttpResponse p0, string p1)
		{
			if (id_extractHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_extractHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "extractHeader", "(Lorg/apache/http/HttpResponse;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_extractIntHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='HttpResponses']/method[@name='extractIntHeader' and count(parameter)=2 and parameter[1][@type='org.apache.http.HttpResponse'] and parameter[2][@type='java.lang.String']]"
		[Register ("extractIntHeader", "(Lorg/apache/http/HttpResponse;Ljava/lang/String;)I", "")]
		public static int ExtractIntHeader (global::Org.Apache.Http.IHttpResponse p0, string p1)
		{
			if (id_extractIntHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_extractIntHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "extractIntHeader", "(Lorg/apache/http/HttpResponse;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_extractIntHeader_Lorg_apache_http_HttpResponse_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
