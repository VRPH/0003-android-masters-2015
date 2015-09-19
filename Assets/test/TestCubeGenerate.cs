using UnityEngine;
using System.Collections;

public class TestCubeGenerate : MonoBehaviour {
	public GameObject cube;
	// Use this for initialization
	void Start () {
		Instantiate (cube, new Vector3 (0f, 3f, 0.1f), Quaternion.identity);

		Instantiate (cube, new Vector3 (0f, 3f, -0.1f), Quaternion.identity);

		Instantiate (cube, new Vector3 (0.1f, 3f, 0f), Quaternion.identity);

		Instantiate (cube, new Vector3 (-0.1f, 3f, 0f), Quaternion.identity);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
