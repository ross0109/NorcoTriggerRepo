using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {


	void Start () {
	
	}

	void Update () {
		//if(networkView.isMine){
			if(transform.position.x >= 30 || transform.position.z >=30 || transform.position.x <=-30 || transform.position.z <=-30){
				DestroyObject(this.gameObject);
			}
	//	}
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.name == "Sphere(Clone)" || other.gameObject.name == "AI")
		{
			DestroyObject(other.gameObject);
		}
	}
}
