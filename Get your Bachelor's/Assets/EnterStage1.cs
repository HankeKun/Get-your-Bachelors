using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterStage1 : MonoBehaviour
{
    private bool playerInRange;
    public LevelLoader levelLoader;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange)
        {
            //levelLoader.whereToGo = 3;
            Debug.Log("Enter Stairs");
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
