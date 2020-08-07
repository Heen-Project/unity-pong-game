using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource batSound;

    private void OnCollisionEnter2D (Collision2D collision){
    	if(collision.gameObject.name == "BatPlayer_1" || collision.gameObject.name == "BatPlayer_2"){
    		this.batSound.Play();
    	} else {
    		this.wallSound.Play();
    	}
    }
}
