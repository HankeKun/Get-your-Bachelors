using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building2Inner : MonoBehaviour
{
    private bool playerInRange;
    public GameObject keyEnter;
    public LevelLoader levelLoader;
    public Rigidbody2D player;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            levelLoader.whereToGo = 1;
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
