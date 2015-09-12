using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
	}

	//void OnCollisionEnter()
	//{
	//	Destroy (gameObject);
	//}
}
