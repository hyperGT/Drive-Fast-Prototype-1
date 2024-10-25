using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 30.0f; // Speed of the vehicle
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        // Rotate the vehicle left or right based on the A and D keys
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(0, -1, 0);
        }else if(Input.GetKey(KeyCode.D)){
            transform.Rotate(0, 1, 0);    
        }
    }
}