using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class EndGame : MonoBehaviour
{
    // display high score
    void Start()
    {
        int highscore = GameObject.Find("GameScore").GetComponent<GameScore>().highscore;
        if(highscore!=0)
            GameObject.Find("Score").GetComponent<TextMeshProUGUI>().SetText("High Score: " + highscore);
        
    }

    // when space, restart game
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Scenes/Start");
        }
        
    }
}
