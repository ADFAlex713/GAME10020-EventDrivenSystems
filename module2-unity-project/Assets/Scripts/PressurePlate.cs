using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    // Event to call when the plate is pressed
    public UnityEvent OnPressed;
    // Event to call when the plate is released
    public UnityEvent OnReleased;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object has the desired tag (e.g., "Player" or "Pushable")
        if (other.CompareTag("Player") || other.CompareTag("Pushable"))
        {
            Debug.Log("Pressure plate activated by: " + other.name);
            OnPressed.Invoke(); // Trigger the Pressed event
            // Add visual animation logic here (e.g., move the plate down)
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the exiting object has the desired tag
        if (other.CompareTag("Player") || other.CompareTag("Pushable"))
        {
            Debug.Log("Pressure plate deactivated by: " + other.name);
            OnReleased.Invoke(); // Trigger the Released event
            // Add visual animation logic here (e.g., move the plate back up)
        }
    }
}
