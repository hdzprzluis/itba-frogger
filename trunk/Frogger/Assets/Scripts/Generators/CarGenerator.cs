using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarGenerator: VehicleGenerator {

	public GameObject carPrefab;

	void Start () {
		pool = new List<GameObject>();
		initialPosition = new Vector3(-44.0F, 1.4F, -420.0F);
		
		for( int i = 0 ; i < 20 ; ++i )
		{
			GameObject car = Instantiate(carPrefab, initialPosition, Quaternion.identity) as GameObject;
			car.SetActiveRecursively(false);
			pool.Add(car);
		}
	}
}