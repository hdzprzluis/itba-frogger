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
	
	void Update()
	{
		//Vector3 fwd = rigidbody.position;
		//Debug.Log(string.Format("MOTORCYCLE Object {0} Position {1}", transform.tag, transform.position));
		Ray ray = new Ray(transform.position, Vector3.forward);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 100.0F)){
			Debug.DrawLine(ray.origin, hit.point);
			Debug.Log(string.Format("COLLISION MOTORCYCLE Tag {0}", hit.collider.tag));
			transform.eulerAngles = new Vector3(0,180,0);
		}
	}
	
	void OnCollisionEnter(Collision ci)
	{
		if (ci.collider.tag == "car" || ci.collider.tag == "motorcycle" || ci.collider.tag == "truck")
		{
			collision = true;
			//rigidbody.AddForce(ci.relativeVelocity * -100);
		}
	}
}
