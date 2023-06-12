using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using static UnityEngine.GraphicsBuffer;

public class LeftHand : MonoBehaviour
{
    public ParticleSystem LeftParticle;
    public GameObject FalseHit;
    public GameObject genneratingpoint;
    public GameObject soundpre;
    public GameObject longhitparticle;
    public GameObject lackofspeed;
    public GameObject perfect;
    public GameObject fail;
    public GameObject UIpoint;

    public LayerMask handMask;
    public float handra = 10;

    public bool LeftHandRight = false;
    public bool a;
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
        if (oldpos != Vector3.zero)
        {
            temp = newpos - oldpos;
        }
        oldpos = newpos;
    }

    private void FixedUpdate()
    {
        makedirection();
        Speed = temp.magnitude / Time.deltaTime;
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
            FalseHit.SetActive(false);
            lackofspeed.SetActive(false);
            perfect.SetActive(true);
            Destroy(collision.gameObject);
        }

            if (a)
        {
            if (collision.gameObject.tag == "BoxLeft")
            {
                Instantiate(LeftParticle, genneratingpoint.transform.position, LeftParticle.transform.rotation);
                Instantiate(soundpre);
                hitnum++;
                Destroy(collision.gameObject);
                FalseHit.SetActive(false);
                lackofspeed.SetActive(false);
                perfect.SetActive(true);
            }
            if (collision.gameObject.tag == "BoxRight")
            {
                FalseHit.SetActive(true);
                lackofspeed.SetActive(false);
                perfect.SetActive(false);
                Destroy(collision.gameObject);
            }
        }
        else
        {
            if (collision.gameObject.tag == "BoxLeft" )
            {
                FalseHit.SetActive(false);
                lackofspeed.SetActive(true);
                perfect.SetActive(false);
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "BoxRight") 
            {
                FalseHit.SetActive(true);
                lackofspeed.SetActive(false);
                perfect.SetActive(false);
                Destroy(collision.gameObject);
            }
        }
    }
}
