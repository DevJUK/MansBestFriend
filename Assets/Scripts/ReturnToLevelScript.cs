using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToLevelScript : MonoBehaviour
{

	public Rooms E_Rooms;

	public GameObject GameController;
	private GameController ControllerScript;

	private void Start()
	{
		ControllerScript = GameController.GetComponent<GameController>();
	}

	// Needs to be set for the 2d end of level 
	private void OnTriggerEnter(Collider other)
	{
		ControllerScript.ChangeLevelScene(E_Rooms);
		//GetComponent<BoxCollider>().enabled = false; 
		ControllerScript.SetPlayerPosition(ControllerScript.GetPlayerPosition());
	}
}
