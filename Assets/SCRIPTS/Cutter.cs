using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    GameObject player;
    [SerializeField]GameObject restartPanel;

    private void Start()
    {
        player = GameObject.Find("elephant");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        restartPanel.SetActive(true);
        Destroy(player, 1f);
    }
}
