package mono.com.syncfusion.charts;


public class SfChart_OnSelectionZoomDeltaListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.charts.SfChart.OnSelectionZoomDeltaListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_OnSelectionZoomDeltaListener:(Lcom/syncfusion/charts/SfChart;Lcom/syncfusion/charts/ChartSelectionZoomDeltaEvent;)V:GetOnSelectionZoomDeltaListener_Lcom_syncfusion_charts_SfChart_Lcom_syncfusion_charts_ChartSelectionZoomDeltaEvent_Handler:Com.Syncfusion.Charts.SfChart/IOnSelectionZoomDeltaListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.SfChart+IOnSelectionZoomDeltaListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", SfChart_OnSelectionZoomDeltaListenerImplementor.class, __md_methods);
	}


	public SfChart_OnSelectionZoomDeltaListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SfChart_OnSelectionZoomDeltaListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.SfChart+IOnSelectionZoomDeltaListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void OnSelectionZoomDeltaListener (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.ChartSelectionZoomDeltaEvent p1)
	{
		n_OnSelectionZoomDeltaListener (p0, p1);
	}

	private native void n_OnSelectionZoomDeltaListener (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.ChartSelectionZoomDeltaEvent p1);

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
