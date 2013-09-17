using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubView", DoNotGenerateAcw=true)]
	public partial class MoPubView : global::Android.Widget.FrameLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/field[@name='AD_HANDLER']"
		[Register ("AD_HANDLER")]
		public const string AdHandler = (string) "/m/ad";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/field[@name='DEFAULT_LOCATION_PRECISION']"
		[Register ("DEFAULT_LOCATION_PRECISION")]
		public const int DefaultLocationPrecision = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/field[@name='HOST']"
		[Register ("HOST")]
		public const string Host = (string) "ads.mopub.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/field[@name='HOST_FOR_TESTING']"
		[Register ("HOST_FOR_TESTING")]
		public const string HostForTesting = (string) "testing.ads.mopub.com";

		static IntPtr mAdViewController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/field[@name='mAdViewController']"
		[Register ("mAdViewController")]
		protected global::Com.Mopub.Mobileads.AdViewController MAdViewController {
			get {
				if (mAdViewController_jfieldId == IntPtr.Zero)
					mAdViewController_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdViewController", "Lcom/mopub/mobileads/AdViewController;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mAdViewController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAdViewController_jfieldId == IntPtr.Zero)
					mAdViewController_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdViewController", "Lcom/mopub/mobileads/AdViewController;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mAdViewController_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mCustomEventBannerAdapter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/field[@name='mCustomEventBannerAdapter']"
		[Register ("mCustomEventBannerAdapter")]
		protected global::Com.Mopub.Mobileads.CustomEventBannerAdapter MCustomEventBannerAdapter {
			get {
				if (mCustomEventBannerAdapter_jfieldId == IntPtr.Zero)
					mCustomEventBannerAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mCustomEventBannerAdapter", "Lcom/mopub/mobileads/CustomEventBannerAdapter;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCustomEventBannerAdapter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBannerAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCustomEventBannerAdapter_jfieldId == IntPtr.Zero)
					mCustomEventBannerAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mCustomEventBannerAdapter", "Lcom/mopub/mobileads/CustomEventBannerAdapter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCustomEventBannerAdapter_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']"
		[Register ("com/mopub/mobileads/MoPubView$BannerAdListener", "", "Com.Mopub.Mobileads.MoPubView/IBannerAdListenerInvoker")]
		public partial interface IBannerAdListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']/method[@name='onBannerClicked' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("onBannerClicked", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerClicked_Lcom_mopub_mobileads_MoPubView_Handler:Com.Mopub.Mobileads.MoPubView/IBannerAdListenerInvoker, Mopub")]
			void OnBannerClicked (global::Com.Mopub.Mobileads.MoPubView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']/method[@name='onBannerCollapsed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("onBannerCollapsed", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_Handler:Com.Mopub.Mobileads.MoPubView/IBannerAdListenerInvoker, Mopub")]
			void OnBannerCollapsed (global::Com.Mopub.Mobileads.MoPubView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']/method[@name='onBannerExpanded' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("onBannerExpanded", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerExpanded_Lcom_mopub_mobileads_MoPubView_Handler:Com.Mopub.Mobileads.MoPubView/IBannerAdListenerInvoker, Mopub")]
			void OnBannerExpanded (global::Com.Mopub.Mobileads.MoPubView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']/method[@name='onBannerFailed' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.MoPubView'] and parameter[2][@type='com.mopub.mobileads.MoPubErrorCode']]"
			[Register ("onBannerFailed", "(Lcom/mopub/mobileads/MoPubView;Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_Handler:Com.Mopub.Mobileads.MoPubView/IBannerAdListenerInvoker, Mopub")]
			void OnBannerFailed (global::Com.Mopub.Mobileads.MoPubView p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']/method[@name='onBannerLoaded' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("onBannerLoaded", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerLoaded_Lcom_mopub_mobileads_MoPubView_Handler:Com.Mopub.Mobileads.MoPubView/IBannerAdListenerInvoker, Mopub")]
			void OnBannerLoaded (global::Com.Mopub.Mobileads.MoPubView p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubView$BannerAdListener", DoNotGenerateAcw=true)]
		internal class IBannerAdListenerInvoker : global::Java.Lang.Object, IBannerAdListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MoPubView$BannerAdListener");
			IntPtr class_ref;

			public static IBannerAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBannerAdListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MoPubView.BannerAdListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBannerAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IBannerAdListenerInvoker); }
			}

			static Delegate cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnBannerClicked_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerClicked_Lcom_mopub_mobileads_MoPubView_);
				return cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnBannerClicked_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerClicked (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_;
			public void OnBannerClicked (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				if (id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerClicked", "(Lcom/mopub/mobileads/MoPubView;)V");
				JNIEnv.CallVoidMethod (Handle, id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_, new JValue (p0));
			}

			static Delegate cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_);
				return cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerCollapsed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_;
			public void OnBannerCollapsed (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				if (id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerCollapsed", "(Lcom/mopub/mobileads/MoPubView;)V");
				JNIEnv.CallVoidMethod (Handle, id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_, new JValue (p0));
			}

			static Delegate cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnBannerExpanded_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerExpanded_Lcom_mopub_mobileads_MoPubView_);
				return cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnBannerExpanded_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerExpanded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_;
			public void OnBannerExpanded (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				if (id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerExpanded", "(Lcom/mopub/mobileads/MoPubView;)V");
				JNIEnv.CallVoidMethod (Handle, id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_, new JValue (p0));
			}

			static Delegate cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
			{
				if (cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
					cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_);
				return cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_;
			}

			static void n_OnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerFailed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_;
			public void OnBannerFailed (global::Com.Mopub.Mobileads.MoPubView p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
			{
				if (id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
					id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onBannerFailed", "(Lcom/mopub/mobileads/MoPubView;Lcom/mopub/mobileads/MoPubErrorCode;)V");
				JNIEnv.CallVoidMethod (Handle, id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnBannerLoaded_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerLoaded_Lcom_mopub_mobileads_MoPubView_);
				return cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnBannerLoaded_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerLoaded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_;
			public void OnBannerLoaded (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				if (id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerLoaded", "(Lcom/mopub/mobileads/MoPubView;)V");
				JNIEnv.CallVoidMethod (Handle, id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_, new JValue (p0));
			}

		}

		public partial class BannerClickedEventArgs : global::System.EventArgs {

			public BannerClickedEventArgs (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubView p0;
			public global::Com.Mopub.Mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		public partial class BannerCollapsedEventArgs : global::System.EventArgs {

			public BannerCollapsedEventArgs (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubView p0;
			public global::Com.Mopub.Mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		public partial class BannerExpandedEventArgs : global::System.EventArgs {

			public BannerExpandedEventArgs (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubView p0;
			public global::Com.Mopub.Mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		public partial class BannerFailedEventArgs : global::System.EventArgs {

			public BannerFailedEventArgs (global::Com.Mopub.Mobileads.MoPubView p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Mopub.Mobileads.MoPubView p0;
			public global::Com.Mopub.Mobileads.MoPubView P0 {
				get { return p0; }
			}

			global::Com.Mopub.Mobileads.MoPubErrorCode p1;
			public global::Com.Mopub.Mobileads.MoPubErrorCode P1 {
				get { return p1; }
			}
		}

		public partial class BannerLoadedEventArgs : global::System.EventArgs {

			public BannerLoadedEventArgs (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubView p0;
			public global::Com.Mopub.Mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MoPubView_BannerAdListenerImplementor")]
		internal sealed class IBannerAdListenerImplementor : global::Java.Lang.Object, IBannerAdListener {

			object sender;

			public IBannerAdListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MoPubView_BannerAdListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BannerClickedEventArgs> OnBannerClickedHandler;
#pragma warning restore 0649

			public void OnBannerClicked (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				var __h = OnBannerClickedHandler;
				if (__h != null)
					__h (sender, new BannerClickedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<BannerCollapsedEventArgs> OnBannerCollapsedHandler;
#pragma warning restore 0649

			public void OnBannerCollapsed (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				var __h = OnBannerCollapsedHandler;
				if (__h != null)
					__h (sender, new BannerCollapsedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<BannerExpandedEventArgs> OnBannerExpandedHandler;
#pragma warning restore 0649

			public void OnBannerExpanded (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				var __h = OnBannerExpandedHandler;
				if (__h != null)
					__h (sender, new BannerExpandedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<BannerFailedEventArgs> OnBannerFailedHandler;
#pragma warning restore 0649

			public void OnBannerFailed (global::Com.Mopub.Mobileads.MoPubView p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
			{
				var __h = OnBannerFailedHandler;
				if (__h != null)
					__h (sender, new BannerFailedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<BannerLoadedEventArgs> OnBannerLoadedHandler;
#pragma warning restore 0649

			public void OnBannerLoaded (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				var __h = OnBannerLoadedHandler;
				if (__h != null)
					__h (sender, new BannerLoadedEventArgs (p0));
			}

			internal static bool __IsEmpty (IBannerAdListenerImplementor value)
			{
				return value.OnBannerClickedHandler == null && value.OnBannerCollapsedHandler == null && value.OnBannerExpandedHandler == null && value.OnBannerFailedHandler == null && value.OnBannerLoadedHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView.LocationAwareness']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubView$LocationAwareness", DoNotGenerateAcw=true)]
		public sealed partial class LocationAwareness : global::Java.Lang.Enum {


			static IntPtr LOCATION_AWARENESS_DISABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView.LocationAwareness']/field[@name='LOCATION_AWARENESS_DISABLED']"
			[Register ("LOCATION_AWARENESS_DISABLED")]
			public static global::Com.Mopub.Mobileads.MoPubView.LocationAwareness LocationAwarenessDisabled {
				get {
					if (LOCATION_AWARENESS_DISABLED_jfieldId == IntPtr.Zero)
						LOCATION_AWARENESS_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_AWARENESS_DISABLED", "Lcom/mopub/mobileads/MoPubView$LocationAwareness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCATION_AWARENESS_DISABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.LocationAwareness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LOCATION_AWARENESS_DISABLED_jfieldId == IntPtr.Zero)
						LOCATION_AWARENESS_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_AWARENESS_DISABLED", "Lcom/mopub/mobileads/MoPubView$LocationAwareness;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LOCATION_AWARENESS_DISABLED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LOCATION_AWARENESS_NORMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView.LocationAwareness']/field[@name='LOCATION_AWARENESS_NORMAL']"
			[Register ("LOCATION_AWARENESS_NORMAL")]
			public static global::Com.Mopub.Mobileads.MoPubView.LocationAwareness LocationAwarenessNormal {
				get {
					if (LOCATION_AWARENESS_NORMAL_jfieldId == IntPtr.Zero)
						LOCATION_AWARENESS_NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_AWARENESS_NORMAL", "Lcom/mopub/mobileads/MoPubView$LocationAwareness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCATION_AWARENESS_NORMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.LocationAwareness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LOCATION_AWARENESS_NORMAL_jfieldId == IntPtr.Zero)
						LOCATION_AWARENESS_NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_AWARENESS_NORMAL", "Lcom/mopub/mobileads/MoPubView$LocationAwareness;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LOCATION_AWARENESS_NORMAL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LOCATION_AWARENESS_TRUNCATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView.LocationAwareness']/field[@name='LOCATION_AWARENESS_TRUNCATED']"
			[Register ("LOCATION_AWARENESS_TRUNCATED")]
			public static global::Com.Mopub.Mobileads.MoPubView.LocationAwareness LocationAwarenessTruncated {
				get {
					if (LOCATION_AWARENESS_TRUNCATED_jfieldId == IntPtr.Zero)
						LOCATION_AWARENESS_TRUNCATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_AWARENESS_TRUNCATED", "Lcom/mopub/mobileads/MoPubView$LocationAwareness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCATION_AWARENESS_TRUNCATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.LocationAwareness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LOCATION_AWARENESS_TRUNCATED_jfieldId == IntPtr.Zero)
						LOCATION_AWARENESS_TRUNCATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_AWARENESS_TRUNCATED", "Lcom/mopub/mobileads/MoPubView$LocationAwareness;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LOCATION_AWARENESS_TRUNCATED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MoPubView$LocationAwareness", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LocationAwareness); }
			}

			internal LocationAwareness (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView.LocationAwareness']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MoPubView$LocationAwareness;", "")]
			public static global::Com.Mopub.Mobileads.MoPubView.LocationAwareness ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/MoPubView$LocationAwareness;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Mopub.Mobileads.MoPubView.LocationAwareness __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.LocationAwareness> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView.LocationAwareness']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/mobileads/MoPubView$LocationAwareness;", "")]
			public static global::Com.Mopub.Mobileads.MoPubView.LocationAwareness[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mobileads/MoPubView$LocationAwareness;");
				return (global::Com.Mopub.Mobileads.MoPubView.LocationAwareness[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mobileads.MoPubView.LocationAwareness));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdClickedListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("com/mopub/mobileads/MoPubView$OnAdClickedListener", "", "Com.Mopub.Mobileads.MoPubView/IOnAdClickedListenerInvoker")]
		public partial interface IOnAdClickedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdClickedListener']/method[@name='OnAdClicked' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("OnAdClicked", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnAdClicked_Lcom_mopub_mobileads_MoPubView_Handler:Com.Mopub.Mobileads.MoPubView/IOnAdClickedListenerInvoker, Mopub")]
			void OnAdClicked (global::Com.Mopub.Mobileads.MoPubView p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubView$OnAdClickedListener", DoNotGenerateAcw=true)]
		internal class IOnAdClickedListenerInvoker : global::Java.Lang.Object, IOnAdClickedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MoPubView$OnAdClickedListener");
			IntPtr class_ref;

			public static IOnAdClickedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAdClickedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MoPubView.OnAdClickedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAdClickedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnAdClickedListenerInvoker); }
			}

			static Delegate cb_OnAdClicked_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnAdClicked_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_OnAdClicked_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_OnAdClicked_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdClicked_Lcom_mopub_mobileads_MoPubView_);
				return cb_OnAdClicked_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnAdClicked_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAdClicked (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnAdClicked_Lcom_mopub_mobileads_MoPubView_;
			public void OnAdClicked (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				if (id_OnAdClicked_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_OnAdClicked_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "OnAdClicked", "(Lcom/mopub/mobileads/MoPubView;)V");
				JNIEnv.CallVoidMethod (Handle, id_OnAdClicked_Lcom_mopub_mobileads_MoPubView_, new JValue (p0));
			}

		}

		public partial class AdClickedEventArgs : global::System.EventArgs {

			public AdClickedEventArgs (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubView p0;
			public global::Com.Mopub.Mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MoPubView_OnAdClickedListenerImplementor")]
		internal sealed class IOnAdClickedListenerImplementor : global::Java.Lang.Object, IOnAdClickedListener {

			object sender;

			public IOnAdClickedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MoPubView_OnAdClickedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AdClickedEventArgs> Handler;
#pragma warning restore 0649

			public void OnAdClicked (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AdClickedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnAdClickedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdClosedListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("com/mopub/mobileads/MoPubView$OnAdClosedListener", "", "Com.Mopub.Mobileads.MoPubView/IOnAdClosedListenerInvoker")]
		public partial interface IOnAdClosedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdClosedListener']/method[@name='OnAdClosed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("OnAdClosed", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnAdClosed_Lcom_mopub_mobileads_MoPubView_Handler:Com.Mopub.Mobileads.MoPubView/IOnAdClosedListenerInvoker, Mopub")]
			void OnAdClosed (global::Com.Mopub.Mobileads.MoPubView p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubView$OnAdClosedListener", DoNotGenerateAcw=true)]
		internal class IOnAdClosedListenerInvoker : global::Java.Lang.Object, IOnAdClosedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MoPubView$OnAdClosedListener");
			IntPtr class_ref;

			public static IOnAdClosedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAdClosedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MoPubView.OnAdClosedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAdClosedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnAdClosedListenerInvoker); }
			}

			static Delegate cb_OnAdClosed_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnAdClosed_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_OnAdClosed_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_OnAdClosed_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdClosed_Lcom_mopub_mobileads_MoPubView_);
				return cb_OnAdClosed_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnAdClosed_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAdClosed (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnAdClosed_Lcom_mopub_mobileads_MoPubView_;
			public void OnAdClosed (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				if (id_OnAdClosed_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_OnAdClosed_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "OnAdClosed", "(Lcom/mopub/mobileads/MoPubView;)V");
				JNIEnv.CallVoidMethod (Handle, id_OnAdClosed_Lcom_mopub_mobileads_MoPubView_, new JValue (p0));
			}

		}

		public partial class AdClosedEventArgs : global::System.EventArgs {

			public AdClosedEventArgs (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubView p0;
			public global::Com.Mopub.Mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MoPubView_OnAdClosedListenerImplementor")]
		internal sealed class IOnAdClosedListenerImplementor : global::Java.Lang.Object, IOnAdClosedListener {

			object sender;

			public IOnAdClosedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MoPubView_OnAdClosedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AdClosedEventArgs> Handler;
#pragma warning restore 0649

			public void OnAdClosed (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AdClosedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnAdClosedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdFailedListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("com/mopub/mobileads/MoPubView$OnAdFailedListener", "", "Com.Mopub.Mobileads.MoPubView/IOnAdFailedListenerInvoker")]
		public partial interface IOnAdFailedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdFailedListener']/method[@name='OnAdFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("OnAdFailed", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnAdFailed_Lcom_mopub_mobileads_MoPubView_Handler:Com.Mopub.Mobileads.MoPubView/IOnAdFailedListenerInvoker, Mopub")]
			void OnAdFailed (global::Com.Mopub.Mobileads.MoPubView p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubView$OnAdFailedListener", DoNotGenerateAcw=true)]
		internal class IOnAdFailedListenerInvoker : global::Java.Lang.Object, IOnAdFailedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MoPubView$OnAdFailedListener");
			IntPtr class_ref;

			public static IOnAdFailedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAdFailedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MoPubView.OnAdFailedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAdFailedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnAdFailedListenerInvoker); }
			}

			static Delegate cb_OnAdFailed_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnAdFailed_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_OnAdFailed_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_OnAdFailed_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdFailed_Lcom_mopub_mobileads_MoPubView_);
				return cb_OnAdFailed_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnAdFailed_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAdFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnAdFailed_Lcom_mopub_mobileads_MoPubView_;
			public void OnAdFailed (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				if (id_OnAdFailed_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_OnAdFailed_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "OnAdFailed", "(Lcom/mopub/mobileads/MoPubView;)V");
				JNIEnv.CallVoidMethod (Handle, id_OnAdFailed_Lcom_mopub_mobileads_MoPubView_, new JValue (p0));
			}

		}

		public partial class AdFailedEventArgs : global::System.EventArgs {

			public AdFailedEventArgs (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubView p0;
			public global::Com.Mopub.Mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MoPubView_OnAdFailedListenerImplementor")]
		internal sealed class IOnAdFailedListenerImplementor : global::Java.Lang.Object, IOnAdFailedListener {

			object sender;

			public IOnAdFailedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MoPubView_OnAdFailedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AdFailedEventArgs> Handler;
#pragma warning restore 0649

			public void OnAdFailed (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AdFailedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnAdFailedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdLoadedListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("com/mopub/mobileads/MoPubView$OnAdLoadedListener", "", "Com.Mopub.Mobileads.MoPubView/IOnAdLoadedListenerInvoker")]
		public partial interface IOnAdLoadedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdLoadedListener']/method[@name='OnAdLoaded' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("OnAdLoaded", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnAdLoaded_Lcom_mopub_mobileads_MoPubView_Handler:Com.Mopub.Mobileads.MoPubView/IOnAdLoadedListenerInvoker, Mopub")]
			void OnAdLoaded (global::Com.Mopub.Mobileads.MoPubView p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubView$OnAdLoadedListener", DoNotGenerateAcw=true)]
		internal class IOnAdLoadedListenerInvoker : global::Java.Lang.Object, IOnAdLoadedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MoPubView$OnAdLoadedListener");
			IntPtr class_ref;

			public static IOnAdLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAdLoadedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MoPubView.OnAdLoadedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAdLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnAdLoadedListenerInvoker); }
			}

			static Delegate cb_OnAdLoaded_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnAdLoaded_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_OnAdLoaded_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_OnAdLoaded_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdLoaded_Lcom_mopub_mobileads_MoPubView_);
				return cb_OnAdLoaded_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnAdLoaded_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAdLoaded (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnAdLoaded_Lcom_mopub_mobileads_MoPubView_;
			public void OnAdLoaded (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				if (id_OnAdLoaded_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_OnAdLoaded_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "OnAdLoaded", "(Lcom/mopub/mobileads/MoPubView;)V");
				JNIEnv.CallVoidMethod (Handle, id_OnAdLoaded_Lcom_mopub_mobileads_MoPubView_, new JValue (p0));
			}

		}

		public partial class AdLoadedEventArgs : global::System.EventArgs {

			public AdLoadedEventArgs (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubView p0;
			public global::Com.Mopub.Mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MoPubView_OnAdLoadedListenerImplementor")]
		internal sealed class IOnAdLoadedListenerImplementor : global::Java.Lang.Object, IOnAdLoadedListener {

			object sender;

			public IOnAdLoadedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MoPubView_OnAdLoadedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AdLoadedEventArgs> Handler;
#pragma warning restore 0649

			public void OnAdLoaded (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AdLoadedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnAdLoadedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdPresentedOverlayListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("com/mopub/mobileads/MoPubView$OnAdPresentedOverlayListener", "", "Com.Mopub.Mobileads.MoPubView/IOnAdPresentedOverlayListenerInvoker")]
		public partial interface IOnAdPresentedOverlayListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdPresentedOverlayListener']/method[@name='OnAdPresentedOverlay' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("OnAdPresentedOverlay", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_Handler:Com.Mopub.Mobileads.MoPubView/IOnAdPresentedOverlayListenerInvoker, Mopub")]
			void OnAdPresentedOverlay (global::Com.Mopub.Mobileads.MoPubView p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubView$OnAdPresentedOverlayListener", DoNotGenerateAcw=true)]
		internal class IOnAdPresentedOverlayListenerInvoker : global::Java.Lang.Object, IOnAdPresentedOverlayListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MoPubView$OnAdPresentedOverlayListener");
			IntPtr class_ref;

			public static IOnAdPresentedOverlayListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAdPresentedOverlayListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MoPubView.OnAdPresentedOverlayListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAdPresentedOverlayListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnAdPresentedOverlayListenerInvoker); }
			}

			static Delegate cb_OnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_OnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_OnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_);
				return cb_OnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAdPresentedOverlay (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_;
			public void OnAdPresentedOverlay (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				if (id_OnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_OnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "OnAdPresentedOverlay", "(Lcom/mopub/mobileads/MoPubView;)V");
				JNIEnv.CallVoidMethod (Handle, id_OnAdPresentedOverlay_Lcom_mopub_mobileads_MoPubView_, new JValue (p0));
			}

		}

		public partial class AdPresentedOverlayEventArgs : global::System.EventArgs {

			public AdPresentedOverlayEventArgs (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubView p0;
			public global::Com.Mopub.Mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MoPubView_OnAdPresentedOverlayListenerImplementor")]
		internal sealed class IOnAdPresentedOverlayListenerImplementor : global::Java.Lang.Object, IOnAdPresentedOverlayListener {

			object sender;

			public IOnAdPresentedOverlayListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MoPubView_OnAdPresentedOverlayListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AdPresentedOverlayEventArgs> Handler;
#pragma warning restore 0649

			public void OnAdPresentedOverlay (global::Com.Mopub.Mobileads.MoPubView p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AdPresentedOverlayEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnAdPresentedOverlayListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdWillLoadListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("com/mopub/mobileads/MoPubView$OnAdWillLoadListener", "", "Com.Mopub.Mobileads.MoPubView/IOnAdWillLoadListenerInvoker")]
		public partial interface IOnAdWillLoadListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.OnAdWillLoadListener']/method[@name='OnAdWillLoad' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.MoPubView'] and parameter[2][@type='java.lang.String']]"
			[Register ("OnAdWillLoad", "(Lcom/mopub/mobileads/MoPubView;Ljava/lang/String;)V", "GetOnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Handler:Com.Mopub.Mobileads.MoPubView/IOnAdWillLoadListenerInvoker, Mopub")]
			void OnAdWillLoad (global::Com.Mopub.Mobileads.MoPubView p0, string p1);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubView$OnAdWillLoadListener", DoNotGenerateAcw=true)]
		internal class IOnAdWillLoadListenerInvoker : global::Java.Lang.Object, IOnAdWillLoadListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MoPubView$OnAdWillLoadListener");
			IntPtr class_ref;

			public static IOnAdWillLoadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAdWillLoadListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MoPubView.OnAdWillLoadListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAdWillLoadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnAdWillLoadListenerInvoker); }
			}

			static Delegate cb_OnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_Handler ()
			{
				if (cb_OnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_ == null)
					cb_OnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_);
				return cb_OnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_;
			}

			static void n_OnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnAdWillLoad (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_;
			public void OnAdWillLoad (global::Com.Mopub.Mobileads.MoPubView p0, string p1)
			{
				if (id_OnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_ == IntPtr.Zero)
					id_OnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnAdWillLoad", "(Lcom/mopub/mobileads/MoPubView;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JNIEnv.CallVoidMethod (Handle, id_OnAdWillLoad_Lcom_mopub_mobileads_MoPubView_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		public partial class AdWillLoadEventArgs : global::System.EventArgs {

			public AdWillLoadEventArgs (global::Com.Mopub.Mobileads.MoPubView p0, string p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Mopub.Mobileads.MoPubView p0;
			public global::Com.Mopub.Mobileads.MoPubView P0 {
				get { return p0; }
			}

			string p1;
			public string P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MoPubView_OnAdWillLoadListenerImplementor")]
		internal sealed class IOnAdWillLoadListenerImplementor : global::Java.Lang.Object, IOnAdWillLoadListener {

			object sender;

			public IOnAdWillLoadListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MoPubView_OnAdWillLoadListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AdWillLoadEventArgs> Handler;
#pragma warning restore 0649

			public void OnAdWillLoad (global::Com.Mopub.Mobileads.MoPubView p0, string p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AdWillLoadEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnAdWillLoadListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MoPubView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubView); }
		}

		protected MoPubView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/constructor[@name='MoPubView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public MoPubView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MoPubView)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/constructor[@name='MoPubView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public MoPubView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MoPubView)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getActivity;
#pragma warning disable 0169
		static Delegate GetGetActivityHandler ()
		{
			if (cb_getActivity == null)
				cb_getActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivity);
			return cb_getActivity;
		}

		static IntPtr n_GetActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		static IntPtr id_getActivity;
		public virtual global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get {
				if (id_getActivity == IntPtr.Zero)
					id_getActivity = JNIEnv.GetMethodID (class_ref, "getActivity", "()Landroid/app/Activity;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallObjectMethod  (Handle, id_getActivity), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getActivity), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getAdHeight;
		public virtual int AdHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getAdHeight' and count(parameter)=0]"
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getAdWidth;
		public virtual int AdWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getAdWidth' and count(parameter)=0]"
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutorefreshEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAutorefreshEnabled;
		static IntPtr id_setAutorefreshEnabled_Z;
		public virtual bool AutorefreshEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getAutorefreshEnabled' and count(parameter)=0]"
			[Register ("getAutorefreshEnabled", "()Z", "GetGetAutorefreshEnabledHandler")]
			get {
				if (id_getAutorefreshEnabled == IntPtr.Zero)
					id_getAutorefreshEnabled = JNIEnv.GetMethodID (class_ref, "getAutorefreshEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getAutorefreshEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getAutorefreshEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setAutorefreshEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_getBannerAdListener;
#pragma warning disable 0169
		static Delegate GetGetBannerAdListenerHandler ()
		{
			if (cb_getBannerAdListener == null)
				cb_getBannerAdListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBannerAdListener);
			return cb_getBannerAdListener;
		}

		static IntPtr n_GetBannerAdListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BannerAdListener);
		}
#pragma warning restore 0169

		static Delegate cb_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_;
#pragma warning disable 0169
		static Delegate GetSetBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_Handler ()
		{
			if (cb_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_ == null)
				cb_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_);
			return cb_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_;
		}

		static void n_SetBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener p0 = (global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BannerAdListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBannerAdListener;
		static IntPtr id_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_;
		public virtual global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener BannerAdListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getBannerAdListener' and count(parameter)=0]"
			[Register ("getBannerAdListener", "()Lcom/mopub/mobileads/MoPubView$BannerAdListener;", "GetGetBannerAdListenerHandler")]
			get {
				if (id_getBannerAdListener == IntPtr.Zero)
					id_getBannerAdListener = JNIEnv.GetMethodID (class_ref, "getBannerAdListener", "()Lcom/mopub/mobileads/MoPubView$BannerAdListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener> (JNIEnv.CallObjectMethod  (Handle, id_getBannerAdListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getBannerAdListener), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setBannerAdListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView.BannerAdListener']]"
			[Register ("setBannerAdListener", "(Lcom/mopub/mobileads/MoPubView$BannerAdListener;)V", "GetSetBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_Handler")]
			set {
				if (id_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_ == IntPtr.Zero)
					id_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_ = JNIEnv.GetMethodID (class_ref, "setBannerAdListener", "(Lcom/mopub/mobileads/MoPubView$BannerAdListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_, new JValue (value));
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClickthroughUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClickthroughUrl;
		static IntPtr id_setClickthroughUrl_Ljava_lang_String_;
		public virtual string ClickthroughUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getClickthroughUrl' and count(parameter)=0]"
			[Register ("getClickthroughUrl", "()Ljava/lang/String;", "GetGetClickthroughUrlHandler")]
			get {
				if (id_getClickthroughUrl == IntPtr.Zero)
					id_getClickthroughUrl = JNIEnv.GetMethodID (class_ref, "getClickthroughUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClickthroughUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getClickthroughUrl), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setClickthroughUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Keywords = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKeywords;
		static IntPtr id_setKeywords_Ljava_lang_String_;
		public virtual string Keywords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getKeywords' and count(parameter)=0]"
			[Register ("getKeywords", "()Ljava/lang/String;", "GetGetKeywordsHandler")]
			get {
				if (id_getKeywords == IntPtr.Zero)
					id_getKeywords = JNIEnv.GetMethodID (class_ref, "getKeywords", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKeywords), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getKeywords), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setKeywords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getLocalExtras;
#pragma warning disable 0169
		static Delegate GetGetLocalExtrasHandler ()
		{
			if (cb_getLocalExtras == null)
				cb_getLocalExtras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalExtras);
			return cb_getLocalExtras;
		}

		static IntPtr n_GetLocalExtras (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.LocalExtras);
		}
#pragma warning restore 0169

		static Delegate cb_setLocalExtras_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetLocalExtras_Ljava_util_Map_Handler ()
		{
			if (cb_setLocalExtras_Ljava_util_Map_ == null)
				cb_setLocalExtras_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocalExtras_Ljava_util_Map_);
			return cb_setLocalExtras_Ljava_util_Map_;
		}

		static void n_SetLocalExtras_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalExtras = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalExtras;
		static IntPtr id_setLocalExtras_Ljava_util_Map_;
		public virtual global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> LocalExtras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getLocalExtras' and count(parameter)=0]"
			[Register ("getLocalExtras", "()Ljava/util/Map;", "GetGetLocalExtrasHandler")]
			get {
				if (id_getLocalExtras == IntPtr.Zero)
					id_getLocalExtras = JNIEnv.GetMethodID (class_ref, "getLocalExtras", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getLocalExtras), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocalExtras), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setLocalExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
			[Register ("setLocalExtras", "(Ljava/util/Map;)V", "GetSetLocalExtras_Ljava_util_Map_Handler")]
			set {
				if (id_setLocalExtras_Ljava_util_Map_ == IntPtr.Zero)
					id_setLocalExtras_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setLocalExtras", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocalExtras_Ljava_util_Map_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (value)));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLocalExtras_Ljava_util_Map_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (value)));
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Location = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Landroid_location_Location_;
		public virtual global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
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

		static Delegate cb_getLocationPrecision;
#pragma warning disable 0169
		static Delegate GetGetLocationPrecisionHandler ()
		{
			if (cb_getLocationPrecision == null)
				cb_getLocationPrecision = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLocationPrecision);
			return cb_getLocationPrecision;
		}

		static int n_GetLocationPrecision (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationPrecision;
		}
#pragma warning restore 0169

		static Delegate cb_setLocationPrecision_I;
#pragma warning disable 0169
		static Delegate GetSetLocationPrecision_IHandler ()
		{
			if (cb_setLocationPrecision_I == null)
				cb_setLocationPrecision_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLocationPrecision_I);
			return cb_setLocationPrecision_I;
		}

		static void n_SetLocationPrecision_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.LocationPrecision = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocationPrecision;
		static IntPtr id_setLocationPrecision_I;
		public virtual int LocationPrecision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getLocationPrecision' and count(parameter)=0]"
			[Register ("getLocationPrecision", "()I", "GetGetLocationPrecisionHandler")]
			get {
				if (id_getLocationPrecision == IntPtr.Zero)
					id_getLocationPrecision = JNIEnv.GetMethodID (class_ref, "getLocationPrecision", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLocationPrecision);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getLocationPrecision);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setLocationPrecision' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLocationPrecision", "(I)V", "GetSetLocationPrecision_IHandler")]
			set {
				if (id_setLocationPrecision_I == IntPtr.Zero)
					id_setLocationPrecision_I = JNIEnv.GetMethodID (class_ref, "setLocationPrecision", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocationPrecision_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLocationPrecision_I, new JValue (value));
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseString);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseString;
		public virtual string ResponseString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getResponseString' and count(parameter)=0]"
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Testing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTesting;
		static IntPtr id_setTesting_Z;
		public virtual bool Testing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getTesting' and count(parameter)=0]"
			[Register ("getTesting", "()Z", "GetGetTestingHandler")]
			get {
				if (id_getTesting == IntPtr.Zero)
					id_getTesting = JNIEnv.GetMethodID (class_ref, "getTesting", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getTesting);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getTesting);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setTesting' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_adClicked;
#pragma warning disable 0169
		static Delegate GetAdClickedHandler ()
		{
			if (cb_adClicked == null)
				cb_adClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdClicked);
			return cb_adClicked;
		}

		static void n_AdClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_adClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='adClicked' and count(parameter)=0]"
		[Register ("adClicked", "()V", "GetAdClickedHandler")]
		protected virtual void AdClicked ()
		{
			if (id_adClicked == IntPtr.Zero)
				id_adClicked = JNIEnv.GetMethodID (class_ref, "adClicked", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_adClicked);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_adClicked);
		}

		static Delegate cb_adClosed;
#pragma warning disable 0169
		static Delegate GetAdClosedHandler ()
		{
			if (cb_adClosed == null)
				cb_adClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdClosed);
			return cb_adClosed;
		}

		static void n_AdClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdClosed ();
		}
#pragma warning restore 0169

		static IntPtr id_adClosed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='adClosed' and count(parameter)=0]"
		[Register ("adClosed", "()V", "GetAdClosedHandler")]
		protected virtual void AdClosed ()
		{
			if (id_adClosed == IntPtr.Zero)
				id_adClosed = JNIEnv.GetMethodID (class_ref, "adClosed", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_adClosed);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_adClosed);
		}

		static Delegate cb_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetAdFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AdFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_AdFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='adFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("adFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetAdFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
		protected virtual void AdFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
		{
			if (id_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "adFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0));
		}

		static Delegate cb_adLoaded;
#pragma warning disable 0169
		static Delegate GetAdLoadedHandler ()
		{
			if (cb_adLoaded == null)
				cb_adLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdLoaded);
			return cb_adLoaded;
		}

		static void n_AdLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdLoaded ();
		}
#pragma warning restore 0169

		static IntPtr id_adLoaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='adLoaded' and count(parameter)=0]"
		[Register ("adLoaded", "()V", "GetAdLoadedHandler")]
		protected virtual void AdLoaded ()
		{
			if (id_adLoaded == IntPtr.Zero)
				id_adLoaded = JNIEnv.GetMethodID (class_ref, "adLoaded", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_adLoaded);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_adLoaded);
		}

		static Delegate cb_adPresentedOverlay;
#pragma warning disable 0169
		static Delegate GetAdPresentedOverlayHandler ()
		{
			if (cb_adPresentedOverlay == null)
				cb_adPresentedOverlay = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdPresentedOverlay);
			return cb_adPresentedOverlay;
		}

		static void n_AdPresentedOverlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdPresentedOverlay ();
		}
#pragma warning restore 0169

		static IntPtr id_adPresentedOverlay;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='adPresentedOverlay' and count(parameter)=0]"
		[Register ("adPresentedOverlay", "()V", "GetAdPresentedOverlayHandler")]
		protected virtual void AdPresentedOverlay ()
		{
			if (id_adPresentedOverlay == IntPtr.Zero)
				id_adPresentedOverlay = JNIEnv.GetMethodID (class_ref, "adPresentedOverlay", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_adPresentedOverlay);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_adPresentedOverlay);
		}

		static Delegate cb_adWillLoad_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdWillLoad_Ljava_lang_String_Handler ()
		{
			if (cb_adWillLoad_Ljava_lang_String_ == null)
				cb_adWillLoad_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AdWillLoad_Ljava_lang_String_);
			return cb_adWillLoad_Ljava_lang_String_;
		}

		static void n_AdWillLoad_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdWillLoad (p0);
		}
#pragma warning restore 0169

		static IntPtr id_adWillLoad_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='adWillLoad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("adWillLoad", "(Ljava/lang/String;)V", "GetAdWillLoad_Ljava_lang_String_Handler")]
		protected virtual void AdWillLoad (string p0)
		{
			if (id_adWillLoad_Ljava_lang_String_ == IntPtr.Zero)
				id_adWillLoad_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "adWillLoad", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_adWillLoad_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_adWillLoad_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.CustomEventActionWillBegin ();
		}
#pragma warning restore 0169

		static IntPtr id_customEventActionWillBegin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='customEventActionWillBegin' and count(parameter)=0]"
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.CustomEventDidFailToLoadAd ();
		}
#pragma warning restore 0169

		static IntPtr id_customEventDidFailToLoadAd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='customEventDidFailToLoadAd' and count(parameter)=0]"
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.CustomEventDidLoadAd ();
		}
#pragma warning restore 0169

		static IntPtr id_customEventDidLoadAd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='customEventDidLoadAd' and count(parameter)=0]"
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

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_destroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_destroy);
		}

		static Delegate cb_forceRefresh;
#pragma warning disable 0169
		static Delegate GetForceRefreshHandler ()
		{
			if (cb_forceRefresh == null)
				cb_forceRefresh = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ForceRefresh);
			return cb_forceRefresh;
		}

		static void n_ForceRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForceRefresh ();
		}
#pragma warning restore 0169

		static IntPtr id_forceRefresh;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='forceRefresh' and count(parameter)=0]"
		[Register ("forceRefresh", "()V", "GetForceRefreshHandler")]
		public virtual void ForceRefresh ()
		{
			if (id_forceRefresh == IntPtr.Zero)
				id_forceRefresh = JNIEnv.GetMethodID (class_ref, "forceRefresh", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_forceRefresh);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_forceRefresh);
		}

		static Delegate cb_getLocationAwareness;
#pragma warning disable 0169
		static Delegate GetGetLocationAwarenessHandler ()
		{
			if (cb_getLocationAwareness == null)
				cb_getLocationAwareness = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationAwareness);
			return cb_getLocationAwareness;
		}

		static IntPtr n_GetLocationAwareness (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetLocationAwareness ());
		}
#pragma warning restore 0169

		static IntPtr id_getLocationAwareness;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getLocationAwareness' and count(parameter)=0]"
		[Register ("getLocationAwareness", "()Lcom/mopub/mobileads/MoPubView$LocationAwareness;", "GetGetLocationAwarenessHandler")]
		public virtual global::Com.Mopub.Mobileads.MoPubView.LocationAwareness GetLocationAwareness ()
		{
			if (id_getLocationAwareness == IntPtr.Zero)
				id_getLocationAwareness = JNIEnv.GetMethodID (class_ref, "getLocationAwareness", "()Lcom/mopub/mobileads/MoPubView$LocationAwareness;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.LocationAwareness> (JNIEnv.CallObjectMethod  (Handle, id_getLocationAwareness), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.LocationAwareness> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocationAwareness), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadAd ();
		}
#pragma warning restore 0169

		static IntPtr id_loadAd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='loadAd' and count(parameter)=0]"
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

		static Delegate cb_loadCustomEvent_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadCustomEvent_Ljava_util_Map_Handler ()
		{
			if (cb_loadCustomEvent_Ljava_util_Map_ == null)
				cb_loadCustomEvent_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadCustomEvent_Ljava_util_Map_);
			return cb_loadCustomEvent_Ljava_util_Map_;
		}

		static void n_LoadCustomEvent_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadCustomEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadCustomEvent_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='loadCustomEvent' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("loadCustomEvent", "(Ljava/util/Map;)V", "GetLoadCustomEvent_Ljava_util_Map_Handler")]
		protected virtual void LoadCustomEvent (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_loadCustomEvent_Ljava_util_Map_ == IntPtr.Zero)
				id_loadCustomEvent_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadCustomEvent", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadCustomEvent_Ljava_util_Map_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadCustomEvent_Ljava_util_Map_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetLoadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_LoadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadFailUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='loadFailUrl' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("loadFailUrl", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetLoadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
		protected virtual void LoadFailUrl (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
		{
			if (id_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "loadFailUrl", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0));
		}

		static Delegate cb_nativeAdLoaded;
#pragma warning disable 0169
		static Delegate GetNativeAdLoadedHandler ()
		{
			if (cb_nativeAdLoaded == null)
				cb_nativeAdLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NativeAdLoaded);
			return cb_nativeAdLoaded;
		}

		static void n_NativeAdLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.NativeAdLoaded ();
		}
#pragma warning restore 0169

		static IntPtr id_nativeAdLoaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='nativeAdLoaded' and count(parameter)=0]"
		[Register ("nativeAdLoaded", "()V", "GetNativeAdLoadedHandler")]
		protected virtual void NativeAdLoaded ()
		{
			if (id_nativeAdLoaded == IntPtr.Zero)
				id_nativeAdLoaded = JNIEnv.GetMethodID (class_ref, "nativeAdLoaded", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_nativeAdLoaded);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_nativeAdLoaded);
		}

		static Delegate cb_registerClick;
#pragma warning disable 0169
		static Delegate GetRegisterClickHandler ()
		{
			if (cb_registerClick == null)
				cb_registerClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterClick);
			return cb_registerClick;
		}

		static void n_RegisterClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterClick ();
		}
#pragma warning restore 0169

		static IntPtr id_registerClick;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='registerClick' and count(parameter)=0]"
		[Register ("registerClick", "()V", "GetRegisterClickHandler")]
		protected virtual void RegisterClick ()
		{
			if (id_registerClick == IntPtr.Zero)
				id_registerClick = JNIEnv.GetMethodID (class_ref, "registerClick", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_registerClick);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_registerClick);
		}

		static Delegate cb_setAdContentView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetAdContentView_Landroid_view_View_Handler ()
		{
			if (cb_setAdContentView_Landroid_view_View_ == null)
				cb_setAdContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdContentView_Landroid_view_View_);
			return cb_setAdContentView_Landroid_view_View_;
		}

		static void n_SetAdContentView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdContentView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdContentView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setAdContentView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setAdContentView", "(Landroid/view/View;)V", "GetSetAdContentView_Landroid_view_View_Handler")]
		public virtual void SetAdContentView (global::Android.Views.View p0)
		{
			if (id_setAdContentView_Landroid_view_View_ == IntPtr.Zero)
				id_setAdContentView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setAdContentView", "(Landroid/view/View;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAdContentView_Landroid_view_View_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAdContentView_Landroid_view_View_, new JValue (p0));
		}

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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdUnitId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdUnitId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setAdUnitId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAdUnitId", "(Ljava/lang/String;)V", "GetSetAdUnitId_Ljava_lang_String_Handler")]
		public virtual void SetAdUnitId (string p0)
		{
			if (id_setAdUnitId_Ljava_lang_String_ == IntPtr.Zero)
				id_setAdUnitId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdUnitId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAdUnitId_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAdUnitId_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_;
#pragma warning disable 0169
		static Delegate GetSetLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_Handler ()
		{
			if (cb_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_ == null)
				cb_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_);
			return cb_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_;
		}

		static void n_SetLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView.LocationAwareness p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.LocationAwareness> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocationAwareness (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setLocationAwareness' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView.LocationAwareness']]"
		[Register ("setLocationAwareness", "(Lcom/mopub/mobileads/MoPubView$LocationAwareness;)V", "GetSetLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_Handler")]
		public virtual void SetLocationAwareness (global::Com.Mopub.Mobileads.MoPubView.LocationAwareness p0)
		{
			if (id_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_ == IntPtr.Zero)
				id_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_ = JNIEnv.GetMethodID (class_ref, "setLocationAwareness", "(Lcom/mopub/mobileads/MoPubView$LocationAwareness;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_, new JValue (p0));
		}

		static Delegate cb_setOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_Handler ()
		{
			if (cb_setOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_ == null)
				cb_setOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_);
			return cb_setOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_;
		}

		static void n_SetOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListener p0 = (global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnAdClickedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setOnAdClickedListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView.OnAdClickedListener']]"
		[Register ("setOnAdClickedListener", "(Lcom/mopub/mobileads/MoPubView$OnAdClickedListener;)V", "GetSetOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_Handler")]
		public virtual void SetOnAdClickedListener (global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListener p0)
		{
			if (id_setOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_ == IntPtr.Zero)
				id_setOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_ = JNIEnv.GetMethodID (class_ref, "setOnAdClickedListener", "(Lcom/mopub/mobileads/MoPubView$OnAdClickedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOnAdClickedListener_Lcom_mopub_mobileads_MoPubView_OnAdClickedListener_, new JValue (p0));
		}

		static Delegate cb_setOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_Handler ()
		{
			if (cb_setOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_ == null)
				cb_setOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_);
			return cb_setOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_;
		}

		static void n_SetOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListener p0 = (global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnAdClosedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setOnAdClosedListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView.OnAdClosedListener']]"
		[Register ("setOnAdClosedListener", "(Lcom/mopub/mobileads/MoPubView$OnAdClosedListener;)V", "GetSetOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_Handler")]
		public virtual void SetOnAdClosedListener (global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListener p0)
		{
			if (id_setOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_ == IntPtr.Zero)
				id_setOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_ = JNIEnv.GetMethodID (class_ref, "setOnAdClosedListener", "(Lcom/mopub/mobileads/MoPubView$OnAdClosedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOnAdClosedListener_Lcom_mopub_mobileads_MoPubView_OnAdClosedListener_, new JValue (p0));
		}

		static Delegate cb_setOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_Handler ()
		{
			if (cb_setOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_ == null)
				cb_setOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_);
			return cb_setOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_;
		}

		static void n_SetOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListener p0 = (global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnAdFailedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setOnAdFailedListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView.OnAdFailedListener']]"
		[Register ("setOnAdFailedListener", "(Lcom/mopub/mobileads/MoPubView$OnAdFailedListener;)V", "GetSetOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_Handler")]
		public virtual void SetOnAdFailedListener (global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListener p0)
		{
			if (id_setOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_ == IntPtr.Zero)
				id_setOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_ = JNIEnv.GetMethodID (class_ref, "setOnAdFailedListener", "(Lcom/mopub/mobileads/MoPubView$OnAdFailedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOnAdFailedListener_Lcom_mopub_mobileads_MoPubView_OnAdFailedListener_, new JValue (p0));
		}

		static Delegate cb_setOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_Handler ()
		{
			if (cb_setOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_ == null)
				cb_setOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_);
			return cb_setOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_;
		}

		static void n_SetOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListener p0 = (global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnAdLoadedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setOnAdLoadedListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView.OnAdLoadedListener']]"
		[Register ("setOnAdLoadedListener", "(Lcom/mopub/mobileads/MoPubView$OnAdLoadedListener;)V", "GetSetOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_Handler")]
		public virtual void SetOnAdLoadedListener (global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListener p0)
		{
			if (id_setOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_ == IntPtr.Zero)
				id_setOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_ = JNIEnv.GetMethodID (class_ref, "setOnAdLoadedListener", "(Lcom/mopub/mobileads/MoPubView$OnAdLoadedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOnAdLoadedListener_Lcom_mopub_mobileads_MoPubView_OnAdLoadedListener_, new JValue (p0));
		}

		static Delegate cb_setOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_;
#pragma warning disable 0169
		static Delegate GetSetOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_Handler ()
		{
			if (cb_setOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_ == null)
				cb_setOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_);
			return cb_setOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_;
		}

		static void n_SetOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListener p0 = (global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnAdPresentedOverlayListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setOnAdPresentedOverlayListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView.OnAdPresentedOverlayListener']]"
		[Register ("setOnAdPresentedOverlayListener", "(Lcom/mopub/mobileads/MoPubView$OnAdPresentedOverlayListener;)V", "GetSetOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_Handler")]
		public virtual void SetOnAdPresentedOverlayListener (global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListener p0)
		{
			if (id_setOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_ == IntPtr.Zero)
				id_setOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_ = JNIEnv.GetMethodID (class_ref, "setOnAdPresentedOverlayListener", "(Lcom/mopub/mobileads/MoPubView$OnAdPresentedOverlayListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOnAdPresentedOverlayListener_Lcom_mopub_mobileads_MoPubView_OnAdPresentedOverlayListener_, new JValue (p0));
		}

		static Delegate cb_setOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_;
#pragma warning disable 0169
		static Delegate GetSetOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_Handler ()
		{
			if (cb_setOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_ == null)
				cb_setOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_);
			return cb_setOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_;
		}

		static void n_SetOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListener p0 = (global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnAdWillLoadListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setOnAdWillLoadListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView.OnAdWillLoadListener']]"
		[Register ("setOnAdWillLoadListener", "(Lcom/mopub/mobileads/MoPubView$OnAdWillLoadListener;)V", "GetSetOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_Handler")]
		public virtual void SetOnAdWillLoadListener (global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListener p0)
		{
			if (id_setOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_ == IntPtr.Zero)
				id_setOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_ = JNIEnv.GetMethodID (class_ref, "setOnAdWillLoadListener", "(Lcom/mopub/mobileads/MoPubView$OnAdWillLoadListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOnAdWillLoadListener_Lcom_mopub_mobileads_MoPubView_OnAdWillLoadListener_, new JValue (p0));
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
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_trackNativeImpression;
#pragma warning disable 0169
		static Delegate GetTrackNativeImpressionHandler ()
		{
			if (cb_trackNativeImpression == null)
				cb_trackNativeImpression = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TrackNativeImpression);
			return cb_trackNativeImpression;
		}

		static void n_TrackNativeImpression (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrackNativeImpression ();
		}
#pragma warning restore 0169

		static IntPtr id_trackNativeImpression;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='trackNativeImpression' and count(parameter)=0]"
		[Register ("trackNativeImpression", "()V", "GetTrackNativeImpressionHandler")]
		protected virtual void TrackNativeImpression ()
		{
			if (id_trackNativeImpression == IntPtr.Zero)
				id_trackNativeImpression = JNIEnv.GetMethodID (class_ref, "trackNativeImpression", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_trackNativeImpression);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_trackNativeImpression);
		}

#region "Event implementation for Com.Mopub.Mobileads.MoPubView.IOnAdClickedListener"
		public event EventHandler<global::Com.Mopub.Mobileads.MoPubView.AdClickedEventArgs> AdClickedEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListenerImplementor>(
						ref weak_implementor_SetOnAdClickedListener,
						__CreateIOnAdClickedListenerImplementor,
						SetOnAdClickedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListenerImplementor>(
						ref weak_implementor_SetOnAdClickedListener,
						global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListenerImplementor.__IsEmpty,
						__v => SetOnAdClickedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnAdClickedListener;

		global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListenerImplementor __CreateIOnAdClickedListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MoPubView.IOnAdClickedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mopub.Mobileads.MoPubView.IOnAdClosedListener"
		public event EventHandler<global::Com.Mopub.Mobileads.MoPubView.AdClosedEventArgs> AdClosedEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListenerImplementor>(
						ref weak_implementor_SetOnAdClosedListener,
						__CreateIOnAdClosedListenerImplementor,
						SetOnAdClosedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListenerImplementor>(
						ref weak_implementor_SetOnAdClosedListener,
						global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListenerImplementor.__IsEmpty,
						__v => SetOnAdClosedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnAdClosedListener;

		global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListenerImplementor __CreateIOnAdClosedListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MoPubView.IOnAdClosedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mopub.Mobileads.MoPubView.IOnAdFailedListener"
		public event EventHandler<global::Com.Mopub.Mobileads.MoPubView.AdFailedEventArgs> AdFailedEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListenerImplementor>(
						ref weak_implementor_SetOnAdFailedListener,
						__CreateIOnAdFailedListenerImplementor,
						SetOnAdFailedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListenerImplementor>(
						ref weak_implementor_SetOnAdFailedListener,
						global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListenerImplementor.__IsEmpty,
						__v => SetOnAdFailedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnAdFailedListener;

		global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListenerImplementor __CreateIOnAdFailedListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MoPubView.IOnAdFailedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListener"
		public event EventHandler<global::Com.Mopub.Mobileads.MoPubView.AdLoadedEventArgs> AdLoadedEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListenerImplementor>(
						ref weak_implementor_SetOnAdLoadedListener,
						__CreateIOnAdLoadedListenerImplementor,
						SetOnAdLoadedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListenerImplementor>(
						ref weak_implementor_SetOnAdLoadedListener,
						global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListenerImplementor.__IsEmpty,
						__v => SetOnAdLoadedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnAdLoadedListener;

		global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListenerImplementor __CreateIOnAdLoadedListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MoPubView.IOnAdLoadedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListener"
		public event EventHandler<global::Com.Mopub.Mobileads.MoPubView.AdPresentedOverlayEventArgs> AdPresentedOverlayEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListenerImplementor>(
						ref weak_implementor_SetOnAdPresentedOverlayListener,
						__CreateIOnAdPresentedOverlayListenerImplementor,
						SetOnAdPresentedOverlayListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListenerImplementor>(
						ref weak_implementor_SetOnAdPresentedOverlayListener,
						global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListenerImplementor.__IsEmpty,
						__v => SetOnAdPresentedOverlayListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnAdPresentedOverlayListener;

		global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListenerImplementor __CreateIOnAdPresentedOverlayListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MoPubView.IOnAdPresentedOverlayListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListener"
		public event EventHandler<global::Com.Mopub.Mobileads.MoPubView.AdWillLoadEventArgs> AdWillLoadEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListenerImplementor>(
						ref weak_implementor_SetOnAdWillLoadListener,
						__CreateIOnAdWillLoadListenerImplementor,
						SetOnAdWillLoadListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListener, global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListenerImplementor>(
						ref weak_implementor_SetOnAdWillLoadListener,
						global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListenerImplementor.__IsEmpty,
						__v => SetOnAdWillLoadListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnAdWillLoadListener;

		global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListenerImplementor __CreateIOnAdWillLoadListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MoPubView.IOnAdWillLoadListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mopub.Mobileads.MoPubView.IBannerAdListener"
		public event EventHandler<global::Com.Mopub.Mobileads.MoPubView.BannerClickedEventArgs> BannerClicked {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener, global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						__CreateIBannerAdListenerImplementor,
						__v => BannerAdListener = __v,
						__h => __h.OnBannerClickedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener, global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor.__IsEmpty,
						__v => BannerAdListener = null,
						__h => __h.OnBannerClickedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.MoPubView.BannerCollapsedEventArgs> BannerCollapsed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener, global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						__CreateIBannerAdListenerImplementor,
						__v => BannerAdListener = __v,
						__h => __h.OnBannerCollapsedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener, global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor.__IsEmpty,
						__v => BannerAdListener = null,
						__h => __h.OnBannerCollapsedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.MoPubView.BannerExpandedEventArgs> BannerExpanded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener, global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						__CreateIBannerAdListenerImplementor,
						__v => BannerAdListener = __v,
						__h => __h.OnBannerExpandedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener, global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor.__IsEmpty,
						__v => BannerAdListener = null,
						__h => __h.OnBannerExpandedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.MoPubView.BannerFailedEventArgs> BannerFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener, global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						__CreateIBannerAdListenerImplementor,
						__v => BannerAdListener = __v,
						__h => __h.OnBannerFailedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener, global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor.__IsEmpty,
						__v => BannerAdListener = null,
						__h => __h.OnBannerFailedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.MoPubView.BannerLoadedEventArgs> BannerLoaded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener, global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						__CreateIBannerAdListenerImplementor,
						__v => BannerAdListener = __v,
						__h => __h.OnBannerLoadedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener, global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor.__IsEmpty,
						__v => BannerAdListener = null,
						__h => __h.OnBannerLoadedHandler -= value);
			}
		}

		WeakReference weak_implementor___SetBannerAdListener;

		global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor __CreateIBannerAdListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MoPubView.IBannerAdListenerImplementor (this);
		}
#endregion
	}
}
