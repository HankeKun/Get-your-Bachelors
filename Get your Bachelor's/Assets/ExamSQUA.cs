using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ExamSQUA : MonoBehaviour
{
    public bool IsExamPassed()
    {
        double points = 0.0;
        points += CheckExercise1();
        points += CheckExercise2();

        for (int i=0; i < toggleAufgabe1r.Length; i++) {
            toggleAufgabe1r[i].isOn = false;
            toggleAufgabe1f[i].isOn = false;
        }

        for (int i=0; i < toggleAufgabe2.Length; i++) {
            toggleAufgabe2[i].isOn = false;
        }

        if (points >= 7.0) return true;
        return false;
    }

    public Toggle[] toggleAufgabe1r; // right toggles
    public Toggle[] toggleAufgabe1f; // false toggles
    private double CheckExercise1()
    {
        double points = 0.0;
        
        if (toggleAufgabe1r[0].isOn) points += 1.0;
        if (toggleAufgabe1r[1].isOn) points += 1.0;
        if (toggleAufgabe1r[2].isOn) points += 1.0;
        if (toggleAufgabe1r[3].isOn) points += 1.0;
        if (toggleAufgabe1r[4].isOn) points += 1.0;
        if (toggleAufgabe1r[5].isOn) points += 1.0;
        if (toggleAufgabe1r[6].isOn) points += 1.0;
        if (toggleAufgabe1r[7].isOn) points += 1.0;

        if (points <= 0.1) points = 0.0;
        return points;
    }

    public Toggle[] toggleAufgabe2;
    private double CheckExercise2()
    {
        double points = 0.0;
        
        if (toggleAufgabe2[0].isOn || toggleAufgabe2[1].isOn)
            points += 6.0;

        return points;
    }
}
