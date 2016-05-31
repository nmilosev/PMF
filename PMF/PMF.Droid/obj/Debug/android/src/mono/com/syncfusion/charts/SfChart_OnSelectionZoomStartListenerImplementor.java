package mono.com.syncfusion.charts;


public class SfChart_OnSelectionZoomStartListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.charts.SfChart.OnSelectionZoomStartListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onSelectionZoomStartListener:(Lcom/syncfusion/charts/SfChart;Lcom/syncfusion/charts/ChartSelectionZoomEvent;)V:GetOnSelectionZoomStartListener_Lcom_syncfusion_charts_SfChart_Lcom_syncfusion_charts_ChartSelectionZoomEvent_Handler:Com.Syncfusion.Charts.SfChart/IOnSelectionZoomStartListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.SfChart+IOnSelectionZoomStartListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", SfChart_OnSelectionZoomStartListenerImplementor.class, __md_methods);
	}


	public SfChart_OnSelectionZoomStartListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SfChart_OnSelectionZoomStartListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.SfChart+IOnSelectionZoomStartListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void onSelectionZoomStartListener (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.ChartSelectionZoomEvent p1)
	{
		n_onSelectionZoomStartListener (p0, p1);
	}

	private native void n_onSelectionZoomStartListener (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.ChartSelectionZoomEvent p1);

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
