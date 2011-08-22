using System;
using UnityEngine;
using System.Collections.Generic;

public class VehicleGenerator : MonoBehaviour
{
	protected List<GameObject> pool;
	protected List<GameObject> vehiculesInStreet;
	protected int ticks;
	protected Vector3 initialPosition;
	private bool stopVehicules;
	
	public int freq = 150;
	
	void Awake()
	{
		vehiculesInStreet = new List<GameObject>();
	}
	
	void FixedUpdate()
	{
		ticks += 1;
		if ( ticks % freq == 0 && !stopVehicules )
		{
			InitGameObject();
		}
	}
	
	public void DestroyObject(GameObject vehicle)
	{
		vehicle.SetActiveRecursively(false);
		pool.Add(vehicle);
		vehiculesInStreet.Remove(vehicle);
		Debug.Log(string.Format("Eliminando {0}", vehicle.tag));
	}
	
	public void InitGameObject()
	{
		if( pool.Count > 0 )
		{
			GameObject vehicle = pool[0];
			pool.RemoveAt(0);
			vehiculesInStreet.Add(vehicle);
			vehicle.transform.position = initialPosition;
			vehicle.SetActiveRecursively(true);	
		}
	}
	
	public void stopAllVehicules()
	{
		stopVehicules = true;
		foreach (GameObject vehicule in pool)
			vehicule.rigidbody.velocity = Vector3.zero;	
		foreach (GameObject vehicule in vehiculesInStreet)
			vehicule.rigidbody.velocity = Vector3.zero;	
	}

}

