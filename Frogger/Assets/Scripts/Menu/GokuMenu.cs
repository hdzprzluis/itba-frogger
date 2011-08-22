using UnityEngine;
using System.Collections;

public class GokuMenu : MonoBehaviour {
	
	private float time = 0.0f;
	public float interpolationPeriod = 0.1f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 time += Time.deltaTime;

   		 if (time >= interpolationPeriod) {
    	    time = 0.0f;
			transform.Rotate(new Vector3(0,10,0));
  	  		}
	}
}
