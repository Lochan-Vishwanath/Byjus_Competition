using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    Vector3 MousePos,MousePos2D;
    Camera MainCamera;
    bool Maincollision = false;

    private void Start()
    {
        MainCamera = Camera.main;
    }

    private void OnMouseUp()
    {
        Maincollision = true;
    }

    private void OnMouseDrag()
    {
        if (Maincollision)
        {
            MousePos = Input.mousePosition;//Debug.Log(MousePos);
            MousePos2D = new Vector3(MousePos.x, MousePos.y, Camera.main.farClipPlane);
            transform.position = Camera.main.ScreenToWorldPoint(MousePos2D); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Maincollision = false;
        }
    }
}
