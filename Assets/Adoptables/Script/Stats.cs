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
        //displayingName.text = "Some cool name";
    }

    void Update()
    {
        hunger.value -= 0.00003f;
        health.value -= 0.00002f;

        if(hunger.value >= 0.6f && health.value >= 0.6f)
        {
            affection.value += 0.00015f;
        }

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
        displayingName.text = inputName.text;
    }
}