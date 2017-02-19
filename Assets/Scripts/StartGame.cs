using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {
  public GameObject mainGame;
  public GameObject startButton;
	// Use this for initialization
	void Start () {
    //mainGame = GameObject.Find("Main Game");
    //startButton = GameObject.Find("Start Game");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public void startGame() {
    startButton.SetActive(false);
    mainGame.SetActive(true);
  }
}
