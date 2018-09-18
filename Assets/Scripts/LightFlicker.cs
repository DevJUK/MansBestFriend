using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{

	public Light SpotLight;

	public int Number;

	private void Start()
	{
		Time.timeScale = 0.2f;
	}

	// Update is called once per frame
	void FixedUpdate ()
	{

		Number = Random.Range(0, 10);


		if (Number <= 1)
		{
			SpotLight.enabled = false;
		}
		else
		{
			SpotLight.enabled = true;
		}

	}
}
