using UnityEngine;
using System.Collections;

public class relativeChild : MonoBehaviour
{
    Transform toCopy;
    FirstPositioner poser;
    public Transform parentt;
    // Use this for initialization
    void Start()
    {
        poser = FindObjectOfType<FirstPositioner>();
        toCopy = poser.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = parentt.position + toCopy.rotation * (poser.relpos * transform.localScale.x);
        transform.rotation = parentt.rotation * toCopy.rotation;
    }
}
