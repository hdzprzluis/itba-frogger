using UnityEngine;
using System.Collections;

public class TitleControl : MonoBehaviour {
	
	private float nextActionTime = 0.0f;
	public float period = 0.6f;
	private int aux = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextActionTime ) {
	       nextActionTime += period;
			if(aux % 4 == 0){
				transform.Rotate(new Vector3(0,0,10));
			}else if(aux % 4 == 1){
				transform.Rotate(new Vector3(0,0,-10));
			}else if(aux % 4 == 2){
				transform.Rotate(new Vector3(0,0,-10));
			}else if(aux % 4 == 3){
				transform.Rotate(new Vector3(0,0,10));
			}
			aux++;
	    }
	}
}
