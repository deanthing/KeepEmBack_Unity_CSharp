using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCamera : MonoBehaviour
{

    void Update()
    {
        // when opening scene is started, move camera slowly forward
        transform.Translate(Vector3.forward * (Time.deltaTime));        
    }
}
