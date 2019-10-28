using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedArea : MonoBehaviour
{
    public GameObject Key;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Key.GetComponent<Key>().AnimateKey();
    }
    private void Update()
    {
        if (Key.GetComponent<Key>().openDoor) gameObject.SetActive(false);
    }
}
