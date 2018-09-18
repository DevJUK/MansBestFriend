using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum Rooms		// Enum of scenes in the game
{
	Menu,
	MainLevel,
	Minigame1,
	Minigame2,
	Minigame3,
	Minigame4,
	Minigame5,
	Minigame6,
	EndScene,
	Fall,
};


public class GameController : MonoBehaviour
{


	public Rooms E_Rooms;

	public Transform PlayerPosition;

	public int GamesCompleted = 0;


	void Awake ()
	{
		DontDestroyOnLoad(gameObject);                          // Don't destroy the object the script is attached to
	}

	private void Update()
	{
		if (GamesCompleted == 6)
		{
			ChangeLevelScene(Rooms.EndScene);
		}
	}


	public void ChangeLevelScene(Rooms state)
	{
		switch(state)
		{
			case Rooms.Menu:
				SceneManager.LoadScene("Menu");
				break;

			case Rooms.MainLevel:
				SceneManager.LoadScene("MainLevel");
				Time.timeScale = 1f;
				break;

			case Rooms.Minigame2:
				SceneManager.LoadScene("Minigame2");
				Time.timeScale = 1f;
				break;

			case Rooms.Minigame3:
				SceneManager.LoadScene("Minigame3");
				Time.timeScale = 1f;
				break;

			case Rooms.Minigame4:
				SceneManager.LoadScene("Minigame4");
				Time.timeScale = 1f;
				break;

			case Rooms.Minigame5:
				SceneManager.LoadScene("Minigame5");
				Time.timeScale = 1f;
				break;

			case Rooms.Minigame6:
				SceneManager.LoadScene("Minigame6");
				Time.timeScale = 1f;
				break;

			case Rooms.EndScene:
				SceneManager.LoadScene("EndScene");
				Time.timeScale = 1f;
				break;

			case Rooms.Fall:
				SceneManager.LoadScene("FallScene");
				Time.timeScale = 1f;
				break;

			default:
				break;
		}
	}






	public Transform GetPlayerPosition()
	{
		return PlayerPosition;
	}

	public int GetGamesCompleted()
	{
		return GamesCompleted;
	}



	public void SetGamesCompleted(int Input)
	{
		GamesCompleted = Input;
	}

	public void SetPlayerPosition(Transform Input)
	{
		PlayerPosition = Input;
	}
}
