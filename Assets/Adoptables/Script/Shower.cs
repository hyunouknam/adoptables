using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : MonoBehaviour
{
    public GameObject waterfall;

    // Use this for initialization
    void Start()
    {
        waterfall.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TurnOnOffShower()
    {
        if (waterfall.activeSelf)
        {
            waterfall.SetActive(false);
        }
        else
        {
            waterfall.SetActive(true);
        }
    }
}