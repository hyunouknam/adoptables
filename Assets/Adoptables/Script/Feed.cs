using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Feed : MonoBehaviour {
	PenguinCharacter penguinCharacter;
    Animator penguinAnimator;
    public AudioClip penguinSound;
    AudioSource audio;

    public Slider hunger;
    public Slider health;
    public Slider affection;

    public GameObject krill;
    public GameObject octopus;
    public GameObject fish;

    public GameObject food;



    // Use this for initialization
    void Start () {
		penguinCharacter = GetComponent <PenguinCharacter> ();
        penguinAnimator = GetComponent<Animator>();

        audio = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update () {

        //Spawns food objects
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
        //Eating increases some stats and penguin makes a noise
        if (this.penguinAnimator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            penguinCharacter.Eat();
            hunger.value += 0.3f;
            health.value += 0.075f;
            affection.value += 0.1f;

            audio.clip = penguinSound;
            audio.Play();
        }
    }

    // These are just to show the food objects

    public void EatKrill()
    {
    
        if (this.penguinAnimator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            krill.SetActive(true);
        }
    }

    public void EatOctopus()
    {
        if (this.penguinAnimator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            octopus.SetActive(true);
        }
    }

    public void EatFish()
    {
        if (this.penguinAnimator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            fish.SetActive(true);
        }
    }
}