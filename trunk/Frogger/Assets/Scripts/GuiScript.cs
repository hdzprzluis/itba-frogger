using UnityEngine;
using System.Collections;

public class GuiScript : MonoBehaviour
{
	public bool show = false;


	// Use this for initialization
	void Start ()
	{
		show = false;
	}

	// Update is called once per frame
	void Update ()
	{
		
	}


	void OnGUI ()
	{
		// Make a background box
		// ininico x inici y, largo, ancho
		if(show){
			int positionX;
			int positionY;
			int menuContainerHeight = 400;
			int menuContainerWidth = 400;
			positionX = Screen.width / 2 - menuContainerWidth / 2;
			positionY = Screen.height / 2 - menuContainerHeight / 2;
						
			GUI.Box (new Rect (positionX, positionY, menuContainerWidth, menuContainerHeight), "Sure?");
			
			// 
			if (GUI.Button (new Rect (positionX + 10, positionY + 80, 380, 100), "Yes")) {
				Application.Quit();
			}
			
			// 2do boton
			if (GUI.Button (new Rect (positionX + 10, positionY + 190, 380, 100), "Cancel")) {
				show = false;	
			}
		
		}
	}
}
