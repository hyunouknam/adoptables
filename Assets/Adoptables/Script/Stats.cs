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

    public Text name;

    //public string animalName;


    void Start()
    {
        name.text = "Some cool name";
    }

    void Update()
    {
        hunger.value -= 0.00002f;
        affection.value -= 0.00002f;
        health.value -= 0.00001f;
    }
}