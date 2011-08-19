using UnityEngine;
using System.Collections;

public class Detector : MonoBehaviour {
	
	private MotorcycleGenerator motoGenerator;
	private CarGenerator carGenerator;
	private TruckGenerator truckGenerator;
	
	// Use this for initialization
	void Start () {
		motoGenerator = GameObject.FindGameObjectWithTag("motoGenerator").GetComponent<MotorcycleGenerator>();
		carGenerator = GameObject.FindGameObjectWithTag("carGenerator").GetComponent<CarGenerator>();
		truckGenerator = GameObject.FindGameObjectWithTag("truckGenerator").GetComponent<TruckGenerator>();
	
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (motoGenerator != null && col.gameObject.tag == "motorcycle")
		{
			motoGenerator.DestroyObject(col.gameObject);
		}
		else if ( carGenerator != null && col.gameObject.tag == "car")
		{
			carGenerator.DestroyObject(col.gameObject);
		}
		else if ( truckGenerator != null && col.gameObject.tag == "truck")
		{
			truckGenerator.DestroyObject(col.gameObject);
		}
	}
}
