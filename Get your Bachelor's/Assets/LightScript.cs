using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightScript : MonoBehaviour
{
    public Light2D light2d;
    public DayNightValue dayNightValue;
    // Start is called before the first frame update
    void Start()
    {
        light2d.intensity = dayNightValue.intensity;
    }
}
