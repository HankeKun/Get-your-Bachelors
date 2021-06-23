using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SecrMueller : MonoBehaviour
{
    private bool playerInRange;
    public GameObject keyEnter;
    public GameObject dialogBox;
    public PlayerMovement playerMovement;
    public TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if(dialogBox.activeInHierarchy)
            {
                FindObjectOfType<DialogManager>().DisplayNextSentence();
            }
            else
            {
                int questState = PlayerPrefs.GetInt("QuestState", 0);
                switch(questState) {
                    case int n when (n <= 3 && n >= 0):
                        FindObjectOfType<DialogManager>().StartDialogue(dialog1, dialogBox, keyEnter, text);
                        break;
                    case int n when (n <= 5 && n >= 4):
                        FindObjectOfType<DialogManager>().StartDialogue(dialog2, dialogBox, keyEnter, text);
                        PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest5);
                        break;
                    case int n when (n == 7 || n == 9):
                        FindObjectOfType<DialogManager>().StartDialogue(dialog1, dialogBox, keyEnter, text);
                        break;
                    case 6:
                        FindObjectOfType<DialogManager>().StartDialogue(dialog3, dialogBox, keyEnter, text);
                        break;
                    case 8:
                        FindObjectOfType<DialogManager>().StartDialogue(dialog4, dialogBox, keyEnter, text);
                        break;
                    case 10:
                        FindObjectOfType<DialogManager>().StartDialogue(dialog5, dialogBox, keyEnter, text);
                        break;
                }
                dialogBox.SetActive(true);
                keyEnter.SetActive(false);
                playerMovement.pState = PlayerState.interact;
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

    private string[] dialog1 = { "Hey, momentan kann ich nichts für dich tun. Komm zu einem späteren Zeitpunkt wieder.", };

    private string[] dialog2 = { "Hey, du bist also neu hier. Dein Studium besteht aus 6 Semestern und dann der Bachelorarbeit.",
    "Das 1. Semester besteht aus dem Fach Grundlagen der Informatik.",
    "Das 2. Semester besteht aus Programmieren.",
    "Das 3. Semester besteht aus Kommunikation und Netze (Internet).",
    "Das 4. Semester besteht aus Datenbanken.",
    "Das 5. Semester besteht aus Software Qualität.",
    "Das 6. Semester besteht aus Mathematik.",
    "Die Bachelorarbeit ist dann eine Zusammensetzung aus Allem.",
    "Falls du mal nicht weiter weißt, komm einfach zu mir." };

    private string[] dialog3 = { "Hey, du bist also momentan im ersten Semester.",
    "Dann solltest du Professor Karl finden. Er unterrichtet Grundlagen der Informatik.",
    "Du solltest ihn im Gebäude 2 Raum 2 finden." };

    private string[] dialog4 = { "Hey, du bist also momentan im zweiten Semester.",
    "Dann solltest du Professor Lucky finden. Er unterrichtet Programmieren.",
    "Du solltest ihn im Gebäude 1 Raum 1 finden." };

    private string[] dialog5 = { "Hey, du bist also momentan im dritten Semester.",
    "Dann solltest du Professor Kurz finden. Er unterrichtet Kommunikation und Netze.",
    "Du solltest ihn im Gebäude 0 Raum 3 finden." };
}