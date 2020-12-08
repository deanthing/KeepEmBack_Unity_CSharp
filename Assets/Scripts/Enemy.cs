using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  


public class Enemy : MonoBehaviour
{

    GameObject Player;
    public CharacterController controller;

    void Update()
    {
        moveToPlayer();

        if(this.transform.position.y < -5) {
            Debug.Log("Fell below map");
            Destroy(this.gameObject);
        }

        // if enenmy goes above terrain, bring it back down to terrain height
        Vector3 p = transform.position;
        if(p.y > Terrain.activeTerrain.SampleHeight(transform.position)) {
             p.y = Terrain.activeTerrain.SampleHeight(transform.position);
             transform.position = p;
        }
        
        
    }

    void moveToPlayer() {
        // move enemy
        Player = GameObject.Find("Player");
        Vector3 offset = Player.transform.position - this.transform.position;
        offset = offset.normalized * 17f;
        controller.SimpleMove(offset);

        // rotate enemy
        Vector3 deltaVec = Player.transform.position - this.transform.position;
        Quaternion rotation = Quaternion.LookRotation(deltaVec);
        this.transform.rotation = rotation;

    }
    
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Player") {
            // check old highscore and update
            int oldHighscore = GameObject.Find("GameScore").GetComponent<GameScore>().highscore;
            int newScore = GameObject.Find("Main Camera").GetComponent<MouseLook>().score;

            if(newScore>oldHighscore) {
                GameObject.Find("GameScore").GetComponent<GameScore>().highscore = newScore;
            }

            // loads the end scene
            SceneManager.LoadScene("Scenes/End");
        }
    }
}
