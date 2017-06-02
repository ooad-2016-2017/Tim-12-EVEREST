using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour {
    public Text scoreBoard;
    private int leftHandScore = 0;
    private int rightHandScore = 0;
    public GameObject ball;
    //private bool incrementScore= true;
	// Use this for initialization
	void Start () {
        ball = GameObject.Find("ballHeart");
	}
	
	// Update is called once per frame
	void Update () {
        if (ball.transform.position.x >= 8.7f/* && incrementScore*/)  leftHandScore++;
        else if(ball.transform.position.x <= -8.7f /* && incrementScore */)  rightHandScore++;

        if (leftHandScore >= 5)
        {
            SceneManager.LoadScene(2);
        }
        if (rightHandScore>= 5)
        {
            SceneManager.LoadScene(3);
        }
        scoreBoard.text = leftHandScore.ToString()+ " - " + rightHandScore.ToString();
    }
}
