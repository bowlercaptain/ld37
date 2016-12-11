using UnityEngine;
using System.Collections;

public class relativeChild : MonoBehaviour {
    Transform toCopy;
	// Use this for initialization
	void Start () {
        toCopy = FindObjectOfType<FirstPositioner>().GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = toCopy.position;
        transform.rotation = toCopy.rotation;
	}
}
