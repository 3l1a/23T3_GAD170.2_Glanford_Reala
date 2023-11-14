using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{
    
    public int Value = 1;
    public int Health;
    public string Rarity;
    public Color RandomColor;
    public Renderer MaterialColour;
    public GameObject MainGame;
    public NewTest MainM;

   

    public List<string> words = new List<string>();
 
 
    // Start is called before the first frame update
    void Start()
    {

        
        SetStats();

        MainM = FindObjectOfType<NewTest>();

        MainM.SortByHealth();
    }

    private void Update()
    {
        
    }

    private void SetStats()
    {
       

        Health = Random.Range(1, 11);

        Value = Health + Random.Range(1, 6);

        Rarity = GetRandomWord();

        RandomColor = new Color(Random.value, Random.value, Random.value);

        MaterialColour = GetComponent<Renderer>();
        MaterialColour.material.color = RandomColor;
    }

    public string GetRandomWord()
    {
        return words[Random.Range(0, words.Count)];
    }
   
}
