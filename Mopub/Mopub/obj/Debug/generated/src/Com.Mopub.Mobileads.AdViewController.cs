using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/AdViewController", DoNotGenerateAcw=true)]
	public partial class AdViewController : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/AdViewController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdViewController); }
		}

		protected AdViewController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/constructor[@name='AdViewController' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.MoPubView']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mopub/mobileads/MoPubView;)V", "")]
		public AdViewController (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.MoPubView p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AdViewController)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Lcom/mopub/mobileads/MoPubView;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mopub/mobileads/MoPubView;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getAdHeight;
#pragma warning disable 0169
		static Delegate GetGetAdHeightHandler ()
		{
			if (cb_getAdHeight == null)
				cb_getAdHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdHeight);
			return cb_getAdHeight;
		}

		static int n_GetAdHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getAdHeight;
		public virtual int AdHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='getAdHeight' and count(parameter)=0]"
			[Register ("getAdHeight", "()I", "GetGetAdHeightHandler")]
			get {
				if (id_getAdHeight == IntPtr.Zero)
					id_getAdHeight = JNIEnv.GetMethodID (class_ref, "getAdHeight", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAdHeight);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getAdHeight);
			}
		}

		static Delegate cb_getAdUnitId;
#pragma warning disable 0169
		static Delegate GetGetAdUnitIdHandler ()
		{
			if (cb_getAdUnitId == null)
				cb_getAdUnitId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdUnitId);
			return cb_getAdUnitId;
		}

		static IntPtr n_GetAdUnitId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdUnitId);
		}
#pragma warning restore 0169

		static Delegate cb_setAdUnitId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdUnitId_Ljava_lang_String_Handler ()
		{
			if (cb_setAdUnitId_Ljava_lang_String_ == null)
				cb_setAdUnitId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdUnitId_Ljava_lang_String_);
			return cb_setAdUnitId_Ljava_lang_String_;
		}

		static void n_SetAdUnitId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdUnitId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdUnitId;
		static IntPtr id_setAdUnitId_Ljava_lang_String_;
		public virtual string AdUnitId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='getAdUnitId' and count(parameter)=0]"
			[Register ("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get {
				if (id_getAdUnitId == IntPtr.Zero)
					id_getAdUnitId = JNIEnv.GetMethodID (class_ref, "getAdUnitId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAdUnitId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAdUnitId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='setAdUnitId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdUnitId", "(Ljava/lang/String;)V", "GetSetAdUnitId_Ljava_lang_String_Handler")]
			set {
				if (id_setAdUnitId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAdUnitId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdUnitId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAdUnitId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAdUnitId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getAdWidth;
#pragma warning disable 0169
		static Delegate GetGetAdWidthHandler ()
		{
			if (cb_getAdWidth == null)
				cb_getAdWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdWidth);
			return cb_getAdWidth;
		}

		static int n_GetAdWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getAdWidth;
		public virtual int AdWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='getAdWidth' and count(parameter)=0]"
			[Register ("getAdWidth", "()I", "GetGetAdWidthHandler")]
			get {
				if (id_getAdWidth == IntPtr.Zero)
					id_getAdWidth = JNIEnv.GetMethodID (class_ref, "getAdWidth", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAdWidth);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getAdWidth);
			}
		}

		static Delegate cb_getAutorefreshEnabled;
#pragma warning disable 0169
		static Delegate GetGetAutorefreshEnabledHandler ()
		{
			if (cb_getAutorefreshEnabled == null)
				cb_getAutorefreshEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutorefreshEnabled);
			return cb_getAutorefreshEnabled;
		}

		static bool n_GetAutorefreshEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutorefreshEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setAutorefreshEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetAutorefreshEnabled_ZHandler ()
		{
			if (cb_setAutorefreshEnabled_Z == null)
				cb_setAutorefreshEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutorefreshEnabled_Z);
			return cb_setAutorefreshEnabled_Z;
		}

		static void n_SetAutorefreshEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutorefreshEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAutorefreshEnabled;
		static IntPtr id_setAutorefreshEnabled_Z;
		public virtual bool AutorefreshEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='getAutorefreshEnabled' and count(parameter)=0]"
			[Register ("getAutorefreshEnabled", "()Z", "GetGetAutorefreshEnabledHandler")]
			get {
				if (id_getAutorefreshEnabled == IntPtr.Zero)
					id_getAutorefreshEnabled = JNIEnv.GetMethodID (class_ref, "getAutorefreshEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getAutorefreshEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getAutorefreshEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='setAutorefreshEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutorefreshEnabled", "(Z)V", "GetSetAutorefreshEnabled_ZHandler")]
			set {
				if (id_setAutorefreshEnabled_Z == IntPtr.Zero)
					id_setAutorefreshEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAutorefreshEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAutorefreshEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAutorefreshEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_getClickthroughUrl;
#pragma warning disable 0169
		static Delegate GetGetClickthroughUrlHandler ()
		{
			if (cb_getClickthroughUrl == null)
				cb_getClickthroughUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClickthroughUrl);
			return cb_getClickthroughUrl;
		}

		static IntPtr n_GetClickthroughUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClickthroughUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setClickthroughUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClickthroughUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setClickthroughUrl_Ljava_lang_String_ == null)
				cb_setClickthroughUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClickthroughUrl_Ljava_lang_String_);
			return cb_setClickthroughUrl_Ljava_lang_String_;
		}

		static void n_SetClickthroughUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClickthroughUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClickthroughUrl;
		static IntPtr id_setClickthroughUrl_Ljava_lang_String_;
		public virtual string ClickthroughUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='getClickthroughUrl' and count(parameter)=0]"
			[Register ("getClickthroughUrl", "()Ljava/lang/String;", "GetGetClickthroughUrlHandler")]
			get {
				if (id_getClickthroughUrl == IntPtr.Zero)
					id_getClickthroughUrl = JNIEnv.GetMethodID (class_ref, "getClickthroughUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClickthroughUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getClickthroughUrl), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='setClickthroughUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClickthroughUrl", "(Ljava/lang/String;)V", "GetSetClickthroughUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setClickthroughUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setClickthroughUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClickthroughUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setClickthroughUrl_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setClickthroughUrl_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getKeywords;
#pragma warning disable 0169
		static Delegate GetGetKeywordsHandler ()
		{
			if (cb_getKeywords == null)
				cb_getKeywords = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeywords);
			return cb_getKeywords;
		}

		static IntPtr n_GetKeywords (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Keywords);
		}
#pragma warning restore 0169

		static Delegate cb_setKeywords_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKeywords_Ljava_lang_String_Handler ()
		{
			if (cb_setKeywords_Ljava_lang_String_ == null)
				cb_setKeywords_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKeywords_Ljava_lang_String_);
			return cb_setKeywords_Ljava_lang_String_;
		}

		static void n_SetKeywords_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Keywords = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKeywords;
		static IntPtr id_setKeywords_Ljava_lang_String_;
		public virtual string Keywords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='getKeywords' and count(parameter)=0]"
			[Register ("getKeywords", "()Ljava/lang/String;", "GetGetKeywordsHandler")]
			get {
				if (id_getKeywords == IntPtr.Zero)
					id_getKeywords = JNIEnv.GetMethodID (class_ref, "getKeywords", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKeywords), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getKeywords), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='setKeywords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKeywords", "(Ljava/lang/String;)V", "GetSetKeywords_Ljava_lang_String_Handler")]
			set {
				if (id_setKeywords_Ljava_lang_String_ == IntPtr.Zero)
					id_setKeywords_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKeywords", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setKeywords_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setKeywords_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static Delegate cb_setLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Landroid_location_Location_Handler ()
		{
			if (cb_setLocation_Landroid_location_Location_ == null)
				cb_setLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Landroid_location_Location_);
			return cb_setLocation_Landroid_location_Location_;
		}

		static void n_SetLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Location = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Landroid_location_Location_;
		public virtual global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
			[Register ("setLocation", "(Landroid/location/Location;)V", "GetSetLocation_Landroid_location_Location_Handler")]
			set {
				if (id_setLocation_Landroid_location_Location_ == IntPtr.Zero)
					id_setLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Landroid/location/Location;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocation_Landroid_location_Location_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLocation_Landroid_location_Location_, new JValue (value));
			}
		}

		static Delegate cb_getMoPubView;
#pragma warning disable 0169
		static Delegate GetGetMoPubViewHandler ()
		{
			if (cb_getMoPubView == null)
				cb_getMoPubView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMoPubView);
			return cb_getMoPubView;
		}

		static IntPtr n_GetMoPubView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MoPubView);
		}
#pragma warning restore 0169

		static IntPtr id_getMoPubView;
		public virtual global::Com.Mopub.Mobileads.MoPubView MoPubView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='getMoPubView' and count(parameter)=0]"
			[Register ("getMoPubView", "()Lcom/mopub/mobileads/MoPubView;", "GetGetMoPubViewHandler")]
			get {
				if (id_getMoPubView == IntPtr.Zero)
					id_getMoPubView = JNIEnv.GetMethodID (class_ref, "getMoPubView", "()Lcom/mopub/mobileads/MoPubView;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (JNIEnv.CallObjectMethod  (Handle, id_getMoPubView), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMoPubView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRedirectUrl;
#pragma warning disable 0169
		static Delegate GetGetRedirectUrlHandler ()
		{
			if (cb_getRedirectUrl == null)
				cb_getRedirectUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedirectUrl);
			return cb_getRedirectUrl;
		}

		static IntPtr n_GetRedirectUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getRedirectUrl;
		public virtual string RedirectUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='getRedirectUrl' and count(parameter)=0]"
			[Register ("getRedirectUrl", "()Ljava/lang/String;", "GetGetRedirectUrlHandler")]
			get {
				if (id_getRedirectUrl == IntPtr.Zero)
					id_getRedirectUrl = JNIEnv.GetMethodID (class_ref, "getRedirectUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRedirectUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getRedirectUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getResponseString;
#pragma warning disable 0169
		static Delegate GetGetResponseStringHandler ()
		{
			if (cb_getResponseString == null)
				cb_getResponseString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseString);
			return cb_getResponseString;
		}

		static IntPtr n_GetResponseString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseString);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseString;
		public virtual string ResponseString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='getResponseString' and count(parameter)=0]"
			[Register ("getResponseString", "()Ljava/lang/String;", "GetGetResponseStringHandler")]
			get {
				if (id_getResponseString == IntPtr.Zero)
					id_getResponseString = JNIEnv.GetMethodID (class_ref, "getResponseString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getResponseString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getResponseString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTesting;
#pragma warning disable 0169
		static Delegate GetGetTestingHandler ()
		{
			if (cb_getTesting == null)
				cb_getTesting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTesting);
			return cb_getTesting;
		}

		static bool n_GetTesting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Testing;
		}
#pragma warning restore 0169

		static Delegate cb_setTesting_Z;
#pragma warning disable 0169
		static Delegate GetSetTesting_ZHandler ()
		{
			if (cb_setTesting_Z == null)
				cb_setTesting_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTesting_Z);
			return cb_setTesting_Z;
		}

		static void n_SetTesting_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Testing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTesting;
		static IntPtr id_setTesting_Z;
		public virtual bool Testing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='getTesting' and count(parameter)=0]"
			[Register ("getTesting", "()Z", "GetGetTestingHandler")]
			get {
				if (id_getTesting == IntPtr.Zero)
					id_getTesting = JNIEnv.GetMethodID (class_ref, "getTesting", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getTesting);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getTesting);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='setTesting' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTesting", "(Z)V", "GetSetTesting_ZHandler")]
			set {
				if (id_setTesting_Z == IntPtr.Zero)
					id_setTesting_Z = JNIEnv.GetMethodID (class_ref, "setTesting", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTesting_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTesting_Z, new JValue (value));
			}
		}

		static Delegate cb_customEventActionWillBegin;
#pragma warning disable 0169
		static Delegate GetCustomEventActionWillBeginHandler ()
		{
			if (cb_customEventActionWillBegin == null)
				cb_customEventActionWillBegin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CustomEventActionWillBegin);
			return cb_customEventActionWillBegin;
		}

		static void n_CustomEventActionWillBegin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.CustomEventActionWillBegin ();
		}
#pragma warning restore 0169

		static IntPtr id_customEventActionWillBegin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='customEventActionWillBegin' and count(parameter)=0]"
		[Register ("customEventActionWillBegin", "()V", "GetCustomEventActionWillBeginHandler")]
		public virtual void CustomEventActionWillBegin ()
		{
			if (id_customEventActionWillBegin == IntPtr.Zero)
				id_customEventActionWillBegin = JNIEnv.GetMethodID (class_ref, "customEventActionWillBegin", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_customEventActionWillBegin);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_customEventActionWillBegin);
		}

		static Delegate cb_customEventDidFailToLoadAd;
#pragma warning disable 0169
		static Delegate GetCustomEventDidFailToLoadAdHandler ()
		{
			if (cb_customEventDidFailToLoadAd == null)
				cb_customEventDidFailToLoadAd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CustomEventDidFailToLoadAd);
			return cb_customEventDidFailToLoadAd;
		}

		static void n_CustomEventDidFailToLoadAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.CustomEventDidFailToLoadAd ();
		}
#pragma warning restore 0169

		static IntPtr id_customEventDidFailToLoadAd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='customEventDidFailToLoadAd' and count(parameter)=0]"
		[Register ("customEventDidFailToLoadAd", "()V", "GetCustomEventDidFailToLoadAdHandler")]
		public virtual void CustomEventDidFailToLoadAd ()
		{
			if (id_customEventDidFailToLoadAd == IntPtr.Zero)
				id_customEventDidFailToLoadAd = JNIEnv.GetMethodID (class_ref, "customEventDidFailToLoadAd", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_customEventDidFailToLoadAd);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_customEventDidFailToLoadAd);
		}

		static Delegate cb_customEventDidLoadAd;
#pragma warning disable 0169
		static Delegate GetCustomEventDidLoadAdHandler ()
		{
			if (cb_customEventDidLoadAd == null)
				cb_customEventDidLoadAd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CustomEventDidLoadAd);
			return cb_customEventDidLoadAd;
		}

		static void n_CustomEventDidLoadAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.CustomEventDidLoadAd ();
		}
#pragma warning restore 0169

		static IntPtr id_customEventDidLoadAd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='customEventDidLoadAd' and count(parameter)=0]"
		[Register ("customEventDidLoadAd", "()V", "GetCustomEventDidLoadAdHandler")]
		public virtual void CustomEventDidLoadAd ()
		{
			if (id_customEventDidLoadAd == IntPtr.Zero)
				id_customEventDidLoadAd = JNIEnv.GetMethodID (class_ref, "customEventDidLoadAd", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_customEventDidLoadAd);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_customEventDidLoadAd);
		}

		static Delegate cb_loadAd;
#pragma warning disable 0169
		static Delegate GetLoadAdHandler ()
		{
			if (cb_loadAd == null)
				cb_loadAd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadAd);
			return cb_loadAd;
		}

		static void n_LoadAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadAd ();
		}
#pragma warning restore 0169

		static IntPtr id_loadAd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='loadAd' and count(parameter)=0]"
		[Register ("loadAd", "()V", "GetLoadAdHandler")]
		public virtual void LoadAd ()
		{
			if (id_loadAd == IntPtr.Zero)
				id_loadAd = JNIEnv.GetMethodID (class_ref, "loadAd", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadAd);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadAd);
		}

		static Delegate cb_reload;
#pragma warning disable 0169
		static Delegate GetReloadHandler ()
		{
			if (cb_reload == null)
				cb_reload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reload);
			return cb_reload;
		}

		static void n_Reload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reload ();
		}
#pragma warning restore 0169

		static IntPtr id_reload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='reload' and count(parameter)=0]"
		[Register ("reload", "()V", "GetReloadHandler")]
		public virtual void Reload ()
		{
			if (id_reload == IntPtr.Zero)
				id_reload = JNIEnv.GetMethodID (class_ref, "reload", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_reload);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_reload);
		}

		static IntPtr id_setShouldHonorServerDimensions_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='setShouldHonorServerDimensions' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setShouldHonorServerDimensions", "(Landroid/view/View;)V", "")]
		protected static void SetShouldHonorServerDimensions (global::Android.Views.View p0)
		{
			if (id_setShouldHonorServerDimensions_Landroid_view_View_ == IntPtr.Zero)
				id_setShouldHonorServerDimensions_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "setShouldHonorServerDimensions", "(Landroid/view/View;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setShouldHonorServerDimensions_Landroid_view_View_, new JValue (p0));
		}

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Mobileads.AdViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdViewController']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
		public virtual void SetTimeout (int p0)
		{
			if (id_setTimeout_I == IntPtr.Zero)
				id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTimeout_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTimeout_I, new JValue (p0));
		}

	}
}
