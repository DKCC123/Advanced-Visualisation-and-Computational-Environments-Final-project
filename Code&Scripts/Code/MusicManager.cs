using SonicBloom.Koreo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public float offsetTime; 
    public string eventID;
    public string eventID1;
    public string eventID2;
    public string eventID3;
    public string eventID4;
    public string eventID5;

    public GameObject cubePb;
    public GameObject cubeTb;
    public GameObject DOGE;
    public GameObject Wall;
    public GameObject GATE;
    public GameObject LONG;
    public GameObject LONG1;
    public GameObject LONG2;
    public GameObject LONG3;

    public Transform originTrans0;
    public Transform originTrans1;
    public Transform originTrans2;
    public Transform originTrans3;
    public Transform originTrans4;
    public Transform originTrans5;
    public Transform originTrans6;

    public Transform Trans180_0;
    public Transform Trans180_1;
    public Transform Trans180_2;
    public Transform Trans180_3;
    public Transform Trans180_4;
    public Transform Trans180_5;
    public Transform Trans180_6;
    public Transform Trans180_7;
    public Transform Trans180_8;

    public Transform DogeTrans1;
    public Transform DogeTrans2;
    public Transform DogeTrans3;
    public Transform DogeTrans4;
    public Transform DogeTrans5;

    int b = 0;
    int c = 0;
    int d = 0;

    void Start()
    {
        Koreographer.Instance.RegisterForEvents(eventID, AddDOGEEvent);
        Koreographer.Instance.RegisterForEvents(eventID1, AddWALLEvent);
        Koreographer.Instance.RegisterForEvents(eventID2, AddGATEEvent);
        Koreographer.Instance.RegisterForEvents(eventID3, AddCubeEvent);
        Koreographer.Instance.RegisterForEvents(eventID4, AddLONGEvent);
        Koreographer.Instance.RegisterForEvents(eventID5, AddchangeEvent);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            b = b + 1;
        }
    }

    void AddchangeEvent(KoreographyEvent koreoEvent) 
    {
        b = b + 1;
    }

    void AddLONGEvent(KoreographyEvent koreoEvent)
    {
        if (b % 2 == 0)
        {
            GameObject[] longob = new[] { LONG,LONG1,LONG2,LONG3 };
            int a3 = Random.Range(0,longob.Length);
             
            Transform[] id = new[] { originTrans0, originTrans1, originTrans2, originTrans3, originTrans4, originTrans5, originTrans6 };
            int a = Random.Range(0, id.Length);
            Instantiate(longob[a3], id[a].position, longob[a3].transform.rotation);
        }
        else 
        {
            Transform[] id180 = new[] { Trans180_0, Trans180_1, Trans180_2, Trans180_3, Trans180_4, Trans180_5, Trans180_6, Trans180_7, Trans180_8 };
            int a2 = Random.Range(0, id180.Length);
            Instantiate(LONG, id180[a2].position, LONG.transform.rotation);
        }
    }


    void AddDOGEEvent(KoreographyEvent koreoEvent)
    {
        Transform[] dogeid = new[] { DogeTrans1,DogeTrans2,DogeTrans3,DogeTrans4,DogeTrans5 };
        int a3 = Random.Range(0, dogeid.Length);
        Instantiate(DOGE, dogeid[a3].position, DOGE.transform.rotation);
    }

    void AddWALLEvent(KoreographyEvent koreoEvent)
    {
        Instantiate(Wall, originTrans4.position, Wall.transform.rotation);
    }

    void AddGATEEvent(KoreographyEvent koreoEvent) 
    {
        Instantiate(GATE, originTrans4.position, GATE.transform.rotation);
    }

    void AddCubeEvent(KoreographyEvent koreoEvent)
    {
        if (b % 2 == 0)
        {
            Transform[] id = new[] { originTrans0, originTrans1, originTrans2, originTrans3, originTrans4, originTrans5, originTrans6 };
            int a = Random.Range(0, id.Length);
            if (a < 3) 
            {
                Instantiate(cubePb, id[a].position, cubePb.transform.rotation);
            }
            if (a == 3)
            {
                if (c % 2 == 0)
                {
                    Instantiate(cubePb, id[a].position, cubePb.transform.rotation);
                    c = c + 1;
                }
                else 
                {
                    Instantiate(cubeTb, id[a].position, cubeTb.transform.rotation);
                    c = c + 1;
                }
            }
            if (a > 3)
            {
                Instantiate(cubeTb, id[a].position, cubeTb.transform.rotation);
            }

        }
        else 
        {
            Transform[] id180 = new[] { Trans180_0, Trans180_1, Trans180_2, Trans180_3, Trans180_4, Trans180_5, Trans180_6, Trans180_7,Trans180_8 };
            int a2 = Random.Range(0, id180.Length);
            if (a2 < 4)
            {
                Instantiate(cubePb, id180[a2].position, cubePb.transform.rotation);
            }
            if (a2 == 4)
            {
                if (d % 2 == 0)
                {
                    Instantiate(cubePb, id180[a2].position, cubePb.transform.rotation);
                    d = d + 1;
                }
                else
                {
                    Instantiate(cubeTb, id180[a2].position, cubeTb.transform.rotation);
                    d = d + 1;
                }
            }
            if (a2 > 4)
            {
                Instantiate(cubeTb, id180[a2].position, cubeTb.transform.rotation);
            }
        }
    }
}
