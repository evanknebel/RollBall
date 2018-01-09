using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //get ballcontroller from the collision
        BallController ballController = other.GetComponent<BallController>();
        //add score
     //   ballController.score += 1;
        //destroy this object
        Destroy(gameObject);
    }
}
