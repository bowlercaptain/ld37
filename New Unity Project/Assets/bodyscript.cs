using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class bodyscript : MonoBehaviour {
	public float hSensitivity=1;
    public float movespeed=10;
	Rigidbody myBody;

	void Awake() { myBody = GetComponent<Rigidbody>(); }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler(new Vector3(0,Input.mousePosition.x*hSensitivity,0));

		myBody.AddRelativeForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
		
	}
}
