using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;

public class Mian : MonoBehaviour
{
    public List<Plant> PlantList = new List<Plant>();


    public enum State {Start, Message, End }
    public State CurrentState;

    public TextMeshProUGUI IntroText;
    private string CurrentText = string.Empty;
    private string FullText;

    // Start is called before the first frame update
    void Start()
    {
        CurrentState = State.Start;
    }

    // Update is called once per frame
    void Update()
    {
      
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
            //StopAllCoroutines();
            //CurrentState = State.End;
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
        //CurrentState = State.Message;
   }
}
