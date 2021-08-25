using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovements : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    float horInput;
    public float horMultiplier = 2;

    private void FixedUpdate(){
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horInput * speed * Time.fixedDeltaTime * horMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        horInput = Input.GetAxis("Horizontal");
    }
}
