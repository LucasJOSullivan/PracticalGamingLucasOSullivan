/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 vector = Vector3.zero;
    CharacterController characterController;
    
    public double speed;
    public double force;
    public double gravity;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<characterController>();
        gravity = 9.81;
    }

    // Update is called once per frame
    void Update()
    {
        vector.x = Input.GetAxis("Horizontal") * speed;
        vector.z = Input.GetAxis("Vertical") * speed;

        if (characterController.isGrounded && Input.GetButton("Jump"))
            vector.y = jumpSpeed;

        vector.y -= gravity * Time.deltaTime;
        characterController.Move(vector * Time.deltaTime);
    }
}
*/