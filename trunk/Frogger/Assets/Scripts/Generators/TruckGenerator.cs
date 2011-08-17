using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TruckGenerator : MonoBehaviour {

	public GameObject cementPrefab;
	public GameObject ramPrefab;
	private List<GameObject> list;
	private int ticks;
	private int freq;
	
	void Start () {
		freq = 150;
		list = new List<GameObject>();
		list.Add(cementPrefab);
		list.Add(ramPrefab);
	}
	
	void FixedUpdate()
	{
		ticks += 1;
		if ( ticks % freq == 0 )
		{
			Debug.Log(string.Format("Truck Ticks {0}", ticks));
			int selectionPrefab = Random.Range(0, list.Count);
			GameObject car = Instantiate(list[selectionPrefab], new Vector3(114.0F, 1.5F, -400.0F), Quaternion.identity) as GameObject;
			//car.rigidbody.velocity = cementPrefab.rigidbody.velocity;
		}
	}
}
