using UnityEngine;
using System.Collections;

public class CarFactory: MonoBehaviour {

	private float nextCarIn = 0.0f; 
	public int minSpawnTime = 2;
	public int maxSpawnTime = 5;
	public GameObject carPreFab;
	
	private static int[] startPositions = {-15,5,0,-5,15};
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		nextCarIn -= Time.deltaTime;
		if (nextCarIn < 0) {
			nextCarIn = Random.Range(minSpawnTime,maxSpawnTime);
			int x, z;
			z = 45;
			x = Random.Range(0, startPositions.Length);
			x = startPositions[x];
			GameObject car = Instantiate(carPreFab, new Vector3(x, 5, z), Quaternion.identity) as GameObject;
			
		}
		
	}
}