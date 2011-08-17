using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {
	
	private float speed;
	private bool collision = false;
	
	// Use this for initialization
	void Start () 
	{
		if ( collider.tag == "car" )
			speed = 100.0F;
		else if ( collider.tag == "truck" )
			speed = 70.0F;
		else if ( collider.tag == "motorcycle" )
			speed = 150.0F;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
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
			// TODO Detectar si colisiona con la rana
		}
	}
}
