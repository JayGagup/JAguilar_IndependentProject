using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCorntoller : MonoBehaviour
{
    public float speed;
    private float HorizontalInput;
    private float VerticalInput;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalInput);
        VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);

        
    }
     
}
