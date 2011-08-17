using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MotorcycleGenerator : MonoBehaviour {

	public GameObject vespaPrefab;
	public GameObject bantamPrefab;
	private List<GameObject> list;
	private int ticks;
	private int freq;
	
	void Start () {
		freq = 89;
		list = new List<GameObject>();
		list.Add(vespaPrefab);
		list.Add(bantamPrefab);
	}
	
	void FixedUpdate()
	{
		ticks += 1;
		if ( ticks % freq == 0 )
		{
			Debug.Log(string.Format("Motorcycle Ticks {0}", ticks));
			int selectionPrefab = Random.Range(0, list.Count);
			GameObject car = Instantiate(list[selectionPrefab], new Vector3(-185.0F, -1.46F, -450.0F), Quaternion.identity) as GameObject;
			//car.rigidbody.velocity = bantamPrefab.rigidbody.velocity;
		}
	}
}
