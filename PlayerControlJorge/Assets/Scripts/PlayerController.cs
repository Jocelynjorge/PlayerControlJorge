using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;

    
    void Update()
    {
        //Move the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
