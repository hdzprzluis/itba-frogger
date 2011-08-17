using System;

public class CarManager
{
	private static CarManager singleton;
	public int ticks;
	public int motorcycleFreq = 280;
	public int carFreq = 325;
	public int truckFreq = 614;
	
	public static CarManager getInstance()
	{
		if( singleton == null )
			singleton = new CarManager();
		return singleton;
	}
}
