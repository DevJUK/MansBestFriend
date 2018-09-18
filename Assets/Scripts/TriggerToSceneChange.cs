using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerToSceneChange : MonoBehaviour
{

	// Pretty much just changes the scene to whatever is selected in the inspector

	public Rooms E_Rooms;

	public GameObject GameController;

	private void OnTriggerEnter(Collider other)
	{
		GameController.GetComponent<GameController>().ChangeLevelScene(E_Rooms);
		GetComponent<BoxCollider>().enabled = false;
		GameController.GetComponent<GameController>().SetPlayerPosition(GameObject.Find("Player").transform);
	}
}
