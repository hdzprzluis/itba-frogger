using UnityEngine;
using System.Collections;

public class TruckMovement : MonoBehaviour {

	private float speed;
	
	private bool collision = false;
	
	// Use this for initialization
	void Start () {
		speed = Random.Range(60, 80);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (!collision)
		{
			rigidbody.velocity = speed * transform.forward;
			//transform.Translate(speed * new Vector3(0,0,1) * Time.deltaTime);	
		}
	}
	
	void OnCollisionEnter(Collision ci)
	{
		Debug.Log(string.Format("rv: {0}", ci.relativeVelocity));
		if (ci.collider.tag == "car" || ci.collider.tag == "motorcycle" || ci.collider.tag == "truck")
		{
			collision = true;
			rigidbody.AddForce(ci.relativeVelocity * -100);
		}
	}
}
