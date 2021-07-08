using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExamDABA : MonoBehaviour
{
    public bool IsExamPassed()
    {
        int points = 0;
        points += CheckExercise1();
        points += CheckExercise2();

        for (int i=0; i < inputAufgabe1.Length; i++) {
            inputAufgabe1[i].text = "";
            inputAufgabe2[i].text = "";
        }
        
        if (points >= 6) return true;
        return false;
    }

    public TMP_InputField[] inputAufgabe1;
    private int CheckExercise1()
    {
        int points = 0;
        if (inputAufgabe1[0].text == "2070") points += 1;
        if (inputAufgabe1[1].text == "5") points += 1;
        if (inputAufgabe1[2].text == "1200") points += 1;
        if (inputAufgabe1[3].text == "300") points += 1;
        return points;
    }

    public TMP_InputField[] inputAufgabe2;
    private int CheckExercise2()
    {
        int points = 0;
        if (inputAufgabe1[0].text == "A") {
            points += 2;
            if (inputAufgabe1[1].text == "C") {
                points += 2;
            }
        }
        if (inputAufgabe1[1].text == "A") {
            points += 2;
            if (inputAufgabe1[0].text == "C") {
                points += 2;
            }
        }
        if (inputAufgabe1[3].text == "A") {
            points += 2;
            if (inputAufgabe1[4].text == "B") {
                points += 2;
            }
        }
        if (inputAufgabe1[4].text == "A") {
            points += 2;
            if (inputAufgabe1[3].text == "B") {
                points += 2;
            }
        }
        return points;
    }
}
