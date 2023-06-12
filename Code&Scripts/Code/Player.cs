using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool HeadRight = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "HeadPoint")
        {
            HeadRight = true;
        }
        else 
        {
            HeadRight=false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
