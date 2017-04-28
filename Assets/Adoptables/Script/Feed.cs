using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour {
	PenguinCharacter penguinCharacter;
	// Use this for initialization
	void Start () {
		penguinCharacter = GetComponent <PenguinCharacter> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void PenguinEat()
	{
		penguinCharacter.Eat();
	}
}