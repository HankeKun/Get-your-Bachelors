using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Button : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject[] pages;

    public void Up()
    {
        int number = int.Parse(text.text);
        number = ++number%10;
        text.text = number.ToString();
    }

    public void Down()
    {
        int number = int.Parse(text.text);
        number = --number;
        if (number < 0) {
            number = 9;
        }
        text.text = number.ToString();
    }

    public void UpHex()
    {
        int number;
        try {
            number = int.Parse(text.text);
            ++number;
            if (number == 10) {
                text.text = "A";
            } else {
                text.text = number.ToString();
            }
        } catch {
            switch (text.text) {
                case "A":
                    text.text = "B";
                    break;
                case "B":
                    text.text = "C";
                    break;
                case "C":
                    text.text = "D";
                    break;
                case "D":
                    text.text = "E";
                    break;
                case "E":
                    text.text = "F";
                    break;
                case "F":
                    text.text = "0";
                    break;
            }
        }
    }

    public void DownHex()
    {
        int number;
        try {
            number = int.Parse(text.text);
            --number;
            if (number == -1) {
                text.text = "F";
            } else {
                text.text = number.ToString();
            }
        } catch {
            switch (text.text) {
                case "A":
                    text.text = "9";
                    break;
                case "B":
                    text.text = "A";
                    break;
                case "C":
                    text.text = "B";
                    break;
                case "D":
                    text.text = "C";
                    break;
                case "E":
                    text.text = "D";
                    break;
                case "F":
                    text.text = "E";
                    break;
            }
        }
    }

    public void nextPage()
    {
        for (int i=0; i < pages.Length; i++) {
            if (pages[i].activeInHierarchy) {
                pages[i].SetActive(false);
                pages[i+1].SetActive(true);
                return;
            }
        }
    }

    public void previousPage()
    {
        for (int i=0; i < pages.Length; i++) {
            if (pages[i].activeInHierarchy) {
                pages[i].SetActive(false);
                pages[i-1].SetActive(true);
                return;
            }
        }
    }
}
