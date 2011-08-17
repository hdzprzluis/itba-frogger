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
		Debug.Log(string.Format("Object {0}, TICKS -- {1}",gameObject.tag, manager.ticks));
		if ( manager.ticks % 321 == 0 )
			option = CarOption.Motorcycle;
		else if( manager.ticks % 389 == 0 )
			option = CarOption.Car;
		else if ( manager.ticks % 543 == 0 )
			option = CarOption.Truck;
		
		if ( option != CarOption.Empty )
			RandomPrefabCreator(option);
	}
	
	void RandomPrefabCreator(CarOption option)
	{
		Vector3 position = Vector3.zero;
		if ( option == CarOption.Car)
		{
			Debug.Log(string.Format("Creating Car"));
			position = new Vector3(-44.0F, 0.0F, -260.0F);
		}
		else if ( option == CarOption.Truck )
		{
			Debug.Log(string.Format("Creating Truck"));
			position = new Vector3(114.0F, 1.5F, -280.0F);
		}
		else if ( option == CarOption.Motorcycle )
		{
			Debug.Log(string.Format("Creating Motorcycle"));
			position = new Vector3(-185.0F, -1.46F, -290.0F);
		}
		
		Debug.Log(string.Format("Position Prefab {0}", position));
		if( position.x != 0 && position.y != 0 && position.z != 0)
		{
			GameObject car = Instantiate(carPreFab, position, Quaternion.identity) as GameObject;
			car.rigidbody.velocity = carPreFab.rigidbody.velocity;
			Debug.Log(string.Format("After Position Prefab {0}", car.transform.position));
		}
	}
		
}