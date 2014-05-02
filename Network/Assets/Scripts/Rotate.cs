using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	Vector3 lookTarget;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rotate();
	}
	void rotate(){
		Vector3 mousePos = Input.mousePosition;
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
		worldPos.y = transform.position.y;
		transform.LookAt(worldPos);
	}
}
