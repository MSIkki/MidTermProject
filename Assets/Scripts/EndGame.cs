using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {
	
	public static int gemCount; 
	public Text winText;// assign in Inspector
	
	
	void OnTriggerEnter (Collider collider) {
		if (collider.gameObject.name == "Player") {
			gemCount +=1;
			Debug.Log ("Congrats!  You found all the gems (I think)!");
			winText.text = "Congrats!  You found all the gems (I think)!";
		}
	}
}