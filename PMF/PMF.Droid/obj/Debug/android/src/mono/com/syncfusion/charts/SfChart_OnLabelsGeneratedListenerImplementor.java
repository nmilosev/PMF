package mono.com.syncfusion.charts;


public class SfChart_OnLabelsGeneratedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.charts.SfChart.OnLabelsGeneratedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onLabelsGenerated:(Lcom/syncfusion/charts/SfChart;Ljava/util/List;)V:GetOnLabelsGenerated_Lcom_syncfusion_charts_SfChart_Ljava_util_List_Handler:Com.Syncfusion.Charts.SfChart/IOnLabelsGeneratedListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.SfChart+IOnLabelsGeneratedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", SfChart_OnLabelsGeneratedListenerImplementor.class, __md_methods);
	}


	public SfChart_OnLabelsGeneratedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SfChart_OnLabelsGeneratedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.SfChart+IOnLabelsGeneratedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void onLabelsGenerated (com.syncfusion.charts.SfChart p0, java.util.List p1)
	{
		n_onLabelsGenerated (p0, p1);
	}

	private native void n_onLabelsGenerated (com.syncfusion.charts.SfChart p0, java.util.List p1);

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
