using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input : MonoBehaviour {

  private int value;
  public Text textObject;
  private Text answer;

  // Use this for initialization
  void Start() {
    answer = GameObject.Find("Answer").GetComponent<Text>();
    //value = Int32.Parse(GetComponent<Text>().text);
    Debug.Log(textObject.text);
    Debug.Log(answer.text);
  }

  // Update is called once per frame
  void Update() {

  }

  public void isPushed() {
    if(textObject.text == "Clear") {
      answer.text = "";
    } else if(textObject.text == "Delete") {
      string currentAnswer = answer.text;
      
      answer.text = currentAnswer.Substring(0, currentAnswer.Length - 1);
    } else {
      string currentAnswer = answer.text;
      currentAnswer += textObject.text;
      answer.text = currentAnswer;
    }
    
  }
}
