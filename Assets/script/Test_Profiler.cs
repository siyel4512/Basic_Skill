using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Profiler : MonoBehaviour
{
    public bool isRotate = false;

    public GameObject obj;

    public float turnSpeed;
    
    // Update is called once per frame
    void Update()
    {
        if (isRotate)
        {
            obj.transform.Rotate(turnSpeed * Time.deltaTime, 0, 0);
        }
    }
}
