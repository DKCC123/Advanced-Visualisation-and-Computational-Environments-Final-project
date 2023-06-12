using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationarond : MonoBehaviour
{
    GameObject Player;
    public float speed = 6;
    public float timer = 2;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("target");
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer < 0) 
        {
            speed = Random.Range(-15, 15);
            timer = Random.Range(2, 10); ;
        }
        transform.RotateAround(Player.transform.position, Vector3.forward, speed * Time.deltaTime);
    }
}
