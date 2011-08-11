using UnityEngine;
using System.Collections;

public class MotorcycleMovement : MonoBehaviour {
	
	private float speed;
	
	private bool collision = false;
	
	// Use this for initialization
	void Start () {
		speed = Random.Range(100, 200);
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
		if (ci.collider.tag == "car" || ci.collider.tag == "motorcycle" || ci.collider.tag == "truck")
		{
			collision = true;
			rigidbody.AddForce(ci.relativeVelocity * -100);
		}
	}
}
