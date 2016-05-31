package mono.com.syncfusion.charts;


public class ChartColorModel_ValueChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.charts.ChartColorModel.ValueChangedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_valueChanged:(Ljava/lang/String;)V:GetValueChanged_Ljava_lang_String_Handler:Com.Syncfusion.Charts.ChartColorModel/IValueChangedListenerInvoker, Syncfusion.SfChart.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.ChartColorModel+IValueChangedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", ChartColorModel_ValueChangedListenerImplementor.class, __md_methods);
	}


	public ChartColorModel_ValueChangedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChartColorModel_ValueChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.ChartColorModel+IValueChangedListenerImplementor, Syncfusion.SfChart.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89", "", this, new java.lang.Object[] {  });
	}


	public void valueChanged (java.lang.String p0)
	{
		n_valueChanged (p0);
	}

	private native void n_valueChanged (java.lang.String p0);

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
