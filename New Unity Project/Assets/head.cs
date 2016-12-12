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
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		float mouseY = Input.mousePosition.y;
		vangle -= mouseY - lastMouseY;
		lastMouseY = mouseY;
        vangle = Mathf.Clamp(vangle, -90, 90);
		transform.localRotation = Quaternion.Euler(new Vector3( vangle, 0));
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hitInfo;
            Physics.Raycast(new Ray(transform.position, transform.forward), out hitInfo);
            if (hitInfo.collider.GetComponent<liftable>() != null)
            {

            }
        }
	}
}
