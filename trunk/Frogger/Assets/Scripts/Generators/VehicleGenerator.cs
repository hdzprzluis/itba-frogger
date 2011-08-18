using System;
using UnityEngine;
using System.Collections.Generic;

public class VehicleGenerator : MonoBehaviour
{
	protected List<GameObject> pool;
	protected int ticks;
	protected int freq;
	protected Vector3 initialPosition;
	
	void FixedUpdate()
	{
		ticks += 1;
		if ( ticks % freq == 0 )
		{
			InitGameObject();
			
		}
	}
	
	public void DestroyObject(GameObject vehicle)
	{
		vehicle.SetActiveRecursively(false);
		pool.Add(vehicle);
		Debug.Log(string.Format("Eliminando {0}", vehicle.tag));
	}
	
	public void InitGameObject()
	{
		GameObject vehicle = pool[0];
		pool.RemoveAt(0);
		vehicle.transform.position = initialPosition;
		vehicle.SetActiveRecursively(true);
	}

}

