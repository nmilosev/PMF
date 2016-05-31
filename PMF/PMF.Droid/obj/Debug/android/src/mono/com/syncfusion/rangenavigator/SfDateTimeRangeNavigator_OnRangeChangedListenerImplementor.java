package mono.com.syncfusion.rangenavigator;


public class SfDateTimeRangeNavigator_OnRangeChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.rangenavigator.SfDateTimeRangeNavigator.OnRangeChangedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onRangeChanged:(Ljava/util/Date;Ljava/util/Date;)V:GetOnRangeChanged_Ljava_util_Date_Ljava_util_Date_Handler:Com.Syncfusion.Rangenavigator.SfDateTimeRangeNavigator/IOnRangeChangedListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Rangenavigator.SfDateTimeRangeNavigator+IOnRangeChangedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", SfDateTimeRangeNavigator_OnRangeChangedListenerImplementor.class, __md_methods);
	}


	public SfDateTimeRangeNavigator_OnRangeChangedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SfDateTimeRangeNavigator_OnRangeChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Rangenavigator.SfDateTimeRangeNavigator+IOnRangeChangedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void onRangeChanged (java.util.Date p0, java.util.Date p1)
	{
		n_onRangeChanged (p0, p1);
	}

	private native void n_onRangeChanged (java.util.Date p0, java.util.Date p1);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
