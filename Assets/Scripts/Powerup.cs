using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    // collision between powerup and player
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Player") {
            // increase player speed
            GameObject.Find("Player").GetComponent<PlayerMovement>().speed += 1.5f;
            Destroy(gameObject);
        }
    }
}
