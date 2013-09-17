using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Resource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/resource/Drawables", DoNotGenerateAcw=true)]
	public sealed partial class Drawables : global::Java.Lang.Enum {


		static IntPtr BACKGROUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/field[@name='BACKGROUND']"
		[Register ("BACKGROUND")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables Background {
			get {
				if (BACKGROUND_jfieldId == IntPtr.Zero)
					BACKGROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKGROUND", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BACKGROUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.Drawables> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BACKGROUND_jfieldId == IntPtr.Zero)
					BACKGROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKGROUND", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, BACKGROUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CLOSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/field[@name='CLOSE']"
		[Register ("CLOSE")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables Close {
			get {
				if (CLOSE_jfieldId == IntPtr.Zero)
					CLOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSE", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.Drawables> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CLOSE_jfieldId == IntPtr.Zero)
					CLOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSE", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CLOSE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DEFAULT_VIDEO_POSTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/field[@name='DEFAULT_VIDEO_POSTER']"
		[Register ("DEFAULT_VIDEO_POSTER")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables DefaultVideoPoster {
			get {
				if (DEFAULT_VIDEO_POSTER_jfieldId == IntPtr.Zero)
					DEFAULT_VIDEO_POSTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_VIDEO_POSTER", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_VIDEO_POSTER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.Drawables> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_VIDEO_POSTER_jfieldId == IntPtr.Zero)
					DEFAULT_VIDEO_POSTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_VIDEO_POSTER", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEFAULT_VIDEO_POSTER_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INTERSTITIAL_CLOSE_BUTTON_NORMAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/field[@name='INTERSTITIAL_CLOSE_BUTTON_NORMAL']"
		[Register ("INTERSTITIAL_CLOSE_BUTTON_NORMAL")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables InterstitialCloseButtonNormal {
			get {
				if (INTERSTITIAL_CLOSE_BUTTON_NORMAL_jfieldId == IntPtr.Zero)
					INTERSTITIAL_CLOSE_BUTTON_NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERSTITIAL_CLOSE_BUTTON_NORMAL", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERSTITIAL_CLOSE_BUTTON_NORMAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.Drawables> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INTERSTITIAL_CLOSE_BUTTON_NORMAL_jfieldId == IntPtr.Zero)
					INTERSTITIAL_CLOSE_BUTTON_NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERSTITIAL_CLOSE_BUTTON_NORMAL", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INTERSTITIAL_CLOSE_BUTTON_NORMAL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INTERSTITIAL_CLOSE_BUTTON_PRESSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/field[@name='INTERSTITIAL_CLOSE_BUTTON_PRESSED']"
		[Register ("INTERSTITIAL_CLOSE_BUTTON_PRESSED")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables InterstitialCloseButtonPressed {
			get {
				if (INTERSTITIAL_CLOSE_BUTTON_PRESSED_jfieldId == IntPtr.Zero)
					INTERSTITIAL_CLOSE_BUTTON_PRESSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERSTITIAL_CLOSE_BUTTON_PRESSED", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERSTITIAL_CLOSE_BUTTON_PRESSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.Drawables> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INTERSTITIAL_CLOSE_BUTTON_PRESSED_jfieldId == IntPtr.Zero)
					INTERSTITIAL_CLOSE_BUTTON_PRESSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERSTITIAL_CLOSE_BUTTON_PRESSED", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INTERSTITIAL_CLOSE_BUTTON_PRESSED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LEFT_ARROW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/field[@name='LEFT_ARROW']"
		[Register ("LEFT_ARROW")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables LeftArrow {
			get {
				if (LEFT_ARROW_jfieldId == IntPtr.Zero)
					LEFT_ARROW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_ARROW", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_ARROW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.Drawables> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LEFT_ARROW_jfieldId == IntPtr.Zero)
					LEFT_ARROW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_ARROW", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LEFT_ARROW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr REFRESH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/field[@name='REFRESH']"
		[Register ("REFRESH")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables Refresh {
			get {
				if (REFRESH_jfieldId == IntPtr.Zero)
					REFRESH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFRESH", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFRESH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.Drawables> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (REFRESH_jfieldId == IntPtr.Zero)
					REFRESH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFRESH", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, REFRESH_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr RIGHT_ARROW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/field[@name='RIGHT_ARROW']"
		[Register ("RIGHT_ARROW")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables RightArrow {
			get {
				if (RIGHT_ARROW_jfieldId == IntPtr.Zero)
					RIGHT_ARROW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_ARROW", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_ARROW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.Drawables> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (RIGHT_ARROW_jfieldId == IntPtr.Zero)
					RIGHT_ARROW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_ARROW", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, RIGHT_ARROW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNLEFT_ARROW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/field[@name='UNLEFT_ARROW']"
		[Register ("UNLEFT_ARROW")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables UnleftArrow {
			get {
				if (UNLEFT_ARROW_jfieldId == IntPtr.Zero)
					UNLEFT_ARROW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNLEFT_ARROW", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNLEFT_ARROW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.Drawables> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNLEFT_ARROW_jfieldId == IntPtr.Zero)
					UNLEFT_ARROW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNLEFT_ARROW", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNLEFT_ARROW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNRIGHT_ARROW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/field[@name='UNRIGHT_ARROW']"
		[Register ("UNRIGHT_ARROW")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables UnrightArrow {
			get {
				if (UNRIGHT_ARROW_jfieldId == IntPtr.Zero)
					UNRIGHT_ARROW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNRIGHT_ARROW", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNRIGHT_ARROW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.Drawables> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNRIGHT_ARROW_jfieldId == IntPtr.Zero)
					UNRIGHT_ARROW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNRIGHT_ARROW", "Lcom/mopub/mobileads/resource/Drawables;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNRIGHT_ARROW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/resource/Drawables", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Drawables); }
		}

		internal Drawables (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_decodeImage_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/method[@name='decodeImage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("decodeImage", "(Landroid/content/Context;)Landroid/graphics/drawable/BitmapDrawable;", "")]
		public global::Android.Graphics.Drawables.BitmapDrawable DecodeImage (global::Android.Content.Context p0)
		{
			if (id_decodeImage_Landroid_content_Context_ == IntPtr.Zero)
				id_decodeImage_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "decodeImage", "(Landroid/content/Context;)Landroid/graphics/drawable/BitmapDrawable;");
			global::Android.Graphics.Drawables.BitmapDrawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.BitmapDrawable> (JNIEnv.CallObjectMethod  (Handle, id_decodeImage_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/resource/Drawables;", "")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/resource/Drawables;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Mopub.Mobileads.Resource.Drawables __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.Drawables> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='Drawables']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/mobileads/resource/Drawables;", "")]
		public static global::Com.Mopub.Mobileads.Resource.Drawables[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mobileads/resource/Drawables;");
			return (global::Com.Mopub.Mobileads.Resource.Drawables[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mobileads.Resource.Drawables));
		}

	}
}
