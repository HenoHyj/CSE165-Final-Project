using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeStanding : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing.");
        }

        // Freeze rotation on the Rigidbody to prevent it from tipping over
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Calculate the upright rotation
        Quaternion uprightRotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);

        // Smoothly interpolate to the upright position
        transform.rotation = Quaternion.Slerp(transform.rotation, uprightRotation, Time.deltaTime * 10f);

        // Optionally, zero out any angular velocity to stop it from spinning
        rb.angularVelocity = Vector3.zero;
    }
}
