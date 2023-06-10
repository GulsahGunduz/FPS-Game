using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomInSensitivity = 2f;
    [SerializeField] float zoomOutSensitivity = .5f;

    bool zoomToggle = false;

    private void OnDisable() 
    {
        fpsCamera.fieldOfView = zoomedOutFOV;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            CheckZoom(zoomToggle);
        }
    }

    private void CheckZoom(bool zoomToggle)
    {
        zoomToggle = !zoomToggle;

        fpsCamera.fieldOfView = zoomToggle ? zoomedInFOV : zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomToggle ? zoomInSensitivity : zoomOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomToggle ? zoomInSensitivity : zoomOutSensitivity;

    }
}
