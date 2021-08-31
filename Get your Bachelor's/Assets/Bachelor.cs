using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        return points >= 10.0;
    }

    private double CheckExercise1()
    {
        double points = 0.0;

        return points;
    }

    private double CheckExercise2()
    {
        double points = 0.0;

        return points;
    }

    private double CheckExercise3()
    {
        double points = 0.0;

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
