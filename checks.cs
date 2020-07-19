using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checks : MonoBehaviour
{
    public GameObject thing;
    public GameObject otherthing;
     int whatYouWrote;
     int answer;
    public Text wrong;
    public void checkIt()
    {
        int First=thing.GetComponent<math>().first;
        int Second = thing.GetComponent<math>().second;
        
         whatYouWrote = otherthing.GetComponent<answer>().number;

        
         answer = First + Second;
        if (answer == whatYouWrote)
        {
            Debug.Log("Yes");
            FindObjectOfType<GameManager>().Game();
        }
        else
        {
            Debug.Log("no");
            wrong.text = "Oops, try again!";
        }
        
    }

    


}
