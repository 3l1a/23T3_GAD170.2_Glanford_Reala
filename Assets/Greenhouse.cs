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

    // Start is called before the first frame update
    void Start()
    {
        //PlantValue = GetComponent<Plant>();
       
    }

    // Update is called once per frame
    void Update()
    {
        TotalValue = PlantValue1.Value + PlantValue2.Value + PlantValue3.Value;
    }

 
}
