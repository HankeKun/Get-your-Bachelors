using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ExamPROG : MonoBehaviour
{
    public bool IsExamPassed()
    {
        double points = 0.0;
        points += CheckExercise1();
        points += CheckExercise2();
        points += CheckExercise3();

        for (int i=0; i < toggleAufgabe1.Length; i++) {
            toggleAufgabe1[i].isOn = false;
        }
        for (int i=0; i < toggleAufgabe2.Length; i++) {
            toggleAufgabe2[i].isOn = false;
        }
        for (int i=0; i < inputAufgabe2.Length; i++) {
            inputAufgabe2[i].text = "";
        }
        for (int i=0; i < inputAufgabe3.Length; i++) {
            inputAufgabe3[i].text = "";
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
        if (points <= 0.1) points = 0.0;
        return points;
    }

    public Toggle[] toggleAufgabe2;
    public TMP_InputField[] inputAufgabe2;
    private double CheckExercise2()
    {
        double points = 0.0;
        if (toggleAufgabe2[0].isOn) {
            //
            points += 0.5;
            if (inputAufgabe2[0].text == "-102") {
                points += 0.5;
            }
        }
        if (!toggleAufgabe2[1].isOn) {
            points += 0.5;
            if (inputAufgabe2[1].text == "") {
                points += 0.5;
            }
        }
        if (!toggleAufgabe2[2].isOn) {
            points += 0.5;
            if (inputAufgabe2[2].text == "") {
                points += 0.5;
            }
        }
        if (toggleAufgabe2[3].isOn) {
            //
            points += 0.5;
            if (inputAufgabe2[3].text == "8") {
                points += 0.5;
            }
        }
        if (toggleAufgabe2[4].isOn) {
            //
            points += 0.5;
            if (inputAufgabe2[4].text == "15a") {
                points += 0.5;
            }
        }
        if (!toggleAufgabe2[5].isOn) {
            points += 0.5;
            if (inputAufgabe2[5].text == "") {
                points += 0.5;
            }
        }
        return points;
    }

    public TMP_InputField[] inputAufgabe3;
    public TMP_Dropdown[] dropLeft;
    public TMP_Dropdown[] dropRight;
    private string[] drop = new string[4];
    private double CheckExercise3()
    {
        for (int i=0; i < dropLeft.Length; i++) {
            drop[i] = dropLeft[i].captionText.text + dropRight[i].captionText.text;
        }

        double points = 0.5;
        int pos = Array.IndexOf(drop, "22");
        if (pos > -1) {
            points += 0.5;
            if (inputAufgabe3[pos+1].text == "1") {
                points += 0.5;
            }
        }
        pos = Array.IndexOf(drop, "21");
        if (pos > -1) {
            points += 0.5;
            if (inputAufgabe3[pos+1].text == "2") {
                points += 0.5;
            }
        }
        pos = Array.IndexOf(drop, "11");
        if (pos > -1) {
            points += 0.5;
            if (inputAufgabe3[pos+1].text == "1") {
                points += 0.5;
            }
        }
        pos = Array.IndexOf(drop, "10");
        if (pos > -1) {
            points += 0.5;
            if (inputAufgabe3[pos+1].text == "1") {
                points += 0.5;
            }
        }

        if (inputAufgabe3[0].text == "3") {
            points += 0.5;
        }

        return points;
    }
}
