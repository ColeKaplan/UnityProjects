using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 SphereSpeed;
    [SerializeField]
    KeyCode SpeedPositive;
    [SerializeField]
    KeyCode SpeedNegative;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = SphereSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(SpeedPositive))
            GetComponent<Rigidbody>().velocity += SphereSpeed;
        if (Input.GetKey(SpeedNegative))
            GetComponent<Rigidbody>().velocity -= SphereSpeed;    }
}
