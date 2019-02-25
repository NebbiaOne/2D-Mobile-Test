using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toucher : MonoBehaviour
{
   
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.touchCount > 0){

            Touch touch = Input.GetTouch(0);
            Vector3 touchposition = Camera.main.ScreenToWorldPoint(touch.position);
            touchposition.z = 0f;
            transform.position = touchposition;
            
            Physics.Raycast(transform.position, Vector3.down, 10);

           Debug.Log ("touching" + touch.position);
           Debug.Log ("transform" + transform.position);
           Debug.DrawRay(transform.position, Vector3.down, Color.cyan);
        }  
    }
}
