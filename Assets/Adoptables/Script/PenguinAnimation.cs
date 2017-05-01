using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PenguinAnimation : MonoBehaviour {
	PenguinCharacter penguinCharacter;
    public Canvas race;
    public Canvas finish;

    public Text place;
    public Text counter;

    public Text affectionLevel;

    int temp;
    float tempLevel;


    void Start () {
		penguinCharacter = GetComponent <PenguinCharacter> ();
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Race Wall")
        {

            temp = int.Parse(counter.text);
            temp++;

            // Places your penguin
            if (penguinCharacter.name == "You")
            {
                place.text = temp.ToString();
            }

            if (temp == 4)  // race finished
            {
                race.enabled = false;
                finish.enabled = true;
                temp = 0;
                
            }
            counter.text = temp.ToString();

        }
    }

    void Update () {
        if (race.enabled)
        {
            penguinCharacter.Toboggan();
            if (penguinCharacter.name == "You")
            {
                tempLevel = int.Parse(affectionLevel.text);
                tempLevel = tempLevel * 0.1f;
    
                penguinCharacter.transform.localPosition += Vector3.forward * Time.deltaTime * Random.value * Random.value * (1f + tempLevel - 0.2f);
            }
            else
            {
                penguinCharacter.transform.localPosition += Vector3.forward * Time.deltaTime * Random.value;
            }
                

        }

		
		if (Input.GetKeyDown (KeyCode.E)) {
			penguinCharacter.Eat();
		}
		
		if (Input.GetKeyDown (KeyCode.K)) {
			penguinCharacter.Death();
		}
		
		if (Input.GetKeyDown (KeyCode.R)) {
			penguinCharacter.Rebirth();
		}		
		if (Input.GetKeyDown (KeyCode.Y)) {
			penguinCharacter.StandUp();
		}
		if (Input.GetKeyDown (KeyCode.G)) {
			penguinCharacter.Grooming();
		}		
		if (Input.GetKeyDown (KeyCode.F)) {
			penguinCharacter.Flap();
		}

		if (Input.GetKeyDown (KeyCode.T)) {
			penguinCharacter.Toboggan();
		}				

		if (Input.GetKeyDown (KeyCode.I)) {
			penguinCharacter.SwimStart();
		}	

		if (Input.GetKeyDown (KeyCode.M)) {
			penguinCharacter.SwimEnd();
		}	


	}
	
	private void FixedUpdate()
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
        //if (Input.GetKey(KeyCode.LeftShift)) v *= 0.5f;
        v *= 0.5f;
        penguinCharacter.Move (v,h);
	}
}
