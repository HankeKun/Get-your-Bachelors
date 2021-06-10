using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExamIGRU : MonoBehaviour
{
    public bool IsExamPassed()
    {
        int correct = 0;
        if (CheckExercise1()) correct++;
        if (CheckExercise2()) correct++;
        if (CheckExercise3()) correct++;
        if (CheckExercise4()) correct++;
        if (CheckExercise5()) correct++;
        if (CheckExercise6()) correct++;

        for (int i=0; i < textAufgabe1.Length; i++) {
            textAufgabe1[i].text = "0";
            textAufgabe5[i].text = "0";
        }

        for (int i=0; i < textAufgabe2.Length; i++) {
            textAufgabe2[i].text = "0";
        }

        for (int i=0; i < textAufgabe4.Length; i++) {
            textAufgabe4[i].text = "0";
        }

        for (int i=0; i < textAufgabe3.Length; i++) {
            textAufgabe3[i].text = "0";
            textAufgabe6Z1[i].text = "0";
            textAufgabe6Z2[i].text = "0";
            textAufgabe6Z3[i].text = "0";
        }

        if (correct >= 3) return true;
        else return false;
    }

    public TextMeshProUGUI[] textAufgabe1;
    private bool CheckExercise1()
    {
        if (textAufgabe1[0].text != "1") return false;
        if (textAufgabe1[1].text != "0") return false;
        if (textAufgabe1[2].text != "0") return false;
        if (textAufgabe1[3].text != "1") return false;
        if (textAufgabe1[4].text != "0") return false;
        if (textAufgabe1[5].text != "1") return false;
        return true;
    }

    public TextMeshProUGUI[] textAufgabe2;
    private bool CheckExercise2()
    {
        if (textAufgabe2[0].text != "1") return false;
        if (textAufgabe2[1].text != "0") return false;
        if (textAufgabe2[2].text != "1") return false;
        if (textAufgabe2[3].text != "1") return false;
        if (textAufgabe2[4].text != "1") return false;
        if (textAufgabe2[5].text != "0") return false;
        if (textAufgabe2[6].text != "0") return false;
        if (textAufgabe2[7].text != "1") return false;
        return true;
    }

    public TextMeshProUGUI[] textAufgabe3;
    private bool CheckExercise3()
    {
        if (textAufgabe3[0].text != "2") return false;
        if (textAufgabe3[1].text != "6") return false;
        return true;
    }

    public TextMeshProUGUI[] textAufgabe4;
    private bool CheckExercise4()
    {
        if (textAufgabe4[0].text != "E") return false;
        if (textAufgabe4[1].text != "2") return false;
        if (textAufgabe4[2].text != "6") return false;
        return true;
    }

    public TextMeshProUGUI[] textAufgabe5;
    private bool CheckExercise5()
    {
        if (textAufgabe5[0].text != "1") return false;
        if (textAufgabe5[1].text != "0") return false;
        if (textAufgabe5[2].text != "1") return false;
        if (textAufgabe5[3].text != "1") return false;
        if (textAufgabe5[4].text != "1") return false;
        if (textAufgabe5[5].text != "0") return false;
        return true;
    }

    public TextMeshProUGUI[] textAufgabe6Z1;
    public TextMeshProUGUI[] textAufgabe6Z2;
    public TextMeshProUGUI[] textAufgabe6Z3;
    private bool CheckExercise6()
    {
        if (textAufgabe6Z1[0].text != "1") return false;
        if (textAufgabe6Z1[1].text != "9") return false;

        if (textAufgabe6Z2[0].text != "2") return false;
        if (textAufgabe6Z2[1].text != "7") return false;

        if (textAufgabe6Z3[0].text != "4") return false;
        if (textAufgabe6Z3[1].text != "6") return false;
        return true;
    }
}
