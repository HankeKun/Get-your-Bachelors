using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadQuest : MonoBehaviour
{
    public Player player;
    public GameObject[] quests;

    void Update()
    {
        switch (player.playerQuestState) {
            // Nothing is for Error Handling
            case Player.PlayerQuestState.Nothing:
                for (int i=0; i < quests.Length; i++)
                    if (i != 0) quests[i].SetActive(false);
                quests[0].SetActive(true);
                break;
            // Du hast Post! Hole den Brief.
            case Player.PlayerQuestState.Quest1:
                for (int i=0; i < quests.Length; i++)
                    if (i != 1) quests[i].SetActive(false);
                quests[1].SetActive(true);
                break;
            // Geh an deinen Schreibtisch und lese den Brief.
            case Player.PlayerQuestState.Quest2:
                for (int i=0; i < quests.Length; i++)
                    if (i != 2) quests[i].SetActive(false);
                quests[2].SetActive(true);
                break;
            // Gehe zur TH und hole deinen Studentenausweis.
            case Player.PlayerQuestState.Quest3:
                for (int i=0; i < quests.Length; i++)
                    if (i != 3) quests[i].SetActive(false);
                quests[3].SetActive(true);
                break;
            // Informiere dich bei Sekretärin Müller über das Studium.
            case Player.PlayerQuestState.Quest4:
                for (int i=0; i < quests.Length; i++)
                    if (i != 4) quests[i].SetActive(false);
                quests[4].SetActive(true);
                break;
            // Geh nach Hause und schlaf damit du fit für das Studium bist.
            case Player.PlayerQuestState.Quest5:
                for (int i=0; i < quests.Length; i++)
                    if (i != 5) quests[i].SetActive(false);
                quests[5].SetActive(true);
                break;
            // Bereit für das erste Semester. Besuch deine Vorlesung und bestehe die Prüfung.
            case Player.PlayerQuestState.Quest6:
                for (int i=0; i < quests.Length; i++)
                    if (i != 6) quests[i].SetActive(false);
                quests[6].SetActive(true);
                break;
            // Geh nach Hause schlafen, um dich auf das zweite Semester vorzubereiten.
            case Player.PlayerQuestState.Quest7:
                for (int i=0; i < quests.Length; i++)
                    if (i != 7) quests[i].SetActive(false);
                quests[7].SetActive(true);
                break;
            default:
                break;
        }
    }
}
