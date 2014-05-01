using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	CharacterController controller;
	int speed = 5;
	Vector3 newPos = new Vector3(0, 0, 0);
	Vector3 lookTarget;

	void Start () {
		controller = gameObject.GetComponent<CharacterController>();
	}

	void Update () {
		if(networkView.isMine){
			newPos = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			controller.Move (newPos*speed*Time.deltaTime*5);
			Rotate ();
		}
	}
	void Rotate(){
		Vector3 mousePos = Input.mousePosition;
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
		worldPos.y = transform.position.y;
		transform.LookAt(worldPos);
	}
}