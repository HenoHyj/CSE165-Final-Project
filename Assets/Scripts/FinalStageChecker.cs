using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalStageChecker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject instructionUI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (instructionUI.activeSelf) {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.isKinematic = true;
        }
    }
}
