using System;

public class CarManager
{
	private static CarManager singleton;
	public int ticks;
	
	public static CarManager getInstance()
	{
		if( singleton == null )
			singleton = new CarManager();
		return singleton;
	}
}
