using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public Transform playerPrefab;

	// Use this for initialization
	void Start () {
		if(Network.isServer)
			Network.Instantiate(playerPrefab, transform.position, transform.rotation, 0);
	}
	//only called on clients
	void OnConnectedToServer(){
		Network.Instantiate(playerPrefab, transform.position, transform.rotation, 0);
	}
	//only called on the server to remove all of the player data from the server
	void OnPlayerDisconnected(NetworkPlayer player) {
		Network.RemoveRPCs(player);
		Network.DestroyPlayerObjects(player);
	}
}
