using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTTON : MonoBehaviour
{
    public void mulai()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void back()
    {
        SceneManager.LoadScene("main menu");
    }

    public void next()
    {
        SceneManager.LoadScene("finish");
    }


    public void keluar()
    {
        Application.Quit();
    }
}
