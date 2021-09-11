using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ProfKurz : MonoBehaviour
{
    private bool playerInRange;
    public GameObject keyEnter;
    public GameObject dialogBox;
    public PlayerMovement playerMovement;
    public TextMeshProUGUI text;
    public GameObject choiceBox;
    public GameObject choiceBoxBachelor;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E) && (playerMovement.pState != PlayerState.gamemenu))
        {
            if (dialogBox.activeInHierarchy)
            {
                FindObjectOfType<DialogManager>().DisplayNextSentence();
                if (PlayerPrefs.GetInt("Ended", 0) == 1) {
                    SceneManager.LoadScene(24);
                }
            }
            else
            {
                int questState = PlayerPrefs.GetInt("QuestState", 0);
                switch(questState) {
                    case int n when (n <= 9 && n >= 0):
                        FindObjectOfType<DialogManager>().StartDialogue(dialog1, dialogBox, keyEnter, text);
                        break;
                    case 10:
                        FindObjectOfType<DialogManager>().StartChoiceDialogue(dialog2, dialogBox, keyEnter, text, choiceBox);
                        break;
                    case int n when (n <= 17 && n >= 11):
                        FindObjectOfType<DialogManager>().StartDialogue(dialog3, dialogBox, keyEnter, text);
                        break;
                    case 18:
                        FindObjectOfType<DialogManager>().StartChoiceDialogue(dialog5, dialogBox, keyEnter, text, choiceBoxBachelor);
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

    private string[] dialog2 = { "Es ist Zeit für die Kommunikation und Netze Prüfung.",
    "Bist du bereit?" };

    private string[] dialog3 = { "Glückwunsch du hast die Prüfung Kommunikation und Netze bestanden.",
    "Nun heißt es dran bleiben und weiter machen." };

    private string[] dialog4 = { "Tut mir leid aber du hast die Prüfung nicht bestanden.",
    "Schau dir nochmal die Vorlesung an und komm wieder, wenn du bereit bist." };
    
    private string[] dialog5 = { "Du willst also also deine Bachelorarbeit bei mir schreiben?." };

    private string[] dialog6 = { "Das war wohl leider nichts mit dem Bachelor.",
    "Da musst du wohl nochmal ran!" };

    private string[] dialog7 = { "Glückwunsch! Damit hast du den Bachelor in Informatik." };

    public GameObject exam;
    public GameObject examPage2;
    public void StartExam()
    {
        FindObjectOfType<DialogManager>().DisplayNextSentence();
        playerMovement.pState = PlayerState.interact;
        exam.SetActive(true);
    }

    public void EndExam()
    {
        exam.SetActive(false);
        examPage2.SetActive(false);

        // Exam bewerten lassen
        // if bestanden dialog 3 und setze QuestState+1
        if (FindObjectOfType<ExamKONE>().IsExamPassed()) {
            FindObjectOfType<DialogManager>().StartDialogue(dialog3, dialogBox, keyEnter, text);
            PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest11);
            PlayerPrefs.SetFloat("DayNight", 0.5f);
        }
        else {
            FindObjectOfType<DialogManager>().StartDialogue(dialog4, dialogBox, keyEnter, text);
        }
        
        dialogBox.SetActive(true);
        keyEnter.SetActive(false);
        playerMovement.pState = PlayerState.interact;
    }

    public GameObject bachelorExamPage1;
    public GameObject bachelorExamPage2;
    public GameObject bachelorExamPage3;
    public GameObject bachelorExamPage4;
    public GameObject bachelorExamPage5;
    public GameObject bachelorExamPage6;

    public void StartBachelor() {
        FindObjectOfType<DialogManager>().DisplayNextSentence();
        playerMovement.pState = PlayerState.interact;
        bachelorExamPage1.SetActive(true);
    }

    public void EndBachelor() {
        bachelorExamPage1.SetActive(false);
        bachelorExamPage2.SetActive(false);
        bachelorExamPage3.SetActive(false);
        bachelorExamPage4.SetActive(false);
        bachelorExamPage5.SetActive(false);
        bachelorExamPage6.SetActive(false);

        if (FindObjectOfType<Bachelor>().IsBachelorPassed()) {
            FindObjectOfType<DialogManager>().StartDialogue(dialog7, dialogBox, keyEnter, text);
            PlayerPrefs.SetInt("Ended", 1);
        }
        else {
            FindObjectOfType<DialogManager>().StartDialogue(dialog6, dialogBox, keyEnter, text);
        }

        dialogBox.SetActive(true);
        keyEnter.SetActive(false);
        playerMovement.pState = PlayerState.interact;
    }
}