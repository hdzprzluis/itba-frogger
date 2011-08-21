using UnityEngine;
using System.Collections;

public class ExitControl: MonoBehaviour {
	
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
		GameObject wantToExit = GameObject.Find("ExitMenuGUI");
		GuiScript themenu = wantToExit.GetComponent<GuiScript>();
		themenu.show = true;
		renderer.material.color= Color.white;
	}		
}
