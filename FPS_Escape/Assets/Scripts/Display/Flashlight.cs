using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] float lightDecay = .03f;
    [SerializeField] float angleDecay = .3f;
    [SerializeField] float minimumAngle = 40f;

    Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (myLight.spotAngle <= minimumAngle)
        {
            return;
        }
        else
        {
            myLight.spotAngle -= angleDecay * Time.deltaTime;

        }

        myLight.intensity -= lightDecay *Time.deltaTime;
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        myLight.spotAngle = restoreAngle;
    }

    public void AddLightIntensity(float intensityAmount)
    {
        myLight.intensity += intensityAmount;
    }
}
