using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {
	
	private float speed;
	
	private bool collision = false;
	
	// Use this for initialization
	void Start () {
		if ( collider.tag == "car" )
			speed = Random.Range(90, 120);
		else if (collider.tag == "truck" )
			speed = Random.Range(50, 90);
		else if (collider.tag == "motorcycle" )
			speed = Random.Range(120, 180);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (!collision)
		{
			rigidbody.velocity = speed * transform.forward;
		}
	}
	
	void Update()
	{
		Ray ray = new Ray(transform.position, Vector3.forward);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 100.0F)){
			// Then they crush, it reduces their speed
			rigidbody.velocity = hit.collider.rigidbody.velocity * 0.8F;
		}
	}
	
	void OnCollisionEnter(Collision ci)
	{
		if (ci.collider.tag == "car" || ci.collider.tag == "motorcycle" || ci.collider.tag == "truck")
		{
			//Debug.Log(string.Format("Car {0} Motorcylce {1} Truck {2}", ci.collider.tag == "car", ci.collider.tag == "motorcycle", ci.collider.tag == "truck"));
			collision = true;
			rigidbody.AddForce(ci.relativeVelocity * -100);
		}
	}
}
