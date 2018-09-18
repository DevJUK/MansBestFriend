using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Doesn't work due to how the camera controls were made

public class LimpScript : MonoBehaviour
{

	public Camera Eyes;

	public float Timer;

	public bool isWalking;
	
	// Update is called once per frame
	void Update ()
	{

		Timer = Timer + 1 * Time.deltaTime;

		if ((Timer > 4) && (isWalking == true))
		{
			Eyes.transform.rotation = Quaternion.Euler(Eyes.transform.rotation.x, Eyes.transform.rotation.y, 5);
			Timer = 0;
		}
	}

	public bool GetisWalking()
	{
		return isWalking;
	}

	public void SetisWalking(bool Input)
	{
		isWalking = Input;
	}
}
