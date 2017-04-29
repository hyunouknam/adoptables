using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : MonoBehaviour
{
    public GameObject waterfall;
    Animator penguinAnimator;
    PenguinCharacter penguinCharacter;


    // Use this for initialization
    void Start()
    {
        waterfall.SetActive(false);
        penguinAnimator = GetComponent<Animator>();
        penguinCharacter = GetComponent<PenguinCharacter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waterfall.activeSelf)
        {
            penguinCharacter.Flap();
        }
    }

    public void TurnOnOffShower()
    {
        if (waterfall.activeSelf)
        {
            waterfall.SetActive(false);
        }
        else
        {

            if (this.penguinAnimator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                waterfall.SetActive(true);
            }
            
        }
    }
}