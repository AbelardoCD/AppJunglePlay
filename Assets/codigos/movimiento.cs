using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float velocidad;  
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

        
    

    // Update is called once per frame
    void Update()
    {
        float movH = CrossPlatformInputManager.GetAxis("Horizontal")* velocidad;
        float movV = CrossPlatformInputManager.GetAxis("Vertical")* velocidad;
        rb.AddForce(movH,0,movV);

        float mH = CrossPlatformInputManager.GetAxis("Mouse X")* velocidad;
        float mV = CrossPlatformInputManager.GetAxis("Mouse Y")* velocidad;
        rb.AddForce(movH,0,movV);
    }
}
