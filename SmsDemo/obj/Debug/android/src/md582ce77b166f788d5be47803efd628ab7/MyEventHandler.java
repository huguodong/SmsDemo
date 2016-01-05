package md582ce77b166f788d5be47803efd628ab7;


public class MyEventHandler
	extends cn.smssdk.EventHandler
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_afterEvent:(IILjava/lang/Object;)V:GetAfterEvent_IILjava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("SmsDemo.MyEventHandler, SmsDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyEventHandler.class, __md_methods);
	}


	public MyEventHandler () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MyEventHandler.class)
			mono.android.TypeManager.Activate ("SmsDemo.MyEventHandler, SmsDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MyEventHandler (android.os.Handler p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == MyEventHandler.class)
			mono.android.TypeManager.Activate ("SmsDemo.MyEventHandler, SmsDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.OS.Handler, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void afterEvent (int p0, int p1, java.lang.Object p2)
	{
		n_afterEvent (p0, p1, p2);
	}

	private native void n_afterEvent (int p0, int p1, java.lang.Object p2);

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
