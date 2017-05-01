using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Stats : MonoBehaviour
{
    public Canvas chooseNewAnimal;
    public Canvas chooseOwnedAnimal;
    public Canvas animalName;
    public Canvas status;
    public Canvas play;
    public Canvas submenu;
    public Canvas food;

    public Slider hunger;
    public Slider affection;
    public Slider health;
    public Text level;

    public Text displayingName;
    public InputField inputName;

    int temp;


    void Start()
    {

    }

    void Update()
    {
        //decrease hunger and health at a constant rate
        hunger.value -= 0.00003f;
        health.value -= 0.00002f;

        //affection increases if hunger and health are high
        if(hunger.value >= 0.6f && health.value >= 0.6f)
        {
            affection.value += 0.00015f;
        }

        //affection level increases when bar is full, and bar starts over from empty
        if(affection.value >= 1f)
        {
            temp = int.Parse(level.text);
            temp++;
            level.text = temp.ToString();
            affection.value = 0f;
        }

    }

    public void UpdateName()
    {
        //shows the name of the animal the user inputted
        displayingName.text = inputName.text;
    }
}