using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAllChecker : MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle toggle1;
    public Toggle toggle2;
    public Toggle toggle3;
    public Toggle toggle4;
    public GameObject checklistUI;
    public GameObject instructiontUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle1.isOn && toggle2.isOn && toggle3.isOn && toggle4.isOn) 
        {
            checklistUI.SetActive(false);
            instructiontUI.SetActive(true);
        }
    }
}
