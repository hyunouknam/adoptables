﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Feed : MonoBehaviour {
	PenguinCharacter penguinCharacter;
    Animator penguinAnimator;
    //Stats stats;

    public Slider hunger;

    public GameObject krill;
    public GameObject octopus;
    public GameObject fish;

    public GameObject food;



    // Use this for initialization
    void Start () {
		penguinCharacter = GetComponent <PenguinCharacter> ();
        penguinAnimator = GetComponent<Animator>();
        //stats = GetComponent<Stats>();
    }

	// Update is called once per frame
	void Update () {
        if (this.penguinAnimator.GetCurrentAnimatorStateInfo(0).IsName("Eat"))
        {
            if (krill.activeSelf)
            {
                krill.SetActive(false);
            }

            if (octopus.activeSelf)
            {
                octopus.SetActive(false);
            }

            if (fish.activeSelf)
            {
                fish.SetActive(false);
            }
        }
    }

	public void PenguinEat()
	{
        if (this.penguinAnimator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            penguinCharacter.Eat();
            hunger.value += 0.3f;
        }
    }

    public void EatKrill()
    {
        //krillLocation = new Vector3(0f, cameraDistance, -4f * cameraDistance);
        //food = Instantiate(krill, transform.position, transform.rotation);
        //food.transform.SetParent

        //food.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);

        krill.SetActive(true);
    }

    public void EatOctopus()
    {
        octopus.SetActive(true);
    }

    public void EatFish()
    {
        fish.SetActive(true);
    }
}