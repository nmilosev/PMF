package mono.com.syncfusion.charts;


public class ChartAxis_OnActualRangeChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.charts.ChartAxis.OnActualRangeChangedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onActualRangeChanged:(Lcom/syncfusion/charts/ActualRangeChangedEvent;)V:GetOnActualRangeChanged_Lcom_syncfusion_charts_ActualRangeChangedEvent_Handler:Com.Syncfusion.Charts.ChartAxis/IOnActualRangeChangedListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.ChartAxis+IOnActualRangeChangedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", ChartAxis_OnActualRangeChangedListenerImplementor.class, __md_methods);
	}


	public ChartAxis_OnActualRangeChangedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChartAxis_OnActualRangeChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.ChartAxis+IOnActualRangeChangedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void onActualRangeChanged (com.syncfusion.charts.ActualRangeChangedEvent p0)
	{
		n_onActualRangeChanged (p0);
	}

	private native void n_onActualRangeChanged (com.syncfusion.charts.ActualRangeChangedEvent p0);

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
