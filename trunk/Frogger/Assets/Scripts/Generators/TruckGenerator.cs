using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TruckGenerator : VehicleGenerator {

	public GameObject cementPrefab;
	public GameObject ramPrefab;
	
	void Start () {
		freq = 150;
		pool = new List<GameObject>();
		initialPosition = new Vector3(114.0F, 1.5F, -400.0F);
		
		for( int i = 0 ; i < 20 ; ++i )
		{
			GameObject truck;
			int selectionPrefab = Random.Range(0, 2);
			if( selectionPrefab == 0 )
			{
				truck = Instantiate(cementPrefab, initialPosition, Quaternion.identity) as GameObject;
				Debug.Log("Se crea una Cement");
			}
			else
			{
				truck = Instantiate(ramPrefab, initialPosition, Quaternion.identity) as GameObject;
				Debug.Log("Se crea una Ram");
			}
			
			truck.SetActiveRecursively(false);
			pool.Add(truck);
		}
	}
}
