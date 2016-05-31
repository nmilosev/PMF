package mono.com.syncfusion.charts;


public class SfChart_OnSelectionChangingListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.charts.SfChart.OnSelectionChangingListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onSelectionChanging:(Lcom/syncfusion/charts/SfChart;Lcom/syncfusion/charts/ChartSelectionChangingEvent;)V:GetOnSelectionChanging_Lcom_syncfusion_charts_SfChart_Lcom_syncfusion_charts_ChartSelectionChangingEvent_Handler:Com.Syncfusion.Charts.SfChart/IOnSelectionChangingListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.SfChart+IOnSelectionChangingListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", SfChart_OnSelectionChangingListenerImplementor.class, __md_methods);
	}


	public SfChart_OnSelectionChangingListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SfChart_OnSelectionChangingListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.SfChart+IOnSelectionChangingListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void onSelectionChanging (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.ChartSelectionChangingEvent p1)
	{
		n_onSelectionChanging (p0, p1);
	}

	private native void n_onSelectionChanging (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.ChartSelectionChangingEvent p1);

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
