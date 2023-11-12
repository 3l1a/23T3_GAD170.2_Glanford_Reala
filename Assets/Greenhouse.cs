using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Greenhouse : MonoBehaviour
{
    public int TotalValue;

    public Plant PlantValue1;
    public Plant PlantValue2;
    public Plant PlantValue3;

    public int Turnes = 0;
    public int NoPlants = 0;


    public float Spacing = 100;
    public GameObject Cube1;

    public TMP_InputField PlantNameInput;
    public TextMeshProUGUI Text;

    // Start is called before the first frame update
    void Start()
    {
        //PlantValue = GetComponent<Plant>();
        Text.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if (Turnes >= 20)
        {
            //end game
        }
        if (NoPlants >= 10)
        {
           // get rid of lowest plant health
        }

        TotalValue = PlantValue1.Value + PlantValue2.Value + PlantValue3.Value;

    }

    public void GetNewPlant()
    {
        Debug.Log(" button");
        GetComponent<Plant>();

        Turnes += 1;
        NoPlants += 1;
        Debug.Log(Turnes);

        Vector3 SpawnPosition = new Vector3(NoPlants * Spacing, 0, 500);
        Instantiate(Cube1, SpawnPosition, Quaternion.identity);

        Text.text = "Name your new plant";
    }
 
}
