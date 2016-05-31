package mono.com.syncfusion.charts;


public class ChartStyle_OnValueChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.charts.ChartStyle.OnValueChangedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onValueChanged:(Ljava/lang/String;Z)V:GetOnValueChanged_Ljava_lang_String_ZHandler:Com.Syncfusion.Charts.ChartStyle/IOnValueChangedListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.ChartStyle+IOnValueChangedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", ChartStyle_OnValueChangedListenerImplementor.class, __md_methods);
	}


	public ChartStyle_OnValueChangedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChartStyle_OnValueChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.ChartStyle+IOnValueChangedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void onValueChanged (java.lang.String p0, boolean p1)
	{
		n_onValueChanged (p0, p1);
	}

	private native void n_onValueChanged (java.lang.String p0, boolean p1);

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
