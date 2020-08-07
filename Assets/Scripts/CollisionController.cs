using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;
    
    void BounceFromBat(Collision2D c){
    	Vector3 ballPosition = this.transform.position;
    	Vector3 batPosition = c.gameObject.transform.position;

    	float batHeight = c.collider.bounds.size.y;
    	float x;

    	if(c.gameObject.name == "BatPlayer_1") x = 1;
    	else  x = -1;

    	float y = (ballPosition.y  - batPosition.y) / batHeight;

    	this.ballMovement.IncreaseSpeed();
    	this.ballMovement.Move(new Vector2(x, y));
    }

    public void OnCollisionEnter2D(Collision2D c){
    	if(c.gameObject.name == "BatPlayer_1" || c.gameObject.name == "BatPlayer_2")  this.BounceFromBat(c);
    	else if (c.gameObject.name == "WallLeft") {
            this.scoreController.AddScorePlayerTwo();
            StartCoroutine(this.ballMovement.StartBall(true));
        }
    	else if (c.gameObject.name == "WallRight") {
            this.scoreController.AddScorePlayerOne();
            StartCoroutine(this.ballMovement.StartBall(false));
        }
    }
}
