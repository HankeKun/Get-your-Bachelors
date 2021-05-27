using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public int whereToGo = 0;
    public Vector2 playerPosition;
    public VectorValue playerStorage;
    public Grid gridStage0;
    public Grid gridStage1;
    public Grid gridStage2;

    void Start()
    {
        int isStage = PlayerPrefs.GetInt("Stage", 0);
        if (isStage != 0 && gridStage0 != null && gridStage1 != null && gridStage2 != null)
        {
            if (isStage == 1)
            {
                gridStage0.gameObject.SetActive(false);
                gridStage1.gameObject.SetActive(true);
            } else if (isStage == 2)
            {
                gridStage0.gameObject.SetActive(false);
                gridStage2.gameObject.SetActive(true);
            }
            PlayerPrefs.SetInt("Stage", 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        switch(whereToGo)
        {
            case 1: // Overwolrd Game
                playerStorage.initialValue = playerPosition;
                LoadNextLevel(1);
                break;
            case 2: // House of Player
                playerStorage.initialValue = playerPosition;
                LoadNextLevel(2);
                break;
            case 3: // Building 0
                playerStorage.initialValue = playerPosition;
                LoadNextLevel(3);
                break;
            case 4: // Building 1
                playerStorage.initialValue = playerPosition;
                LoadNextLevel(4);
                break;
            case 5: // Building 2
                playerStorage.initialValue = playerPosition;
                LoadNextLevel(5);
                break;
            case 6: // Building 0 Room 1 (Stage 0)
                playerStorage.initialValue = new Vector2(0, -3);
                LoadNextLevel(6);
                break;
            case 7: // Building 0 Room 2 Toilet (Stage 0)
                playerStorage.initialValue = new Vector2(4, -3);
                LoadNextLevel(7);
                break;
            case 8: // Building 0 Room 3 (Stage 1)
                PlayerPrefs.SetInt("Stage", 1);
                playerStorage.initialValue = new Vector2(0, -3);
                LoadNextLevel(8);
                break;
            case 9: // Building 0 Room 4 Toilet (Stage 1)
                PlayerPrefs.SetInt("Stage", 1);
                playerStorage.initialValue = new Vector2(4, -3);
                LoadNextLevel(9);
                break;
            case 10: // Building 0 Room 5 (Stage 2)
                PlayerPrefs.SetInt("Stage", 2);
                playerStorage.initialValue = new Vector2(0, -3);
                LoadNextLevel(10);
                break;
            case 11: // Building 0 Room 6 Office (Stage 2)
                PlayerPrefs.SetInt("Stage", 2);
                playerStorage.initialValue = new Vector2(0, -3);
                LoadNextLevel(11);
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
