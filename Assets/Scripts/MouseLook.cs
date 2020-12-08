using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 150f;
    public Transform playerBody;

    float xRotation = 0f;
    public int score = 0;
    void Start()
    {
        // lock cursor in game
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        look();
        shoot();
    }

    void shoot() {
        if(Input.GetMouseButtonDown(0)){
                // instantiate raycast
                RaycastHit hit;
                Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f,0.5f,0)); 
                Physics.Raycast(ray, out hit);
                Debug.DrawLine(transform.position, hit.point, Color.red);

                // if hit enemy, destroy gameobject and increase score
                if (hit.transform.CompareTag("Enemy")) {
                    Destroy(hit.transform.gameObject);
                    score++;
                    GameObject.Find("Score").GetComponent<TextMeshProUGUI>().SetText("Score: " + score);
                }

        }
    }

    void look() {
        // get mouse movement
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        // rotate player with clamp
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

}



