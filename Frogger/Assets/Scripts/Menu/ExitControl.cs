using UnityEngine;
using System.Collections;

public class ExitControl: MonoBehaviour {
	public bool selected = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(selected){
	        renderer.material.color = Color.blue;
			if(Input.GetKeyDown(KeyCode.Return)){
				OnMouseDrag();
			}
		}
	}
	
	void OnMouseEnter() {
		renderer.material.color = Color.blue;
		selected = true;
    }
	
	void OnMouseExit(){
        renderer.material.color = new Color(255,255,255,255);
		selected =  false;
	}
	void OnMouseDrag(){
		renderer.material.color = Color.red;
		GameObject wantToExit = GameObject.Find("ExitMenuGUI");
		GuiScript themenu = wantToExit.GetComponent<GuiScript>();
		themenu.show = true;
		renderer.material.color= Color.white;
	}		
}
