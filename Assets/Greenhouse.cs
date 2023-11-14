using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//public class Greenhouse : MonoBehaviour
//{

//    public int Turnes = 0;
//    public int NoPlants = 0;


//    public float Spacing = 100;
//    public GameObject Cube1;
//    public Mian gameManager;

//    public TMP_InputField PlantNameInput;
//    public TextMeshProUGUI Text;

//    public GameObject inputField;

//    // Start is called before the first frame update
//    void Start()
//    {
//        //PlantValue = GetComponent<Plant>();
//        Text.text = " ";
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Turnes >= 20)
//        {
//            //end game
//        }
//        if (NoPlants >= 10)
//        {
//            gameManager.DeactivateLowestHealthObject();

//            NoPlants--;
//        }

//    }

//    public void GetNewPlant()
//    {

//        Debug.Log(" button");
//        GetComponent<Plant>();

//        Turnes += 1;
//        NoPlants += 1;


//        Vector3 SpawnPosition = new Vector3(NoPlants * Spacing, 0, 500);
//        Plant newPlant = Instantiate(Cube1, SpawnPosition, Quaternion.identity).GetComponent<Plant>();
        

//        Text.text = "Name your new plant";

//        gameManager.PlantList.Add(newPlant);

//        //gameManager.CalculateTotalHealth();

//    }

//    public void Reset()
//    {
        



//    }

//    public void RemovePlant(Plant PlantToRemove)
//    {
//        gameManager.PlantList.Remove(PlantToRemove);
//    }

//}
