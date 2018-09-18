using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChangeState : MonoBehaviour
{

	[Header("Variables")]
	public GameObject GameManager;				// Gameobject for the Menu Manager
	public Rooms state;					// Getting the global scope Enum from the Menu Manager

	private GameController ControllerScript;				// Getting the menu manager script

	// Use this for initialization
	void Start ()
	{
		ControllerScript = GameManager.GetComponent<GameController>();		// Just makes the manager variable lead to get the menu manager script
	}

	public void SwapState()
	{
		ControllerScript.ChangeLevelScene(state);						// loads the scene selected in the inspector
	}
}
