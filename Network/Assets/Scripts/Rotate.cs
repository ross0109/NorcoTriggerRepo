using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	Vector3 lookTarget;
	public Transform prefab;
	int shootSpeed = 1500;

	void Start () {
	
	}

	void Update () {
		//if(networkView.isMine){
			Vector3 mousePos = Input.mousePosition;
			Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
			worldPos.y = transform.position.y;
			transform.LookAt(worldPos);		
			if(Input.GetMouseButtonDown(0)){
				Transform b = (Transform)Instantiate (prefab, transform.position, transform.localRotation);
				b.rigidbody.AddForce(b.transform.forward * shootSpeed);
			//}
		}
	}
}
