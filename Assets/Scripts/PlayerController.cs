using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float DragSpeed;

	
	// Update is called once per frame
	void Update ()
    {

        // Gets the A,S,W,D inputs from the keyboard
        float moveHoz = Input.GetAxis("Horizontal");
        float moveVer = Input.GetAxis("Vertical");

        // Sets up the Vector3 for Movement using the inputted keyboard controls
        Vector3 Movement = new Vector3(moveHoz / DragSpeed, 0.0f, moveVer / DragSpeed);

        // Point in direction of camera
        Movement = Camera.main.transform.TransformDirection(Movement);

        transform.Translate(Movement);

		if (!Input.anyKey)
		{
			GetComponent<LimpScript>().SetisWalking(false);
		}
		else
		{
			GetComponent<LimpScript>().SetisWalking(true);
		}

    }
}
