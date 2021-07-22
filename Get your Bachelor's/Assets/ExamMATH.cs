using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ExamMATH : MonoBehaviour
{
    public bool IsExamPassed()
    {
        double points = 0.0;
        points += CheckExercise1();
        points += CheckExercise2();
        points += CheckExercise3();

        for (int i=0; i < inputAufgabe1.Length; i++) {
            inputAufgabe1[i].text = "";
        }

        for (int i=0; i < toggleAufgabe2.Length; i++) {
            toggleAufgabe2[i].isOn = false;
        }

        for (int i=0; i < inputAufgabe3.Length; i++) {
            inputAufgabe3[i].text = "";
        }
        Debug.Log("Aufgabe alle: " + points);
        if (points >= 7.9) return true; // >= 8.0
        return false;
    }

    public TMP_InputField[] inputAufgabe1;
    private double CheckExercise1()
    {
        double points = 0;

        if (inputAufgabe1[0].text == "0") points += 0.5;
        if (inputAufgabe1[1].text == "0") points += 0.5;
        if (inputAufgabe1[2].text == "0") points += 0.5;
        if (inputAufgabe1[3].text == "0") points += 0.5;
        if (inputAufgabe1[4].text == "0") points += 0.5;
        if (inputAufgabe1[5].text == "1") points += 0.5;
        if (inputAufgabe1[6].text == "1") points += 0.5;
        if (inputAufgabe1[7].text == "1") points += 0.5;
        
        return points;
    }

    public Toggle[] toggleAufgabe2;
    private double CheckExercise2()
    {
        double points = 0;

        if (toggleAufgabe2[0].isOn) points += 2.0;
        if (toggleAufgabe2[1].isOn) points += 2.0;
        if (toggleAufgabe2[2].isOn) points += 2.0;
        
        return points;
    }

    public TMP_InputField[] inputAufgabe3;
    private double CheckExercise3()
    {
        double points = 0;

        if (inputAufgabe3[0].text == "24") points += 2.0;
        if (inputAufgabe3[1].text == "2") points += 2.0;
        if (inputAufgabe3[2].text == "1268") points += 2.0;
        
        return points;
    }
}
