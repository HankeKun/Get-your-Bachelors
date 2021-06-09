using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Button : MonoBehaviour
{
    public TextMeshProUGUI text;

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
}
