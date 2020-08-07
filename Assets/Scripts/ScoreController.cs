using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    private int scorePlayerOne = 0;
    private int scorePlayerTwo = 0;

    public GameObject scoreTextPlayerOne;
    public GameObject scoreTextPlayerTwo;

    public int goalToWin;

    void Update(){
    	if (this.scorePlayerOne >= this.goalToWin || this.scorePlayerTwo >= this.goalToWin){
            SceneManager.LoadScene("GameOver");
    	}
    }

    public void FixedUpdate(){
    	Text ui_p1_score = this.scoreTextPlayerOne.GetComponent<Text>();
		ui_p1_score.text = this.scorePlayerOne.ToString();
    	Text ui_p2_score = this.scoreTextPlayerTwo.GetComponent<Text>();
		ui_p2_score.text = this.scorePlayerTwo.ToString();
    }

    public void AddScorePlayerOne(){
    	this.scorePlayerOne++;
    }
    
    public void AddScorePlayerTwo(){
    	this.scorePlayerTwo++;
    }

}
