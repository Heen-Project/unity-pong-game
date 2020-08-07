using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public float speedIncrement;
    public float maxSpeed;

    int hit;

    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    void PositionBall(bool isStartingFromPlayer1){
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        if(isStartingFromPlayer1) this.gameObject.transform.localPosition = new Vector3(-100,0,0);
        else this.gameObject.transform.localPosition = new Vector3(100,0,0);
    }

    public IEnumerator StartBall(bool isStartingFromPlayer1 = true){
        this.PositionBall(isStartingFromPlayer1);
    	this.hit = 0;
    	yield return new WaitForSeconds(2);
    	if(isStartingFromPlayer1) this.Move(new Vector2(-1,0));
    	else this.Move(new Vector2(1,0));
    }

    public void Move(Vector2 dir)
    {
        dir = dir.normalized;
        float accumulatedSpeed = this.speed + this.speedIncrement * this.hit;
        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity  = dir * accumulatedSpeed;
    }

    public void IncreaseSpeed(){
        if(this.hit * this.speedIncrement <= this.maxSpeed) this.hit++;
    }
}
