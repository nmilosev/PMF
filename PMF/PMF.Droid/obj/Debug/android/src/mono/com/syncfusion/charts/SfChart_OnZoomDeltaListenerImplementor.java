package mono.com.syncfusion.charts;


public class SfChart_OnZoomDeltaListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.charts.SfChart.OnZoomDeltaListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_OnZoomDeltaListener:(Lcom/syncfusion/charts/SfChart;Lcom/syncfusion/charts/ChartZoomDeltaEvent;)V:GetOnZoomDeltaListener_Lcom_syncfusion_charts_SfChart_Lcom_syncfusion_charts_ChartZoomDeltaEvent_Handler:Com.Syncfusion.Charts.SfChart/IOnZoomDeltaListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.SfChart+IOnZoomDeltaListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", SfChart_OnZoomDeltaListenerImplementor.class, __md_methods);
	}


	public SfChart_OnZoomDeltaListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SfChart_OnZoomDeltaListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.SfChart+IOnZoomDeltaListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void OnZoomDeltaListener (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.ChartZoomDeltaEvent p1)
	{
		n_OnZoomDeltaListener (p0, p1);
	}

	private native void n_OnZoomDeltaListener (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.ChartZoomDeltaEvent p1);

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
