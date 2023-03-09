using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    Rigidbody rb;
    Vector2 movedirection = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical");
        float turnAmount = Input.GetAxis("Horizontal");

        rb.AddForce(Vector3.forward, ForceMode.Impulse);
    }
}
