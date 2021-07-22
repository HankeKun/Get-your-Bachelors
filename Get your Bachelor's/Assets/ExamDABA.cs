using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

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
        if (inputAufgabe2[0].text.Equals("A", StringComparison.OrdinalIgnoreCase)) {
            points += 2;
            if (inputAufgabe2[1].text.Equals("C", StringComparison.OrdinalIgnoreCase)) {
                points += 2;
            }
        }
        if (inputAufgabe2[1].text.Equals("A", StringComparison.OrdinalIgnoreCase)) {
            points += 2;
            if (inputAufgabe2[0].text.Equals("C", StringComparison.OrdinalIgnoreCase)) {
                points += 2;
            }
        }
        if (inputAufgabe2[2].text.Equals("A", StringComparison.OrdinalIgnoreCase)) {
            points += 2;
            if (inputAufgabe2[3].text.Equals("B", StringComparison.OrdinalIgnoreCase)) {
                points += 2;
            }
        }
        if (inputAufgabe2[3].text.Equals("A", StringComparison.OrdinalIgnoreCase)) {
            points += 2;
            if (inputAufgabe2[2].text.Equals("B", StringComparison.OrdinalIgnoreCase)) {
                points += 2;
            }
        }
        return points;
    }
}
