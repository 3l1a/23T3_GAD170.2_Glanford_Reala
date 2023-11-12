using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using TMPro;

public class Plant : MonoBehaviour
{
    public string PlantName;

    public int Value = 1;
    public int Health;
    public string Rarity;
    public Color RandomColor;
    public Renderer MaterialColour;


    public List<string> words = new List<string>();
 
 
    public string GetRandomWord()
    {
        return words[Random.Range(0, words.Count)];
    }

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

        Health = Random.Range(1, 11);

        Rarity = GetRandomWord();

        RandomColor = new Color(Random.value, Random.value, Random.value);

        MaterialColour = GetComponent<Renderer>();
        MaterialColour.material.color = RandomColor;
    }
}
