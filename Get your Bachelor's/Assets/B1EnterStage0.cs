using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B1EnterStage0 : MonoBehaviour
{
    private bool playerInRange;
    public LevelLoader levelLoader;
    public Grid gridStage0;
    public Grid gridStage1;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange)
        {
            PlayerPrefs.SetInt("Stage", 0);
            gridStage0.gameObject.SetActive(true);
            gridStage1.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}