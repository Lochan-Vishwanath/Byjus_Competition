using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundandMusic : MonoBehaviour
{
    public AudioClip WIN,FAIL,Knockback;

    public static bool SWIN, SFAIL, SKnockback;

    AudioSource As;

    private void Start()
    {
        As = GetComponent<AudioSource>();
        SWIN = SFAIL = SKnockback = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            As.PlayOneShot(Knockback);
        }
        if (collision.gameObject.tag == "Good")
        {
            As.PlayOneShot(WIN);
        }
    }

    private void Update()
    {
        if (SWIN)
        {
            As.PlayOneShot(WIN);
            SWIN = false;
        }
        if (SFAIL)
        {
            As.PlayOneShot(FAIL);
            SFAIL = false;
        }
        if (SKnockback)
        {
            As.PlayOneShot(Knockback);
            SKnockback = false;
        }
    }

    //public void PlayWIN()
    //{
    //    As.PlayOneShot(WIN);
    //}

    //public void PlayFAIL()
    //{
    //    As.PlayOneShot(FAIL);
    //}

    //public void PlayKnockback()
    //{
    //    As.PlayOneShot(Knockback);
    //}
}
