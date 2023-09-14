using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

struct myStruct
{
    public string name;
}

public class PlayerController : MonoBehaviour
{

    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextUI;
    
    

    /*test ¿ë*/
    public GameObject[] pickUpObject;
    public int pickUpCount;

    private Rigidbody rb;
    private myStruct myStruct;
    private float movementX = 0;
    private float movementY = 0;

    private int count;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextUI.SetActive(false);

        pickUpObject = GameObject.FindGameObjectsWithTag("PickUp");
        pickUpCount = pickUpObject.Length;
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "count : " + count.ToString();
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
        count = count + 1;

        if(count >= 12)
        {
            winTextUI.SetActive(true);
        }

        SetCountText();
    }
}
