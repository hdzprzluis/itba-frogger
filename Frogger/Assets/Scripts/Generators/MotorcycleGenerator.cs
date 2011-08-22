using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MotorcycleGenerator : VehicleGenerator {

	public GameObject vespaPrefab;
	public GameObject bantamPrefab;
	
	void Start () {
		pool = new List<GameObject>();
		initialPosition = new Vector3(-126.0F, -1.46F, -450.0F);
		
		for( int i = 0 ; i < 20 ; ++i )
		{
			GameObject moto;
			int selectionPrefab = Random.Range(0, 2);
			if( selectionPrefab == 0 )
			{
				moto = Instantiate(vespaPrefab, initialPosition, Quaternion.identity) as GameObject;
				//Debug.Log("Se crea una Vespa");
			}
			else
			{
				moto = Instantiate(bantamPrefab, initialPosition, Quaternion.identity) as GameObject;
				//Debug.Log("Se crea una Bantam");
			}
			
			moto.SetActiveRecursively(false);
			pool.Add(moto);
		}
	}
}
