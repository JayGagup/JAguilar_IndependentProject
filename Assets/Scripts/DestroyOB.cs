using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOB : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("We can destroy");
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            Destroy(gameObject);
        }
    }

}
