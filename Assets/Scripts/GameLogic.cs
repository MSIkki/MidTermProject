
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public Text myTextObject;

	public static int gemCount = 0;
	
	// Use this for initialization
	void OnGUI () {
		string gemText = "Total Gems: " + gemCount;
		GUI.Box (new Rect(Screen.width - 150, 20, 130, 20), gemText);
	}
}