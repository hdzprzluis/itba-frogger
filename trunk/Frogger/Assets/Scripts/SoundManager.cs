using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	public AudioClip carClaxon;
	public AudioClip bikeClaxon;
	public AudioClip otherHorn;
	public AudioClip quilombo;
	public AudioClip gokuDies;

	public 
	// Use this for initialization
	void Start () {
		gameObject.AddComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Random.Range(0,1000) < 10){
			int a = Random.Range(0,4);
			if( a%4 == 0){
				audio.PlayOneShot(carClaxon,10000);
			}else if( a%4 ==1){
				audio.PlayOneShot(bikeClaxon,10000);
			}else if( a%4 ==2){
				audio.PlayOneShot(otherHorn,10000);
			}
		}
	}
	public void PlayGokuDies(){
		audio.PlayOneShot(gokuDies,10000);
	}

}
