using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatPlayer1 : MonoBehaviour
{
    public float speed;

    void FixedUpdate (){
    	float velocity = Input.GetAxisRaw("Vertical");
    	GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocity) * speed;
    }
}
