package md599d3aa520eff97dcee55b2e9000bea44;


public class ChartZoomPanBehaviorHelper
	extends com.syncfusion.charts.ChartZoomPanBehavior
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onScaleStart:(FFF)V:GetOnScaleStart_FFFHandler\n" +
			"n_onScaleDelta:(FFF)V:GetOnScaleDelta_FFFHandler\n" +
			"n_onScaleEnd:(FFF)V:GetOnScaleEnd_FFFHandler\n" +
			"n_onTouchDown:(FF)V:GetOnTouchDown_FFHandler\n" +
			"n_onTouchMove:(FF)V:GetOnTouchMove_FFHandler\n" +
			"n_onScroll:(FFFF)V:GetOnScroll_FFFFHandler\n" +
			"n_onTouchUp:(FF)V:GetOnTouchUp_FFHandler\n" +
			"n_onDoubleTap:(FF)V:GetOnDoubleTap_FFHandler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.SfChart.XForms.Droid.ChartZoomPanBehaviorHelper, Syncfusion.SfChart.XForms.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=null", ChartZoomPanBehaviorHelper.class, __md_methods);
	}


	public ChartZoomPanBehaviorHelper () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChartZoomPanBehaviorHelper.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfChart.XForms.Droid.ChartZoomPanBehaviorHelper, Syncfusion.SfChart.XForms.Android, Version=14.1451.0.46, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onScaleStart (float p0, float p1, float p2)
	{
		n_onScaleStart (p0, p1, p2);
	}

	private native void n_onScaleStart (float p0, float p1, float p2);


	public void onScaleDelta (float p0, float p1, float p2)
	{
		n_onScaleDelta (p0, p1, p2);
	}

	private native void n_onScaleDelta (float p0, float p1, float p2);


	public void onScaleEnd (float p0, float p1, float p2)
	{
		n_onScaleEnd (p0, p1, p2);
	}

	private native void n_onScaleEnd (float p0, float p1, float p2);


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


	public void onScroll (float p0, float p1, float p2, float p3)
	{
		n_onScroll (p0, p1, p2, p3);
	}

	private native void n_onScroll (float p0, float p1, float p2, float p3);


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
