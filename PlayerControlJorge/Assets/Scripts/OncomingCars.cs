using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingCars : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        //Move foward
        transform.Translate(Vector3.forward*Time.deltaTime*20);
    }
}
