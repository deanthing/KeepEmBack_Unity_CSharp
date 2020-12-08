using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSpawner : MonoBehaviour
{
    public GameObject Powerup;
    float next = 0f;
    float period = 10f;
    float time;

    void Update()
    {
        // when time is greater than threshold, spawn
        time = Time.timeSinceLevelLoad;
        if (time>next) {
            next += period;
            SpawnPowerup();
        }
    }

    void SpawnPowerup() {
        // get random position inside terrain
        int spawnX = Random.Range(110,415);
        int spawnZ = Random.Range(106,385);

        // instantiate powerup
        Instantiate(Powerup, new Vector3(spawnX, 1.5f, spawnZ), Quaternion.identity);
    }


    // top left cord 110, 0, 385
    // top right cord 415, 0, 385
    // bottom right cord 415, 0, 106
    // bottom left cord  110, 0, 106

}
