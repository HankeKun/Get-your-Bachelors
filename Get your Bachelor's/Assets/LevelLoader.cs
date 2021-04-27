using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public int whereToGo = 0;

    // Update is called once per frame
    void Update()
    {
        switch(whereToGo)
        {
            case 1:
                LoadNextLevel(1);
                break;
            case 2:
                LoadNextLevel(2);
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
