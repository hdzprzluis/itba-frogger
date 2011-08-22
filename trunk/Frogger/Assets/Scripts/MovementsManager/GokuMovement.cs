using UnityEngine;
using System.Collections;

public class GokuMovement : MonoBehaviour {
	
	private Vector3 initialPosition;
	private ParticleEmitter flame;
	private ParticleEmitter smoke;
	private bool enableToMove;
	private bool killed = false;
	
	private MotorcycleGenerator motoGenerator;
	private CarGenerator carGenerator;
	private TruckGenerator truckGenerator;
	

	
	// Use this for initialization
	void Start () {
		initialPosition = new Vector3(200.0F, 75.0F, -23.0F);
		transform.position = initialPosition;
		flame = transform.Find("Flames").GetComponent<ParticleEmitter>();
		smoke = transform.Find("Smoke").GetComponent<ParticleEmitter>();
		enableToMove = false;
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
				themenu.showPause = false;
				Time.timeScale = 1;
			}else{
				themenu.showPause = true;
			}

		}
		if ( enableToMove )
		{
			if( Input.GetKey(KeyCode.DownArrow) )
			{
				if ( rigidbody.position.x < 200 )
					rigidbody.position = transform.position + Vector3.right * 20;
			}
			else if( Input.GetKey(KeyCode.UpArrow) )
			{
				if ( rigidbody.position.x > -175 )
					rigidbody.position = transform.position + Vector3.right * -20;
			}
			else if( Input.GetKey(KeyCode.LeftArrow) )
			{
				if ( rigidbody.position.z > -340 )
					rigidbody.position = transform.position + Vector3.forward * -20;
			}
			else if( Input.GetKey(KeyCode.RightArrow) )
			{
				if ( rigidbody.position.z < 348 )
					rigidbody.position = transform.position + Vector3.forward * 20;
			}
			
			if ( rigidbody.position.x < -180 )
			{
				// TODO Hacer algo cuando gana
				GameObject wantToExit = GameObject.Find("GameGuiObject");
				GameGuiScript themenu = wantToExit.GetComponent<GameGuiScript>();
				themenu.showWin = true;
			}
		}
	}
	
	void stopAllVehicules()
	{
		motoGenerator.stopAllVehicules();
		carGenerator.stopAllVehicules();
		truckGenerator.stopAllVehicules();
	}
	
	void OnCollisionEnter(Collision col)
	{
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
