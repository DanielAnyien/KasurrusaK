using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Base");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
