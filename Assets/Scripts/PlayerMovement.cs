using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 20f;

    void Start() {
        // delete all enemies at the start of the game
        GameObject[] gameObjects =  GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject en in gameObjects) 
            Destroy(en);

    }
    void Update()
    {
        // player movement
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        controller.SimpleMove(move * speed);

    }

}
