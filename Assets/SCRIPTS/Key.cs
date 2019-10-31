using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    Animator myanimator;
    public RectTransform Panle;
    public bool openDoor = false;

    void Start()
    {
        myanimator = GetComponent<Animator>();
    }

    public void AnimateKey()
    {
        myanimator.SetTrigger("Highlight");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Panle.gameObject.SetActive(true);
    }
}
