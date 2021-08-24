using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousePlayerInner : MonoBehaviour
{
    private bool playerInRange;
    public PlayerMovement playerMovement;
    public GameObject keyEnter;
    public LevelLoader levelLoader;
    public Rigidbody2D player;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E) && (playerMovement.pState != PlayerState.gamemenu))
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
