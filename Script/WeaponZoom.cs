using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField]
    Camera fpsCamera;

    [SerializeField]
    float zoomedOutFOV = 60f;

    [SerializeField]
    float zoomedInFOV = 20f;

    [SerializeField]
    float zoomedOutSensitivity = 2f;

    [SerializeField]
    float zoomedInSensitivity = .5f;

    bool zoomedInToogle = false;

    [SerializeField]
    RigidbodyFirstPersonController fpsController;


    private void OnDisable(){
        ZoomOut();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToogle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomIn()
    {
        zoomedInToogle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsController.mouseLook.XSensitivity = zoomedInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedInSensitivity;
    }

    private void ZoomOut()
    {
        zoomedInToogle = false;
        fpsCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomedOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedOutSensitivity;
    }
}
