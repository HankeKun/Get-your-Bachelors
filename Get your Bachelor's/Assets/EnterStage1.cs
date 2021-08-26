using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterStage1 : MonoBehaviour
{
    private bool playerInRange;
    public LevelLoader levelLoader;
    public Grid gridStage0;
    public Grid gridStage1;
    public Grid gridStage2;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange)
        {
            PlayerPrefs.SetInt("Stage", 1);
            gridStage0.gameObject.SetActive(false);
            gridStage1.gameObject.SetActive(true);
            gridStage2.gameObject.SetActive(false);
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
