using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update
    Transform  sphere_transform;
    static int score = 0;
    void Start()
    {
        sphere_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseEnter()
    {
        score = score + 1;
        Destroy(gameObject);
        print(score);
    }
}
