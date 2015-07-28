using UnityEngine;
using System.Collections;

public class GemCollect : MonoBehaviour {

	public static int gemCount; 
		
	// Update is called once per frame
	void Update () {
		transform.Rotate (0f,5f,0f);
	}

	void OnTriggerEnter (Collider collider) {
		switch (collider.gameObject.name) {
		case "Player":

			GameLogic.gemCount++;
			Destroy (gameObject);

			break;
		}
	}
}
