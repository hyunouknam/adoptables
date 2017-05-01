using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public Slider hunger;
    public Slider affection;
    public Slider health;
    public Text level;

    public Text displayingName;
    //public InputField inputName;

    public Text gold;
    public Text silver;
    public Text bronze;


    void Start()
    {

    }

    void Update()
    {

    }

    public void Save()
    {
        //Saves all the information

        PlayerPrefs.SetString("displayingName", displayingName.text);

        PlayerPrefs.SetFloat("hunger", hunger.value);
        PlayerPrefs.SetFloat("affection", affection.value);
        PlayerPrefs.SetFloat("health", health.value);
        PlayerPrefs.SetString("level", level.text);
        PlayerPrefs.SetString("gold", gold.text);
        PlayerPrefs.SetString("silver", silver.text);
        PlayerPrefs.SetString("bronze", bronze.text);
    }

    public void LoadName()
    {
        displayingName.text = PlayerPrefs.GetString("displayingName");
    }

    public void Load()
    {
        //Loads all information

        hunger.value = PlayerPrefs.GetFloat("hunger");
        affection.value = PlayerPrefs.GetFloat("affection");
        health.value = PlayerPrefs.GetFloat("health");
        level.text = PlayerPrefs.GetString("level");
        gold.text = PlayerPrefs.GetString("gold");
        silver.text = PlayerPrefs.GetString("silver");
        bronze.text = PlayerPrefs.GetString("bronze");
    }
}