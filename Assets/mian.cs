using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

//public class Mian : MonoBehaviour
//{
//    public List<Plant> PlantList = new List<Plant>();
//    public int Health;
//    public float totalHealth = 0;
//    //public float PlantHealth
//    public int I;
//    public Greenhouse GreenHouse;
//    public GameObject Plant;

//    public GameObject Cube1;

//    public TextMeshProUGUI IntroText;
//    private string CurrentText = string.Empty;
//    private string FullText;

//    public enum State { Start, Message, getInput, End }
//    public State CurrentState;

    

//    // Start is called before the first frame update
//    void Start()
//    {
//        CurrentState = State.Start;

        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        PlantList.Sort(SortByHealth);
//        I = GreenHouse.NoPlants;

//        if (I > 10)
//        {
//            //DeactivateLowestHealthObject();
//        }

//        if (CurrentState == State.Start)
//        {
//            FullText = "Welcome to Nexys! youve traveled 568 years to finally reach this wonderful new world, and now its time to embark on your exciting new carrer. " +
//                "Drum roll please... " +
//                "Botany! " +
//                " this is your work station and lucky you we are starting you off with your first vagaly plant like, eukaryotic life form";
//            StartCoroutine(TypeWriter());
//        }
//        else if (CurrentState == State.Message)
//        {
//            StopAllCoroutines();
//            CurrentState = State.End;
//        }
//        else if (CurrentState == State.End)
//        {
//            //Debug.Log("working");
//        }


//    }

//    IEnumerator TypeWriter()
//    {
//        for (int i = 0; i < FullText.Length + 1; i++)
//        {
//            IntroText.text = CurrentText;
//            CurrentText = FullText.Substring(0, i);
//            yield return new WaitForSeconds(0.1f);
//        }
//        yield return new WaitForSeconds(3);
//        IntroText.text = string.Empty;
//        CurrentState = State.Message;
//    } // glitchy



//    public void DeactivateLowestHealthObject() // not working
//    {
//        Destroy(PlantList[0]);

        

//        if (Cube1.GetComponent<MonoBehaviour>() == null)
//        {
//            Destroy(Plant);
//            //PlantList.Find
//            // Deactivate the object
//            Cube1.SetActive(false);

//        }

//        PlantList.RemoveAt(0);

        

//    }
//    static int SortByHealth(Plant p1, Plant p2)
//    {
//        return p1.Health.CompareTo(p2.Health);
//    }

//    public float CalculateTotalHealth()
//    {

//        foreach (Plant plant in PlantList)
//        {
//            int PlantHealth = plant.Health;

//            Debug.Log("plant health :" + PlantHealth);

//            totalHealth += PlantHealth;
            
//            Debug.Log("total Health: " + totalHealth.ToString());
//        }

//        return totalHealth;


//    }
//}
