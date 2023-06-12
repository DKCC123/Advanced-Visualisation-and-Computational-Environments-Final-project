using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class changePannel : MonoBehaviour
{
    public GameObject Pannel1;
    public GameObject Pannel2;
    public Button Option;
    public Button OptionBack;

    // Start is called before the first frame update
    void Start()
    {
        Pannel1.SetActive(true);
        Pannel2.SetActive(false);
        Option.GetComponent<Button>().onClick.AddListener(IntoOption);
        OptionBack.GetComponent<Button>().onClick.AddListener(BackOption);
    }

    private void IntoOption()
    {
        Pannel1.SetActive(false);
        Pannel2.SetActive(true);
    }

    private void BackOption()
    {
        Pannel1.SetActive(true);
        Pannel2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
