using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIfade : MonoBehaviour
{
    public GameObject self;
    public float fadeTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (self.activeInHierarchy)
        {
            fadeTime = fadeTime - Time.deltaTime;
            if (fadeTime < 0)
            {
                self.SetActive(false);
                fadeTime = 2;
            }
        }
        else
        {
            fadeTime = 2;
        }
    }
}
