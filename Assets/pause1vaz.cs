﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pause1vaz : MonoBehaviour {

    public GameObject prodol;
    public GameObject restart;
    public GameObject exit;
    public GameObject outoffueltext;


    public void pause()
    {
        Time.timeScale = 0;
        prodol.SetActive(true);
        restart.SetActive(true);
        exit.SetActive(true);
        outoffueltext.SetActive(false);

    }
    public void dalee()
    {
        prodol.SetActive(false);
        restart.SetActive(false);
        exit.SetActive(false);
        Time.timeScale = 1;

    }
    public void res() 
    {
        PlayerPrefs.Save();
        PlayerPrefs.GetInt("score");
        SceneManager.LoadScene(40);

        Time.timeScale = 1;
    }
    public void Exit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(39);

    }
}