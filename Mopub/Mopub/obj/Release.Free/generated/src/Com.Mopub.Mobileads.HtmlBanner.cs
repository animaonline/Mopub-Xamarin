using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBanner']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/HtmlBanner", DoNotGenerateAcw=true)]
	public partial class HtmlBanner : global::Com.Mopub.Mobileads.CustomEventBanner {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/HtmlBanner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HtmlBanner); }
		}

		protected HtmlBanner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBanner']/constructor[@name='HtmlBanner' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public HtmlBanner () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HtmlBanner)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_);
			return cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_LoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mopub.Mobileads.HtmlBanner __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBanner> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p1 = (global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadBanner (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBanner']/method[@name='loadBanner' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.util.Map']]"
		[Register ("loadBanner", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;Ljava/util/Map;Ljava/util/Map;)V", "GetLoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected override void LoadBanner (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2, global::System.Collections.Generic.IDictionary<string, string> p3)
		{
			if (id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadBanner", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_, new JValue (p0), new JValue (p1), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3)));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_, new JValue (p0), new JValue (p1), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p2)), new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p3)));
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_onInvalidate;
#pragma warning disable 0169
		static Delegate GetOnInvalidateHandler ()
		{
			if (cb_onInvalidate == null)
				cb_onInvalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInvalidate);
			return cb_onInvalidate;
		}

		static void n_OnInvalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.HtmlBanner __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBanner> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInvalidate ();
		}
#pragma warning restore 0169

		static IntPtr id_onInvalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBanner']/method[@name='onInvalidate' and count(parameter)=0]"
		[Register ("onInvalidate", "()V", "GetOnInvalidateHandler")]
		protected override void OnInvalidate ()
		{
			if (id_onInvalidate == IntPtr.Zero)
				id_onInvalidate = JNIEnv.GetMethodID (class_ref, "onInvalidate", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onInvalidate);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onInvalidate);
		}

	}
}
