package md599d3aa520eff97dcee55b2e9000bea44;


public class ChartTooltipBehaviorHelper
	extends com.syncfusion.charts.ChartTooltipBehavior
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouchDown:(FF)V:GetOnTouchDown_FFHandler\n" +
			"n_onTouchMove:(FF)V:GetOnTouchMove_FFHandler\n" +
			"n_onTouchUp:(FF)V:GetOnTouchUp_FFHandler\n" +
			"n_onDoubleTap:(FF)V:GetOnDoubleTap_FFHandler\n" +
			"n_getView:(Lcom/syncfusion/charts/TooltipView;)Landroid/view/View;:GetGetView_Lcom_syncfusion_charts_TooltipView_Handler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.SfChart.XForms.Droid.ChartTooltipBehaviorHelper, Syncfusion.SfChart.XForms.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=null", ChartTooltipBehaviorHelper.class, __md_methods);
	}


	public ChartTooltipBehaviorHelper () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChartTooltipBehaviorHelper.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfChart.XForms.Droid.ChartTooltipBehaviorHelper, Syncfusion.SfChart.XForms.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onTouchDown (float p0, float p1)
	{
		n_onTouchDown (p0, p1);
	}

	private native void n_onTouchDown (float p0, float p1);


	public void onTouchMove (float p0, float p1)
	{
		n_onTouchMove (p0, p1);
	}

	private native void n_onTouchMove (float p0, float p1);


	public void onTouchUp (float p0, float p1)
	{
		n_onTouchUp (p0, p1);
	}

	private native void n_onTouchUp (float p0, float p1);


	public void onDoubleTap (float p0, float p1)
	{
		n_onDoubleTap (p0, p1);
	}

	private native void n_onDoubleTap (float p0, float p1);


	public android.view.View getView (com.syncfusion.charts.TooltipView p0)
	{
		return n_getView (p0);
	}

	private native android.view.View n_getView (com.syncfusion.charts.TooltipView p0);

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
