using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour {

  private Text answer;
  private Text question;
  private int correctAnswer;
  public int score = 0;
  public int numberAnswered = 0;

  // Use this for initialization
  void Start () {
    question = GameObject.Find("Question").GetComponent<Text>();
    answer = GameObject.Find("Answer").GetComponent<Text>();
    CreateQuestion();

  }
	
	// Update is called once per frame
	void Update () {
		
	}

  public void Validate() {
    if(answer.text == correctAnswer.ToString()) {
      Debug.Log("Correct");
      score++;
    } else {
      Debug.Log("Incorrect");
    }
    numberAnswered++;
    answer.text = "";
    CreateQuestion();
  }

  public void CreateQuestion() {
    int numberOne = Random.Range(0, 11);
    int numberTwo = Random.Range(0, 11);
    correctAnswer = numberOne * numberTwo;
    question.text = numberOne.ToString() + " X " + numberTwo.ToString();
  }
}
