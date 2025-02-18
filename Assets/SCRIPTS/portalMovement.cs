﻿using UnityEngine;

public class portalMovement : MonoBehaviour
{
    float x, y;
    public int n=0;

    private void Start()
    {
        switch (n)
        {
            case 1: x = 0; y = 0.5f; break;
            case 2: x = 0.5f; y = 0.5f; break;
            case 3: x = 0.5f; y = 0; break;
            case 4: x = 0.5f; y = -0.5f; break;
            case 5: x = 0; y = -0.5f; break;
            case 6: x = -0.5f; y =-0.5f ; break;
            case 7: x = -0.5f; y =0 ; break;
            case 8: x = -0.5f; y =0.5f ; break;
            default: x = 0; y = 0; break;
        }
    }

    public Transform position;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.transform.tag=="Player"){
            collision.gameObject.SetActive(false);
            collision.transform.position=position.position + new Vector3(x,y,0);
            collision.gameObject.SetActive(true);
        }
    }
}
