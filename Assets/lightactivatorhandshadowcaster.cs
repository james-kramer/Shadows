using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightactivatorhandshadowcaster : MonoBehaviour
{
    public GameObject lightobject;
    public Transform follow;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = follow.position + offset;
    }

    void OnTriggerEnter()
    {
        lightobject.SetActive(true);
    }

    void OnTriggerExit()
    {
        lightobject.SetActive(false);
    }
}
