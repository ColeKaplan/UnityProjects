using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 velocitySphere;
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = velocitySphere;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += velocitySphere;
        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= velocitySphere;
    }
}
