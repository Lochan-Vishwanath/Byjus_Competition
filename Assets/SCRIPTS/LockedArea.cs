using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedArea : MonoBehaviour
{
    GameObject Key;

    private void Start()
    {
        Key = GameObject.Find("Key");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Key.GetComponent<Key>().AnimateKey();
    }
    //private void Update()
    //{
    //    if (Key.GetComponent<Key>().openDoor) gameObject.SetActive(false);
    //}
}
