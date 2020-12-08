using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject fireAnimation;

    float timer = 0f;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            shoot();

    }

    public void shoot() {
        // display shooting animation
        Vector3 playerPos = this.transform.position ;
        Debug.Log("shoot");
        Vector3 playerDirection = this.transform.forward;
        Quaternion playerRotation = this.transform.rotation;
        Vector3 spawnPos = playerPos + playerDirection*0.1f;
        GameObject shot = Instantiate(fireAnimation, spawnPos, playerRotation);
        shot.transform.Rotate(0,90,0);
        shot.gameObject.transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
        // destory shot animation quickly
        Object.Destroy(shot, 0.07f);
    }
}
