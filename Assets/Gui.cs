using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Gui : MonoBehaviour
{
    public Canvas Menu;
    public Canvas ChooseNewAnimal;
    public Canvas ChooseOwnedAnimal;
    public Canvas AnimalName;
    public Canvas Status;
    public Canvas Play;

    void Awake()
    {
        Menu.enabled = true;
        ChooseNewAnimal.enabled = false;
        ChooseOwnedAnimal.enabled = false;
        AnimalName.enabled = false;
        Status.enabled = false;
        Play.enabled = false;
    }

    public void MenuOn()
    {
        Menu.enabled = true;
        ChooseNewAnimal.enabled = false;
        ChooseOwnedAnimal.enabled = false;
        AnimalName.enabled = false;
        Status.enabled = false;
        Play.enabled = false;
    }

    public void ChooseNewAnimalOn()
    {
        Menu.enabled = false;
        ChooseNewAnimal.enabled = true;
        ChooseOwnedAnimal.enabled = false;
        AnimalName.enabled = false;
        Status.enabled = false;
        Play.enabled = false;
    }

    public void ChooseOWnedAnimalOn()
    {
        Menu.enabled = false;
        ChooseNewAnimal.enabled = false;
        ChooseOwnedAnimal.enabled = true;
        AnimalName.enabled = false;
        Status.enabled = false;
        Play.enabled = false;
    }

    public void AnimalNameOn()
    {
        Menu.enabled = false;
        ChooseNewAnimal.enabled = false;
        ChooseOwnedAnimal.enabled = false;
        AnimalName.enabled = true;
        Status.enabled = false;
        Play.enabled = false;
    }

    public void StatusOn()
    {
        Menu.enabled = false;
        ChooseNewAnimal.enabled = false;
        ChooseOwnedAnimal.enabled = false;
        AnimalName.enabled = false;
        Status.enabled = true;
        Play.enabled = false;
    }

    public void PlayOn()
    {
        Menu.enabled = false;
        ChooseNewAnimal.enabled = false;
        ChooseOwnedAnimal.enabled = false;
        AnimalName.enabled = false;
        Status.enabled = false;
        Play.enabled = true;
    }


}