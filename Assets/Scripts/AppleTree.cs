﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    //Prefab for instantiating apples
    public GameObject applePrefab;

    //Speed at which the AppleTree moves in meters/second
    public float speed = 1f;

    //Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    //Chance taht the AppleTree will change directions
    public float chanceToChangeDirections = 0.1f;

    //Rate which Apples will be instantiated
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Dropping apples every second        
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        //Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //Move Right
        } else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //Move left
        } 

    }

    void FixedUpdate()
    {
        //Changing direction Randomly
       if (Random.value < chanceToChangeDirections)
        {
            speed *= -1; //Change direction
        }
    }
}
