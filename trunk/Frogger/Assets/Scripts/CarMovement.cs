using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {
	
	private float speed;
	
	private bool collision = false;
	
	// Use this for initialization
	void Start () {
		speed = Random.Range(90, 120);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (!collision)
		{
			rigidbody.velocity = speed * transform.forward;
		}
	}
	
	void OnCollisionEnter(Collision ci)
	{
		Debug.Log(string.Format("rv: {0}", ci.relativeVelocity));
		if (ci.collider.tag == "car" || ci.collider.tag == "motorcycle" || ci.collider.tag == "truck")
		{
			Debug.Log(string.Format("Car {0} Motorcylce {1} Truck {2}", ci.collider.tag == "car", ci.collider.tag == "motorcycle", ci.collider.tag == "truck"));
			collision = true;
			rigidbody.AddForce(ci.relativeVelocity * -100);
		}
	}
}
