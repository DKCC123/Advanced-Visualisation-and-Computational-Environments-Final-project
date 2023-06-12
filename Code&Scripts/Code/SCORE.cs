using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SCORE : MonoBehaviour
{
    public TMP_Text hit;
    public TMP_Text HP;
    public TMP_Text RSpeed;
    public TMP_Text LSpeed;

    bool right;
    bool left;
    bool head;


    float spright;
    float spleft;
    int a;
    int c;
    int b = 100;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag=="Hide")
        {
            b= b - 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        a = GameObject.Find("righthand").gameObject.GetComponent<RightHand>().hitnum;
        c = GameObject.Find("lefthand").gameObject.GetComponent<LeftHand>().hitnum;

        RSpeed.SetText(GameObject.Find("righthand").gameObject.GetComponent<RightHand>().Speed.ToString());
        LSpeed.SetText(GameObject.Find("lefthand").gameObject.GetComponent<LeftHand>().Speed.ToString());
        hit.SetText((a+c).ToString());
        HP.SetText(b.ToString());
    }
}
