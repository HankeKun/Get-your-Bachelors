using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentences;

    public PlayerMovement playerMovement;
    private GameObject dialogBox;
    private GameObject keyEnter;
    private TextMeshProUGUI text;
    
    void Start() {
        sentences = new Queue<string>();
    }

    public void StartDialogue(string[] dialogue, GameObject dialogBox, GameObject keyEnter, TextMeshProUGUI text)
    {
        this.dialogBox = dialogBox;
        this.keyEnter = keyEnter;
        this.text = text;

        sentences.Clear();

        foreach (string sentence in dialogue) {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        if (sentences.Count == 0) {
            EndDialogue();
            return;
        }
        text.SetText(sentences.Dequeue());
    }

    void EndDialogue() {
        dialogBox.SetActive(false);
        keyEnter.SetActive(true);
        playerMovement.pState = PlayerState.walk;
    }
}
