using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PenguinAnimation : MonoBehaviour {
	PenguinCharacter penguinCharacter;
    public Canvas race;
    public Canvas finish;

    public Text place;
    public Text counter;

    public Text gold;
    public Text silver;
    public Text bronze;

    public Image goldImage;
    public Image silverImage;
    public Image bronzeImage;

    public Image first;
    public Image second;
    public Image third;
    public Image fourth;

    public Text affectionLevel;

    int tempMedal;
    int temp;
    float tempLevel;


    void Start () {
		penguinCharacter = GetComponent <PenguinCharacter> ();
        
    }

    void OnCollisionEnter(Collision col)
    {
        //if all penguins reach the end, ends the race and shows you a score screen
        if(col.gameObject.name == "Race Wall")
        {

            temp = int.Parse(counter.text);
            temp++;

            // Ranks your penguin by what place it came in the race
            if (penguinCharacter.name == "You")
            {
                place.text = temp.ToString();
                if(temp == 1)
                {
                    tempMedal = int.Parse(gold.text);
                    tempMedal++;
                    gold.text = tempMedal.ToString();
                    goldImage.enabled = true;
                    silverImage.enabled = false;
                    bronzeImage.enabled = false;

                    first.enabled = true;
                    second.enabled = false;
                    third.enabled = false;
                    fourth.enabled = false;

                }
                else if(temp == 2)
                {
                    tempMedal = int.Parse(silver.text);
                    tempMedal++;
                    silver.text = tempMedal.ToString();
                    goldImage.enabled = false;
                    silverImage.enabled = true;
                    bronzeImage.enabled = false;

                    first.enabled = false;
                    second.enabled = true;
                    third.enabled = false;
                    fourth.enabled = false;
                }
                else if(temp == 3)
                {
                    tempMedal = int.Parse(bronze.text);
                    tempMedal++;
                    bronze.text = tempMedal.ToString();
                    goldImage.enabled = false;
                    silverImage.enabled = false;
                    bronzeImage.enabled = true;

                    first.enabled = false;
                    second.enabled = false;
                    third.enabled = true;
                    fourth.enabled = false;
                }
                else
                {
                    goldImage.enabled = false;
                    silverImage.enabled = false;
                    bronzeImage.enabled = false;

                    first.enabled = false;
                    second.enabled = false;
                    third.enabled = false;
                    fourth.enabled = true;
                }

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

    public void ResetRace()
    {
        //resets all the penguins to original position for new race next time
        if (penguinCharacter.name == "You")
        {
            penguinCharacter.transform.localPosition = new Vector3(penguinCharacter.transform.localPosition.x, penguinCharacter.transform.localPosition.y, penguinCharacter.transform.localPosition.z - 33);
        }

        if (penguinCharacter.name == "Penguin 2")
        {
            penguinCharacter.transform.localPosition = new Vector3(penguinCharacter.transform.localPosition.x, penguinCharacter.transform.localPosition.y, penguinCharacter.transform.localPosition.z - 33);
        }

        if (penguinCharacter.name == "Penguin 3")
        {
            penguinCharacter.transform.localPosition = new Vector3(penguinCharacter.transform.localPosition.x, penguinCharacter.transform.localPosition.y, penguinCharacter.transform.localPosition.z - 33);
        }

        if (penguinCharacter.name == "Penguin 4")
        {
            penguinCharacter.transform.localPosition = new Vector3(penguinCharacter.transform.localPosition.x, penguinCharacter.transform.localPosition.y, penguinCharacter.transform.localPosition.z - 33);
        }

    }

    void Update () {
        //penguins toboggan in the race.
        if (race.enabled)
        {
            penguinCharacter.Toboggan();

            //player's penguin's speed is affected by its affection level
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
