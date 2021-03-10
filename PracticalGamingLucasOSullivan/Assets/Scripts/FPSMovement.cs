using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMovement : MonoBehaviour
{
    Rigidbody rb;
    float mspeed;
    float minspeed = 0;
    [SerializeField] float runspeed = 13;
    [SerializeField] float walkspeed = 6;
    [SerializeField] float jforce;
    [SerializeField] float gravity;
    public int jumpCount; 

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       gravity = 9.81f;
       jumpCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
            mspeed = walkspeed;
        else 
            mspeed = runspeed;
        Vector3 moveBy = transform.right * x + transform.forward * z;
  
        rb.MovePosition(transform.position + moveBy.normalized * mspeed * Time.deltaTime);

        /*
        if ((Input.GetKeyDown(Keycode.Space)) && (rb.isGrounded)
        {
        jumpCount = 1;
        }
        if (!rb.isGrounded)
        {
        jumpcount = 0;

        while (Input.GetKeyDown(KeyCode.X))
        {
            mspeed = mspeed / 2.00f;
        }
        
        while (Input.GetKeyDown(KeyCode.LeftShift))
        {
            mspeed = mspeed * 1.5f;
        }
        */


    }
}
