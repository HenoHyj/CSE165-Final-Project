using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] GameObject woundUI;
    [SerializeField] GameObject temperatureUI;
    [SerializeField] GameObject consentUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        temperatureUI.SetActive(false);
        woundUI.SetActive(false);
        consentUI.SetActive(true);
    }
}
