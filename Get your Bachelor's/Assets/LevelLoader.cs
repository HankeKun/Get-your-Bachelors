﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public int whereToGo = 0;
    public Vector2 playerPosition;
    public VectorValue playerStorage;

    // Update is called once per frame
    void Update()
    {
        switch(whereToGo)
        {
            case 1:
                playerStorage.initialValue = playerPosition;
                LoadNextLevel(1);
                break;
            case 2:
                playerStorage.initialValue = playerPosition;
                LoadNextLevel(2);
                break;
            case 3:
                playerStorage.initialValue = playerPosition;
                LoadNextLevel(3);
                break;
            case 4:
                playerStorage.initialValue = playerPosition;
                LoadNextLevel(4);
                break;
            case 5:
                playerStorage.initialValue = playerPosition;
                LoadNextLevel(5);
                break;
            case 6:
                playerStorage.initialValue = new Vector2(0, -3);
                LoadNextLevel(6);
                break;
            default:
                break;
        }
    }

    public void LoadNextLevel(int level)
    {
        StartCoroutine(LoadLevel(level));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);
    }
}
