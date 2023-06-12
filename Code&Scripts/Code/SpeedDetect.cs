using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDetect : MonoBehaviour
{
    public Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 speed =  body.GetPointVelocity(transform.position);
        Debug.Log(speed);
    }
}
