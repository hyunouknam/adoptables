using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shower : MonoBehaviour
{
    Animator penguinAnimator;
    PenguinCharacter penguinCharacter;

    public GameObject waterfall;
    public Slider health;


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
            health.value += 0.0005f;
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