package mono.com.syncfusion.charts;


public class SfChart_OnTooltipCreatedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.charts.SfChart.OnTooltipCreatedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreated:(Lcom/syncfusion/charts/SfChart;Lcom/syncfusion/charts/TooltipView;)V:GetOnCreated_Lcom_syncfusion_charts_SfChart_Lcom_syncfusion_charts_TooltipView_Handler:Com.Syncfusion.Charts.SfChart/IOnTooltipCreatedListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.SfChart+IOnTooltipCreatedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", SfChart_OnTooltipCreatedListenerImplementor.class, __md_methods);
	}


	public SfChart_OnTooltipCreatedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SfChart_OnTooltipCreatedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.SfChart+IOnTooltipCreatedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void onCreated (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.TooltipView p1)
	{
		n_onCreated (p0, p1);
	}

	private native void n_onCreated (com.syncfusion.charts.SfChart p0, com.syncfusion.charts.TooltipView p1);

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
