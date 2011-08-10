using UnityEngine;
using System.Collections;

public class CarTransform: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(17 * new Vector3(0,0,-1) * Time.deltaTime);	
	}
}
