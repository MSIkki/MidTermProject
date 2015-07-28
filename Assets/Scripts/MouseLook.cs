using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	public Camera myCamera;

	float rotationY; //This will store our current pitch

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");

		//transform.Rotate (0f, mouseX, 0f); //Horizontal rotation
		// myCamera.transform.Rotate (-mouseY, 0f, 0f); //Vertical rotation

		// CLAMPED Y-LOOK
		// 1) Modify pitch
		rotationY -= mouseY;

		// 2) Correct pitch / clamp it
		rotationY = Mathf.Clamp ( rotationY, -15f, 25f );

		// 3) Apply the pitch to the camera
		myCamera.transform.localEulerAngles = new Vector3( rotationY, 0f, 0f);
	}
}
