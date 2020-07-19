using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer : MonoBehaviour
{
    public InputField field;
       string Snumber;
    public int number;

   
    public void onsubmit()
    {
        Snumber = field.text;
         number = int.Parse(Snumber);
    }
   
}
