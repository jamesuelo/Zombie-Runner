using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField]
    float lightDecay = .1f;

    [SerializeField]
    float angleDecay = 1f;

    [SerializeField]
    float minimumAngle = 40f;

    Light myLight;

    // Start is called before the first frame update
    private void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    private void Update()
    {
        DecreaseLightAngle();
        DecreseLightIntensity();
    }

    private void RestoreLightAngle(float restoreAngle)
    {
        myLight.spotAngle = restoreAngle;
    }

    private void RestoreLightIntensity(float intensityAmount)
    {
        myLight.intensity += intensityAmount;
    }
    private void DecreaseLightAngle()
    {
        if (myLight.spotAngle <= minimumAngle)
        {
            return;
        }
        else
        {
            myLight.spotAngle -= angleDecay * Time.deltaTime;
        }
    }

    private void DecreseLightIntensity()
    {
        myLight.intensity -= lightDecay * Time.deltaTime;
    }
}
