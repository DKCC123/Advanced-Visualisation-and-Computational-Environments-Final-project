using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Valve.VR;


public class RightHand : MonoBehaviour
{

    public ParticleSystem RightParticle;
    public GameObject FalseHit;
    public GameObject genneratingpoint;
    public GameObject soundpre;
    public GameObject perfect;
    public GameObject fail;
    public GameObject longhitparticle;
    public GameObject lackofspeed;
    public GameObject UIpoint;
    public GameObject player;
    public GameObject transpoint;

    public LayerMask handMask;
    public float handra = 10;

    public bool RightHandRight = false;
    public bool a;
    public bool longhit = false;
    public int hitnum = 0;
    public float Speed;

    Vector3 oldpos;
    Vector3 newpos;
    Vector3 temp;
    // Start is called before the first frame update
    void Start()
    {
        FalseHit.SetActive(false);
        lackofspeed.SetActive(false);
        perfect.SetActive(false);
    }

    void makedirection() 
    {
        newpos = transform.position;
        if (oldpos!=Vector3.zero)
        {
            temp = newpos-oldpos;
        }
        oldpos = newpos;
    }

    private void FixedUpdate()
    {
        makedirection();
        Speed = temp.magnitude/Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Speed);
        if (Speed >= 0.001f)
        {
            a = true;
        }
        else 
        {
            a = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        var inputDevices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevices(inputDevices);

        if (collision.gameObject.tag =="gate") 
        {
            player.transform.position = transpoint.transform.position;
            player.transform.rotation = player.transform.rotation;
        }

        if (collision.gameObject.tag == "long")
        {
            longhitparticle.SetActive(true);
            hitnum++;
        }
        else 
        {
            longhitparticle.SetActive(false);
        }

        if (collision.gameObject.tag == "RightPoint")
        {
            hitnum++;
            RightHandRight = true;
            FalseHit.SetActive(false);
            lackofspeed.SetActive(false);
            perfect.SetActive(true);
            Destroy(collision.gameObject);
        }
        else 
        {
            RightHandRight = false;
        }
        if (a)
        {
            if (collision.gameObject.tag == "BoxRight")
            {
                Instantiate(RightParticle, genneratingpoint.transform.position, RightParticle.transform.rotation);
                hitnum++;
                Destroy(collision.gameObject);
                Instantiate(soundpre);
                FalseHit.SetActive(false);
                lackofspeed.SetActive(false);
                perfect.SetActive(true);
            }
            if (collision.gameObject.tag == "BoxLeft")
            {
                FalseHit.SetActive(true);
                lackofspeed.SetActive(false);
                perfect.SetActive(false);
                Destroy(collision.gameObject);
            }
        }
        else 
        {
            if (collision.gameObject.tag == "BoxRight") 
            {
                FalseHit.SetActive(false);
                lackofspeed.SetActive(true);
                perfect.SetActive(false);
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "BoxLeft")
            {
                FalseHit.SetActive(true);
                lackofspeed.SetActive(false);
                perfect.SetActive(false);
                Destroy(collision.gameObject);
            }
        }
    }
}
