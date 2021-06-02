using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    Transform  cylinder_transform;
    // Start is called before the first frame update
    void Start()
    {
        cylinder_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cylinder_transform.Rotate(0.5f,0,0);
    }


    void OnMouseDown()
    {
        cylinder_transform.Rotate(0,0,10f);
    }
}
