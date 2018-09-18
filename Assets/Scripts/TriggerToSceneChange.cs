using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerToSceneChange : MonoBehaviour
{

	// Pretty much just changes the scene to whatever is selected in the inspector

	public Rooms E_Rooms;

	public GameObject GameController;
	private GameController ControllerScript;

	private void Start()
	{
		ControllerScript = GameController.GetComponent<GameController>(); 
	}

	private void OnTriggerEnter(Collider other)
	{
		ControllerScript.ChangeLevelScene(E_Rooms);
		GetComponent<BoxCollider>().enabled = false;
		ControllerScript.SetGamesCompleted(ControllerScript.GetGamesCompleted() + 1);
		ControllerScript.SetPlayerPosition(GameObject.Find("Player").transform);
	}
}
