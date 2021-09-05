﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bachelor : MonoBehaviour
{
    public bool IsBachelorPassed()
    {
        double points = 0.0;
        
        points += CheckExercise1();
        points += CheckExercise2();
        points += CheckExercise3();
        points += CheckExercise4();
        points += CheckExercise5();
        points += CheckExercise6();

        for (int i=0; i < textAufgabe1a.Length; i++) {
            textAufgabe1a[i].text = "0";
        }
        for (int i=0; i < textAufgabe1b.Length; i++) {
            textAufgabe1b[i].text = "0";
        }
        for (int i=0; i < textAufgabe1c.Length; i++) {
            textAufgabe1c[i].text = "0";
        }
        for (int i=0; i < textAufgabe1d.Length; i++) {
            textAufgabe1d[i].text = "0";
        }
        for (int i=0; i < toggleAufgabe2.Length; i++) {
            toggleAufgabe2[i].isOn = false;
        }

        return points >= 10.0;
    }

    public TextMeshProUGUI[] textAufgabe1a;
    public TextMeshProUGUI[] textAufgabe1b;
    public TextMeshProUGUI[] textAufgabe1c;
    public TextMeshProUGUI[] textAufgabe1d;
    private double CheckExercise1()
    {
        double points = 0.0;
        
        if (textAufgabe1a[0].text == "1"
        && textAufgabe1a[1].text == "1"
        && textAufgabe1a[2].text == "1"
        && textAufgabe1a[3].text == "0"
        && textAufgabe1a[4].text == "0"
        && textAufgabe1a[5].text == "1")
        points += 2.0;

        if (textAufgabe1b[0].text == "1"
        && textAufgabe1b[1].text == "1"
        && textAufgabe1b[2].text == "0"
        && textAufgabe1b[3].text == "1"
        && textAufgabe1b[4].text == "0"
        && textAufgabe1b[5].text == "0"
        && textAufgabe1b[6].text == "1"
        && textAufgabe1b[7].text == "0")
        points += 2.0;

        if (textAufgabe1c[0].text == "6"
        && textAufgabe1c[1].text == "3")
        points += 2.0;

        if (textAufgabe1d[0].text == "F"
        && textAufgabe1d[1].text == "C"
        && textAufgabe1d[2].text == "1")
        points += 2.0;

        return points;
    }

    public Toggle[] toggleAufgabe2;
    private double CheckExercise2()
    {
        double points = 0.0;

        if (toggleAufgabe2[0].isOn) {
            points += 2.0;
        }
        if (toggleAufgabe2[1].isOn) {
            points -= 2.0;
        }
        if (toggleAufgabe2[2].isOn) {
            points += 2.0;
        }
        if (toggleAufgabe2[3].isOn) {
            points -= 2.0;
        }
        if (toggleAufgabe2[4].isOn) {
            points += 2.0;
        }
        if (toggleAufgabe2[5].isOn) {
            points -= 2.0;
        }
        if (toggleAufgabe2[6].isOn) {
            points -= 2.0;
        }
        if (toggleAufgabe2[7].isOn) {
            points += 2.0;
        }
        return points;
    }

    public TMP_InputField[] inputAufgabe3a;
    public TMP_InputField[] inputAufgabe3b;
    public TMP_InputField[] inputAufgabe3c;
    public TMP_InputField[] inputAufgabe3d;
    public TMP_InputField[] inputAufgabe3e;
    public TMP_InputField inputAufgabe3f;
    private double CheckExercise3()
    {
        double points = 0.0;
        if (inputAufgabe3a[0].text == "255" &&
        inputAufgabe3a[1].text == "255" &&
        inputAufgabe3a[2].text == "0" &&
        inputAufgabe3a[3].text == "0")
            points += 1.0;

        if (inputAufgabe3b[0].text == "147" &&
        inputAufgabe3b[1].text == "11" &&
        inputAufgabe3b[2].text == "255" &&
        inputAufgabe3b[3].text == "255")
            points += 1.0;

        if (inputAufgabe3c[0].text == "147" &&
        inputAufgabe3c[1].text == "11" &&
        inputAufgabe3c[2].text == "255" &&
        inputAufgabe3c[3].text == "254")
            points += 1.0;

        if (inputAufgabe3d[0].text == "147" &&
        inputAufgabe3d[1].text == "11" &&
        inputAufgabe3d[2].text == "0" &&
        inputAufgabe3d[3].text == "1")
            points += 2.0;

        if (inputAufgabe3e[0].text == "147" &&
        inputAufgabe3e[1].text == "11" &&
        inputAufgabe3e[2].text == "9" &&
        inputAufgabe3e[3].text == "0")
            points += 1.0;

        if (inputAufgabe3f.text == "256")
            points += 2.0;

        if (points <= 0.1) points = 0.0;
        return points;
    }

    private double CheckExercise4()
    {
        double points = 0.0;

        return points;
    }

    private double CheckExercise5()
    {
        double points = 0.0;

        return points;
    }

    private double CheckExercise6()
    {
        double points = 0.0;

        return points;
    }
}
