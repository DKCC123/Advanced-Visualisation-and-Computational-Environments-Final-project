using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongMove : MonoBehaviour
{
    GameObject Player;
    public float speed = 0.1f;
    public GameObject SoundPlayer;
    public LayerMask targetMask;
    public float targetra = 10;
    Vector3 speedvector;
    public float speedfactor = 1;
    float timer = 10
        ;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("target");
        speedvector = (Player.transform.position-transform.position).normalized;
    }


    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer<0) 
        {
            Destroy(gameObject);
        }

        transform.Translate(speedvector*speedfactor, Space.World);

    }
}
