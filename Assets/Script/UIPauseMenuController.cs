using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIPauseMenuController : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public GameObject gameplayPanel;
    public Button buttonResume;

    private void Start()
    {
        buttonResume.onClick.AddListener(ResumeGame);
        pauseMenuPanel.gameObject.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenuPanel.gameObject.SetActive(true);
        gameplayPanel.SetActive(false);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenuPanel.gameObject.SetActive(false);
        gameplayPanel.SetActive(true);
    }
}
