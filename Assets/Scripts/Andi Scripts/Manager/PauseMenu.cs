using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public bool isGamePaused;
    public GameObject PauseMenuUI;
    public GameObject enemy;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
        enemy.transform.Translate(0,0,0);
        player1.transform.Translate(0,0,0);
        player2.transform.Translate(0,0,0);
        player3.transform.Translate(0,0,0);
        player4.transform.Translate(0,0,0);
    }
}
