using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerQuestState playerQuestState;

    public void Update() {
        playerQuestState = (PlayerQuestState) PlayerPrefs.GetInt("QuestState", 0);
    }

    public enum PlayerQuestState {
        Nothing = 0,
        Quest1 = 1, // Du hast Post! Hole den Brief.
        Quest2 = 2, // Geh an deinen Schreibtisch und lese den Brief.
        Quest3 = 3, // Gehe zur TH und hole deinen Studentenausweis.
        Quest4 = 4, // Informiere dich bei Sekretärin Müller über das Studium.
        Quest5 = 5, // Geh nach Hause und schlaf damit du fit für das Studium bist.
        Quest6 = 6, // Bereit für das erste Semester. Besuch deine Vorlesung.
        Quest7 = 7 
    }
}
