using UnityEngine;
using System.Collections;

public class negativeMover : MonoBehaviour
{
    public Transform zeroTarget;
    Transform toCopy;
    FirstPositioner poser;
    // Use this for initialization
    void Start()
    {
        poser = FindObjectOfType<FirstPositioner>();
        toCopy = poser.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = zeroTarget.rotation * Quaternion.Inverse(toCopy.rotation);
		Debug.Log(poser.relpos);
		Debug.Log(poser.relpos * zeroTarget.localScale.x);
		Debug.Log(Quaternion.Inverse(zeroTarget.rotation) * (poser.relpos * zeroTarget.localScale.x));
        transform.position = zeroTarget.position - Quaternion.Inverse(toCopy.rotation) * (poser.relpos * zeroTarget.localScale.x);
    }
}
