using UnityEngine;
using System.Collections;

public class CubeGenerator : MonoBehaviour {
	public float delay = 0.1f;
	public float height = 10f;
	public GameObject cube;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", delay, delay);
	}
	
	// Update is called once per frame
	void Spawn () {
		float r_0 = Random.Range(-20, -2);
		float r_1 = Random.Range(2, 20);
		float r_2 = Random.Range(-20, -2);
		float r_3 = Random.Range(2, 20);
		var instance1 = Instantiate(cube, new Vector3(r_0, height, r_1), Quaternion.identity) as GameObject;
		var instance2 = Instantiate(cube, new Vector3(r_2, height, r_3), Quaternion.identity) as GameObject;
		instance1.transform.localScale += new Vector3(0, Random.Range(5,15), 0);
		instance2.transform.localScale += new Vector3(0, Random.Range(10,15), 0);
	}

	void Update (){
		if (gameObject.transform.position.y <= -10)
			Destroy (cube);
	}
}
