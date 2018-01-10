using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeedX;
    public float rotationSpeedY;
    public float rotationSpeedZ;

    // Use this for initialization
    void Start ()
    {
        rotationSpeedX = Random.Range(-10, 10);
        rotationSpeedY = Random.Range(-10, 10);
        rotationSpeedZ = Random.Range(-10, 10);

    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(rotationSpeedX, rotationSpeedY, rotationSpeedZ);
	}

    private void OnTriggerEnter(Collider other)
    {
        //get ballcontroller from the collision
        BallController ballController = other.GetComponent<BallController>();
        //add score
        if (ballController != null)
        {
            ballController.score += 1;
        }
        //destroy this object
        Destroy(gameObject);
    }
}
