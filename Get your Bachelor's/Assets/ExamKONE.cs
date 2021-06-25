using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ExamKONE : MonoBehaviour
{
    public bool IsExamPassed()
    {
        double points = 0.0;
        points += CheckExercise1();
        points += CheckExercise2();

        for (int i=0; i < inputAufgabe1a.Length; i++) {
            inputAufgabe1a[i].text = "";
            inputAufgabe1b[i].text = "";
            inputAufgabe1c[i].text = "";
            inputAufgabe1d[i].text = "";
            inputAufgabe1e[i].text = "";
        }
        for (int i=0; i < inputAufgabe2b.Length; i++) {
            inputAufgabe2b[i].text = "";
        }
        for (int i=0; i < inputAufgabe2c.Length; i++) {
            inputAufgabe2c[i].text = "";
        }
        inputAufgabe1f.text = "";
        inputAufgabe2a.text = "";
        
        if (points >= 5.0) return true;
        return false;
    }

    public TMP_InputField[] inputAufgabe1a;
    public TMP_InputField[] inputAufgabe1b;
    public TMP_InputField[] inputAufgabe1c;
    public TMP_InputField[] inputAufgabe1d;
    public TMP_InputField[] inputAufgabe1e;
    public TMP_InputField inputAufgabe1f;
    private double CheckExercise1()
    {
        double points = 0.0;
        if (inputAufgabe1a[0].text == "255" &&
        inputAufgabe1a[1].text == "255" &&
        inputAufgabe1a[2].text == "0" &&
        inputAufgabe1a[3].text == "0")
            points += 1.0;

        if (inputAufgabe1b[0].text == "147" &&
        inputAufgabe1b[1].text == "11" &&
        inputAufgabe1b[2].text == "255" &&
        inputAufgabe1b[3].text == "255")
            points += 1.0;

        if (inputAufgabe1c[0].text == "147" &&
        inputAufgabe1c[1].text == "11" &&
        inputAufgabe1c[2].text == "255" &&
        inputAufgabe1c[3].text == "254")
            points += 1.0;

        if (inputAufgabe1d[0].text == "147" &&
        inputAufgabe1d[1].text == "11" &&
        inputAufgabe1d[2].text == "0" &&
        inputAufgabe1d[3].text == "1")
            points += 1.0;

        if (inputAufgabe1e[0].text == "147" &&
        inputAufgabe1e[1].text == "11" &&
        inputAufgabe1e[2].text == "9" &&
        inputAufgabe1e[3].text == "0")
            points += 1.0;

        if (inputAufgabe1f.text == "256")
            points += 1.0;

        if (points <= 0.1) points = 0.0;
        return points;
    }
    
    public TMP_InputField inputAufgabe2a;
    public TMP_InputField[] inputAufgabe2b;
    public TMP_InputField[] inputAufgabe2c;
    private double CheckExercise2()
    {
        double points = 0.0;
        if (inputAufgabe2a.text == "254")
            points += 1.0;

        Boolean last = false;
        if (inputAufgabe2b[0].text == "147" &&
        inputAufgabe2b[1].text == "11" &&
        inputAufgabe2b[2].text == "2") {
            if (inputAufgabe2b[3].text == "0") {
                points += 1.0;
            } else if (inputAufgabe2b[3].text == "255") {
                points += 1.0;
                last = true;
            }
        }
        if (inputAufgabe2b[4].text == "147" &&
        inputAufgabe2b[5].text == "11" &&
        inputAufgabe2b[6].text == "2") {
            if (inputAufgabe2b[7].text == "0" && last) {
                points += 1.0;
            } else if (inputAufgabe2b[7].text == "255" && !last) {
                points += 1.0;
                last = true;
            }
        }

        if (inputAufgabe2c[0].text == "255" &&
        inputAufgabe2c[1].text == "255" &&
        inputAufgabe2c[2].text == "255" &&
        inputAufgabe2c[3].text == "0" &&
        inputAufgabe2c[4].text == "24")
            points += 1.0;

        if (points <= 0.1) points = 0.0;
        return points;
    }
}
