using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	public float depthBelow = 10f;
	public float boundingBoxWidth = 100f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < (-1)*depthBelow)
			Destroy (gameObject);

		if (((Mathf.Abs (gameObject.transform.position.x)) > boundingBoxWidth) ||
		    ((Mathf.Abs (gameObject.transform.position.y)) > boundingBoxWidth) ||
		    ((Mathf.Abs (gameObject.transform.position.z)) > boundingBoxWidth))
			Destroy (gameObject);
	}

	public void killObject (){
		Destroy (gameObject);
	}

	void OnCollisionEnter(Collision collision){
		Destroy (gameObject);
	}
}
