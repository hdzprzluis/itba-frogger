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
	
	void Update()
	{
		//Vector3 fwd = rigidbody.position;
		//Debug.Log(string.Format("CAR Object {0} Position {1}", transform.tag, transform.position));
		Ray ray = new Ray(transform.position, Vector3.forward);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 100.0F)){
			Debug.DrawLine(ray.origin, hit.point);
			Debug.Log(string.Format("COLLISION CAR Tag {0}", hit.collider.tag));
			transform.eulerAngles = new Vector3(0,180,0);
		}
	}
	
	void OnCollisionEnter(Collision ci)
	{
		if (ci.collider.tag == "car" || ci.collider.tag == "motorcycle" || ci.collider.tag == "truck")
		{
			Debug.Log(string.Format("Car {0} Motorcylce {1} Truck {2}", ci.collider.tag == "car", ci.collider.tag == "motorcycle", ci.collider.tag == "truck"));
			collision = true;
			rigidbody.AddForce(ci.relativeVelocity * -100);
		}
	}
}
