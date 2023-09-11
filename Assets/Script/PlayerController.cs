using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

struct myStruct
{
    public string name;
}

public class PlayerController : MonoBehaviour
{

    public float speed = 0;

    private Rigidbody rb;
    private myStruct myStruct;
    private float movementX = 0;
    private float movementY = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
            Debug.Log("rb Null");
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        Debug.Log("X :" + movementX);
        Debug.Log("Y :" + movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
