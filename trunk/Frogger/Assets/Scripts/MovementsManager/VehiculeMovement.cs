using UnityEngine;
using System.Collections;

public class VehiculeMovement : MonoBehaviour {
	
	protected float speed;
	protected bool collision = false;
	
	void FixedUpdate()
	{
		if( !collision )
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
