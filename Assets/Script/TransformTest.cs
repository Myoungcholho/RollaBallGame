using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    float xpos;
    float ypos;
    float zpos;

    Vector3 positionVector;
    Transform myTransform;

    private void Awake()
    {
        xpos = 1;
        ypos = 2;
        zpos = 3;

        positionVector = new Vector3(xpos, ypos, zpos);
        myTransform = GetComponent<Transform>();

    }


    private void Start()
    {
        myTransform.position = positionVector;

        positionVector.x = 10;

        transform.position = positionVector;

        //transform.position.x = 10;

        xpos = transform.position.x;
        xpos = 20;

        /* struct ดย by of Value */
        Vector3 vector3 = transform.position;
        vector3.x = 10;

    }
    // Update is called once per frame
    void Update()
    {

    }
}
