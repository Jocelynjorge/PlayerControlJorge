using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
   

    // Update is called once per frame
    void FixedUpdate()
    {
        //get the users vertical input
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
