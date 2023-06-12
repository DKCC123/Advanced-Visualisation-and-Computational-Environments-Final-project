using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 0.1f;
    GameObject Player;
    public GameObject SoundPlayer;
    public GameObject rightparticle;
    public GameObject leftparticle;
    public GameObject wrong;
    public GameObject nospeed;
    bool speedright;
    bool speedleft;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("target");
        speedright = GameObject.Find("righthand").gameObject.GetComponent<RightHand>().a;
        speedleft = GameObject.Find("lefthand").gameObject.GetComponent<LeftHand>().a;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "target") 
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 speedvector = new Vector3(0, 0, -speed);
        //transform.Translate(speedvector, Space.World);
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, speed);
    }
}
