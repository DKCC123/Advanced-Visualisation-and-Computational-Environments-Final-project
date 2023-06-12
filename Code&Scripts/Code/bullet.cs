using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 10;
    public float timer = 3;
        // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.forward * -Speed;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer < 0) 
        {
            Destroy(gameObject);
        }
    }
}
