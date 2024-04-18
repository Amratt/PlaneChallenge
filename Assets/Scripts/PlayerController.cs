using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float forwarSpeed = 20.0f;
    private float upDirectionalSpeed = 40.0f;
    private float verticalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * forwarSpeed);
        transform.Rotate(Vector3.left, Time.deltaTime * upDirectionalSpeed * verticalInput);
    }
}
