using UnityEngine;
using System.Collections;

public class CarGenerator: MonoBehaviour {

	public GameObject vehiculePrefab;
	private int ticks;
	private int freq;
	
	void Start () {
		freq = 100;
	}
	
	void FixedUpdate()
	{
		ticks += 1;
		if ( ticks % freq == 0 )
		{
			Debug.Log(string.Format("Car Ticks {0}", ticks));
			GameObject car = Instantiate(vehiculePrefab, new Vector3(-44.0F, 1.4F, -420.0F), Quaternion.identity) as GameObject;
			//car.rigidbody.velocity = vehiculePrefab.rigidbody.velocity;
		}
	}		
}