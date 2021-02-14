using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rate of forward/backward movement.
    private float speed = 15.0f;

    //Turning Rate/Weight of vehicle.
    private float turnSpeed = 15.0f;

    //Will be assigned in Update by the Player inputting.
    private float horizontalInput;
    private float verticalInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);

        //h.Input and v.Input assigned here
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); Replaced by with transform.Rotate

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

}
