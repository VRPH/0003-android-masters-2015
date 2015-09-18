using UnityEngine;
using System.Collections;

public class CubeGenerator : MonoBehaviour {
	public float delay = 0.1f;
	public float height = 10f;
	public GameObject cube;

	float r = 2;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", delay, delay);
	}

	void Spawn () {
		Instantiate(cube, 
					new Vector3(Random.Range(-20, -2), height + Random.Range (-r,r), Random.Range(2, 20)), 
					Quaternion.identity);
		Instantiate(cube, 
		            new Vector3(Random.Range(2, 20), height + Random.Range (-r,r), Random.Range(-20, -2)), 
					Quaternion.identity);
		Instantiate(cube, 
		            new Vector3(Random.Range(2, 20), height + Random.Range (-r,r), Random.Range(2, 20)), 
					Quaternion.identity);
		Instantiate(cube, 
		            new Vector3(Random.Range(-20, 2), height + Random.Range (-r,r), Random.Range(-20, -2)), 
					Quaternion.identity);
	}

	void Update (){
		if (gameObject.transform.position.y <= -10)
			Destroy (cube);
	}
}
