using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 WallSpeed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = WallSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
