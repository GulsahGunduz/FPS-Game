using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float intensityAmount = 2f;
    [SerializeField] float restoreAngle = 70f;

    Flashlight flashlight;

    private void Start() 
    {
        flashlight = FindObjectOfType<Flashlight>();    
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            flashlight.AddLightIntensity(intensityAmount);
            flashlight.RestoreLightAngle(restoreAngle);
        }
    }

}
