using UnityEngine;
using System.Collections;

public class GokuMovement : MonoBehaviour {
	
	
	private ParticleEmitter flame;
	private ParticleEmitter smoke;
	private bool enableToMove;
	private bool killed = false;
	
	private MotorcycleGenerator motoGenerator;
	private CarGenerator carGenerator;
	private TruckGenerator truckGenerator;
	
	public int speed = 20;

	// Use this for initialization
	void Start () {
		flame = transform.Find("Flames").GetComponent<ParticleEmitter>();
		smoke = transform.Find("Smoke").GetComponent<ParticleEmitter>();
		enableToMove = false;
		transform.position = new Vector3(189, 33, 116);
		Invoke("startToPlay", 2.0F);
		
		motoGenerator = GameObject.FindGameObjectWithTag("motoGenerator").GetComponent<MotorcycleGenerator>();
		carGenerator = GameObject.FindGameObjectWithTag("carGenerator").GetComponent<CarGenerator>();
		truckGenerator = GameObject.FindGameObjectWithTag("truckGenerator").GetComponent<TruckGenerator>();
	}
	
	void startToPlay()
	{
		enableToMove = true;
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Pause)){
			GameObject wantToExit = GameObject.Find("GameGuiObject");
			GameGuiScript themenu = wantToExit.GetComponent<GameGuiScript>();
			if( themenu.showPause){
				GameObject sound = GameObject.Find("SoundObject");
				SoundManager soundM = sound.GetComponent<SoundManager>();
				soundM.VolumeUp();
				themenu.showPause = false;
				Time.timeScale = 1;
			}else{
				themenu.showPause = true;
			}

		}
		if ( enableToMove )
		{
			double width = 0.9 * ((float) (Screen.width / 2));
			double height = 0.9 * ((float) (Screen.height /2));

			
			if( Input.GetKey(KeyCode.DownArrow) )
			{
				if ( rigidbody.position.x < height )
					rigidbody.position = transform.position + Vector3.right * speed;
			}
			else if( Input.GetKey(KeyCode.UpArrow) )
			{
				if ( rigidbody.position.x > -height )
					rigidbody.position = transform.position + Vector3.left * speed;
			}
			else if( Input.GetKey(KeyCode.LeftArrow) )
			{
				if ( rigidbody.position.z > -width )
					rigidbody.position = transform.position + Vector3.back * speed;
			}
			else if( Input.GetKey(KeyCode.RightArrow) )
			{
				if ( rigidbody.position.z < width )
					rigidbody.position = transform.position + Vector3.forward * speed;
			}
			
		}
	}
	
	void stopAllVehicules()
	{
		motoGenerator.stopAllVehicules();
		carGenerator.stopAllVehicules();
		truckGenerator.stopAllVehicules();
	}
	void RotateOnWin()
	{	
		transform.Rotate(new Vector3(0,10,0));
	}
	void OnCollisionEnter(Collision col)
	{
		Debug.Log(col.collider.tag);
		if (col.collider.tag == "Finish") {
			enableToMove = false;
			InvokeRepeating ("RotateOnWin", 0, 0.1F);
			GameObject sound = GameObject.Find("SoundObject");
			SoundManager soundM = sound.GetComponent<SoundManager>();
			soundM.PlayGokuWins();
			GameObject wantToExit = GameObject.Find("GameGuiObject");		
			GameGuiScript themenu = wantToExit.GetComponent<GameGuiScript>();		
			themenu.showWin = true;	
			return;
		}
		
		flame.emit = true;
		enableToMove = false;
		col.rigidbody.AddExplosionForce(5.0F, Vector3.right, 10.0F);
		stopAllVehicules();		
		Invoke("showSmoke", 2.0F);
		if(killed == false){
			GameObject sound = GameObject.Find("SoundObject");
			SoundManager soundM = sound.GetComponent<SoundManager>();
			soundM.PlayGokuDies();
			killed = true;
		}
	}
	
	void showSmoke()
	{
		GameObject wantToExit = GameObject.Find("GameGuiObject");
		GameGuiScript themenu = wantToExit.GetComponent<GameGuiScript>();
		themenu.showLoose = true;
		flame.emit = false;
		smoke.emit = true;


		//Invoke("killGoku", 10.0F); ???
	}
	
	void killGoku()
	{
		smoke.emit = false;
		Application.LoadLevel("Scene1");
		//gameObject.SetActiveRecursively(false);
	}
		
}
