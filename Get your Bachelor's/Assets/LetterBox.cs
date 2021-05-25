using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterBox : MonoBehaviour
{
    private bool playerInRange;
    public GameObject keyEnter;
    public Sprite post;
    public Sprite noPost;
    public GameObject textOneLetter;
    public GameObject textNoLetter;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest1) {
            GetComponent<SpriteRenderer>().sprite = post;
        } else {
            GetComponent<SpriteRenderer>().sprite = noPost;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest1) {
            GetComponent<SpriteRenderer>().sprite = post;
        } else {
            GetComponent<SpriteRenderer>().sprite = noPost;
        }

        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest1) {
                PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest2);
                StartCoroutine(GetLetterCoroutine(textOneLetter));
            } else {
                StartCoroutine(GetLetterCoroutine(textNoLetter));
            }
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

    IEnumerator GetLetterCoroutine(GameObject text)
    {
        text.SetActive(true);
        yield return new WaitForSeconds(2);
        text.SetActive(false);
    }
}
