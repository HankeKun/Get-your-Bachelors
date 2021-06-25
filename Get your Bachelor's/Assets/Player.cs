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
        Quest6 = 6, // Bereit für das erste Semester. Besuch deine Vorlesung und bestehe die Prüfung.
        Quest7 = 7, // Geh nach Hause schlafen, um dich auf das zweite Semester vorzubereiten.
        Quest8 = 8, // Bestehe die Prüfung des 2. Semesters.
        Quest9 = 9, // Geh nach Hause schlafen, um dich auf das dritte Semester vorzubereiten.
        Quest10 = 10, // Bestehe die Prüfung des 3. Semesters.
        Quest11 = 11, // Geh nach Hause schlafen, um dich auf das vierte Semester vorzubereiten.
        Quest12 = 12 // Bestehe die Prüfung des 4. Semesters.
    }
}
