using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public Slider hunger;
    public Slider affection;
    public Slider health;

    public Text displayingName;
    //public InputField inputName;


    void Start()
    {

    }

    void Update ()
    {

    }
    
    public void Save()
    {
        PlayerPrefs.SetString("displayingName", displayingName.text);

        PlayerPrefs.SetFloat("hunger", hunger.value);
        PlayerPrefs.SetFloat("affection", affection.value);
        PlayerPrefs.SetFloat("health", health.value);
    }

    public void LoadName()
    {
        displayingName.text = PlayerPrefs.GetString("displayingName");
    }

    public void Load()
    {

        hunger.value = PlayerPrefs.GetFloat("hunger");
        affection.value = PlayerPrefs.GetFloat("affection");
        health.value = PlayerPrefs.GetFloat("health");
    }
}