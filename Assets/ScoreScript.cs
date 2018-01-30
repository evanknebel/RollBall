﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text score;
    public BallController ballController;
 

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(ballController.score == 6 || ballController.score == 15)
        {
            score.text = "Gate open";
        }
        else
        {
            score.text = ballController.score.ToString();
        }
	}
}
