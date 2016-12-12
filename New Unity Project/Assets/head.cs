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

	Vector3 relpos;
	Quaternion relrot;
	Transform held;
	// Update is called once per frame
	void Update () {
		float mouseY = Input.mousePosition.y;
		vangle -= mouseY - lastMouseY;
		lastMouseY = mouseY;
        vangle = Mathf.Clamp(vangle, -90, 90);
		transform.localRotation = Quaternion.Euler(new Vector3( vangle, 0));
		if (held != null)
		{
			held.position = transform.position + transform.forward * relpos.magnitude;
			held.rotation = transform.rotation * relrot;
			if (Input.GetKeyDown(KeyCode.E))
			{
				held = null;
			}
		} else if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hitInfo;
			Ray hitRay = new Ray(transform.position, transform.forward);
            Physics.Raycast(hitRay, out hitInfo);
			liftable target=null;
            if (hitInfo.collider.GetComponent<liftChild>() != null)
            {
				target = hitInfo.transform.parent.GetComponent<liftable>();
            } else if (hitInfo.collider.GetComponent<liftable>() != null) {
				target = hitInfo.collider.GetComponent<liftable>();
            } else
			{ Debug.Log("no hit "+hitInfo.transform.name); }
			if (target != null) {
				relpos = target.transform.position - transform.position;
				relrot = Quaternion.Inverse(transform.rotation) * target.transform.rotation;
				held = target.transform;
			}
        }
		
	}
}
