using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonActions : MonoBehaviour
{
    static int counter = 0;

    public Text ANS;
    public RectTransform Explaination,Panel;
    public GameObject Key;

    public void WrongAns()
    {
        counter++;
        if (counter >= 3)
        {
            ANS.text = "";
            Explaination.gameObject.SetActive(true);
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
    }

    IEnumerator ClosePanel()
    {
        yield return new WaitForSeconds(0.4f);
        Panel.gameObject.SetActive(false);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
