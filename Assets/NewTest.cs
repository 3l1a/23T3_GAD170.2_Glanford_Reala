using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class NewTest : MonoBehaviour
{
    public enum State { Start, AskAddPlant, AddPlant, KeepRefuse, NamePlant, End };
    public State CurrentState;

    public GameObject Plant;
    public Plant PlantRef;
    public List<Plant> PlantList = new List<Plant>();

    public int Health;
    public float totalValue = 0;

    public int Turnes = 0;
   
    public float Spacing = 100;

    public TextMeshProUGUI PlantNameText;
    public TextMeshProUGUI IntroText;
    public TextMeshProUGUI StateText;

    public TMP_InputField InputField;
    public string FullText;
    public string CurrentText;
    public string PlantNameString;

    public bool Keep;
    public bool Refuse;

    // Start is called before the first frame update
    void Start()
    {
        CurrentState = State.Start;
        PlantNameText.text = string.Empty;

    }
    public void GetNewPlantButton()
    {

        CurrentState = State.AddPlant;

        TurnCheck();


    }
    private void Update()
    {

        StateText.text = CurrentState.ToString();

        if (CurrentState == State.Start)
        {
            FullText = "Welcome ";// +
                                  //"to Nexys!youve traveled 568 years to finally reach this wonderful new world, and now its time to embark on your exciting new carrer. " +
                                  //"Drum roll please... " +
                                  //"Botany! " +
                                  //" this is your work station and lucky you we are starting you off with your first vagaly plant like, eukaryotic life form";
            StartCoroutine(TypeWriter());

        }
        else if (CurrentState == State.AddPlant)
        {
            CheckTurnes();

            Debug.Log(" button");

            Turnes += 1;

            Vector3 SpawnPosition = new Vector3(Turnes * Spacing - 400, 0, 800);

            GameObject newPlant = Instantiate(Plant, SpawnPosition, Quaternion.identity);

            newPlant.name = "newPlant";// + Turnes;

            CurrentState = State.KeepRefuse;
        }

        if (CurrentState == State.KeepRefuse)
        {

            GameObject newPlant = GameObject.Find("newPlant");

            if (Keep == true)
            {
                PlantNameText.text = "Name your new plant";

                PlantList.Add(newPlant.GetComponent<Plant>());

                newPlant.name = PlantNameString;

                RemoveLeastHealthyPlant();

                Keep = false;
                Refuse = false;

                CurrentState = State.NamePlant;

            }
            else if (Refuse == true)
            {

                Destroy(newPlant);

                PlantList.Remove(newPlant.GetComponent<Plant>());

                Keep = false;
                Refuse = false;

                CurrentState = State.AskAddPlant;
            }
            else
            {
                return;
            }
           
        }

        if (CurrentState == State.End)
        {
            CalculateTotalHealth();

            StateText.text = "Total Value = " + totalValue;

            Debug.Log("Total Value = " + totalValue);
        }

        if (CurrentState == State.NamePlant)
        {
            RenamePlant();
        }

    }


    static int SortByHealth(Plant p1, Plant p2)
    {
        return p1.Health.CompareTo(p2.Health);
    }

    public float CalculateTotalHealth() // calculates total, but can obly be usesd once?
    {
        totalValue = 0;
        foreach (Plant plant in PlantList)
        {
            int PlantValue = plant.Value;

            totalValue += PlantValue;

        }

        return totalValue;


    }

    public void DeactivateLowestHealthObject() // remove lowest health plant from list and then distroys game object
    {
        Debug.Log("DeactivateLowestHealthObjectt has been called");

        Plant PlantToBeRemoved = PlantList[0];

        RemovePlant(PlantToBeRemoved);

        Destroy(PlantToBeRemoved.gameObject);


    }

    public void RemovePlant(Plant PlantToRemove)
    {
        Debug.Log("Remove Plant has been called" + PlantToRemove.name);

        PlantList.Remove(PlantToRemove);

    }
    private void RemoveLeastHealthyPlant()
    {
        Debug.Log("RemoveLastHealthyPlant has been called");

        if (PlantList.Count >= 10)
        {
            Debug.Log("PlantList is Greater/EqualTo 10");

            DeactivateLowestHealthObject();


        }

    }
    private void CheckTurnes()
    {

        if (Turnes >= 20)
        {
            //end game
        }

    }

    public void SortByHealth()
    {
        if (PlantList.Count > 0)
        {
            Debug.Log("Sorting");

            PlantList.Sort(SortByHealth);
        }
    }

    private void RenamePlant()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            PlantNameString = InputField.text;

            Debug.Log("nameing");
           
            InputField.text = string.Empty;

            PlantNameText.text = string.Empty;

            CurrentState = State.AskAddPlant;
        }
    }
    public void KeepButton()
    {
        Keep = true;
        Refuse = false;

    }

    public void RefuseButton()
    {
        Keep = false;
        Refuse = true;

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

        CurrentState = State.AskAddPlant;
    }

    public void TurnCheck()
    {
        if(Turnes >= 20)
        {
            Debug.Log("GameOver");

            CurrentState = State.End;
        }
    }

}
