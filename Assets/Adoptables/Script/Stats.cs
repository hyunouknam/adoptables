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

    //public string animalName;


    void Start()
    {

    }

    void Update()
    {
        hunger.value -= 0.00002f;
    }
}