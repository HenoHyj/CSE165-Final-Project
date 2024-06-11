using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Voice;
using System;
using Oculus.Interaction.PoseDetection;

public class ScanAction : MonoBehaviour
{
    [SerializeField] GameObject woundUI;
    [SerializeField] GameObject temperatureUI;
    [SerializeField] GameObject consentUI;
    [SerializeField] AudioSource scanAudio;
    [SerializeField] GameObject body;
    [SerializeField] GameObject hoodie;
    [SerializeField] GameObject shorts;
    [SerializeField] GameObject hair;
    [SerializeField] GameObject eye;
    [SerializeField] Material newMaterial; 



    private bool isLeftStop;
    private bool isRightStop;
    // Start is called before the first frame update

    public void popUpCanvas(string[] values)
    {
        scanAudio.Play(0);
        Invoke("ShowPopUp", 1.0f);
        ChangeObjectMaterials(body);
        ChangeObjectMaterials(eye);
        ChangeObjectMaterials(hair);
        HideClothes();
    }

    public void ChangeObjectMaterials(GameObject bodyPart)
    {
        Renderer renderer = bodyPart.GetComponent<Renderer>();
        if (renderer != null)
        {
            Material[] materials = renderer.materials;
            for (int i = 0; i < materials.Length; i++)
            {
                materials[i] =  newMaterial;
            }
            renderer.materials = materials; // Apply the modified materials back to the renderer
        }
        else
        {
            Debug.LogError("Renderer component not found on the target GameObject.");
        }
    }
    public void HideClothes()
    {
        if (hoodie != null && shorts != null)
        {
            hoodie.SetActive(false);
            shorts.SetActive(false);
        }
        else
        {
            Debug.LogError("Clothes GameObject is not assigned.");
        }
    }

    public void ShowPopUp()
    {
        temperatureUI.SetActive(true);
        woundUI.SetActive(true);
    }

    public void closeConsentCanvas()
    {
        consentUI.SetActive(false);
    }
    public void closeCanvas(string[] values)
    {
        temperatureUI.SetActive(false);
        woundUI.SetActive(false);
        consentUI.SetActive(false);
    }
}
