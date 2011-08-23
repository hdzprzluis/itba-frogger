using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject newgameObject = GameObject.Find("text_NewGame");
		NewGameControl newGameItem = newgameObject.GetComponent<NewGameControl>();
		
		GameObject optionobject = GameObject.Find("Text_OPTION");
		OptionsControl optionItem = optionobject.GetComponent<OptionsControl>();

		GameObject exitobject = GameObject.Find("text_Exit");
		ExitControl exitItem = exitobject.GetComponent<ExitControl>();
		
		if( Input.GetKeyDown(KeyCode.DownArrow) ){
			if(!newGameItem.selected && !optionItem.selected && !exitItem.selected){
				newGameItem.selected  = true;
			}else if(newGameItem.selected && !optionItem.selected && !exitItem.selected){
				newGameItem.renderer.material.color = new Color(255,255,255,255);
				newGameItem.selected  = false;
				optionItem.selected  = true;
			}else if(!newGameItem.selected && optionItem.selected && !exitItem.selected){
				optionItem.renderer.material.color = new Color(255,255,255,255);
				optionItem.selected  = false;
				exitItem.selected = true;
			}else if(!newGameItem.selected && !optionItem.selected && exitItem.selected){
				exitItem.renderer.material.color = new Color(255,255,255,255);
				exitItem.selected  = false;
				newGameItem.selected  = true;
			}
		}else if(Input.GetKeyDown(KeyCode.UpArrow)){
			if(!newGameItem.selected && !optionItem.selected && !exitItem.selected){
				exitItem.selected = true;
			}else if(newGameItem.selected && !optionItem.selected && !exitItem.selected){
				newGameItem.renderer.material.color = new Color(255,255,255,255);
				newGameItem.selected  = false;
				exitItem.selected  = true;
			}else if(!newGameItem.selected && optionItem.selected && !exitItem.selected){
				optionItem.renderer.material.color = new Color(255,255,255,255);
				optionItem.selected  = false;
				newGameItem.selected = true;
			}else if(!newGameItem.selected && !optionItem.selected && exitItem.selected){
				exitItem.renderer.material.color = new Color(255,255,255,255);
				exitItem.selected  = false;
				optionItem.selected  = true;
			}
		}
	}
}