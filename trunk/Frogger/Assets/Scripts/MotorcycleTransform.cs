using UnityEngine;
using System.Collections;

public class MotorcycleTransform : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(20 * new Vector3(0,0,1) * Time.deltaTime);	
	}
}
