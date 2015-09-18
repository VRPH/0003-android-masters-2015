using UnityEngine;
using System.Collections;

// Applies an explosion force to all nearby rigidbodies
public class Explode : MonoBehaviour {
	public GameObject explosionSphere;
	public float radius = 20.0F;
	public float power = 100.0F;

	void Start(){
	}
	
	public void applyExplosion() {
		Vector3 explosionPos = transform.position;
		Instantiate (explosionSphere, transform.position, Quaternion.identity);
		//GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		//sphere.transform.position = transform.position;

		Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
		foreach (Collider hit in colliders) {
			Rigidbody rb = hit.GetComponent<Rigidbody>();
			//GameObject deadCube = hit;

			if (rb != null){
				rb.AddExplosionForce(power, explosionPos, radius, 0F);
				StartCoroutine(explosionDelay());
				Destroy(hit);
			}
				
			
		}
	}

	IEnumerator explosionDelay(){
		yield return new WaitForSeconds(1);
	}
}