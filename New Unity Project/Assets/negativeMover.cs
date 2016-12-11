using UnityEngine;
using System.Collections;

public class negativeMover : MonoBehaviour
{
    public Transform zeroTarget;
    Transform toCopy;
    // Use this for initialization
    void Start()
    {
        toCopy = FindObjectOfType<FirstPositioner>().GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = zeroTarget.rotation * Quaternion.Inverse(toCopy.rotation);
        transform.position = zeroTarget.position - toCopy.position * transform.localScale.magnitude;
    }
}
