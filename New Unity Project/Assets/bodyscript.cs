using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class bodyscript : MonoBehaviour {
	public float hSensitivity=1;
    public float movespeed=10;
	Rigidbody myBody;
	public UnityEngine.UI.Text theendText;

	void Awake() { myBody = GetComponent<Rigidbody>();
		//Cursor.lockState = CursorLockMode.Locked;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}
		if(Input.GetKeyDown(KeyCode.R)) {
			Application.LoadLevel(0);
		}
		transform.rotation = Quaternion.Euler(new Vector3(0,Input.mousePosition.x*hSensitivity,0));

		myBody.AddRelativeForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
		

		if (transform.position.y < -500) {
			theendText.enabled = true;
		}
	}
}
