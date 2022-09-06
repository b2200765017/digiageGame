using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    #region  singleton
    public static SceneController instance;
    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    #endregion

    private int index;

    public void SceneChange(int value)
    {
        SceneManager.LoadScene(value);
    }
    public void NextScene()
    {
        index = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(index);
    }
    public void PreviousScene()
    {
        index = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(index);
    }

}
