using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	public AudioClip carClaxon;
	public AudioClip bikeClaxon;
	public AudioClip otherHorn;
	public AudioClip quilombo;
	public AudioClip gokuDies;
	public AudioClip gokuWin;
	public AudioClip background;

	public 
	// Use this for initialization
	void Start () {
		gameObject.AddComponent<AudioSource>();
		audio.clip = background;
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if(Random.Range(0,1000) < 10){
			int a = Random.Range(0,4);
			if( a%4 == 0){
				audio.PlayOneShot(carClaxon,0.2F);
			}else if( a%4 ==1){
				audio.PlayOneShot(bikeClaxon,0.2F);
			}else if( a%4 ==2){
				audio.PlayOneShot(otherHorn,0.2F);
			}
		}
	}
	public void PlayGokuDies(){
		audio.PlayOneShot(gokuDies);
	}
	public void PlayGokuWins(){
		audio.PlayOneShot(gokuWin);
	}
	public void VolumeDown(){
		audio.volume = 0.2F;
	}
	public void VolumeUp(){
		audio.volume = 1F;
	}


}
