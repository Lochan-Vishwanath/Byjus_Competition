using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] GameObject NxtLvlPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundandMusic.SWIN = true;
        Destroy(collision.gameObject,0.8f);
        NxtLvlPanel.SetActive(true);
    }
}
