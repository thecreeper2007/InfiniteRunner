using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMouseOver : MonoBehaviour {

    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.black;
    }

    void OnMouseEnter()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.black;
    }
}
