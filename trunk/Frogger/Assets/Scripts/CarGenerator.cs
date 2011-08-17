using UnityEngine;
using System.Collections;

public class CarGenerator: MonoBehaviour {

	public GameObject carPreFab;
	private CarManager manager;
	
	// Use this for initialization
	void Start () {
		manager = CarManager.getInstance();
	}
	
	void FixedUpdate()
	{
		CarOption option = CarOption.Empty;
		manager.ticks += 1;
		//Debug.Log(string.Format("Object {0}, TICKS -- {1}",gameObject.tag, manager.ticks));
		if ( manager.ticks % manager.motorcycleFreq == 0 )
			option = CarOption.Motorcycle;
		else if( manager.ticks % manager.carFreq == 0 )
			option = CarOption.Car;
		else if ( manager.ticks % manager.truckFreq == 0 )
			option = CarOption.Truck;
		
		if ( option != CarOption.Empty )
			RandomPrefabCreator(option);
	}
	
	void RandomPrefabCreator(CarOption option)
	{
		Vector3 position = Vector3.zero;
		if ( option == CarOption.Car && gameObject.tag == "car")
		{
			Debug.Log(string.Format("Creating Car"));
			position = new Vector3(-44.0F, 1.0F, -420.0F);
		}
		else if ( option == CarOption.Truck && gameObject.tag == "truck" )
		{
			Debug.Log(string.Format("Creating Truck"));
			position = new Vector3(114.0F, 1.5F, -400.0F);
		}
		else if ( option == CarOption.Motorcycle && gameObject.tag == "motorcycle" )
		{
			Debug.Log(string.Format("Creating Motorcycle"));
			position = new Vector3(-185.0F, -1.46F, -450.0F);
		}
		
		//Debug.Log(string.Format("Position Prefab {0}", position));
		if( position.x != 0 && position.y != 0 && position.z != 0)
		{
			GameObject car = Instantiate(carPreFab, position, Quaternion.identity) as GameObject;
			car.rigidbody.velocity = carPreFab.rigidbody.velocity;
			//Debug.Log(string.Format("After Position Prefab {0}", car.transform.position));
		}
	}
		
}