using UnityEngine;

public class MedicalSupplyCollisionChecker : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    [SerializeField] AudioSource thankAudio;
    private int times = 0;
    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object's tag is "MedicalSupply"
        if (collision.gameObject.CompareTag("MedicalSupply"))
        {
            // Perform an action, for example, log to console
            audio.Play(0);
            Debug.Log("Medical supply collided with " + gameObject.name);
            times++;
            if (times >= 3)
            {
                thankAudio.Play(0);
            }

            // You can add more actions here, e.g., increment inventory, heal player, etc.
        }
    }

}