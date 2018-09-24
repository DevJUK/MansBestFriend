using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
	public GameObject GameManager;
	private GameController ControllerScript;

	private void Start()
	{
		ControllerScript = GameManager.GetComponent<GameController>();
	}

	private void OnTriggerEnter(Collider other)
	{

		ControllerScript.ChangeLevelScene(Rooms.Fall);

	}
}
