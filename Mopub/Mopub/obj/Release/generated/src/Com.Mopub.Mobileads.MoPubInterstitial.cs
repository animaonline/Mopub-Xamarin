using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubInterstitial", DoNotGenerateAcw=true)]
	public partial class MoPubInterstitial : global::Java.Lang.Object, global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubInterstitial.InterstitialAdListener']"
		[Register ("com/mopub/mobileads/MoPubInterstitial$InterstitialAdListener", "", "Com.Mopub.Mobileads.MoPubInterstitial/IInterstitialAdListenerInvoker")]
		public partial interface IInterstitialAdListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubInterstitial.InterstitialAdListener']/method[@name='onInterstitialClicked' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial']]"
			[Register ("onInterstitialClicked", "(Lcom/mopub/mobileads/MoPubInterstitial;)V", "GetOnInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_Handler:Com.Mopub.Mobileads.MoPubInterstitial/IInterstitialAdListenerInvoker, Mopub")]
			void OnInterstitialClicked (global::Com.Mopub.Mobileads.MoPubInterstitial p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubInterstitial.InterstitialAdListener']/method[@name='onInterstitialDismissed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial']]"
			[Register ("onInterstitialDismissed", "(Lcom/mopub/mobileads/MoPubInterstitial;)V", "GetOnInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_Handler:Com.Mopub.Mobileads.MoPubInterstitial/IInterstitialAdListenerInvoker, Mopub")]
			void OnInterstitialDismissed (global::Com.Mopub.Mobileads.MoPubInterstitial p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubInterstitial.InterstitialAdListener']/method[@name='onInterstitialFailed' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial'] and parameter[2][@type='com.mopub.mobileads.MoPubErrorCode']]"
			[Register ("onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubInterstitial;Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_Handler:Com.Mopub.Mobileads.MoPubInterstitial/IInterstitialAdListenerInvoker, Mopub")]
			void OnInterstitialFailed (global::Com.Mopub.Mobileads.MoPubInterstitial p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubInterstitial.InterstitialAdListener']/method[@name='onInterstitialLoaded' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial']]"
			[Register ("onInterstitialLoaded", "(Lcom/mopub/mobileads/MoPubInterstitial;)V", "GetOnInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_Handler:Com.Mopub.Mobileads.MoPubInterstitial/IInterstitialAdListenerInvoker, Mopub")]
			void OnInterstitialLoaded (global::Com.Mopub.Mobileads.MoPubInterstitial p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubInterstitial.InterstitialAdListener']/method[@name='onInterstitialShown' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial']]"
			[Register ("onInterstitialShown", "(Lcom/mopub/mobileads/MoPubInterstitial;)V", "GetOnInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_Handler:Com.Mopub.Mobileads.MoPubInterstitial/IInterstitialAdListenerInvoker, Mopub")]
			void OnInterstitialShown (global::Com.Mopub.Mobileads.MoPubInterstitial p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubInterstitial$InterstitialAdListener", DoNotGenerateAcw=true)]
		internal class IInterstitialAdListenerInvoker : global::Java.Lang.Object, IInterstitialAdListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MoPubInterstitial$InterstitialAdListener");
			IntPtr class_ref;

			public static IInterstitialAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInterstitialAdListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MoPubInterstitial.InterstitialAdListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInterstitialAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IInterstitialAdListenerInvoker); }
			}

			static Delegate cb_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_;
#pragma warning disable 0169
			static Delegate GetOnInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_Handler ()
			{
				if (cb_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_ == null)
					cb_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_);
				return cb_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_;
			}

			static void n_OnInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialClicked (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_;
			public void OnInterstitialClicked (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				if (id_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_ == IntPtr.Zero)
					id_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialClicked", "(Lcom/mopub/mobileads/MoPubInterstitial;)V");
				JNIEnv.CallVoidMethod (Handle, id_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_, new JValue (p0));
			}

			static Delegate cb_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_;
#pragma warning disable 0169
			static Delegate GetOnInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_Handler ()
			{
				if (cb_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_ == null)
					cb_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_);
				return cb_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_;
			}

			static void n_OnInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialDismissed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_;
			public void OnInterstitialDismissed (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				if (id_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_ == IntPtr.Zero)
					id_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialDismissed", "(Lcom/mopub/mobileads/MoPubInterstitial;)V");
				JNIEnv.CallVoidMethod (Handle, id_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_, new JValue (p0));
			}

			static Delegate cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
			{
				if (cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
					cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_);
				return cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_;
			}

			static void n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialFailed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_;
			public void OnInterstitialFailed (global::Com.Mopub.Mobileads.MoPubInterstitial p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
			{
				if (id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
					id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubInterstitial;Lcom/mopub/mobileads/MoPubErrorCode;)V");
				JNIEnv.CallVoidMethod (Handle, id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_;
#pragma warning disable 0169
			static Delegate GetOnInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_Handler ()
			{
				if (cb_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_ == null)
					cb_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_);
				return cb_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_;
			}

			static void n_OnInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialLoaded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_;
			public void OnInterstitialLoaded (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				if (id_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_ == IntPtr.Zero)
					id_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialLoaded", "(Lcom/mopub/mobileads/MoPubInterstitial;)V");
				JNIEnv.CallVoidMethod (Handle, id_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_, new JValue (p0));
			}

			static Delegate cb_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_;
#pragma warning disable 0169
			static Delegate GetOnInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_Handler ()
			{
				if (cb_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_ == null)
					cb_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_);
				return cb_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_;
			}

			static void n_OnInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialShown (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_;
			public void OnInterstitialShown (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				if (id_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_ == IntPtr.Zero)
					id_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialShown", "(Lcom/mopub/mobileads/MoPubInterstitial;)V");
				JNIEnv.CallVoidMethod (Handle, id_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_, new JValue (p0));
			}

		}

		public partial class InterstitialClickedEventArgs : global::System.EventArgs {

			public InterstitialClickedEventArgs (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubInterstitial p0;
			public global::Com.Mopub.Mobileads.MoPubInterstitial P0 {
				get { return p0; }
			}
		}

		public partial class InterstitialDismissedEventArgs : global::System.EventArgs {

			public InterstitialDismissedEventArgs (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubInterstitial p0;
			public global::Com.Mopub.Mobileads.MoPubInterstitial P0 {
				get { return p0; }
			}
		}

		public partial class InterstitialFailedEventArgs : global::System.EventArgs {

			public InterstitialFailedEventArgs (global::Com.Mopub.Mobileads.MoPubInterstitial p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Mopub.Mobileads.MoPubInterstitial p0;
			public global::Com.Mopub.Mobileads.MoPubInterstitial P0 {
				get { return p0; }
			}

			global::Com.Mopub.Mobileads.MoPubErrorCode p1;
			public global::Com.Mopub.Mobileads.MoPubErrorCode P1 {
				get { return p1; }
			}
		}

		public partial class InterstitialLoadedEventArgs : global::System.EventArgs {

			public InterstitialLoadedEventArgs (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubInterstitial p0;
			public global::Com.Mopub.Mobileads.MoPubInterstitial P0 {
				get { return p0; }
			}
		}

		public partial class InterstitialShownEventArgs : global::System.EventArgs {

			public InterstitialShownEventArgs (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubInterstitial p0;
			public global::Com.Mopub.Mobileads.MoPubInterstitial P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MoPubInterstitial_InterstitialAdListenerImplementor")]
		internal sealed class IInterstitialAdListenerImplementor : global::Java.Lang.Object, IInterstitialAdListener {

			object sender;

			public IInterstitialAdListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MoPubInterstitial_InterstitialAdListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InterstitialClickedEventArgs> OnInterstitialClickedHandler;
#pragma warning restore 0649

			public void OnInterstitialClicked (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				var __h = OnInterstitialClickedHandler;
				if (__h != null)
					__h (sender, new InterstitialClickedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<InterstitialDismissedEventArgs> OnInterstitialDismissedHandler;
#pragma warning restore 0649

			public void OnInterstitialDismissed (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				var __h = OnInterstitialDismissedHandler;
				if (__h != null)
					__h (sender, new InterstitialDismissedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<InterstitialFailedEventArgs> OnInterstitialFailedHandler;
#pragma warning restore 0649

			public void OnInterstitialFailed (global::Com.Mopub.Mobileads.MoPubInterstitial p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
			{
				var __h = OnInterstitialFailedHandler;
				if (__h != null)
					__h (sender, new InterstitialFailedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<InterstitialLoadedEventArgs> OnInterstitialLoadedHandler;
#pragma warning restore 0649

			public void OnInterstitialLoaded (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				var __h = OnInterstitialLoadedHandler;
				if (__h != null)
					__h (sender, new InterstitialLoadedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<InterstitialShownEventArgs> OnInterstitialShownHandler;
#pragma warning restore 0649

			public void OnInterstitialShown (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
			{
				var __h = OnInterstitialShownHandler;
				if (__h != null)
					__h (sender, new InterstitialShownEventArgs (p0));
			}

			internal static bool __IsEmpty (IInterstitialAdListenerImplementor value)
			{
				return value.OnInterstitialClickedHandler == null && value.OnInterstitialDismissedHandler == null && value.OnInterstitialFailedHandler == null && value.OnInterstitialLoadedHandler == null && value.OnInterstitialShownHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial.InterstitialState']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubInterstitial$InterstitialState", DoNotGenerateAcw=true)]
		public sealed partial class InterstitialState : global::Java.Lang.Enum {


			static IntPtr CUSTOM_EVENT_AD_READY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial.InterstitialState']/field[@name='CUSTOM_EVENT_AD_READY']"
			[Register ("CUSTOM_EVENT_AD_READY")]
			public static global::Com.Mopub.Mobileads.MoPubInterstitial.InterstitialState CustomEventAdReady {
				get {
					if (CUSTOM_EVENT_AD_READY_jfieldId == IntPtr.Zero)
						CUSTOM_EVENT_AD_READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM_EVENT_AD_READY", "Lcom/mopub/mobileads/MoPubInterstitial$InterstitialState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_EVENT_AD_READY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.InterstitialState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CUSTOM_EVENT_AD_READY_jfieldId == IntPtr.Zero)
						CUSTOM_EVENT_AD_READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM_EVENT_AD_READY", "Lcom/mopub/mobileads/MoPubInterstitial$InterstitialState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CUSTOM_EVENT_AD_READY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NOT_READY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial.InterstitialState']/field[@name='NOT_READY']"
			[Register ("NOT_READY")]
			public static global::Com.Mopub.Mobileads.MoPubInterstitial.InterstitialState NotReady {
				get {
					if (NOT_READY_jfieldId == IntPtr.Zero)
						NOT_READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_READY", "Lcom/mopub/mobileads/MoPubInterstitial$InterstitialState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_READY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.InterstitialState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NOT_READY_jfieldId == IntPtr.Zero)
						NOT_READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_READY", "Lcom/mopub/mobileads/MoPubInterstitial$InterstitialState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NOT_READY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MoPubInterstitial$InterstitialState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InterstitialState); }
			}

			internal InterstitialState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubInterstitial.MoPubInterstitialListener']"
		[ObsoleteAttribute ("This class is obsoleted in this android platform")]
		[Register ("com/mopub/mobileads/MoPubInterstitial$MoPubInterstitialListener", "", "Com.Mopub.Mobileads.MoPubInterstitial/IMoPubInterstitialListenerInvoker")]
		public partial interface IMoPubInterstitialListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubInterstitial.MoPubInterstitialListener']/method[@name='OnInterstitialFailed' and count(parameter)=0]"
			[Register ("OnInterstitialFailed", "()V", "GetOnInterstitialFailedHandler:Com.Mopub.Mobileads.MoPubInterstitial/IMoPubInterstitialListenerInvoker, Mopub")]
			void OnInterstitialFailed ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubInterstitial.MoPubInterstitialListener']/method[@name='OnInterstitialLoaded' and count(parameter)=0]"
			[Register ("OnInterstitialLoaded", "()V", "GetOnInterstitialLoadedHandler:Com.Mopub.Mobileads.MoPubInterstitial/IMoPubInterstitialListenerInvoker, Mopub")]
			void OnInterstitialLoaded ();

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubInterstitial$MoPubInterstitialListener", DoNotGenerateAcw=true)]
		internal class IMoPubInterstitialListenerInvoker : global::Java.Lang.Object, IMoPubInterstitialListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MoPubInterstitial$MoPubInterstitialListener");
			IntPtr class_ref;

			public static IMoPubInterstitialListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMoPubInterstitialListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MoPubInterstitial.MoPubInterstitialListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMoPubInterstitialListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IMoPubInterstitialListenerInvoker); }
			}

			static Delegate cb_OnInterstitialFailed;
#pragma warning disable 0169
			static Delegate GetOnInterstitialFailedHandler ()
			{
				if (cb_OnInterstitialFailed == null)
					cb_OnInterstitialFailed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialFailed);
				return cb_OnInterstitialFailed;
			}

			static void n_OnInterstitialFailed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListener> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialFailed ();
			}
#pragma warning restore 0169

			IntPtr id_OnInterstitialFailed;
			public void OnInterstitialFailed ()
			{
				if (id_OnInterstitialFailed == IntPtr.Zero)
					id_OnInterstitialFailed = JNIEnv.GetMethodID (class_ref, "OnInterstitialFailed", "()V");
				JNIEnv.CallVoidMethod (Handle, id_OnInterstitialFailed);
			}

			static Delegate cb_OnInterstitialLoaded;
#pragma warning disable 0169
			static Delegate GetOnInterstitialLoadedHandler ()
			{
				if (cb_OnInterstitialLoaded == null)
					cb_OnInterstitialLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialLoaded);
				return cb_OnInterstitialLoaded;
			}

			static void n_OnInterstitialLoaded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListener> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialLoaded ();
			}
#pragma warning restore 0169

			IntPtr id_OnInterstitialLoaded;
			public void OnInterstitialLoaded ()
			{
				if (id_OnInterstitialLoaded == IntPtr.Zero)
					id_OnInterstitialLoaded = JNIEnv.GetMethodID (class_ref, "OnInterstitialLoaded", "()V");
				JNIEnv.CallVoidMethod (Handle, id_OnInterstitialLoaded);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MoPubInterstitial_MoPubInterstitialListenerImplementor")]
		internal sealed class IMoPubInterstitialListenerImplementor : global::Java.Lang.Object, IMoPubInterstitialListener {

			object sender;

			public IMoPubInterstitialListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/mopub/mobileads/MoPubInterstitial_MoPubInterstitialListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnInterstitialFailedHandler;
#pragma warning restore 0649

			public void OnInterstitialFailed ()
			{
				var __h = OnInterstitialFailedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnInterstitialLoadedHandler;
#pragma warning restore 0649

			public void OnInterstitialLoaded ()
			{
				var __h = OnInterstitialLoadedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IMoPubInterstitialListenerImplementor value)
			{
				return value.OnInterstitialFailedHandler == null && value.OnInterstitialLoadedHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial.MoPubInterstitialView']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubInterstitial$MoPubInterstitialView", DoNotGenerateAcw=true)]
		public partial class MoPubInterstitialView : global::Com.Mopub.Mobileads.MoPubView {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MoPubInterstitial$MoPubInterstitialView", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MoPubInterstitialView); }
			}

			protected MoPubInterstitialView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial.MoPubInterstitialView']/constructor[@name='MoPubInterstitial.MoPubInterstitialView' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial'] and parameter[2][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/mopub/mobileads/MoPubInterstitial;Landroid/content/Context;)V", "")]
			public MoPubInterstitialView (global::Com.Mopub.Mobileads.MoPubInterstitial __self, global::Android.Content.Context p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MoPubInterstitialView)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", new JValue (__self), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/MoPubInterstitial;Landroid/content/Context;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Landroid_content_Context_, new JValue (__self), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_trackImpression;
#pragma warning disable 0169
			static Delegate GetTrackImpressionHandler ()
			{
				if (cb_trackImpression == null)
					cb_trackImpression = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TrackImpression);
				return cb_trackImpression;
			}

			static void n_TrackImpression (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubInterstitial.MoPubInterstitialView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.MoPubInterstitialView> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.TrackImpression ();
			}
#pragma warning restore 0169

			static IntPtr id_trackImpression;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial.MoPubInterstitialView']/method[@name='trackImpression' and count(parameter)=0]"
			[Register ("trackImpression", "()V", "GetTrackImpressionHandler")]
			protected virtual void TrackImpression ()
			{
				if (id_trackImpression == IntPtr.Zero)
					id_trackImpression = JNIEnv.GetMethodID (class_ref, "trackImpression", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_trackImpression);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_trackImpression);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MoPubInterstitial", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubInterstitial); }
		}

		protected MoPubInterstitial (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/constructor[@name='MoPubInterstitial' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/app/Activity;Ljava/lang/String;)V", "")]
		public MoPubInterstitial (global::Android.App.Activity p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (MoPubInterstitial)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/app/Activity;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_app_Activity_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Landroid_app_Activity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_app_Activity_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		static IntPtr id_getActivity;
		public virtual global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='getActivity' and count(parameter)=0]"
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

		static Delegate cb_getInterstitialAdListener;
#pragma warning disable 0169
		static Delegate GetGetInterstitialAdListenerHandler ()
		{
			if (cb_getInterstitialAdListener == null)
				cb_getInterstitialAdListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterstitialAdListener);
			return cb_getInterstitialAdListener;
		}

		static IntPtr n_GetInterstitialAdListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InterstitialAdListener);
		}
#pragma warning restore 0169

		static Delegate cb_setInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_;
#pragma warning disable 0169
		static Delegate GetSetInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_Handler ()
		{
			if (cb_setInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_ == null)
				cb_setInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_);
			return cb_setInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_;
		}

		static void n_SetInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener p0 = (global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InterstitialAdListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInterstitialAdListener;
		static IntPtr id_setInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_;
		public virtual global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener InterstitialAdListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='getInterstitialAdListener' and count(parameter)=0]"
			[Register ("getInterstitialAdListener", "()Lcom/mopub/mobileads/MoPubInterstitial$InterstitialAdListener;", "GetGetInterstitialAdListenerHandler")]
			get {
				if (id_getInterstitialAdListener == IntPtr.Zero)
					id_getInterstitialAdListener = JNIEnv.GetMethodID (class_ref, "getInterstitialAdListener", "()Lcom/mopub/mobileads/MoPubInterstitial$InterstitialAdListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener> (JNIEnv.CallObjectMethod  (Handle, id_getInterstitialAdListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getInterstitialAdListener), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='setInterstitialAdListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial.InterstitialAdListener']]"
			[Register ("setInterstitialAdListener", "(Lcom/mopub/mobileads/MoPubInterstitial$InterstitialAdListener;)V", "GetSetInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_Handler")]
			set {
				if (id_setInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_ == IntPtr.Zero)
					id_setInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_ = JNIEnv.GetMethodID (class_ref, "setInterstitialAdListener", "(Lcom/mopub/mobileads/MoPubInterstitial$InterstitialAdListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setInterstitialAdListener_Lcom_mopub_mobileads_MoPubInterstitial_InterstitialAdListener_, new JValue (value));
			}
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		static IntPtr id_isReady;
		public virtual bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isReady);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isReady);
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Keywords = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKeywords;
		static IntPtr id_setKeywords_Ljava_lang_String_;
		public virtual string Keywords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='getKeywords' and count(parameter)=0]"
			[Register ("getKeywords", "()Ljava/lang/String;", "GetGetKeywordsHandler")]
			get {
				if (id_getKeywords == IntPtr.Zero)
					id_getKeywords = JNIEnv.GetMethodID (class_ref, "getKeywords", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKeywords), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getKeywords), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='setKeywords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getListener;
#pragma warning disable 0169
		static Delegate GetGetListenerHandler ()
		{
			if (cb_getListener == null)
				cb_getListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListener);
			return cb_getListener;
		}

		static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listener);
		}
#pragma warning restore 0169

		static Delegate cb_setListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_Handler ()
		{
			if (cb_setListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_ == null)
				cb_setListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_);
			return cb_setListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_;
		}

		static void n_SetListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListener p0 = (global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Listener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getListener;
		static IntPtr id_setListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_;
		[Obsolete (@"deprecated")]
		public virtual global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lcom/mopub/mobileads/MoPubInterstitial$MoPubInterstitialListener;", "GetGetListenerHandler")]
			get {
				if (id_getListener == IntPtr.Zero)
					id_getListener = JNIEnv.GetMethodID (class_ref, "getListener", "()Lcom/mopub/mobileads/MoPubInterstitial$MoPubInterstitialListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListener> (JNIEnv.CallObjectMethod  (Handle, id_getListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getListener), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial.MoPubInterstitialListener']]"
			[Register ("setListener", "(Lcom/mopub/mobileads/MoPubInterstitial$MoPubInterstitialListener;)V", "GetSetListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_Handler")]
			set {
				if (id_setListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_ == IntPtr.Zero)
					id_setListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/mopub/mobileads/MoPubInterstitial$MoPubInterstitialListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setListener_Lcom_mopub_mobileads_MoPubInterstitial_MoPubInterstitialListener_, new JValue (value));
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalExtras = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalExtras;
		static IntPtr id_setLocalExtras_Ljava_util_Map_;
		public virtual global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> LocalExtras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='getLocalExtras' and count(parameter)=0]"
			[Register ("getLocalExtras", "()Ljava/util/Map;", "GetGetLocalExtrasHandler")]
			get {
				if (id_getLocalExtras == IntPtr.Zero)
					id_getLocalExtras = JNIEnv.GetMethodID (class_ref, "getLocalExtras", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getLocalExtras), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocalExtras), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='setLocalExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		public virtual global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocationAwareness);
		}
#pragma warning restore 0169

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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView.LocationAwareness p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.LocationAwareness> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocationAwareness = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocationAwareness;
		static IntPtr id_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_;
		public virtual global::Com.Mopub.Mobileads.MoPubView.LocationAwareness LocationAwareness {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='getLocationAwareness' and count(parameter)=0]"
			[Register ("getLocationAwareness", "()Lcom/mopub/mobileads/MoPubView$LocationAwareness;", "GetGetLocationAwarenessHandler")]
			get {
				if (id_getLocationAwareness == IntPtr.Zero)
					id_getLocationAwareness = JNIEnv.GetMethodID (class_ref, "getLocationAwareness", "()Lcom/mopub/mobileads/MoPubView$LocationAwareness;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.LocationAwareness> (JNIEnv.CallObjectMethod  (Handle, id_getLocationAwareness), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView.LocationAwareness> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocationAwareness), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='setLocationAwareness' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView.LocationAwareness']]"
			[Register ("setLocationAwareness", "(Lcom/mopub/mobileads/MoPubView$LocationAwareness;)V", "GetSetLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_Handler")]
			set {
				if (id_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_ == IntPtr.Zero)
					id_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_ = JNIEnv.GetMethodID (class_ref, "setLocationAwareness", "(Lcom/mopub/mobileads/MoPubView$LocationAwareness;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLocationAwareness_Lcom_mopub_mobileads_MoPubView_LocationAwareness_, new JValue (value));
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.LocationPrecision = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocationPrecision;
		static IntPtr id_setLocationPrecision_I;
		public virtual int LocationPrecision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='getLocationPrecision' and count(parameter)=0]"
			[Register ("getLocationPrecision", "()I", "GetGetLocationPrecisionHandler")]
			get {
				if (id_getLocationPrecision == IntPtr.Zero)
					id_getLocationPrecision = JNIEnv.GetMethodID (class_ref, "getLocationPrecision", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLocationPrecision);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getLocationPrecision);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='setLocationPrecision' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Testing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTesting;
		static IntPtr id_setTesting_Z;
		public virtual bool Testing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='getTesting' and count(parameter)=0]"
			[Register ("getTesting", "()Z", "GetGetTestingHandler")]
			get {
				if (id_getTesting == IntPtr.Zero)
					id_getTesting = JNIEnv.GetMethodID (class_ref, "getTesting", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getTesting);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getTesting);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='setTesting' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.CustomEventActionWillBegin ();
		}
#pragma warning restore 0169

		static IntPtr id_customEventActionWillBegin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='customEventActionWillBegin' and count(parameter)=0]"
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.CustomEventDidFailToLoadAd ();
		}
#pragma warning restore 0169

		static IntPtr id_customEventDidFailToLoadAd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='customEventDidFailToLoadAd' and count(parameter)=0]"
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.CustomEventDidLoadAd ();
		}
#pragma warning restore 0169

		static IntPtr id_customEventDidLoadAd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='customEventDidLoadAd' and count(parameter)=0]"
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='destroy' and count(parameter)=0]"
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
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForceRefresh ();
		}
#pragma warning restore 0169

		static IntPtr id_forceRefresh;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='forceRefresh' and count(parameter)=0]"
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

		static Delegate cb_load;
#pragma warning disable 0169
		static Delegate GetLoadHandler ()
		{
			if (cb_load == null)
				cb_load = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Load);
			return cb_load;
		}

		static void n_Load (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Load ();
		}
#pragma warning restore 0169

		static IntPtr id_load;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "GetLoadHandler")]
		public virtual void Load ()
		{
			if (id_load == IntPtr.Zero)
				id_load = JNIEnv.GetMethodID (class_ref, "load", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_load);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_load);
		}

		static Delegate cb_onCustomEventInterstitialClicked;
#pragma warning disable 0169
		static Delegate GetOnCustomEventInterstitialClickedHandler ()
		{
			if (cb_onCustomEventInterstitialClicked == null)
				cb_onCustomEventInterstitialClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCustomEventInterstitialClicked);
			return cb_onCustomEventInterstitialClicked;
		}

		static void n_OnCustomEventInterstitialClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCustomEventInterstitialClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_onCustomEventInterstitialClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='onCustomEventInterstitialClicked' and count(parameter)=0]"
		[Register ("onCustomEventInterstitialClicked", "()V", "GetOnCustomEventInterstitialClickedHandler")]
		public virtual void OnCustomEventInterstitialClicked ()
		{
			if (id_onCustomEventInterstitialClicked == IntPtr.Zero)
				id_onCustomEventInterstitialClicked = JNIEnv.GetMethodID (class_ref, "onCustomEventInterstitialClicked", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCustomEventInterstitialClicked);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCustomEventInterstitialClicked);
		}

		static Delegate cb_onCustomEventInterstitialDismissed;
#pragma warning disable 0169
		static Delegate GetOnCustomEventInterstitialDismissedHandler ()
		{
			if (cb_onCustomEventInterstitialDismissed == null)
				cb_onCustomEventInterstitialDismissed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCustomEventInterstitialDismissed);
			return cb_onCustomEventInterstitialDismissed;
		}

		static void n_OnCustomEventInterstitialDismissed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCustomEventInterstitialDismissed ();
		}
#pragma warning restore 0169

		static IntPtr id_onCustomEventInterstitialDismissed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='onCustomEventInterstitialDismissed' and count(parameter)=0]"
		[Register ("onCustomEventInterstitialDismissed", "()V", "GetOnCustomEventInterstitialDismissedHandler")]
		public virtual void OnCustomEventInterstitialDismissed ()
		{
			if (id_onCustomEventInterstitialDismissed == IntPtr.Zero)
				id_onCustomEventInterstitialDismissed = JNIEnv.GetMethodID (class_ref, "onCustomEventInterstitialDismissed", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCustomEventInterstitialDismissed);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCustomEventInterstitialDismissed);
		}

		static Delegate cb_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetOnCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_OnCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCustomEventInterstitialFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='onCustomEventInterstitialFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("onCustomEventInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
		public virtual void OnCustomEventInterstitialFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
		{
			if (id_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onCustomEventInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_, new JValue (p0));
		}

		static Delegate cb_onCustomEventInterstitialLoaded;
#pragma warning disable 0169
		static Delegate GetOnCustomEventInterstitialLoadedHandler ()
		{
			if (cb_onCustomEventInterstitialLoaded == null)
				cb_onCustomEventInterstitialLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCustomEventInterstitialLoaded);
			return cb_onCustomEventInterstitialLoaded;
		}

		static void n_OnCustomEventInterstitialLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCustomEventInterstitialLoaded ();
		}
#pragma warning restore 0169

		static IntPtr id_onCustomEventInterstitialLoaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='onCustomEventInterstitialLoaded' and count(parameter)=0]"
		[Register ("onCustomEventInterstitialLoaded", "()V", "GetOnCustomEventInterstitialLoadedHandler")]
		public virtual void OnCustomEventInterstitialLoaded ()
		{
			if (id_onCustomEventInterstitialLoaded == IntPtr.Zero)
				id_onCustomEventInterstitialLoaded = JNIEnv.GetMethodID (class_ref, "onCustomEventInterstitialLoaded", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCustomEventInterstitialLoaded);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCustomEventInterstitialLoaded);
		}

		static Delegate cb_onCustomEventInterstitialShown_Z;
#pragma warning disable 0169
		static Delegate GetOnCustomEventInterstitialShown_ZHandler ()
		{
			if (cb_onCustomEventInterstitialShown_Z == null)
				cb_onCustomEventInterstitialShown_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnCustomEventInterstitialShown_Z);
			return cb_onCustomEventInterstitialShown_Z;
		}

		static void n_OnCustomEventInterstitialShown_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCustomEventInterstitialShown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCustomEventInterstitialShown_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='onCustomEventInterstitialShown' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onCustomEventInterstitialShown", "(Z)V", "GetOnCustomEventInterstitialShown_ZHandler")]
		public virtual void OnCustomEventInterstitialShown (bool p0)
		{
			if (id_onCustomEventInterstitialShown_Z == IntPtr.Zero)
				id_onCustomEventInterstitialShown_Z = JNIEnv.GetMethodID (class_ref, "onCustomEventInterstitialShown", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCustomEventInterstitialShown_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCustomEventInterstitialShown_Z, new JValue (p0));
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Show);
			return cb_show;
		}

		static bool n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Show ();
		}
#pragma warning restore 0169

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubInterstitial']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()Z", "GetShowHandler")]
		public virtual bool Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_show);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_show);
		}

#region "Event implementation for Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener"
		public event EventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.InterstitialClickedEventArgs> InterstitialClicked {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener, global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor>(
						ref weak_implementor___SetInterstitialAdListener,
						__CreateIInterstitialAdListenerImplementor,
						__v => InterstitialAdListener = __v,
						__h => __h.OnInterstitialClickedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener, global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor>(
						ref weak_implementor___SetInterstitialAdListener,
						global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor.__IsEmpty,
						__v => InterstitialAdListener = null,
						__h => __h.OnInterstitialClickedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.InterstitialDismissedEventArgs> InterstitialDismissed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener, global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor>(
						ref weak_implementor___SetInterstitialAdListener,
						__CreateIInterstitialAdListenerImplementor,
						__v => InterstitialAdListener = __v,
						__h => __h.OnInterstitialDismissedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener, global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor>(
						ref weak_implementor___SetInterstitialAdListener,
						global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor.__IsEmpty,
						__v => InterstitialAdListener = null,
						__h => __h.OnInterstitialDismissedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.InterstitialFailedEventArgs> InterstitialFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener, global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor>(
						ref weak_implementor___SetInterstitialAdListener,
						__CreateIInterstitialAdListenerImplementor,
						__v => InterstitialAdListener = __v,
						__h => __h.OnInterstitialFailedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener, global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor>(
						ref weak_implementor___SetInterstitialAdListener,
						global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor.__IsEmpty,
						__v => InterstitialAdListener = null,
						__h => __h.OnInterstitialFailedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.InterstitialLoadedEventArgs> InterstitialLoaded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener, global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor>(
						ref weak_implementor___SetInterstitialAdListener,
						__CreateIInterstitialAdListenerImplementor,
						__v => InterstitialAdListener = __v,
						__h => __h.OnInterstitialLoadedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener, global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor>(
						ref weak_implementor___SetInterstitialAdListener,
						global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor.__IsEmpty,
						__v => InterstitialAdListener = null,
						__h => __h.OnInterstitialLoadedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.InterstitialShownEventArgs> InterstitialShown {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener, global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor>(
						ref weak_implementor___SetInterstitialAdListener,
						__CreateIInterstitialAdListenerImplementor,
						__v => InterstitialAdListener = __v,
						__h => __h.OnInterstitialShownHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener, global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor>(
						ref weak_implementor___SetInterstitialAdListener,
						global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor.__IsEmpty,
						__v => InterstitialAdListener = null,
						__h => __h.OnInterstitialShownHandler -= value);
			}
		}

		WeakReference weak_implementor___SetInterstitialAdListener;

		global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor __CreateIInterstitialAdListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListener"

		global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListenerImplementor __CreateIMoPubInterstitialListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.MoPubInterstitial.IMoPubInterstitialListenerImplementor (this);
		}
#endregion
	}
}
