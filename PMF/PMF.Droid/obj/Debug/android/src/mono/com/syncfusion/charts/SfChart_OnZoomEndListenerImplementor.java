package mono.com.syncfusion.charts;


public class SfChart_OnZoomEndListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.charts.SfChart.OnZoomEndListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_OnZoomEndListener:(Lcom/syncfusion/charts/SfChart;Lcom/syncfusion/charts/ChartZoomEvent;)V:GetOnZoomEndListener_Lcom_syncfusion_charts_SfChart_Lcom_syncfusion_charts_ChartZoomEvent_Handler:Com.Syncfusion.Charts.SfChart/IOnZoomEndListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.SfChart+IOnZoomEndListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", SfChart_OnZoomEndListenerImplementor.class, __md_methods);
	}


	public SfChart_OnZoomEndListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SfChart_OnZoomEndListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.SfChart+IOnZoomEndListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void OnZoomEndListener (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.ChartZoomEvent p1)
	{
		n_OnZoomEndListener (p0, p1);
	}

	private native void n_OnZoomEndListener (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.ChartZoomEvent p1);

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
