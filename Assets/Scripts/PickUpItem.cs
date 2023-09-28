using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{

    public GameObject itemToPickup;

    // Reference to the hand (or another position) where the item will be carried
    public Transform carryPosition;

    private bool isCarrying = false;

    void Update()
    {
        // Check if the player presses a key (e.g., "E") to pick up or drop the item
       
    }

    private void OnTriggerEnter(Collider other)
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isCarrying)
            {
                // Pick up the item
                PickUpIT();
            }
            else
            {
                // Drop the item
                DropItem();
            }
        }
    }
    void PickUpIT()
    {
        if (itemToPickup != null)
        {
            // Set the item's parent to the carry position to attach it to the player's hand (or another position)
            itemToPickup.transform.SetParent(carryPosition);
            itemToPickup.transform.localPosition = Vector3.zero; // Adjust the local position as needed
            itemToPickup.transform.localRotation = Quaternion.identity; // Adjust the local rotation as needed
            itemToPickup.GetComponent<Rigidbody>().isKinematic = true; // Disable physics while carrying

            isCarrying = true;
        }
    }

    void DropItem()
    {
        if (itemToPickup != null)
        {
            // Reset the item's parent to detach it from the player's hand (or another position)
            itemToPickup.transform.SetParent(null);
            itemToPickup.GetComponent<Rigidbody>().isKinematic = false; // Enable physics when dropping

            isCarrying = false;
        }
    }
}