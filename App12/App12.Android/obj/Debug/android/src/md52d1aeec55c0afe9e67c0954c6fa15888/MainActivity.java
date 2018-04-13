package md52d1aeec55c0afe9e67c0954c6fa15888;


public class MainActivity
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.FormsAppCompatActivity
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnSystemUiVisibilityChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onWindowFocusChanged:(Z)V:GetOnWindowFocusChanged_ZHandler\n" +
			"n_onSystemUiVisibilityChange:(I)V:GetOnSystemUiVisibilityChange_IHandler:Android.Views.View/IOnSystemUiVisibilityChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("App12.Droid.MainActivity, App12.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("App12.Droid.MainActivity, App12.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onWindowFocusChanged (boolean p0)
	{
		n_onWindowFocusChanged (p0);
	}

	private native void n_onWindowFocusChanged (boolean p0);


	public void onSystemUiVisibilityChange (int p0)
	{
		n_onSystemUiVisibilityChange (p0);
	}

	private native void n_onSystemUiVisibilityChange (int p0);

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
