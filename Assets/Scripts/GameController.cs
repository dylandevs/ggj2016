using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	enum GameStates{
		Menu=0,
		Intro,
		Playing,
		Paused,
		End
	};

	public float startTimeSeconds;

	float timeLeftSeconds;
	GameStates gameState = GameStates.Menu;
	GameObject cat;
	GameObject menu;
	Transform menuPivot;

	// Use this for initialization
	void Start () {
		timeLeftSeconds = startTimeSeconds;
		cat = GameObject.Find("Cat");
		menu = GameObject.Find("Menu");
		menuPivot = menu.transform.FindChild("MenuPivot").transform;
		ChangeGameState(GameStates.Menu);
	}
	
	// Update is called once per frame
	void Update () {

		if (gameState == GameStates.Menu){
			menuPivot.Rotate(0.0f,-0.5f,0.0f);

			if (Input.GetKeyUp("space")){
				ChangeGameState(GameStates.Intro);
			}

		} else if (gameState == GameStates.Playing){
			if (timeLeftSeconds > 0)
				timeLeftSeconds -= Time.deltaTime;
			else {
				timeLeftSeconds = 0;
				ChangeGameState(GameStates.End);
			}
		}
	}

	void ChangeGameState(GameStates _gameState){
		gameState = _gameState;

		if (gameState == GameStates.Intro){
			cat.SetActive(false);
			menu.SetActive(false);

			//HACK SINCE THERE IS NO INTRO ANIMATION ATM
			ChangeGameState(GameStates.Playing);
		} else if (gameState == GameStates.Playing){
			cat.SetActive(true);
			menu.SetActive(false);
		} else if (gameState == GameStates.Menu){
			cat.SetActive(false);
			menu.SetActive(true);
		} else if (gameState == GameStates.End){
			cat.SetActive(false);
			menu.SetActive(false);
		}
	}

	void AddTime(float _timeSeconds){
		timeLeftSeconds += _timeSeconds;
	}
}
