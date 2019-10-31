using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonActions : MonoBehaviour
{
    static int counter = 0;

    public Text ANS;
    [SerializeField] GameObject Explaination,Panel;
    GameObject Key,Blocked;

    private void Start()
    {
        Key = GameObject.Find("Key");
        Blocked = GameObject.Find("BlueLocked");
    }

    public void WrongAns()
    {
        counter++;
        if (counter >= 3)
        {
            ANS.text = "";
            Explaination.SetActive(true);
            StartCoroutine("ClosePanel");
            return;
        }
        SoundandMusic.SFAIL = true;
        ANS.text = "Wrong Answer";
    }

    public void RightAns()
    {
        ANS.text = "Right Answer";
        Key.GetComponent<Key>().openDoor = true;
        SoundandMusic.SWIN = true;
        StartCoroutine("ClosePanel");
        Key.SetActive(false);
        Blocked.SetActive(false);
    }

    IEnumerator ClosePanel()
    {
        yield return new WaitForSeconds(0.4f);
        Panel.SetActive(false);
    }

    public void RestartScene()
    {
        counter = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NxtLevel()
    {
        counter = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
