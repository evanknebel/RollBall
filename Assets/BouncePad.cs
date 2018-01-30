using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnCollisionEnter(Collision other)
    {
        Rigidbody ball = other.gameObject.GetComponent<Rigidbody>();
        //add score
        if (ball != null)
        {
            ball.AddForce(new Vector3(0, 4, 0), ForceMode.Impulse);
        }
    }
}
