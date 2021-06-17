using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExamPROG : MonoBehaviour
{
    public bool IsExamPassed()
    {
        double points = 0.5;
        points += CheckExercise1();
        points += CheckExercise2();
        points += CheckExercise3();

        for (int i=0; i < toggleAufgabe1.Length; i++) {
            toggleAufgabe1[i].isOn = false;
        }
        
        if (points >= 7.0) return true;
        return false;
    }

    public Toggle[] toggleAufgabe1;
    private double CheckExercise1()
    {
        double points = 0.0;
        if (toggleAufgabe1[0].isOn) {
            points += 1.0;
        }
        if (toggleAufgabe1[1].isOn) {
            points -= 1.0;
        }
        if (toggleAufgabe1[2].isOn) {
            points += 1.0;
        }
        if (toggleAufgabe1[3].isOn) {
            points += 1.0;
        }
        if (toggleAufgabe1[4].isOn) {
            points -= 1.0;
        }
        if (toggleAufgabe1[5].isOn) {
            points -= 1.0;
        }
        if (points <= 0.0) points = 0.0; 
        return points;
    }

    public TextMeshProUGUI[] textAufgabe2;
    private int CheckExercise2()
    {
        if (textAufgabe2[0].text != "1") return 0;
        if (textAufgabe2[1].text != "0") return 0;
        if (textAufgabe2[2].text != "1") return 0;
        if (textAufgabe2[3].text != "1") return 0;
        if (textAufgabe2[4].text != "1") return 0;
        if (textAufgabe2[5].text != "0") return 0;
        if (textAufgabe2[6].text != "0") return 0;
        if (textAufgabe2[7].text != "1") return 0;
        return 2;
    }

    public TextMeshProUGUI[] textAufgabe3;
    private int CheckExercise3()
    {
        if (textAufgabe3[0].text != "2") return 0;
        if (textAufgabe3[1].text != "6") return 0;
        return 2;
    }

    public TextMeshProUGUI[] textAufgabe4;
    private int CheckExercise4()
    {
        if (textAufgabe4[0].text != "E") return 0;
        if (textAufgabe4[1].text != "2") return 0;
        if (textAufgabe4[2].text != "6") return 0;
        return 2;
    }

    public TextMeshProUGUI[] textAufgabe5;
    private int CheckExercise5()
    {
        if (textAufgabe5[0].text != "1") return 0;
        if (textAufgabe5[1].text != "0") return 0;
        if (textAufgabe5[2].text != "1") return 0;
        if (textAufgabe5[3].text != "1") return 0;
        if (textAufgabe5[4].text != "1") return 0;
        if (textAufgabe5[5].text != "0") return 0;
        return 3;
    }

    public TextMeshProUGUI[] textAufgabe6Z1;
    public TextMeshProUGUI[] textAufgabe6Z2;
    public TextMeshProUGUI[] textAufgabe6Z3;
    private int CheckExercise6()
    {
        int pointsEx6 = 0;

        if (textAufgabe6Z1[0].text == "1" && textAufgabe6Z1[1].text == "9") pointsEx6++;

        if (textAufgabe6Z2[0].text == "2" && textAufgabe6Z2[1].text == "7") pointsEx6++;

        if (textAufgabe6Z3[0].text == "4" && textAufgabe6Z3[1].text == "6") pointsEx6++;

        return pointsEx6;
    }
}
