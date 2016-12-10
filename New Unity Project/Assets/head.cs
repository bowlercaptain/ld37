using UnityEngine;
using System.Collections;

public class head : MonoBehaviour {
	public float vSensitivity = 1;

	float vangle;
	float lastMouseY;
	// Use this for initialization
	void Start () {
		lastMouseY = Input.mousePosition.y;
		vangle = 0;
	}
	
	// Update is called once per frame
	void Update () {
		float mouseY = Input.mousePosition.y;
		vangle -= mouseY - lastMouseY;
		lastMouseY = mouseY;
        vangle = Mathf.Clamp(vangle, -90, 90);
		transform.localRotation = Quaternion.Euler(new Vector3( vangle, 0));
	}
}
