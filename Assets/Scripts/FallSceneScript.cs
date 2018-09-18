using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSceneScript : MonoBehaviour
{
	public GameObject GameManager;
	public float SceneTimer;

	// Use this for initialization
	void Start ()
	{
		SceneTimer = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		SceneTimer = SceneTimer + 1 * Time.deltaTime;

		if (SceneTimer >= 6)
		{
			GameManager.GetComponent<GameController>().ChangeLevelScene(Rooms.Menu);
		}
	}
}
