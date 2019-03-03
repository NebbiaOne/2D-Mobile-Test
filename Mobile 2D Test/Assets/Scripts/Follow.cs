using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private float speed = 10.0f;
    private Vector2 target;
    private Vector2 position;
    private Camera maincam;
    public GameObject TouchTracker;


    void Start()
    {
        target = TouchTracker.transform.position;
        maincam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
