using UnityEngine;
using System.Collections;

public class TitleControl : MonoBehaviour {
	
	private int aux = 0;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("RotateTitle", 0, 0.5F);
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void RotateTitle(){
		 
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
