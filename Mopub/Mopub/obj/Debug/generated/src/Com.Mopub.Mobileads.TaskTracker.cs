using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='TaskTracker']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/TaskTracker", DoNotGenerateAcw=true)]
	public partial class TaskTracker : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/TaskTracker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TaskTracker); }
		}

		protected TaskTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='TaskTracker']/constructor[@name='TaskTracker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public TaskTracker () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TaskTracker)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getCurrentTaskId;
#pragma warning disable 0169
		static Delegate GetGetCurrentTaskIdHandler ()
		{
			if (cb_getCurrentTaskId == null)
				cb_getCurrentTaskId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurrentTaskId);
			return cb_getCurrentTaskId;
		}

		static long n_GetCurrentTaskId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.TaskTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.TaskTracker> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTaskId;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentTaskId;
		public virtual long CurrentTaskId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='TaskTracker']/method[@name='getCurrentTaskId' and count(parameter)=0]"
			[Register ("getCurrentTaskId", "()J", "GetGetCurrentTaskIdHandler")]
			get {
				if (id_getCurrentTaskId == IntPtr.Zero)
					id_getCurrentTaskId = JNIEnv.GetMethodID (class_ref, "getCurrentTaskId", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getCurrentTaskId);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getCurrentTaskId);
			}
		}

		static Delegate cb_isMostCurrentTask_J;
#pragma warning disable 0169
		static Delegate GetIsMostCurrentTask_JHandler ()
		{
			if (cb_isMostCurrentTask_J == null)
				cb_isMostCurrentTask_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_IsMostCurrentTask_J);
			return cb_isMostCurrentTask_J;
		}

		static bool n_IsMostCurrentTask_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mopub.Mobileads.TaskTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.TaskTracker> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMostCurrentTask (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isMostCurrentTask_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='TaskTracker']/method[@name='isMostCurrentTask' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("isMostCurrentTask", "(J)Z", "GetIsMostCurrentTask_JHandler")]
		public virtual bool IsMostCurrentTask (long p0)
		{
			if (id_isMostCurrentTask_J == IntPtr.Zero)
				id_isMostCurrentTask_J = JNIEnv.GetMethodID (class_ref, "isMostCurrentTask", "(J)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isMostCurrentTask_J, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isMostCurrentTask_J, new JValue (p0));
		}

		static Delegate cb_markTaskCompleted_J;
#pragma warning disable 0169
		static Delegate GetMarkTaskCompleted_JHandler ()
		{
			if (cb_markTaskCompleted_J == null)
				cb_markTaskCompleted_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_MarkTaskCompleted_J);
			return cb_markTaskCompleted_J;
		}

		static void n_MarkTaskCompleted_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mopub.Mobileads.TaskTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.TaskTracker> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkTaskCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_markTaskCompleted_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='TaskTracker']/method[@name='markTaskCompleted' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("markTaskCompleted", "(J)V", "GetMarkTaskCompleted_JHandler")]
		public virtual void MarkTaskCompleted (long p0)
		{
			if (id_markTaskCompleted_J == IntPtr.Zero)
				id_markTaskCompleted_J = JNIEnv.GetMethodID (class_ref, "markTaskCompleted", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_markTaskCompleted_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_markTaskCompleted_J, new JValue (p0));
		}

		static Delegate cb_newTaskStarted;
#pragma warning disable 0169
		static Delegate GetNewTaskStartedHandler ()
		{
			if (cb_newTaskStarted == null)
				cb_newTaskStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NewTaskStarted);
			return cb_newTaskStarted;
		}

		static void n_NewTaskStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.TaskTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.TaskTracker> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.NewTaskStarted ();
		}
#pragma warning restore 0169

		static IntPtr id_newTaskStarted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='TaskTracker']/method[@name='newTaskStarted' and count(parameter)=0]"
		[Register ("newTaskStarted", "()V", "GetNewTaskStartedHandler")]
		public virtual void NewTaskStarted ()
		{
			if (id_newTaskStarted == IntPtr.Zero)
				id_newTaskStarted = JNIEnv.GetMethodID (class_ref, "newTaskStarted", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_newTaskStarted);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_newTaskStarted);
		}

	}
}
