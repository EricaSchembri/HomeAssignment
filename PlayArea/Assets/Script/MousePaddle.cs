﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePaddle : MonoBehaviour
{

    private Ball myBall;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        //save the mouse position in Unity units 
        //(depending on the number of units on screen
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 10f) - 5f;

        //creates a Vector3 which saves a coordinate
        //in (x,y,z). 
        //this.transform.position.y: keeps the starting y-value
        Vector3 paddlePosition = new Vector3(this.transform.position.x, 0f, 0f);



        //make the paddle move with the mouse
        paddlePosition.y = Mathf.Clamp(mousePosInUnits, -4f, 4f);



        //set the position of the paddle (this) to paddlePosition
        this.transform.position = paddlePosition; 


    }
}