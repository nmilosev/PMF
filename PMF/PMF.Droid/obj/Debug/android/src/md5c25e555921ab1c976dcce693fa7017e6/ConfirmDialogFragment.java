package md5c25e555921ab1c976dcce693fa7017e6;


public class ConfirmDialogFragment
	extends md5c25e555921ab1c976dcce693fa7017e6.AbstractDialogFragment_1
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Acr.UserDialogs.Fragments.ConfirmDialogFragment, Acr.UserDialogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ConfirmDialogFragment.class, __md_methods);
	}


	public ConfirmDialogFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ConfirmDialogFragment.class)
			mono.android.TypeManager.Activate ("Acr.UserDialogs.Fragments.ConfirmDialogFragment, Acr.UserDialogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
