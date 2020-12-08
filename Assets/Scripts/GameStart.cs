using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

    void Update()
    {   
        // when space is inputted, load game scene
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Scenes/Level");
        }
    }
}
