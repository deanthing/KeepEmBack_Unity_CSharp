using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    float next = 0f;
    float period = 1f;
    float time;

    void Update()
    {
        // when time is greater than threshold, spawn enemy
        time = Time.timeSinceLevelLoad;
        if (time>next) {
            next += period;
            SpawnSingle();
        }
    }  

    // spawns a single enemy
     public void SpawnSingle() {

        // get random between 0 and 1
        int leftOrRight  = Random.Range(0,2);
        float x;

        // randomly choose out of camera view left or right
        if(leftOrRight == 0) {
            x  = -0.1f;
        } else {
            x = 1.2f;
        }
        
        // spawn at world coords
        Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(x, 0.5f, 40f));
        v3Pos.y = 0;
        Instantiate(enemy, v3Pos, Quaternion.identity);

        // terrain boundaries
        // top left cord 110, 0, 385
        // top right cord 415, 0, 385
        // bottom right cord 415, 0, 106
        // bottom left cord  110, 0, 106
    }

}
