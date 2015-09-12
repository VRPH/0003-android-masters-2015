using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	public float depthBelow = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < (-1)*depthBelow)
			Destroy (gameObject);
	}

	public void killObject (){
		Destroy (gameObject);
	}
}
