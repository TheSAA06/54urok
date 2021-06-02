using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    string namee = "wasya";
    int age = 14;
    float time = 0.5f;


    static int score = 0;
    Transform  cube_transform;
    // Start is called before the first frame update
    void Start()
    {
        cube_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cube_transform.Translate(0.1f,0,0);
        cube_transform.Rotate(0,-0.7f,0.7f);
    }

    void OnMouseDown()
    {
        score = score + 1;
        if(score==4){
            Destroy(gameObject);
            print("Ты собрал все кубики!");
        }else{
            print(score);
            Destroy(gameObject);
        }
    }
}
