using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Voice;
using System;
using Oculus.Interaction.PoseDetection;
using UnityEngine.SceneManagement;

public class AllCanvasSwitcher : MonoBehaviour
{
    [SerializeField] GameObject woundUI;
    [SerializeField] GameObject temperatureUI;
    [SerializeField] GameObject consentUI;
    [SerializeField] GameObject checklistUI;
    [SerializeField] AudioSource scanAudio;
    [SerializeField] AudioSource scanAudio2;
    [SerializeField] AudioSource consentAudio;

    // Start is called before the first frame update

    public void GoConsentCanvas()
    {
        woundUI.SetActive(false);
        temperatureUI.SetActive(false);
        consentUI.SetActive(true);
        consentAudio.Play(0);
    }

    public void GoChecklistCanvas()
    {
        if(consentUI.activeSelf)
        {
            consentUI.SetActive(false);
            checklistUI.SetActive(true);
        }

    }

    public void NotGoChecklistCanvas()
    {
        if (consentUI.activeSelf)
        {
            consentUI.SetActive(false);
        }

    }
}
