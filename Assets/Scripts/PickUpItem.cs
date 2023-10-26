using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public GameObject platesPrefab;
    public Transform handPos;
    private bool isCreated;
    // Start is called before the first frame update
    void Start()
    {
        
    }



    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (!isCreated)
            {
                Instantiate(platesPrefab, handPos.position, handPos.rotation);
                Destroy(other.gameObject);
                isCreated = true;
            }
        }
    }


    
    // Update is called once per frame
    void Update()
    {
        
    }
}
