using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    Vector3 moveTo;
    public float lerpTime;

    public BallController ball;

	// Use this for initialization
	void Start ()
    {
        moveTo = transform.forward * -7;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (ball.score >= 6)
        {
            //gameObject.SetActive(false);
            transform.position = Vector3.Lerp(transform.position,transform.position + moveTo, lerpTime * Time.deltaTime);
        }
	}
}
