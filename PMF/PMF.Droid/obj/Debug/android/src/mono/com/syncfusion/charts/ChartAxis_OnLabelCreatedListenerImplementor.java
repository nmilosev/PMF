package mono.com.syncfusion.charts;


public class ChartAxis_OnLabelCreatedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.charts.ChartAxis.OnLabelCreatedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onLabelCreated:(ILcom/syncfusion/charts/ChartAxis$ChartAxisLabel;)V:GetOnLabelCreated_ILcom_syncfusion_charts_ChartAxis_ChartAxisLabel_Handler:Com.Syncfusion.Charts.ChartAxis/IOnLabelCreatedListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.ChartAxis+IOnLabelCreatedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", ChartAxis_OnLabelCreatedListenerImplementor.class, __md_methods);
	}


	public ChartAxis_OnLabelCreatedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChartAxis_OnLabelCreatedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.ChartAxis+IOnLabelCreatedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void onLabelCreated (int p0, com.syncfusion.charts.ChartAxis.ChartAxisLabel p1)
	{
		n_onLabelCreated (p0, p1);
	}

	private native void n_onLabelCreated (int p0, com.syncfusion.charts.ChartAxis.ChartAxisLabel p1);

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
