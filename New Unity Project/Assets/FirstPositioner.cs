using UnityEngine;
using System.Collections;

public class FirstPositioner : MonoBehaviour {
    public Vector3 relpos = new Vector3();
    public Transform myParent;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        relpos = transform.position - myParent.transform.position;
	}
}
