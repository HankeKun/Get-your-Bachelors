using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoom3 : MonoBehaviour
{
    private bool playerInRange;
    public GameObject keyEnter;
    public LevelLoader levelLoader;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            //levelLoader.whereToGo = 3;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            keyEnter.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            keyEnter.SetActive(false);
        }
    }
}
