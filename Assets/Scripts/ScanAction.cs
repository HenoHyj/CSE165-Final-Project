using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Voice;
using System;

public class ScanAction : MonoBehaviour
{
    [SerializeField] GameObject popUpUI;
    // Start is called before the first frame update
    public void popUpCanvas(string[] values)
    {
        popUpUI.SetActive(true);
    }

    public void closeCanvas(string[] values)
    {
        popUpUI.SetActive(false);
    }
}
