using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundPlay : MonoBehaviour
{
    float a = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a = a - Time.deltaTime;
        if (a<0) 
        {
            Destroy(gameObject);
        }
    }
}
