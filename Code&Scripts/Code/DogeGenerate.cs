using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogeGenerate : MonoBehaviour
{
    public GameObject Doge;

    public Transform originTrans0;
    public Transform originTrans1;
    public Transform originTrans2;

    public float turnrate = 1;
    float timer = 1;
    float reloadtimer = 5;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        a = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        Transform[] id = new[] { originTrans0, originTrans1, originTrans2 };

        if (timer<0) 
        {
            reloadtimer = reloadtimer - Time.deltaTime;
            Quaternion q = Quaternion.LookRotation(id[a].position - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, turnrate * Time.deltaTime);
            if (reloadtimer<0) 
            {
                a = Random.Range(0, 2);
                timer = 1;
                reloadtimer = 5;
            }
        }


    }
}
