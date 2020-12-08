using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    private static bool created = false;
    // make score public so we can access and modify it
    public int highscore = 0;

    void Awake()
    {   
        // dont destroy highscore on load
        if (!created){
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
    }
}
