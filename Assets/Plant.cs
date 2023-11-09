using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using TMPro;

public class Plant : MonoBehaviour
{
    public string Colour;

    public string PlantName;

    public int Value = 1;

    // Start is called before the first frame update
    void Start()
    {
        SetStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetStats()
    {
        Value = Random.Range(1, 11);
    }
}
