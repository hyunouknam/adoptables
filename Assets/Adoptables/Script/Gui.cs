using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Gui : MonoBehaviour
{
    public Canvas menu;
    public Canvas chooseNewAnimal;
    public Canvas chooseOwnedAnimal;
    public Canvas animalName;
    public Canvas status;
    public Canvas play;
    public Canvas loading;
    public Canvas submenu;
	public Canvas food;
    public Canvas race;
    public Canvas finish;

    void Awake()
    {
        menu.enabled = false;
        chooseNewAnimal.enabled = false;
        chooseOwnedAnimal.enabled = false;
        animalName.enabled = false;
        status.enabled = false;
        play.enabled = false;
        loading.enabled = true;
        submenu.enabled = false;
		food.enabled = false;
        race.enabled = false;
        finish.enabled = false;

    }

    public void MenuOn()
    {
        menu.enabled = true;
        chooseNewAnimal.enabled = false;
        chooseOwnedAnimal.enabled = false;
        animalName.enabled = false;
        status.enabled = false;
        play.enabled = false;
        loading.enabled = false;
        submenu.enabled = false;
		food.enabled = false;
        race.enabled = false;
        finish.enabled = false;
    }

    public void ChooseNewAnimalOn()
    {
        menu.enabled = false;
        chooseNewAnimal.enabled = true;
        chooseOwnedAnimal.enabled = false;
        animalName.enabled = false;
        status.enabled = false;
        play.enabled = false;
        loading.enabled = false;
        submenu.enabled = false;
		food.enabled = false;
        race.enabled = false;
        finish.enabled = false;
    }

    public void ChooseOwnedAnimalOn()
    {
        menu.enabled = false;
        chooseNewAnimal.enabled = false;
        chooseOwnedAnimal.enabled = true;
        animalName.enabled = false;
        status.enabled = false;
        play.enabled = false;
        loading.enabled = false;
        submenu.enabled = false;
		food.enabled = false;
        race.enabled = false;
        finish.enabled = false;
    }

    public void AnimalNameOn()
    {
        menu.enabled = false;
        chooseNewAnimal.enabled = false;
        chooseOwnedAnimal.enabled = false;
        animalName.enabled = true;
        status.enabled = false;
        play.enabled = false;
        loading.enabled = false;
        submenu.enabled = false;
		food.enabled = false;
        race.enabled = false;
        finish.enabled = false;
    }

    public void StatusOn()
    {
        menu.enabled = false;
        chooseNewAnimal.enabled = false;
        chooseOwnedAnimal.enabled = false;
        animalName.enabled = false;
        status.enabled = true;
        play.enabled = false;
        loading.enabled = false;
        submenu.enabled = false;
		food.enabled = false;
        race.enabled = false;
        finish.enabled = false;
    }

    public void PlayOn()
    {
        menu.enabled = false;
        chooseNewAnimal.enabled = false;
        chooseOwnedAnimal.enabled = false;
        animalName.enabled = false;
        status.enabled = false;
        play.enabled = true;
        loading.enabled = false;
        submenu.enabled = false;
		food.enabled = false;
        race.enabled = false;
        finish.enabled = false;
    }

    public void SubMenuOn()
    {
        menu.enabled = false;
        chooseNewAnimal.enabled = false;
        chooseOwnedAnimal.enabled = false;
        animalName.enabled = false;
        status.enabled = false;
        play.enabled = false;
        loading.enabled = false;
        submenu.enabled = true;
		food.enabled = false;
        race.enabled = false;
        finish.enabled = false;
    }

	public void FoodOn()
	{
		menu.enabled = false;
		chooseNewAnimal.enabled = false;
		chooseOwnedAnimal.enabled = false;
		animalName.enabled = false;
		status.enabled = false;
		play.enabled = false;
		loading.enabled = false;
		submenu.enabled = false;
		food.enabled = true;
        race.enabled = false;
        finish.enabled = false;
    }

    public void RaceOn()
    {
        menu.enabled = false;
        chooseNewAnimal.enabled = false;
        chooseOwnedAnimal.enabled = false;
        animalName.enabled = false;
        status.enabled = false;
        play.enabled = false;
        loading.enabled = false;
        submenu.enabled = false;
        food.enabled = false;
        race.enabled = true;
        finish.enabled = false;
    }

    public void FinishOn()
    {
        menu.enabled = false;
        chooseNewAnimal.enabled = false;
        chooseOwnedAnimal.enabled = false;
        animalName.enabled = false;
        status.enabled = false;
        play.enabled = false;
        loading.enabled = false;
        submenu.enabled = false;
        food.enabled = false;
        race.enabled = false;
        finish.enabled = true;
    }
}