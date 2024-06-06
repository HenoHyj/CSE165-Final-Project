using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Voice;
using System;

public class ScanAction : MonoBehaviour
{
    [SerializeField] GameObject woundUI;
    [SerializeField] GameObject temperatureUI;
    // Start is called before the first frame update
    public void popUpCanvas(string[] values)
    {
        Invoke("ShowPopUp", 3.0f);
    }

    private void ShowPopUp()
    {
        temperatureUI.SetActive(true);
        woundUI.SetActive(true);
    }

    public void closeCanvas(string[] values)
    {
        temperatureUI.SetActive(false);
        woundUI.SetActive(false);
    }
}
