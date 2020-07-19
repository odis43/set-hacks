using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class math : MonoBehaviour
{
   
    public Text text;

    
    public int first;
    public int second;
    
   
     public void Awake()
    {
        first = Random.Range(0, 50);
        second = Random.Range(0, 50);
        text.text = first + "+" + second;
        
        

    }
       
    
    
}
