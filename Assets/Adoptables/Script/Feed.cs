using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Feed : MonoBehaviour {
	PenguinCharacter penguinCharacter;
    Animator penguinAnimator;
    public AudioClip penguinSound;

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

        AudioSource audio = GetComponent<AudioSource>();
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
            health.value += 0.075f;
            affection.value += 0.1f;
        }
    }

    public void EatKrill()
    {
        //krillLocation = new Vector3(0f, cameraDistance, -4f * cameraDistance);
        //food = Instantiate(krill, transform.position, transform.rotation);
        //food.transform.SetParent

        //food.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);

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