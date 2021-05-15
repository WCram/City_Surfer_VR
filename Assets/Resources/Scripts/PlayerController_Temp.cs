using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Temp : MonoBehaviour
{
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            rb.AddForce(Vector3.forward);
        }
        Debug.Log(rb.velocity.ToString());
    }

    // private void FixedUpdate()
    // {
    //     
    //     
    // } // FixedUpdate()
    
} // class
