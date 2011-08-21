using UnityEngine;
using System.Collections;

public class OptionsControl : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnMouseEnter() {
        renderer.material.color = Color.blue;
    }
	
	void OnMouseExit(){
        renderer.material.color = new Color(255,255,255,255);
	}
	void OnMouseDrag(){
		renderer.material.color = Color.red;
	}		
}
