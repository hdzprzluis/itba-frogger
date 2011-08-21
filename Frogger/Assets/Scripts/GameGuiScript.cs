using UnityEngine;
using System.Collections;

public class GameGuiScript : MonoBehaviour {
	
	public bool showPause = false;
	public bool showWin = false;
	public bool showLoose = false;
	public Font myFont;
	float timeCounter;
	// Use this for initialization
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI ()
	{
		// Make a background box
		// ininico x inici y, largo, ancho
		if(showPause){
			GUIStyle myStyle = GUIStyle.none;
  			myStyle.font = myFont;
			myStyle.fontSize=70;
			myStyle.normal.textColor = Color.white;
			
			
			int positionX;
			int positionY;
			int menuContainerHeight = 400;
			int menuContainerWidth = 400;
			positionX = Screen.width / 2 - menuContainerWidth / 2;
			positionY = Screen.height / 2 - menuContainerHeight / 2;
			Time.timeScale = 0;
			GUI.Box (new Rect (positionX, positionY, menuContainerWidth, menuContainerHeight),"");
			
			GUI.Label(new Rect (positionX, positionY, menuContainerWidth, menuContainerHeight),"Pause",myStyle);
			
			// 
			if (GUI.Button (new Rect (positionX + 10, positionY + 80, 380, 100), "Continue")) {
				showPause = false;
							Time.timeScale = 1;
			}
			
			// 2do boton
			if (GUI.Button (new Rect (positionX + 10, positionY + 190, 380, 100), "Quit")) {
				Application.LoadLevel("s2");

			}
		
		}
		if(showLoose){
			GUIStyle myStyle = GUIStyle.none;
  			myStyle.font = myFont;
			myStyle.fontSize=80;
		//	ArrayList<Color> colorList = new ArrayList<Color>();
		//	colorList.Add(Color.white);
		//	colorList.Add(Color.red);
		//	colorList.Add(Color.yellow);	
			
			myStyle.normal.textColor = Color.white;
			
			
			int positionX;
			int positionY;
			int menuContainerHeight = 400;
			int menuContainerWidth = 570;
			positionX = Screen.width / 2 - menuContainerWidth / 2;
			positionY = Screen.height / 2 - menuContainerHeight / 2;
			GUI.Box (new Rect (positionX, positionY, menuContainerWidth, menuContainerHeight),"");
			
			
			GUI.Label(new Rect (positionX + 10, positionY, menuContainerWidth, menuContainerHeight),"You Loose",myStyle);
			
			// 
			if (GUI.Button (new Rect (positionX + 10, positionY + 90, menuContainerWidth - 20, 100), "Try Again?")) {
				showLoose = false;
				Application.LoadLevel("Scene1");
			}
			
			// 2do boton
			if (GUI.Button (new Rect (positionX + 10, positionY + 230, menuContainerWidth - 20, 100), "Main Menu")) {
				Application.LoadLevel("s2");

			}
		
		}
		if(showWin){
				GUIStyle myStyle = GUIStyle.none;
  			myStyle.font = myFont;
			myStyle.fontSize=80;
			
			myStyle.normal.textColor = Color.white;
			
			
			int positionX;
			int positionY;
			int menuContainerHeight = 400;
			int menuContainerWidth = 570;
			positionX = Screen.width / 2 - menuContainerWidth / 2;
			positionY = Screen.height / 2 - menuContainerHeight / 2;
			GUI.Box (new Rect (positionX, positionY, menuContainerWidth, menuContainerHeight),"");
			
			
			GUI.Label(new Rect (positionX + 10, positionY, menuContainerWidth, menuContainerHeight),"You Win!!",myStyle);
			
			// 
			if (GUI.Button (new Rect (positionX + 10, positionY + 90, menuContainerWidth - 20, 100), "Play Again?")) {
				showLoose = false;
				Application.LoadLevel("Scene1");
			}
			
			// 2do boton
			if (GUI.Button (new Rect (positionX + 10, positionY + 230, menuContainerWidth - 20, 100), "Main Menu")) {
				Application.LoadLevel("s2");

			}
		
		}
	}
}
