using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class Mian : MonoBehaviour
{
    public List<Plant> PlantList = new List<Plant>();
    public int Health;
    public int NoPlant;
    public GameObject Greenhouse;
    public GameObject Plant;
    

    void DeactivateLowestHealthObject()
    {

        Health = GetComponent<Plant>().Health;

        float lowestHealth = float.MaxValue;
        int index = -1;

        // Find the object with the lowest health
        for (int i = 0; i < Health; i++)
        {
            if (Health < lowestHealth)
            {
                lowestHealth = Health;
                index = i;
            }
        }

        // Deactivate the object with the lowest health
        if (index != -1)
        {
            //PlantList[index].SetActive(false);
            Debug.Log("Deactivated object with the lowest health. Index: " + index);
        }
    }
    float CalculateTotalHealth()
    {
        float totalHealth = 0;

        // Sum up the health values
        for (int i = 0; i < Health; i++)
        {
            totalHealth += Health;
        }
        Debug.Log(totalHealth.ToString());
        return totalHealth;
        
    }


    public enum State {Start, Message, End }
    public State CurrentState;


    public GameObject GreenHouse;



    public TextMeshProUGUI IntroText;
    private string CurrentText = string.Empty;
    private string FullText;



    // Start is called before the first frame update
    void Start()
    {
        CurrentState = State.Start;

        NoPlant = GetComponent<Greenhouse>().NoPlants;
    }

    // Update is called once per frame
    void Update()
    {

        CalculateTotalHealth();

       if (NoPlant > 10)
        {
            DeactivateLowestHealthObject();
        }

        if (CurrentState == State.Start)
        {
            FullText = "Welcome to Nexys! youve traveled 568 years to finally reach this wonderful new world, and now its time to embark on your exciting new carrer. " +
                "Drum roll please... " +
                "Botany! " +
                " this is your work station and lucky you we are starting you off with your first vagaly plant like, eukaryotic life form";
            StartCoroutine(TypeWriter());
        }
       if (CurrentState == State.Message)
        {
            StopAllCoroutines();
            CurrentState = State.End;
        }
       else if(CurrentState == State.End)
        {
            //Debug.Log("working");
        }
        
    }

    IEnumerator TypeWriter()
    {
        for (int i = 0; i < FullText.Length + 1; i++)
        {
            IntroText.text = CurrentText;
            CurrentText = FullText.Substring(0, i);
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(3);
        IntroText.text = string.Empty;
        CurrentState = State.Message;
   }

       //GreenHouse.GetComponent<Greenhouse>().GetNewPlant();
    
}
