using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Transform attachmentPoint; // The point where the item will attach to the player's hand
    private bool isCarried = false;   // Flag to track if the item is currently being carried

    private void OnTriggerEnter(Collider other)
    {
        if (!isCarried && other.CompareTag("Player"))
        {
            // Check if the player presses a key (e.g., "E") to pick up the item
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Attach the item to the player's hand
                AttachToHand(other.transform);
                isCarried = true;
            }
        }
    }

    private void AttachToHand(Transform playerTransform)
    {
        // Attach the item to the player's hand (or attachment point)
        transform.SetParent(attachmentPoint);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        GetComponent<Rigidbody>().isKinematic = true; // Disable physics while carrying
    }
}

