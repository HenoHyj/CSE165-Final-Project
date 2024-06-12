using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MedicalSupplyManager : MonoBehaviour
{
    public Toggle toggle; // Reference to the toggle to turn on/off
    public Color emissionColor;
    public Material material;
    public Material changeToMaterial;
    private bool isTouched = false;
    public Renderer renderer;
    public GameObject checklistUI;
    private HandGrabInteractable interactable;
    void Start()
    {
        RendererExtensions.UpdateGIMaterials(renderer);
        interactable = gameObject.GetComponent<HandGrabInteractable>();
    }

    void Update()
    {
        if (checklistUI.activeSelf) {
            EnableEmission();
        }
        // Check for hand input
        if (interactable.Interactors.FirstOrDefault<HandGrabInteractor>() != null)
        {
            DisableEmission(); // Disable emission when touched
            if (toggle != null)
            {
                toggle.isOn = true; // Turn on the toggle
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the hand has touched this GameObject
        
        if (other.CompareTag("Hand"))
        {
            isTouched = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Reset touch state when the hand stops touching the GameObject
        if (other.CompareTag("Hand"))
        {
            isTouched = false;
        }
    }
    void DisableEmission()
    {
        if (material != null)
        {
            renderer.material = material;
        }
    }

    public void EnableEmission()
    {
        if (material != null)
        {
            renderer.material = changeToMaterial;
        }
    }

    public void SetEmissionColor(Color color)
    {
        if (material != null)
        {
            material.SetColor("EmissionColor", color);
        }
    }
}
