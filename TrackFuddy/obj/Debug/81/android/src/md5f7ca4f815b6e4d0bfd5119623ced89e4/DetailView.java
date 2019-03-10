package md5f7ca4f815b6e4d0bfd5119623ced89e4;


public class DetailView
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("TrackFuddy.Resources.layout.DetailView, TrackFuddy", DetailView.class, __md_methods);
	}


	public DetailView ()
	{
		super ();
		if (getClass () == DetailView.class)
			mono.android.TypeManager.Activate ("TrackFuddy.Resources.layout.DetailView, TrackFuddy", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
