using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour {

  public GameObject mainGame;
  public GameObject startButton;
  private Text answer;
  private Text question;
  private Text score;
  private Text timer;
  private bool isRunning = false;
  private int correctAnswer;
  public int correct = 0;
  public int numberAnswered = 0;
  public int runTime = 60;
  private float timeRemaining;

  // Use this for initialization
  void Start () {
    //question = GameObject.Find("Question").GetComponent<Text>();
    //answer = GameObject.Find("Answer").GetComponent<Text>();
    //score = GameObject.Find("Score").GetComponent<Text>();
    //timer = GameObject.Find("Timer").GetComponent<Text>();
    //score.text = correct + "/" + numberAnswered;
    //timeRemaining = (float)runTime;
    //isRunning = true;
    //CreateQuestion();

  }
  void OnEnable() {
    question = GameObject.Find("Question").GetComponent<Text>();
    answer = GameObject.Find("Answer").GetComponent<Text>();
    score = GameObject.Find("Score").GetComponent<Text>();
    timer = GameObject.Find("Timer").GetComponent<Text>();
    correct = 0;
    numberAnswered = 0;
    timeRemaining = (float)runTime;
    score.text = correct + "/" + numberAnswered;
    answer.text = "";
    timeRemaining = (float)runTime;
    isRunning = true;
    CreateQuestion();
  }

  // Update is called once per frame
  void Update () {
    if (isRunning) {
      timeRemaining -= Time.deltaTime;
      timer.text = ((int)timeRemaining).ToString();
      if (timeRemaining < 0) {
        isRunning = false;
        startButton.SetActive(true);
        mainGame.SetActive(false);
      }
    }
	}

  public void Validate() {
    if(isRunning) {
      if (answer.text == correctAnswer.ToString()) {
        Debug.Log("Correct");
        correct++;
      } else {
        Debug.Log("Incorrect");
      }
      numberAnswered++;
      answer.text = "";
      score.text = correct + "/" + numberAnswered;
      CreateQuestion();
    }
  }

  public void CreateQuestion() {
    int numberOne = Random.Range(0, 11);
    int numberTwo = Random.Range(0, 11);
    correctAnswer = numberOne * numberTwo;
    question.text = numberOne.ToString() + " X " + numberTwo.ToString();
  }
}
